namespace NotHotDogApp
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.fileImagen = new System.Windows.Forms.OpenFileDialog();
            this.picResultado = new System.Windows.Forms.PictureBox();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picImagen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(287, 222);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.picResultado);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 93);
            this.panel3.TabIndex = 1;
            // 
            // fileImagen
            // 
            this.fileImagen.Filter = " (*.jpg)|*.jpg";
            // 
            // picResultado
            // 
            this.picResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picResultado.Image = global::NotHotDogApp.Properties.Resources.Resultado;
            this.picResultado.Location = new System.Drawing.Point(0, 0);
            this.picResultado.Name = "picResultado";
            this.picResultado.Size = new System.Drawing.Size(287, 93);
            this.picResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResultado.TabIndex = 1;
            this.picResultado.TabStop = false;
            // 
            // picImagen
            // 
            this.picImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImagen.Location = new System.Drawing.Point(0, 0);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(287, 222);
            this.picImagen.TabIndex = 0;
            this.picImagen.TabStop = false;
            this.picImagen.Click += new System.EventHandler(this.picImagen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::NotHotDogApp.Properties.Resources.NotHotDogTitle;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 64);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 380);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "NotHotDog";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picResultado;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.OpenFileDialog fileImagen;
    }
}

