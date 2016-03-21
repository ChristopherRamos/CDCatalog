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
    public partial class SearchForm : Form
    {
        private string callingMenuItem;

        public SearchForm()
        {
            InitializeComponent();
        }

        //Overload SearchForm class to accept a parameter that lets form know of calling menu item.
        public SearchForm(string _menuitem)
        { 
            InitializeComponent();
            callingMenuItem = _menuitem;

            if (callingMenuItem == "Artist")
            {
                radioButtonFindArtist.Checked = true;
            }
            else if (callingMenuItem == "Genre")
            {
                radioButtonFindGenre.Checked = true;
            }
            else if (callingMenuItem == "Title")
            {
                radioButtonFindTitle.Checked = true;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string searchtype = "";
            bool isChecked = radioButtonFindTitle.Checked;

            if (isChecked)
            {
                searchtype = "Title";
            }
            else if (radioButtonFindArtist.Checked)
            {
                searchtype = "Artist";
            }
            else if (radioButtonFindGenre.Checked)
            {
                searchtype = "Genre";
            }

            populateDataGridViewFind(textBoxFindKeywordSearch.Text, searchtype);
        }

        private void showDetails(string assettype, int id)
        {
            dataGridViewDetails.DataSource = null;

            labelDetailsInfo.Text = "";
            labelDetailsAlbumTitle.Text = "";
            labelDetailsArtist.Text = "";
            labelDetailsYear.Text = "";
            labelDetailsRating.Text = "";

            if (assettype == "Song")
            {
                labelDetailsInfo.Text = "Below are additional details of the song selected above:";
                try
                {
                    using (var context = new CDCatalogContext())
                    {
                        var SongArtistGenreList =
                                             from ts in context.Songs
                                             join n in context.Artists on ts.ArtistId equals n.ID
                                             join g in context.Genres on ts.GenreID equals g.ID
                                             join a in context.Albums on ts.AlbumId equals a.Id
                                             where ts.Id == id
                                             select new { ts, n, g, a };

                        var SongDetails = new List<Details>();

                        foreach (var item in SongArtistGenreList)
                        {
                            SongDetails.Add(new Details()
                            {
                                AssetType = "Song",
                                Title = item.ts.Title.ToString(),
                                Artist = item.n.Name,
                                AlbumTitle = item.a.Title,
                                TrackNumber = Convert.ToInt32(item.ts.TrackNumber),
                                Genre = item.g.Name,
                                TrackLength = Convert.ToInt32(item.ts.TrackLength),
                                Rating = Convert.ToInt32(item.ts.Rating)
                            });
                        }

                        dataGridViewDetails.DataSource = SongDetails;
                        dataGridViewDetails.Columns[0].Visible = false;
                        dataGridViewDetails.Columns[7].Visible = false;
                        dataGridViewDetails.ReadOnly = true;
                        //remove highlighting in details
                        dataGridViewDetails.ClearSelection();
                        dataGridViewDetails.CurrentCell = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem showing Song details:" + ex.Message.ToString());
                }
            }
            else if (assettype == "CD")
            {
                try
                {
                    using (var context = new CDCatalogContext())
                    {
                        //ta = title album, n = name
                        var AlbumArtistList =
                                             from ta in context.Albums
                                             join n in context.Artists on ta.ArtistId equals n.ID
                                             where ta.Id == id
                                             select new { ta, n };
                        //ts = title song
                        var AlbumSongList =
                                            from ts in context.Songs
                                            join ta in context.Albums on ts.AlbumId equals ta.Id
                                            where ta.Id == id
                                            orderby ts.TrackNumber ascending
                                            select new { ts, ta };

                        var SongDetails = new List<Details>();

                        foreach (var item in AlbumSongList)
                        {
                            SongDetails.Add(new Details()
                            {
                                Title = item.ts.Title.ToString(),
                                TrackNumber = Convert.ToInt32(item.ts.TrackNumber),
                                TrackLength = Convert.ToInt32(item.ts.TrackLength)
                            });
                        }

                        labelDetailsInfo.Text = "The following are additional details and list of songs on the album selected above:";

                        foreach (var item in AlbumArtistList)
                        {
                            labelDetailsAlbumTitle.Text = "Album Title: " + item.ta.Title;
                            labelDetailsArtist.Text = "Artist: " + item.n.Name;
                            labelDetailsYear.Text = "Year: " + item.ta.Year.ToString();
                            labelDetailsRating.Text = "Rating: " + item.ta.Rating.ToString();
                        }


                        dataGridViewDetails.DataSource = SongDetails;
                        dataGridViewDetails.Columns[0].Visible = false;
                        dataGridViewDetails.Columns[2].Visible = false;
                        dataGridViewDetails.Columns[3].Visible = false;
                        dataGridViewDetails.Columns[5].Visible = false;
                        dataGridViewDetails.Columns[6].Visible = false;
                        dataGridViewDetails.Columns[7].Visible = false;
                        dataGridViewDetails.Columns[8].Visible = false;
                        dataGridViewDetails.ReadOnly = true;
                        //remove highlighting in details
                        dataGridViewDetails.ClearSelection();
                        dataGridViewDetails.CurrentCell = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem showing Album details:" + ex.Message.ToString());
                }
            }
        }

        private void populateDataGridViewFind(string keyword, string searchtype)
        {
            using (var context = new CDCatalogContext())
            {
                try
                {
                    switch (searchtype)
                    {
                        case "Title":

                            var AlbumArtistList = from ta in context.Albums
                                                  join n in context.Artists on ta.ArtistId equals n.ID
                                                  where (ta.Title.Contains(keyword))
                                                  select new { ta, n };

                            var SongArtistList = from ts in context.Songs
                                                 join n in context.Artists on ts.ArtistId equals n.ID
                                                 where (ts.Title.Contains(keyword))
                                                 select new { ts, n };

                            if (AlbumArtistList.Any() == false && SongArtistList.Any() == false) 
                            {
                                MessageBox.Show("There were no Songs or CDs matching your search criteria.");
                                break;
                            }

                            var MergedSongCDlist = new List<CombinedSongsAlbums>();

                            foreach (var item in AlbumArtistList)
                            {
                                MergedSongCDlist.Add(new CombinedSongsAlbums()
                                {
                                    AssetType = "CD",
                                    Title = item.ta.Title,
                                    Artist = item.n.Name,
                                    ID = item.ta.Id

                                });
                            }

                            foreach (var item in SongArtistList)
                            {
                                MergedSongCDlist.Add(new CombinedSongsAlbums()
                                {
                                    AssetType = "Song",
                                    Title = item.ts.Title,
                                    Artist = item.n.Name,
                                    ID = item.ts.Id,
                                });

                            }


                            dataGridViewFindSongCD.DataSource = MergedSongCDlist;
                            dataGridViewFindSongCD.Columns[3].Visible = false;
                            dataGridViewFindSongCD.ReadOnly = true;

                            break;

                        case "Artist":
                            {

                                var AlbumArtistList2 = from ta in context.Albums
                                                       join n in context.Artists on ta.ArtistId equals n.ID
                                                       where (n.Name.Contains(keyword))
                                                       select new { ta, n };

                                var SongArtistList2 = from ts in context.Songs
                                                      join n in context.Artists on ts.ArtistId equals n.ID
                                                      where (n.Name.Contains(keyword))
                                                      select new { ts, n };

                                if (AlbumArtistList2.Any() == false && SongArtistList2.Any() == false)
                                {
                                    MessageBox.Show("There were no Songs or CDs matching your search criteria.");
                                    break;
                                }

                                var MergedSongCDlist2 = new List<CombinedSongsAlbums>();

                                foreach (var item in AlbumArtistList2)
                                {
                                    MergedSongCDlist2.Add(new CombinedSongsAlbums()
                                    {
                                        AssetType = "CD",
                                        Title = item.ta.Title,
                                        Artist = item.n.Name,
                                        ID = item.ta.Id

                                    });
                                }

                                foreach (var item in SongArtistList2)
                                {
                                    MergedSongCDlist2.Add(new CombinedSongsAlbums()
                                    {
                                        AssetType = "Song",
                                        Title = item.ts.Title,
                                        Artist = item.n.Name,
                                        ID = item.ts.Id,
                                    });

                                }


                                dataGridViewFindSongCD.DataSource = MergedSongCDlist2;
                                dataGridViewFindSongCD.Columns[3].Visible = false;
                                dataGridViewFindSongCD.ReadOnly = true;

                            }
                            break;

                        case "Genre":
                            {

                                var AlbumSongArtistGenreList = from ta in context.Albums
                                                               join ts in context.Songs on ta.Id equals ts.AlbumId
                                                               join g in context.Genres on ts.GenreID equals g.ID
                                                               join n in context.Artists on ts.ArtistId equals n.ID
                                                               where (g.Name.Contains(keyword))
                                                               select new { ta, ts, g, n };

                                if (AlbumSongArtistGenreList.Any() == false)
                                {
                                    MessageBox.Show("There were no Songs or CDs matching your search criteria.");
                                    break;
                                }

                                var MergedSongCDlist3 = new List<CombinedSongsAlbums>();

                                foreach (var item in AlbumSongArtistGenreList)
                                {
                                    MergedSongCDlist3.Add(new CombinedSongsAlbums()
                                    {
                                        AssetType = "Song",
                                        Title = item.ts.Title,
                                        Artist = item.n.Name,
                                        ID = item.ts.Id
                                    });

                                    MergedSongCDlist3.Add(new CombinedSongsAlbums()
                                    {
                                        AssetType = "CD",
                                        Title = item.ta.Title,
                                        Artist = item.n.Name,
                                        ID = item.ta.Id
                                    });
                                }

                                dataGridViewFindSongCD.DataSource = MergedSongCDlist3;
                                dataGridViewFindSongCD.Columns[3].Visible = false;
                                dataGridViewFindSongCD.ReadOnly = true;
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem displaying search results:" + ex.Message.ToString());
                }

            }
        }

        private void dataGridViewFindSongCD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Get row values to pass to showDetails method
            //To get consistent results, need to duplicate this for _CellContentClick, _CellContentDoubleClick, and _CellClick
            try
            {
                string assettype = dataGridViewFindSongCD.SelectedRows[0].Cells[2].Value.ToString();
                int assetid = Convert.ToInt32(dataGridViewFindSongCD.SelectedRows[0].Cells[3].Value);
                showDetails(assettype, assetid);
            }

            catch (Exception ex)
            {
                MessageBox.Show("There was a problem displaying details:" + ex.Message.ToString());
            }
        }

        private void dataGridViewFindSongCD_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string assettype = dataGridViewFindSongCD.SelectedRows[0].Cells[2].Value.ToString();
                int assetid = Convert.ToInt32(dataGridViewFindSongCD.SelectedRows[0].Cells[3].Value);
                showDetails(assettype, assetid);
            }

            catch (Exception ex)
            {
                MessageBox.Show("There was a problem displaying details:" + ex.Message.ToString());
            }
        }

        private void dataGridViewFindSongCD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string assettype = dataGridViewFindSongCD.SelectedRows[0].Cells[2].Value.ToString();
                int assetid = Convert.ToInt32(dataGridViewFindSongCD.SelectedRows[0].Cells[3].Value);
                showDetails(assettype, assetid);
            }
           
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem displaying details:" + ex.Message.ToString());
            }
        }
    }
}
