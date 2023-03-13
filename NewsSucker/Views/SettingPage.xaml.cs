using NewsSucker.Data;
using NewsSucker.ViewModels;

namespace NewsSucker.Views;

public partial class SettingPage : ContentPage
{
	public SettingPage()
	{
		InitializeComponent();
		BindingContext = new SettingViewModel();
	}
}