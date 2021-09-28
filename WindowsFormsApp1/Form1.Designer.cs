
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MusicPlayerApp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SongsList = new System.Windows.Forms.ListBox();
            this.Songsselect = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.OWNER = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.MusicPlayerApp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1442, 90);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MusicPlayerApp
            // 
            this.MusicPlayerApp.AutoSize = true;
            this.MusicPlayerApp.Font = new System.Drawing.Font("Segoe Print", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicPlayerApp.Location = new System.Drawing.Point(34, 26);
            this.MusicPlayerApp.Name = "MusicPlayerApp";
            this.MusicPlayerApp.Size = new System.Drawing.Size(254, 51);
            this.MusicPlayerApp.TabIndex = 0;
            this.MusicPlayerApp.Text = "MusicPlayerApp";
            this.MusicPlayerApp.Click += new System.EventHandler(this.MusicPlayerApp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1382, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 51);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // SongsList
            // 
            this.SongsList.FormattingEnabled = true;
            this.SongsList.ItemHeight = 25;
            this.SongsList.Location = new System.Drawing.Point(1058, 124);
            this.SongsList.Name = "SongsList";
            this.SongsList.Size = new System.Drawing.Size(350, 529);
            this.SongsList.TabIndex = 1;
            // 
            // Songsselect
            // 
            this.Songsselect.BackColor = System.Drawing.Color.OrangeRed;
            this.Songsselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Songsselect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Songsselect.Location = new System.Drawing.Point(1058, 668);
            this.Songsselect.Name = "Songsselect";
            this.Songsselect.Size = new System.Drawing.Size(350, 101);
            this.Songsselect.TabIndex = 2;
            this.Songsselect.Text = "Select Songs";
            this.Songsselect.UseVisualStyleBackColor = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(33, 116);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(981, 653);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            // 
            // OWNER
            // 
            this.OWNER.AutoSize = true;
            this.OWNER.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.OWNER.Location = new System.Drawing.Point(600, 818);
            this.OWNER.Name = "OWNER";
            this.OWNER.Size = new System.Drawing.Size(224, 25);
            this.OWNER.TabIndex = 4;
            this.OWNER.Text = "Developed by Sameer";
            this.OWNER.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 872);
            this.Controls.Add(this.OWNER);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.Songsselect);
            this.Controls.Add(this.SongsList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "MusicPlayerApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MusicPlayerApp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox SongsList;
        private System.Windows.Forms.Button Songsselect;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label OWNER;
    }
}

