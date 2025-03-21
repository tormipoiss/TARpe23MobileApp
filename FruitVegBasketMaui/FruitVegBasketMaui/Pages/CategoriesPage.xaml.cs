using FruitVegBasket.Services;
using FruitVegBasket.ViewModels;
using Models;
using System.Collections.ObjectModel;

namespace Pages;

public partial class CategoriesPage : ContentPage
{
    private readonly CategoryService _categoryService;

	public CategoriesPage(CategoryService categoryService)
	{
		InitializeComponent();
        _categoryService = categoryService;
		BindingContext = this;
	}
	public ObservableCollection<Category> Categories { get; set; } = new ();

	protected override async void OnAppearing()
    {
        base.OnAppearing();
		Categories.Clear();
		foreach (var category in await _categoryService.GetCategoriesAsync())
		{
			Categories.Add(category);
		}
    }

	private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (e.CurrentSelection?[0] is Category category)
		{
			var parameter = new Dictionary<string, object>
			{
				[nameof(CategoryProductsViewModel.SelectedCategory)] = category
			};
            await Shell.Current.GoToAsync(nameof(CategoryProductsPage), animate: true, parameter);
        }
	}
}