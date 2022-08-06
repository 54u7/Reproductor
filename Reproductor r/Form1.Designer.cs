namespace Reproductor_r
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRuta = new System.Windows.Forms.Label();
            this.mtbVolumen = new XComponent.SliderBar.MACTrackBar();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblIni = new System.Windows.Forms.Label();
            this.mtbDuracionVid = new XComponent.SliderBar.MACTrackBar();
            this.wmpMedia = new AxWMPLib.AxWindowsMediaPlayer();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tmSlider = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(848, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblRuta);
            this.panel1.Controls.Add(this.mtbVolumen);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.lblVolumen);
            this.panel1.Controls.Add(this.lblFin);
            this.panel1.Controls.Add(this.lblIni);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.mtbDuracionVid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 493);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 155);
            this.panel1.TabIndex = 3;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(12, 121);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(0, 13);
            this.lblRuta.TabIndex = 10;
            // 
            // mtbVolumen
            // 
            this.mtbVolumen.BackColor = System.Drawing.Color.Transparent;
            this.mtbVolumen.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtbVolumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbVolumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtbVolumen.IndentHeight = 6;
            this.mtbVolumen.Location = new System.Drawing.Point(751, 40);
            this.mtbVolumen.Maximum = 100;
            this.mtbVolumen.Minimum = 0;
            this.mtbVolumen.Name = "mtbVolumen";
            this.mtbVolumen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.mtbVolumen.Size = new System.Drawing.Size(28, 66);
            this.mtbVolumen.TabIndex = 9;
            this.mtbVolumen.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtbVolumen.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.mtbVolumen.TickHeight = 4;
            this.mtbVolumen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtbVolumen.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.mtbVolumen.TrackerSize = new System.Drawing.Size(16, 16);
            this.mtbVolumen.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtbVolumen.TrackLineHeight = 3;
            this.mtbVolumen.Value = 0;
            this.mtbVolumen.Visible = false;
            this.mtbVolumen.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.mtbVolumen_ValueChanged);
            this.mtbVolumen.MouseLeave += new System.EventHandler(this.mtbVolumen_MouseLeave);
            // 
            // lblVolumen
            // 
            this.lblVolumen.AutoSize = true;
            this.lblVolumen.Location = new System.Drawing.Point(785, 93);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(13, 13);
            this.lblVolumen.TabIndex = 7;
            this.lblVolumen.Text = "0";
            this.lblVolumen.Visible = false;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(808, 24);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(28, 13);
            this.lblFin.TabIndex = 6;
            this.lblFin.Text = "0:00";
            // 
            // lblIni
            // 
            this.lblIni.AutoSize = true;
            this.lblIni.Location = new System.Drawing.Point(12, 24);
            this.lblIni.Name = "lblIni";
            this.lblIni.Size = new System.Drawing.Size(28, 13);
            this.lblIni.TabIndex = 5;
            this.lblIni.Text = "0:00";
            // 
            // mtbDuracionVid
            // 
            this.mtbDuracionVid.BackColor = System.Drawing.Color.Transparent;
            this.mtbDuracionVid.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.mtbDuracionVid.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbDuracionVid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.mtbDuracionVid.IndentHeight = 6;
            this.mtbDuracionVid.Location = new System.Drawing.Point(43, 9);
            this.mtbDuracionVid.Maximum = 100;
            this.mtbDuracionVid.Minimum = 0;
            this.mtbDuracionVid.Name = "mtbDuracionVid";
            this.mtbDuracionVid.Size = new System.Drawing.Size(755, 28);
            this.mtbDuracionVid.TabIndex = 0;
            this.mtbDuracionVid.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.mtbDuracionVid.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.mtbDuracionVid.TickHeight = 4;
            this.mtbDuracionVid.TickStyle = System.Windows.Forms.TickStyle.None;
            this.mtbDuracionVid.TrackerColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(198)))));
            this.mtbDuracionVid.TrackerSize = new System.Drawing.Size(16, 16);
            this.mtbDuracionVid.TrackLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.mtbDuracionVid.TrackLineHeight = 3;
            this.mtbDuracionVid.Value = 0;
            this.mtbDuracionVid.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.mtbDuracionVid_ValueChanged);
            // 
            // wmpMedia
            // 
            this.wmpMedia.Enabled = true;
            this.wmpMedia.Location = new System.Drawing.Point(0, 27);
            this.wmpMedia.Name = "wmpMedia";
            this.wmpMedia.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpMedia.OcxState")));
            this.wmpMedia.Size = new System.Drawing.Size(848, 460);
            this.wmpMedia.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Image = global::Reproductor_r.Properties.Resources.icons8_fin_48;
            this.button6.Location = new System.Drawing.Point(634, 43);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 66);
            this.button6.TabIndex = 13;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Image = global::Reproductor_r.Properties.Resources.icons8_adelante_10_48;
            this.button5.Location = new System.Drawing.Point(533, 43);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 66);
            this.button5.TabIndex = 12;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Reproductor_r.Properties.Resources.ic;
            this.button1.Location = new System.Drawing.Point(133, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 66);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Image = global::Reproductor_r.Properties.Resources.icons8_volumen_bajo_26;
            this.button4.Location = new System.Drawing.Point(751, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(32, 31);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button4_MouseMove);
            // 
            // button3
            // 
            this.button3.Image = global::Reproductor_r.Properties.Resources.icons8_pausa_48;
            this.button3.Location = new System.Drawing.Point(432, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 66);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Reproductor_r.Properties.Resources.icons8_reproducir_10_48;
            this.button2.Location = new System.Drawing.Point(234, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 66);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::Reproductor_r.Properties.Resources.icons8_play_48;
            this.btnPlay.Location = new System.Drawing.Point(333, 43);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(95, 66);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tmSlider
            // 
            this.tmSlider.Tick += new System.EventHandler(this.tmSlider_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.wmpMedia);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpMedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpMedia;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPlay;
        private XComponent.SliderBar.MACTrackBar mtbDuracionVid;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.Label lblIni;
        private XComponent.SliderBar.MACTrackBar mtbVolumen;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmSlider;
    }
}

