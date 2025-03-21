
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
}