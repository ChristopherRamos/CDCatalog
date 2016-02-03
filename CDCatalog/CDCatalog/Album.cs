using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDCatalog
{
    public class Album
    {
        public int Id { get; set; }
        public int artistId { get; set; }
        public string title { get; set; }  
        public int year { get; set; }
        public double rating { get; set; }
    }
}
