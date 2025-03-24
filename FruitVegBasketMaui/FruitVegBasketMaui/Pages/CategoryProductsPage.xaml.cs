
using FruitVegBasket.ViewModels;

namespace Pages;

public partial class CategoryProductsPage : ContentPage
{
    private readonly CategoryProductsViewModel _viewModel;

    public CategoryProductsPage(CategoryProductsViewModel viewModel)
	{
		InitializeComponent();
        _viewModel = viewModel;
        BindingContext = _viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.InitializeAsync();
    }

    private void ProductsListControl_AddRemoveCartClicked(object sender, Controls.ProductCartItemChangeEventArgs e)
    {
        if (e.Count > 0)
        {
            _viewModel.AddToCartCommand.Execute(e.ProductId);
        }
        else
        {
            _viewModel.RemoveFromCartCommand.Execute(e.ProductId);
        }
    }
}