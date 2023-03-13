using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NewsSucker.Models;
using NewsSucker.Services;

namespace NewsSucker.ViewModels
{
    public partial class MusicViewModel : ObservableObject
    {
        [ObservableProperty]
        List<Story> stories;

        [ObservableProperty]
        bool isRefreshing;

        readonly RssReader rssReader;

        public MusicViewModel()
        {
            rssReader = new RssReader();
            Task.Run(Refresh);
            
        }

        [RelayCommand]
        public async Task Refresh()
        {
            var newlist = await rssReader.LoadRssFeed("https://www.dr.dk/nyheder/service/feeds/musik");
            Stories = newlist.ToList();
            IsRefreshing = false;
        }
    }
}
