﻿using System;
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
    public partial class AddAlbumForm : Form
    {
        public AddAlbumForm()
        {
            InitializeComponent();
            refreshComboBoxes();
        }

        private void btnAddCD_Click(object sender, EventArgs e)
        {
            //Upon clicking the Add Album button, create album object then using linq, save it to the database.
            int artId = Convert.ToInt32(comboBoxAddCDArtist.SelectedValue);

            var album = new Album
            {
                ArtistId = artId,
                Title = textBoxAddCDTitle.Text,
                Year = Convert.ToInt32(numericUpDownAddCDYear.Value),
            };

            try
            {
                 using (var context = new CDCatalogContext())
                 {

                    if (context.Albums.Any(x => x.ArtistId == artId && x.Title == textBoxAddCDTitle.Text))
                    {
                        MessageBox.Show("Cannot add already existing album");
                    }
                    else
                    {
                        context.Albums.Add(album);
                        context.SaveChanges();
                    }  
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show("There was a problem saving this album:" + ex.Message.ToString());
            }
            
            refreshComboBoxes();
        }

        //This method refreshes the combo box so that its always up-to-date, whenever a new song is added.
        private void refreshComboBoxes()
        {
            try
            {
                using (var context = new CDCatalogContext())
                {
                    var Artistlist = context.Artists.OrderBy(a => a.Name).ToList();
                    //var Genrelist = context.Genres.OrderBy(g => g.Name).ToList();
                    //var Songlist = context.Songs.OrderBy(s => s.Title).ToList();
                    //var CDlist = context.Albums.OrderBy(c => c.Title).ToList();

                    //var MergedSongCDlist = new List<CombinedSongsAlbums>();

                    //foreach (var item in Songlist)
                    //{
                    //    MergedSongCDlist.Add(new CombinedSongsAlbums()
                    //    {
                    //        Title = "Song - " + item.Title,
                    //        ID = item.Id,
                    //        AssetType = "Song"
                    //    });

                    //}

                    //foreach (var item in CDlist)
                    //{
                    //    MergedSongCDlist.Add(new CombinedSongsAlbums()
                    //    {
                    //        Title = "CD - " + item.Title,
                    //        ID = item.Id,
                    //        AssetType = "Album"
                    //    });
                    //}

                    this.comboBoxAddCDArtist.DataSource = Artistlist;
                    this.comboBoxAddCDArtist.DisplayMember = "Name";
                    this.comboBoxAddCDArtist.ValueMember = "ID";
                }
             }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem refreshing combo boxes:" + ex.Message.ToString());
            }
        }
    }
}
