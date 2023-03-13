using NewsSucker.Models;
using NewsSucker.Services;
using NewsSucker.ViewModels;

namespace NewsSucker.Views;

public partial class MusicPage : ContentPage
{
    readonly WebService webService;
    public MusicPage()
	{
		InitializeComponent();
		BindingContext = new MusicViewModel();
        webService = new WebService();
	}

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        webService.OpenStoryOnWeb((Story)e.CurrentSelection.FirstOrDefault());
        cview.SelectedItem = null;
    }
}