using MauiPlanets.Models;

namespace MauiPlanets.Views;

public partial class PlanetsDetailsPage : ContentPage
{
	public PlanetsDetailsPage(Planet planet)
	{
		InitializeComponent();

		this.BindingContext = planet;
	}
}