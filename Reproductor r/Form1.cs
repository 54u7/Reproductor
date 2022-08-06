using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor_r
{
    public partial class Form1 : Form
    {
        int vol = 50;
        int play = 0;
        OpenFileDialog op = new OpenFileDialog();
        private string ruta = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lblVolumen.Text = (mtbVolumen.Value = wmpMedia.settings.volume = vol).ToString();

            this.wmpMedia.uiMode = "none";
        }

        private void mtbVolumen_ValueChanged(object sender, decimal value)
        {
            wmpMedia.settings.volume = mtbVolumen.Value;

            lblVolumen.Text = wmpMedia.settings.volume.ToString();
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            mtbVolumen.Visible = true;
            lblVolumen.Visible = true;
        }

        private void mtbVolumen_MouseLeave(object sender, EventArgs e)
        {
            lblVolumen.Visible = false;
            mtbVolumen.Visible = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //wmpMedia.URL = ruta;
            //wmpMedia.Ctlcontrols.play();
            //play = 1;

            //if (wmpMedia.playState == wmpMedia)
            //{
            //wmpMedia.Ctlcontrols.
            //}

            if (play == 3)
            {
                wmpMedia.Ctlcontrols.play();
                tmSlider.Start();

                play = 2;
            }


        }

        public void abrirArchivo()
        {
            op.Filter = "Archivo files|*.mp3;*.mp4;.*;";
            DialogResult dres1 = op.ShowDialog();
            if (dres1 == DialogResult.Abort)
                return;
            if (dres1 == DialogResult.Cancel)
                return;
            ruta = op.FileName;
            lblRuta.Text = op.SafeFileName;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                abrirArchivo();

                if (ruta != "")
                {
                    play = 2;
                    AbrirMusica();

                }
                else
                {

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //wmpMedia.Ctlcontrols.pause();
            //play = 2;

            if (play == 1)
            {
                AbrirMusica();
                play = 2;
            }
            else if (play == 2)
            {
                wmpMedia.Ctlcontrols.pause();
                tmSlider.Stop();

                play = 3;
            }
            //else if (play == 3)
            //{
            //    wmpMedia.Ctlcontrols.play();
            //    tmSlider.Start();

            //    play = 2;
            //}
        }

        private void mtbDuracionVid_ValueChanged(object sender, decimal value)
        {
            mtbDuracionVid.Maximum = (int)wmpMedia.currentMedia.duration;

            if (mtbDuracionVid.Value == (int)wmpMedia.Ctlcontrols.currentPosition)
            {

            }
            else
            {
                wmpMedia.Ctlcontrols.currentPosition = mtbDuracionVid.Value;
            }

        }

        private void tmSlider_Tick(object sender, EventArgs e)
        {
            try
            {
                mtbDuracionVid.Value = (int)wmpMedia.Ctlcontrols.currentPosition;
                lblIni.Text = wmpMedia.Ctlcontrols.currentPositionString;
                lblFin.Text = wmpMedia.currentMedia.durationString;
            }
            catch
            {


            }
        }

        public void AbrirMusica()
        {

            try
            {

                wmpMedia.URL = @"" + ruta;
                wmpMedia.Ctlcontrols.play();

                this.Visible = true;
                tmSlider.Start();

                mtbDuracionVid.Enabled = true;

            }
            catch
            {


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((mtbDuracionVid.Value = mtbDuracionVid.Value - 15) < 0)
            {
                mtbDuracionVid.Value = 0;
            }
            else
            {
                mtbDuracionVid.Value = mtbDuracionVid.Value - 15;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((mtbDuracionVid.Value = mtbDuracionVid.Value + 15) < 0)
            {
                mtbDuracionVid.Value = 0;
            }
            else
            {
                mtbDuracionVid.Value = mtbDuracionVid.Value + 15;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((mtbDuracionVid.Value = mtbDuracionVid.Value - 15000) < 0)
            {
                mtbDuracionVid.Value = 0;
            }
            else
            {
                mtbDuracionVid.Value = mtbDuracionVid.Value - 15000;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((mtbDuracionVid.Value = mtbDuracionVid.Value + 15000) < 0)
            {
                mtbDuracionVid.Value = 0;
            }
            else
            {
                mtbDuracionVid.Value = mtbDuracionVid.Value + 15000;
            }
        }
    }
}
