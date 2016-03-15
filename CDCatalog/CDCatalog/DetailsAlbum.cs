using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDCatalog
{
    class DetailsAlbum
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }
        public List<Song> Songs { get; set; }
    }
}
