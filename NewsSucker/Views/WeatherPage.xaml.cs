using NewsSucker.Models;
using NewsSucker.Services;
using NewsSucker.ViewModels;

namespace NewsSucker.Views;

public partial class WeatherPage : ContentPage
{
	readonly WebService webService;
	public WeatherPage()
	{
		InitializeComponent();
		BindingContext = new WeatherViewModel();
		webService = new WebService();
	}

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        webService.OpenStoryOnWeb((Story)e.CurrentSelection.FirstOrDefault());
		cview.SelectedItem = null;
    }

}