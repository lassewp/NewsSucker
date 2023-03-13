using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NewsSucker.Data;
using NewsSucker.Models;
using System.Collections.ObjectModel;

namespace NewsSucker.ViewModels
{
    public partial class SettingViewModel : ObservableObject
    {

        [ObservableProperty]
        ObservableCollection<NewFilter> filters;

        [ObservableProperty]
        string userInput;

        DbMaster dbMaster;

        public SettingViewModel()
        {
            dbMaster = new DbMaster();
            Filters = new ObservableCollection<NewFilter>();
            GetFilters();
        }

        [RelayCommand]
        public void AddWord()
        {
            UserInput = string.Empty;
            
        }

        [RelayCommand]
        public async void AddNewFilter()
        {
            string result = await Application.Current.MainPage.DisplayPromptAsync("Add new filter", "Enter a name for the new filter");
            if (!string.IsNullOrWhiteSpace(result))
            {
                dbMaster.AddFilter(result);
            }        
        }

        public async Task GetFilters()
        {
            dbMaster.GetFilters();
        }

    }
}
