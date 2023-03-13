using System.Collections.ObjectModel;

namespace NewsSucker.Models
{
    public class Settings
    {
        public int Id { get; set; }
        public bool DarkMode { get; set; }
        public string FilterWords { get; set; }
    }
}
