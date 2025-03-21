using CommunityToolkit.Mvvm.ComponentModel;
using Models;
using FruitVegBasket.Services;
using System.Collections.ObjectModel;
using Services;
using FruitVegBasketMaui.Shared.Dtos;
using CommunityToolkit.Mvvm.Input;
using Pages;

namespace FruitVegBasket.ViewModels
{
    public partial class HomePageViewModel : ObservableObject, IDisposable
    {
        private readonly CategoryService _categoryService;
        private readonly OffersService _offersService;
        private readonly ProductsService _productsService;
        private readonly CartViewModel _cartViewModel;

        public HomePageViewModel(CategoryService categoryService, OffersService offersService
            , ProductsService productsService, CartViewModel cartViewModel)
        {
            _categoryService = categoryService;
            _offersService = offersService;
            _productsService = productsService;
            _cartViewModel = cartViewModel;

            _cartViewModel.CartCountUpdated += CartViewModel_CartCountUpdated;
            _cartViewModel.CartItemUpdated += CartViewModel_CartItemUpdated;
            _cartViewModel.CartItemRemoved += CartViewModel_CartItemRemoved;
        }

        private void CartViewModel_CartItemRemoved(object sender, int productId) =>
            ModifyProductQuantity(productId, 0);

        private void CartViewModel_CartItemUpdated(object sender, CartItem e) =>
            ModifyProductQuantity(e.ProductId, e.Quantity);

        private void ModifyProductQuantity(int productId, int quantity)
        {
            var product = PopularProducts.FirstOrDefault(p => p.Id == productId);
            if (product is not null)
            {
                product.CartQuantity = quantity;
            }
        }

        private void CartViewModel_CartCountUpdated(object sender, int cartCount) => CartCount = cartCount;

        public ObservableCollection<Category> Categories { get; set; } = new();
        public ObservableCollection<Offer> Offers { get; set; } = new();
        public ObservableCollection<ProductDto> PopularProducts { get; set; } = new();

        [ObservableProperty]
        private bool _isBusy = true;

        [ObservableProperty]
        private int _cartCount;
        private bool _isInitialized = false;

        public async Task InitializeAsync()
        {
            if (_isInitialized)
                return;
            try
            {
                var offersTask = _offersService.GetActiveOffersAsync();
                var popularProductsTask = _productsService.GetPopularProductsAsync();
                foreach (var category in await _categoryService.GetMainCategoriesAsync())
                {
                    Categories.Add(category);
                }
                foreach (var offer in await offersTask)
                {
                    Offers.Add(offer);
                }
                foreach (var product in await popularProductsTask)
                {
                    PopularProducts.Add(product);
                }
                _isInitialized = true;
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        private void AddToCart(int productId) => UpdateCart(productId, 1);
        [RelayCommand]
        private void RemoveFromCart(int productId) => UpdateCart(productId, -1);

        [RelayCommand]
        private async Task GoToCategoryProductsPage(Category category)
        {
            var parameter = new Dictionary<string, object>
            {
                [nameof(CategoryProductsViewModel.SelectedCategory)] = category
            };
            await Shell.Current.GoToAsync(nameof(CategoryProductsPage), animate: true, parameter);
        }

        private void UpdateCart(int productId, int count)
        {
            var product = PopularProducts.FirstOrDefault(p => p.Id == productId);
            if (product is not null)
            {
                product.CartQuantity += count;

                if (count == -1)
                {
                    // We are removing from cart
                    _cartViewModel.RemoveFromCartCommand.Execute(product.Id);
                }
                else
                {
                    //Adding to cart
                    _cartViewModel.AddToCartCommand.Execute(product);
                }
                CartCount = _cartViewModel.Count;
            }
        }

        public void Dispose()
        {
            _cartViewModel.CartCountUpdated -= CartViewModel_CartCountUpdated;
            _cartViewModel.CartItemUpdated -= CartViewModel_CartItemUpdated;
            _cartViewModel.CartItemRemoved -= CartViewModel_CartItemRemoved;
        }
    }
}