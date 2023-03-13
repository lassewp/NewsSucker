using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSucker.Models
{
    public class Story 
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string StoryURL { get; set; }
        public string? ImageURL { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
