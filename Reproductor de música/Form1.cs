using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using WMPLib;
using TagLib;

namespace Reproductor_de_música
{
    public partial class Form1 : Form
    {

        WindowsMediaPlayer player = new WindowsMediaPlayer();
        int index;

        public Form1()
        {
            InitializeComponent();
            index = lista_canciones.Items.Count + 1;


            String path = @"C:\Users\Public\Music\Sample Music";
            string[] array1 = Directory.GetFiles(path,"*.mp3");
            foreach(string canción in array1)
            {
                int slash = canción.LastIndexOf("\\") + 1;
                string str = canción.Substring(slash, canción.Length - slash);
                lista_canciones.Items.Add(str);
            }


            lista_canciones.SelectedIndex = 0;
            botón_pausa.Enabled = false;
            botón_stop.Enabled = false;
            index = lista_canciones.Items.Count + 1;
        }

        public void Metadatos()
        {
            TagLib.File file = TagLib.File.Create(player.URL);

            String artista = file.Tag.FirstPerformer;
            String album = file.Tag.Album;
            String año = Convert.ToString(file.Tag.Year);
            String género = file.Tag.FirstGenre;

            label_artista.Text = artista;
            label_album.Text = album;
            label_año.Text = año;
            label_genero.Text = género;
        }

        public void botón_inicio_Click(object sender, EventArgs e)
        {
            lista_canciones.SelectedIndex = 0;
        }

        private void botón_atras_Click(object sender, EventArgs e)
        {
            if (lista_canciones.SelectedIndex == 0)
            {

            }
            else
            {
                lista_canciones.SelectedIndex = lista_canciones.SelectedIndex - 1;
            }            
        }

        private void botón_siguiente_Click(object sender, EventArgs e)
        {
            int items_en_lista = lista_canciones.Items.Count;
            if (lista_canciones.SelectedIndex == items_en_lista-1)
            {

            }
            else
            {
                lista_canciones.SelectedIndex = lista_canciones.SelectedIndex + 1;
            }
        }

        private void botón_fin_Click(object sender, EventArgs e)
        {
            int items_en_lista = lista_canciones.Items.Count;
            lista_canciones.SelectedIndex = items_en_lista - 1;
        }

        private void botón_play_Click(object sender, EventArgs e)
        {
            player.URL = lista_canciones.GetItemText(lista_canciones.SelectedItem);
            player.controls.play();
            Metadatos();
            botón_play.Enabled = false;
            botón_pausa.Enabled = true;
            botón_stop.Enabled = true;
            index = lista_canciones.SelectedIndex;
        }

        private void botón_stop_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            botón_stop.Enabled = false;
            botón_play.Enabled = true;
            botón_pausa.Enabled = false;
        }

        private void botón_pausa_Click(object sender, EventArgs e)
        {
            player.controls.pause();
            botón_pausa.Enabled = false;
            botón_play.Enabled = true;
        }

        private void lista_canciones_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if (lista_canciones.SelectedIndex != index)
            {
                botón_play.Enabled = true;
            }
            else
            {
                botón_play.Enabled = false;
            }
        }
    }
}