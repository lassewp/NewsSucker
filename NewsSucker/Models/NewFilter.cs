using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsSucker.Models
{
    public class NewFilter
    {
        public string Name { get; set; }
        public List<string> Words { get; set; }
    }
}
