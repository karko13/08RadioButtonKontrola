namespace _08RadioButtonKontrolaIvanoKarkovic
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
            this.AvionRadio = new System.Windows.Forms.RadioButton();
            this.dizajnkutija = new System.Windows.Forms.GroupBox();
            this.BusRadio = new System.Windows.Forms.RadioButton();
            this.VlastitoVozilo = new System.Windows.Forms.RadioButton();
            this.Rezerviraj = new System.Windows.Forms.Button();
            this.kutija = new System.Windows.Forms.TextBox();
            this.dizajnkutija.SuspendLayout();
            this.SuspendLayout();
            // 
            // AvionRadio
            // 
            this.AvionRadio.AutoSize = true;
            this.AvionRadio.Location = new System.Drawing.Point(16, 29);
            this.AvionRadio.Name = "AvionRadio";
            this.AvionRadio.Size = new System.Drawing.Size(52, 17);
            this.AvionRadio.TabIndex = 0;
            this.AvionRadio.TabStop = true;
            this.AvionRadio.Text = "Avion";
            this.AvionRadio.UseVisualStyleBackColor = true;
            this.AvionRadio.CheckedChanged += new System.EventHandler(this.AvionRadio_CheckedChanged);
            // 
            // dizajnkutija
            // 
            this.dizajnkutija.Controls.Add(this.VlastitoVozilo);
            this.dizajnkutija.Controls.Add(this.BusRadio);
            this.dizajnkutija.Controls.Add(this.AvionRadio);
            this.dizajnkutija.Location = new System.Drawing.Point(276, 61);
            this.dizajnkutija.Name = "dizajnkutija";
            this.dizajnkutija.Size = new System.Drawing.Size(250, 170);
            this.dizajnkutija.TabIndex = 1;
            this.dizajnkutija.TabStop = false;
            this.dizajnkutija.Text = "Odaberi rezervaciju:";
            // 
            // BusRadio
            // 
            this.BusRadio.AutoSize = true;
            this.BusRadio.Location = new System.Drawing.Point(16, 53);
            this.BusRadio.Name = "BusRadio";
            this.BusRadio.Size = new System.Drawing.Size(43, 17);
            this.BusRadio.TabIndex = 1;
            this.BusRadio.TabStop = true;
            this.BusRadio.Text = "Bus";
            this.BusRadio.UseVisualStyleBackColor = true;
            // 
            // VlastitoVozilo
            // 
            this.VlastitoVozilo.AutoSize = true;
            this.VlastitoVozilo.Location = new System.Drawing.Point(16, 77);
            this.VlastitoVozilo.Name = "VlastitoVozilo";
            this.VlastitoVozilo.Size = new System.Drawing.Size(89, 17);
            this.VlastitoVozilo.TabIndex = 2;
            this.VlastitoVozilo.TabStop = true;
            this.VlastitoVozilo.Text = "Vlastito vozilo";
            this.VlastitoVozilo.UseVisualStyleBackColor = true;
            // 
            // Rezerviraj
            // 
            this.Rezerviraj.Location = new System.Drawing.Point(276, 267);
            this.Rezerviraj.Name = "Rezerviraj";
            this.Rezerviraj.Size = new System.Drawing.Size(250, 35);
            this.Rezerviraj.TabIndex = 2;
            this.Rezerviraj.Text = "REZERVIRAJ";
            this.Rezerviraj.UseVisualStyleBackColor = true;
            this.Rezerviraj.Click += new System.EventHandler(this.Rezerviraj_Click);
            // 
            // kutija
            // 
            this.kutija.Location = new System.Drawing.Point(276, 331);
            this.kutija.Multiline = true;
            this.kutija.Name = "kutija";
            this.kutija.Size = new System.Drawing.Size(250, 83);
            this.kutija.TabIndex = 3;
            this.kutija.Text = "Odabrali ste prijevoz: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kutija);
            this.Controls.Add(this.Rezerviraj);
            this.Controls.Add(this.dizajnkutija);
            this.Name = "Form1";
            this.Text = "Form1";
            this.dizajnkutija.ResumeLayout(false);
            this.dizajnkutija.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton AvionRadio;
        private System.Windows.Forms.GroupBox dizajnkutija;
        private System.Windows.Forms.RadioButton VlastitoVozilo;
        private System.Windows.Forms.RadioButton BusRadio;
        private System.Windows.Forms.Button Rezerviraj;
        private System.Windows.Forms.TextBox kutija;
    }
}

