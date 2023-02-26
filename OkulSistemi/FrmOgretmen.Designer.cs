namespace OkulSistemi
{
    partial class FrmOgretmen
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
            this.btndersislemleri = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnsınavnot = new System.Windows.Forms.Button();
            this.btnogretmen = new System.Windows.Forms.Button();
            this.btnogrenciislemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndersislemleri
            // 
            this.btndersislemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndersislemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndersislemleri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndersislemleri.Location = new System.Drawing.Point(34, 24);
            this.btndersislemleri.Name = "btndersislemleri";
            this.btndersislemleri.Size = new System.Drawing.Size(245, 71);
            this.btndersislemleri.TabIndex = 0;
            this.btndersislemleri.Text = "DERS İŞLEMLERİ";
            this.btndersislemleri.UseVisualStyleBackColor = true;
            this.btndersislemleri.Click += new System.EventHandler(this.btndersislemleri_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(34, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 71);
            this.button2.TabIndex = 1;
            this.button2.Text = "KULÜP İŞLEMLERİ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnsınavnot
            // 
            this.btnsınavnot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsınavnot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsınavnot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsınavnot.Location = new System.Drawing.Point(34, 178);
            this.btnsınavnot.Name = "btnsınavnot";
            this.btnsınavnot.Size = new System.Drawing.Size(245, 71);
            this.btnsınavnot.TabIndex = 2;
            this.btnsınavnot.Text = "SINAV NOTLARI";
            this.btnsınavnot.UseVisualStyleBackColor = true;
            this.btnsınavnot.Click += new System.EventHandler(this.btnsınavnot_Click);
            // 
            // btnogretmen
            // 
            this.btnogretmen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnogretmen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnogretmen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnogretmen.Location = new System.Drawing.Point(34, 255);
            this.btnogretmen.Name = "btnogretmen";
            this.btnogretmen.Size = new System.Drawing.Size(245, 71);
            this.btnogretmen.TabIndex = 3;
            this.btnogretmen.Text = "ÖĞRETMENLER";
            this.btnogretmen.UseVisualStyleBackColor = true;
            this.btnogretmen.Click += new System.EventHandler(this.btnogretmen_Click);
            // 
            // btnogrenciislemleri
            // 
            this.btnogrenciislemleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnogrenciislemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnogrenciislemleri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnogrenciislemleri.Location = new System.Drawing.Point(34, 332);
            this.btnogrenciislemleri.Name = "btnogrenciislemleri";
            this.btnogrenciislemleri.Size = new System.Drawing.Size(245, 71);
            this.btnogrenciislemleri.TabIndex = 4;
            this.btnogrenciislemleri.Text = "ÖĞRENCİ İŞLEMLERİ";
            this.btnogrenciislemleri.UseVisualStyleBackColor = true;
            this.btnogrenciislemleri.Click += new System.EventHandler(this.btnogrenciislemleri_Click);
            // 
            // FrmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(322, 443);
            this.Controls.Add(this.btnogrenciislemleri);
            this.Controls.Add(this.btnogretmen);
            this.Controls.Add(this.btnsınavnot);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btndersislemleri);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmOgretmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOgretmen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndersislemleri;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnsınavnot;
        private System.Windows.Forms.Button btnogretmen;
        private System.Windows.Forms.Button btnogrenciislemleri;
    }
}