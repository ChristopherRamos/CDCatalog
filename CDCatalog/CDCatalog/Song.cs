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
        public int ArtistId { get; set; }
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public int TrackNumber { get; set; }
        public int GenreID { get; set; }
        public int TrackLength { get; set; }
        public double Rating { get; set; }  
    }
}
