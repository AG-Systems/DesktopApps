using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlowMusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] f, p;
        int x = 0;
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.URL = p[listBox1.SelectedIndex];
        }
        
        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer2.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            axWindowsMediaPlayer2.settings.setMode("loop", true);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            OpenFileDialog open = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                f = openFileDialog1.SafeFileNames;
                p = openFileDialog1.FileNames;
                for (int i = 0; i < f.Length; i++)
                {
                    listBox1.Items.Add(f[i]);
                }
                /*
                    foreach (string d in open.FileName)
                    {
                        listBox1.Items.Add(d);
                    }
                    */
            }
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.uiMode = "none";
        }

        private void unhideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.uiMode = "full";
            button1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.FileName;
                axWindowsMediaPlayer2.URL = textBox1.Text;
                axWindowsMediaPlayer2.uiMode = "none";
                axWindowsMediaPlayer2.Ctlcontrols.play();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            OpenFileDialog open = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                f = openFileDialog1.SafeFileNames;
                p = openFileDialog1.FileNames;
                for (int i = 0; i < f.Length; i++)
                {
                    listBox1.Items.Add(f[i]);
                }
            
                foreach (string d in open.FileName)
                {
                    listBox1.Items.Add(d);
                }
                */
            x++;
            if (x % 2 == 0)
            {
                menuStrip1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                axWindowsMediaPlayer1.Visible = false;
            }
            else
            {
                menuStrip1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                axWindowsMediaPlayer1.Visible = true;
            }
            }

        }
    }
