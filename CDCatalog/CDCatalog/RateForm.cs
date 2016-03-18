using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDCatalog
{
    public partial class RateForm : Form
    {
        public RateForm()
        {
            InitializeComponent();
            refreshComboBoxes();
        }

        private void buttonRate_Click(object sender, EventArgs e)
        {
            string comboBoxDisplayString = comboBoxRateSongorCD.Text;
            bool isSong = comboBoxDisplayString.Contains("Song - ");
            string comboBoxAsset;

            if (isSong == true)
            {
                comboBoxAsset = "Song";
            }
            else
            {
                comboBoxAsset = "Album";
            }

            InsertRating(Convert.ToInt32(comboBoxRateSongorCD.SelectedValue), comboBoxAsset, Convert.ToInt32(numericUpDownRateSongCD.Value));
        }

        private static void InsertRating(int i, string t, int r)
        {
            using (var context = new CDCatalogContext())
            {
                if (t == "Song")
                {
                    Song s = (from x in context.Songs
                              where x.Id == i
                              select x).FirstOrDefault();
                    s.Rating = r;
                    context.SaveChanges();
                }

                else
                {
                    Album a = (from x in context.Albums
                               where x.Id == i
                               select x).FirstOrDefault();
                    a.Rating = r;
                    context.SaveChanges();
                }
            }
        }

        private void refreshComboBoxes()
        {
            using (var context = new CDCatalogContext())
            {
                var Artistlist = context.Artists.OrderBy(a => a.Name).ToList();
                var Genrelist = context.Genres.OrderBy(g => g.Name).ToList();
                var Songlist = context.Songs.OrderBy(s => s.Title).ToList();
                var CDlist = context.Albums.OrderBy(c => c.Title).ToList();

                var MergedSongCDlist = new List<CombinedSongsAlbums>();

                foreach (var item in Songlist)
                {
                    MergedSongCDlist.Add(new CombinedSongsAlbums()
                    {
                        Title = "Song - " + item.Title,
                        ID = item.Id,
                        AssetType = "Song"
                    });

                }

                foreach (var item in CDlist)
                {
                    MergedSongCDlist.Add(new CombinedSongsAlbums()
                    {
                        Title = "CD - " + item.Title,
                        ID = item.Id,
                        AssetType = "Album"
                    });
                }

                this.comboBoxRateSongorCD.DataSource = MergedSongCDlist;
                this.comboBoxRateSongorCD.DisplayMember = "Title";
                this.comboBoxRateSongorCD.ValueMember = "ID";
            }
        }

      
    }
}
