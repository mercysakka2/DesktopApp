namespace DesktopApp
{
    partial class HomePage
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
            AsistenKesehatan = new Label();
            inputGejala = new Label();
            pengingatObat = new Label();
            gejalaNpenanganan = new Label();
            boxInputGejala = new ComboBox();
            txtPengingatObat = new TextBox();
            txtGejalaNPenanganan = new TextBox();
            SuspendLayout();
            // 
            // AsistenKesehatan
            // 
            AsistenKesehatan.AutoSize = true;
            AsistenKesehatan.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            AsistenKesehatan.Location = new Point(189, 28);
            AsistenKesehatan.Name = "AsistenKesehatan";
            AsistenKesehatan.Size = new Size(569, 48);
            AsistenKesehatan.TabIndex = 0;
            AsistenKesehatan.Text = "Assistant Kesehatan Sederhana";
            // 
            // inputGejala
            // 
            inputGejala.AutoSize = true;
            inputGejala.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            inputGejala.Location = new Point(64, 164);
            inputGejala.Name = "inputGejala";
            inputGejala.Size = new Size(121, 25);
            inputGejala.TabIndex = 1;
            inputGejala.Text = "Input Gejala:";
            // 
            // pengingatObat
            // 
            pengingatObat.AutoSize = true;
            pengingatObat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            pengingatObat.Location = new Point(64, 248);
            pengingatObat.Name = "pengingatObat";
            pengingatObat.Size = new Size(150, 25);
            pengingatObat.TabIndex = 2;
            pengingatObat.Text = "Pengingat Obat:";
            // 
            // gejalaNpenanganan
            // 
            gejalaNpenanganan.AutoSize = true;
            gejalaNpenanganan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gejalaNpenanganan.Location = new Point(64, 329);
            gejalaNpenanganan.Name = "gejalaNpenanganan";
            gejalaNpenanganan.Size = new Size(217, 25);
            gejalaNpenanganan.TabIndex = 3;
            gejalaNpenanganan.Text = "Gejala dan Penanganan:";
            // 
            // boxInputGejala
            // 
            boxInputGejala.FormattingEnabled = true;
            boxInputGejala.Items.AddRange(new object[] { "Demam, sering disertai dengan menggigil dan berkeringat.", "Batuk kering, bisa disertai dengan sakit tenggorokan.", "Sakit kepala atau migrain", "Mual dan Muntah", "Nyeri Otot" });
            boxInputGejala.Location = new Point(325, 161);
            boxInputGejala.Name = "boxInputGejala";
            boxInputGejala.Size = new Size(453, 33);
            boxInputGejala.TabIndex = 7;
            boxInputGejala.SelectedIndexChanged += boxInputGejala_SelectedIndexChanged;
            // 
            // txtPengingatObat
            // 
            txtPengingatObat.Location = new Point(325, 245);
            txtPengingatObat.Name = "txtPengingatObat";
            txtPengingatObat.Size = new Size(452, 31);
            txtPengingatObat.TabIndex = 10;
            // 
            // txtGejalaNPenanganan
            // 
            txtGejalaNPenanganan.Location = new Point(325, 326);
            txtGejalaNPenanganan.Name = "txtGejalaNPenanganan";
            txtGejalaNPenanganan.Size = new Size(452, 31);
            txtGejalaNPenanganan.TabIndex = 11;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(933, 555);
            Controls.Add(txtGejalaNPenanganan);
            Controls.Add(txtPengingatObat);
            Controls.Add(boxInputGejala);
            Controls.Add(gejalaNpenanganan);
            Controls.Add(pengingatObat);
            Controls.Add(inputGejala);
            Controls.Add(AsistenKesehatan);
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AsistenKesehatan;
        private Label inputGejala;
        private Label pengingatObat;
        private Label gejalaNpenanganan;
        private ComboBox boxInputGejala;
        private TextBox txtPengingatObat;
        private TextBox txtGejalaNPenanganan;
    }
}