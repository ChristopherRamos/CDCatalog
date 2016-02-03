using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDCatalog
{
    public class Song
    {
        public int Id { get; set; }
        public int artistId { get; set; }
        public int albumId { get; set; }
        public string title { get; set; }
        public int trackNumber { get; set; }
        public string genre { get; set; }
        public int trackLength { get; set; }
        public double rating { get; set; }  
    }
}
