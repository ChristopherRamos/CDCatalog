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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //refreshComboBoxes();
        }

        private int GetArtistId(string p)
        {
            using (var context = new CDCatalogContext())
            {

                var artistid = context.Artists
                    .Where(a => a.Name.ToUpper() == p.ToString().ToUpper());

                //First check to see if Artist already in database

                if (artistid.Any())
                {
                    return artistid.FirstOrDefault().ID;
                }
                else
                {
                    // Artist is not in the database, Insert new artist and return ID
                    InsertNewArtist(p);

                    var artistid2 = context.Artists
                    .Where(a => a.Name.ToUpper() == p.ToString().ToUpper());

                    return artistid2.FirstOrDefault().ID;
                }

            }
        }

        private int GetGenreId(string p)
        {
            using (var context = new CDCatalogContext())
            {

                var genreID = context.Genres
                    .Where(a => a.Name.ToUpper() == p.ToString().ToUpper());

                //First check to see if Genre already in database

                if (genreID.Any())
                {
                    return genreID.FirstOrDefault().ID;
                }
                else
                {
                    // Genre is not in the database, Insert new genre and return ID
                    InsertNewGenre(p);

                    var genreID2 = context.Genres
                    .Where(a => a.Name.ToUpper() == p.ToString().ToUpper());

                    return genreID2.FirstOrDefault().ID;
                }

            }
        }

        private static void InsertNewArtist(string p)
        {
               var artist = new Artist
               {
                  Name = p
               };

                using(var context = new CDCatalogContext())
                {
                    context.Artists.Add(artist);
                    context.SaveChanges();
                }
        }

        private static void InsertNewGenre(string p)
        {
            var genre = new Genre
            {
                Name = p
            };

            using (var context = new CDCatalogContext())
            {
                context.Genres.Add(genre);
                context.SaveChanges();
            }
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

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            GetArtistId(textBoxAddArtist.Text);
            //refreshComboBoxes();
        }

        private void buttonAddGenre_Click(object sender, EventArgs e)
        {
            GetGenreId(textBoxAddGenre.Text);
            //refreshComboBoxes();
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
            else{
                comboBoxAsset = "Album";
            }

            InsertRating(Convert.ToInt32(comboBoxRateSongorCD.SelectedValue), comboBoxAsset, Convert.ToInt32(numericUpDownRateSongCD.Value));
        }

        private void populateDataGridViewFind(string keyword, string searchtype)
        {
            
            using(var context = new CDCatalogContext())
            {

                switch (searchtype)
                {

                case "Title":

                        var AlbumArtistList = from ta in context.Albums 
                                           join n in context.Artists on ta.ArtistId equals n.ID
                                           where (ta.Title.Contains(keyword))
                                           select new {ta,n};

                        var SongArtistList = from ts in context.Songs 
                                           join n in context.Artists on ts.ArtistId equals n.ID
                                           where (ts.Title.Contains(keyword))
                                           select new {ts,n};


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

                }
                break;
            }

        }
        }
               

        //private void refreshComboBoxes()
        //{
        //    using (var context = new CDCatalogContext())
        //    {
        //        var Artistlist = context.Artists.OrderBy(a => a.Name).ToList();
        //        var Genrelist = context.Genres.OrderBy(g => g.Name).ToList();
        //        var Songlist = context.Songs.OrderBy(s => s.Title).ToList();
        //        var CDlist = context.Albums.OrderBy(c => c.Title).ToList();

        //        var MergedSongCDlist = new List<CombinedSongsAlbums>();

        //        foreach (var item in Songlist)
        //        {
        //            MergedSongCDlist.Add(new CombinedSongsAlbums()
        //            {
        //                Title = "Song - " + item.Title,
        //                ID = item.Id,
        //                AssetType = "Song"
        //            });

        //        }

        //        foreach (var item in CDlist)
        //        {
        //            MergedSongCDlist.Add(new CombinedSongsAlbums()
        //            {
        //                Title = "CD - " + item.Title,
        //                ID = item.Id,
        //                AssetType = "Album"
        //            });
        //        }

        //        this.comboBoxAddCDArtist.DataSource = Artistlist;
        //        this.comboBoxAddCDArtist.DisplayMember = "Name";
        //        this.comboBoxAddCDArtist.ValueMember = "ID";

        //        this.comboBoxAddSongArtist.DataSource = Artistlist;
        //        this.comboBoxAddSongArtist.DisplayMember = "Name";
        //        this.comboBoxAddSongArtist.ValueMember = "ID";

        //        this.comboBoxAddSongAlbum.DataSource = CDlist;
        //        this.comboBoxAddSongAlbum.DisplayMember = "Title";
        //        this.comboBoxAddSongAlbum.ValueMember = "Id";

        //        this.comboBoxAddSongGenre.DataSource = Genrelist;
        //        this.comboBoxAddSongGenre.DisplayMember = "Name";
        //        this.comboBoxAddSongGenre.ValueMember = "ID";

        //        this.comboBoxRateSongorCD.DataSource = MergedSongCDlist;
        //        this.comboBoxRateSongorCD.DisplayMember = "Title";
        //        this.comboBoxRateSongorCD.ValueMember = "ID";
        //    }      
        //}

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

        private void dataGridViewFindSongCD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            string assetype = dataGridViewFindSongCD.SelectedCells[2].Value.ToString();
            int assetid = Convert.ToInt32(dataGridViewFindSongCD.SelectedCells[3].Value);

            showDetails(assetype, assetid);
        }

        ////extension method used for shuffling a list
        //private static Random randomGenerator = new Random();

        //public static void Shuffle<T>(this IList<T> list)
        //{
        //    int n = list.Count;
        //    while (n > 1) {
        //        n--;
        //        int k = randomGenerator.Next(n + 1);
        //        T value = list[k];
        //        list[k] = list[n];
        //        list[n] = value;
        //    }
        //}

        private void generatePlaylist(int maxplaylistLength)
        {
            
             using (var context = new CDCatalogContext())
                {
     
                    var SongArtistAlbumList = 
                                         from ts in context.Songs
                                         join n in context.Artists on ts.ArtistId equals n.ID
                                         join a in context.Albums on ts.AlbumId equals a.Id
                                         where ts.TrackLength <= maxplaylistLength
                                         //changes index numbers (shuffles list)
                                         orderby Guid.NewGuid()
                                         select new { ts, n, a};

                    var playlistDetails = new List<Details>();

                    int totalTime = 0;

                    foreach (var item in SongArtistAlbumList)
                    {   
                        int songTrackLength = item.ts.TrackLength;

                        if (songTrackLength <= maxplaylistLength && (totalTime + songTrackLength) <= maxplaylistLength)

                        {
                            playlistDetails.Add(new Details()
                            {
                                Title = item.ts.Title.ToString(),
                                Artist = item.n.Name,
                                AlbumTitle = item.a.Title,
                                TrackLength = item.ts.TrackLength
                            });

                            totalTime = totalTime + songTrackLength;
                        }

                    }

                    dataGridViewPlaylist.DataSource = playlistDetails;
                    dataGridViewPlaylist.Columns[0].Visible = false;
                    dataGridViewPlaylist.Columns[4].Visible = false;
                    dataGridViewPlaylist.Columns[5].Visible = false;
                    //dataGridViewPlaylist.Columns[7].Visible = false;

                }
        }

        private void showDetails(string assettype, int id)
        {
            dataGridViewDetails.DataSource = null;

            if (assettype == "Song")
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
                }
                 
            }
            else if (assettype == "CD")
            { 
                 using (var context = new CDCatalogContext())
                {
                     //ta = title album, n = name
                    var AlbumArtistList = 
                                         from ta in context.Albums
                                         join n in context.Artists on ta.ArtistId equals n.ID
                                         where ta.Id == id
                                         select new { ta, n};
                     //ts = title song
                    var AlbumSongList =
                                        from ts in context.Songs
                                        join ta in context.Albums on ts.AlbumId equals ta.Id
                                        where ta.Id == id
                                        select new { ts, ta};

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

                    dataGridViewDetails.DataSource = SongDetails;
                    dataGridViewDetails.Columns[0].Visible = false;
                    dataGridViewDetails.Columns[2].Visible = false;
                    dataGridViewDetails.Columns[3].Visible = false;
                    dataGridViewDetails.Columns[5].Visible = false;
                    dataGridViewDetails.Columns[7].Visible = false;
                }
            
            }
        }

        private void buttonCreatePlaylist_Click(object sender, EventArgs e)
        {
            int playlistlength = (Convert.ToInt32(numericUpDownCreatePlaylist.Value))*60;
            generatePlaylist(playlistlength);
        }

        private void albumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildFormsExcept("AddAlbumForm");
            this.IsMdiContainer = true;
            var AddAlbumForm = new AddAlbumForm();
            AddAlbumForm.MdiParent = this;
            AddAlbumForm.WindowState = FormWindowState.Maximized;
            AddAlbumForm.Show();
        }

        private void songToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChildFormsExcept("AddSongForm");
            this.IsMdiContainer = true;
            var AddSongForm = new AddSongForm();
            AddSongForm.MdiParent = this;
            AddSongForm.WindowState = FormWindowState.Maximized;
            AddSongForm.Show();
        }

        public void CloseChildFormsExcept(string name)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                if (Application.OpenForms[i].Name != name && Application.OpenForms[i].Name !="MainForm")
                    Application.OpenForms[i].Close();
        }
    }
}