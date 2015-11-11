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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.URL = p[listBox1.SelectedIndex];
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
