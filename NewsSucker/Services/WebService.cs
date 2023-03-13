using NewsSucker.Models;

namespace NewsSucker.Services
{
    public class WebService
    {
        public async void OpenStoryOnWeb(Story story)
        {
            try
            {
                Uri uri = new Uri(story.StoryURL);
                await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {

                // An unexpected error occurred. No browser may be installed on the device.
            }
        }

        //public async Task<string> GetStoryImage(string url)
        //{

        //}
    }


}
