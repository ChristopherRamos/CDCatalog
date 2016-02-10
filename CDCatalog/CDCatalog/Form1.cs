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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {

            var song = new Song
            {
                ArtistId = GetArtistId(textBoxAddSongArtist.Text),
                Title = textBoxAddSongTitle.Text,
                TrackNumber = Convert.ToInt32(numericUpDownAddSongTrackNumber.Value),
                Genre = comboBoxAddSongGenre.Text,
                TrackLength = Convert.ToInt32(numericUpDownAddSongTrackLength.Value),
                Rating = Convert.ToInt32(numericUpDownAddSongRating.Value)
            };

            using (var context = new CDCatalogContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Songs.Add(song);
                context.SaveChanges();
            }
        }

        private int GetArtistId(string p)
        {
            //check to see if Artist already in database
            using (var context = new CDCatalogContext())
            {
                var artistid = context.Artists
                    .Where(a => a.Name.ToUpper() == p.ToString().ToUpper());

             //if(artists != null)
             //{
             //   return artist.
             //}


                return artistid.FirstOrDefault().ID;

                
            }

            //if not add artist and get id
        }


    }
}