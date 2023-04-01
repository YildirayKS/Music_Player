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
using System.Threading;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer wplayer;

        List<String> musics = new List<String>();

        public Form1()
        {
            InitializeComponent();

            btn_play.Enabled = false;
            btn_stop.Enabled = false;
            btn_delete.Enabled = false;
            musicSoundTrackbar.Enabled = false;

            wplayer = new WindowsMediaPlayer();

            wplayer.settings.volume = musicSoundTrackbar.Value;
        }

        private void btn_selectFolder_Click(object sender, EventArgs e)
        {
            listBox_musics.Items.Clear();

            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            string[] extensions = { ".mp3"}; //this array can be expanded in the future by adding other extensions.

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(folderBrowser.SelectedPath);

                string folderPath = folderBrowser.SelectedPath;

                folderPathLabel.Text = folderPath;

                foreach (var file in files)
                {
                    string fileExtension = Path.GetExtension(file);

                    foreach (var extension in extensions) 
                    {
                        if (fileExtension == extension)
                        {
                            string musicFile = Path.GetFileName(file);

                            listBox_musics.Items.Add(musicFile);

                            btn_play.Enabled = true;
                            btn_stop.Enabled = true;
                            btn_delete.Enabled = true;
                            musicSoundTrackbar.Enabled = true;

                        }
                    }
                }

            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (listBox_musics.SelectedIndex != -1)
            {
                int selectedItem = listBox_musics.SelectedIndex;
                listBox_musics.Items.RemoveAt(selectedItem);

                if (wplayer.playState == WMPPlayState.wmppsPlaying)
                {
                    wplayer.controls.stop();
                }
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (listBox_musics.SelectedIndex != -1)
            {
                string musicPath = Path.Combine(folderPathLabel.Text, listBox_musics.SelectedItem.ToString());

                string music = Path.GetFileName(musicPath);

                wplayer.URL = Path.Combine(folderPathLabel.Text, music);

                wplayer.controls.play();
            }


        }
        private void btn_stop_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
        }

        private void musicSoundTrackbar_Scroll(object sender, EventArgs e)
        {
            wplayer.settings.volume = musicSoundTrackbar.Value;
        }
    }
}

