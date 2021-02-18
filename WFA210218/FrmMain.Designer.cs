
namespace WFA210218
{
    partial class FrmMain
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
            this.dgvTanulok = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbKSzAdatok = new System.Windows.Forms.RichTextBox();
            this.btnUjTanulo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbOsszOra = new System.Windows.Forms.TextBox();
            this.tbMegvan50 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.tbOsztaly = new System.Windows.Forms.TextBox();
            this.tbEvfolyam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdatokModositasa = new System.Windows.Forms.Button();
            this.cbEvismetlo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTanulok)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTanulok
            // 
            this.dgvTanulok.AllowUserToAddRows = false;
            this.dgvTanulok.AllowUserToDeleteRows = false;
            this.dgvTanulok.AllowUserToResizeColumns = false;
            this.dgvTanulok.AllowUserToResizeRows = false;
            this.dgvTanulok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTanulok.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTanulok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTanulok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvTanulok.Location = new System.Drawing.Point(12, 88);
            this.dgvTanulok.Name = "dgvTanulok";
            this.dgvTanulok.RowHeadersVisible = false;
            this.dgvTanulok.RowHeadersWidth = 51;
            this.dgvTanulok.RowTemplate.Height = 24;
            this.dgvTanulok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTanulok.Size = new System.Drawing.Size(915, 195);
            this.dgvTanulok.TabIndex = 0;
            this.dgvTanulok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTanulok_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Név";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Évfolyam";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Osztály";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Évismétlő";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Közösségi szolgálat";
            // 
            // rtbKSzAdatok
            // 
            this.rtbKSzAdatok.Enabled = false;
            this.rtbKSzAdatok.Location = new System.Drawing.Point(458, 344);
            this.rtbKSzAdatok.Name = "rtbKSzAdatok";
            this.rtbKSzAdatok.Size = new System.Drawing.Size(469, 130);
            this.rtbKSzAdatok.TabIndex = 4;
            this.rtbKSzAdatok.Text = "Szervezetek, ahol teljesítette (név és óra):";
            // 
            // btnUjTanulo
            // 
            this.btnUjTanulo.Location = new System.Drawing.Point(578, 23);
            this.btnUjTanulo.Name = "btnUjTanulo";
            this.btnUjTanulo.Size = new System.Drawing.Size(349, 37);
            this.btnUjTanulo.TabIndex = 3;
            this.btnUjTanulo.Text = "Új tanuló adatainak felvitele";
            this.btnUjTanulo.UseVisualStyleBackColor = true;
            this.btnUjTanulo.Click += new System.EventHandler(this.BtnUjTanulo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(453, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(413, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kiválasztott tanuló közösségi szolgálati adatai:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(455, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Teljesített órák összesen:";
            // 
            // tbOsszOra
            // 
            this.tbOsszOra.Enabled = false;
            this.tbOsszOra.Location = new System.Drawing.Point(659, 494);
            this.tbOsszOra.Name = "tbOsszOra";
            this.tbOsszOra.Size = new System.Drawing.Size(268, 22);
            this.tbOsszOra.TabIndex = 1;
            // 
            // tbMegvan50
            // 
            this.tbMegvan50.Enabled = false;
            this.tbMegvan50.Location = new System.Drawing.Point(659, 539);
            this.tbMegvan50.Name = "tbMegvan50";
            this.tbMegvan50.Size = new System.Drawing.Size(268, 22);
            this.tbMegvan50.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 542);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Megvan 50?";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(154, 344);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(273, 22);
            this.tbNev.TabIndex = 1;
            // 
            // tbOsztaly
            // 
            this.tbOsztaly.Location = new System.Drawing.Point(154, 434);
            this.tbOsztaly.Name = "tbOsztaly";
            this.tbOsztaly.Size = new System.Drawing.Size(273, 22);
            this.tbOsztaly.TabIndex = 1;
            // 
            // tbEvfolyam
            // 
            this.tbEvfolyam.Location = new System.Drawing.Point(154, 389);
            this.tbEvfolyam.Name = "tbEvfolyam";
            this.tbEvfolyam.Size = new System.Drawing.Size(273, 22);
            this.tbEvfolyam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Osztály:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Évfolyam:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 484);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Évismétlő:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(23, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kiválasztott gyerek adatainak módosítása:";
            // 
            // btnAdatokModositasa
            // 
            this.btnAdatokModositasa.Enabled = false;
            this.btnAdatokModositasa.Location = new System.Drawing.Point(12, 532);
            this.btnAdatokModositasa.Name = "btnAdatokModositasa";
            this.btnAdatokModositasa.Size = new System.Drawing.Size(415, 37);
            this.btnAdatokModositasa.TabIndex = 3;
            this.btnAdatokModositasa.Text = "Adatok módosítása";
            this.btnAdatokModositasa.UseVisualStyleBackColor = true;
            this.btnAdatokModositasa.Click += new System.EventHandler(this.BtnAdatokModositasa_Click);
            // 
            // cbEvismetlo
            // 
            this.cbEvismetlo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvismetlo.FormattingEnabled = true;
            this.cbEvismetlo.Items.AddRange(new object[] {
            "Nem",
            "Igen"});
            this.cbEvismetlo.Location = new System.Drawing.Point(154, 477);
            this.cbEvismetlo.Name = "cbEvismetlo";
            this.cbEvismetlo.Size = new System.Drawing.Size(273, 24);
            this.cbEvismetlo.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 588);
            this.Controls.Add(this.cbEvismetlo);
            this.Controls.Add(this.rtbKSzAdatok);
            this.Controls.Add(this.btnUjTanulo);
            this.Controls.Add(this.btnAdatokModositasa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbMegvan50);
            this.Controls.Add(this.tbOsszOra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEvfolyam);
            this.Controls.Add(this.tbOsztaly);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.dgvTanulok);
            this.Name = "FrmMain";
            this.Text = "Közösségi szolgálat";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTanulok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTanulok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbKSzAdatok;
        private System.Windows.Forms.Button btnUjTanulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbOsszOra;
        private System.Windows.Forms.TextBox tbMegvan50;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.TextBox tbOsztaly;
        private System.Windows.Forms.TextBox tbEvfolyam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdatokModositasa;
        private System.Windows.Forms.ComboBox cbEvismetlo;
    }
}

