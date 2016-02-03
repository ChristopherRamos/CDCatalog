using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDCatalog
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            List<int> Songies = new List<int> {1,3,5};

            //using (var ctx = new CDCatalogContext())
            //{
            //    Song songer = new Song() { albumId =1, artistId=1, genre="Rock", Id=1, rating=4, title="Smells like Heaven", trackLength=300, trackNumber=1};
            //    ctx.Songs.Add(songer);
            //    ctx.SaveChanges();
            //}


            //using (var ctx = new CDCatalogContext())
            //{
            //    Album alby = new Album() { artistId = 1, rating=4, Songs=Songies, title="Bustas Rhymes", year=2016};
            //    ctx.Albums.Add(alby);
            //    ctx.SaveChanges();
            
            //}


        }


    }
}
