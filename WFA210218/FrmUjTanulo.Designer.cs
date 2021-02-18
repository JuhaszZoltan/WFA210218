
namespace WFA210218
{
    partial class FrmUjTanulo
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
            this.cbEvismetlo = new System.Windows.Forms.ComboBox();
            this.btnUjTanulo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbOsztaly = new System.Windows.Forms.TextBox();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.cbEvfolyam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbEvismetlo
            // 
            this.cbEvismetlo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvismetlo.FormattingEnabled = true;
            this.cbEvismetlo.Items.AddRange(new object[] {
            "Nem",
            "Igen"});
            this.cbEvismetlo.Location = new System.Drawing.Point(154, 183);
            this.cbEvismetlo.Name = "cbEvismetlo";
            this.cbEvismetlo.Size = new System.Drawing.Size(267, 24);
            this.cbEvismetlo.TabIndex = 15;
            // 
            // btnUjTanulo
            // 
            this.btnUjTanulo.Location = new System.Drawing.Point(12, 238);
            this.btnUjTanulo.Name = "btnUjTanulo";
            this.btnUjTanulo.Size = new System.Drawing.Size(422, 37);
            this.btnUjTanulo.TabIndex = 14;
            this.btnUjTanulo.Text = "Új tanuló rögzítése";
            this.btnUjTanulo.UseVisualStyleBackColor = true;
            this.btnUjTanulo.Click += new System.EventHandler(this.BtnUjTanulo_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Új tanuló adatai:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Évismétlő:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Évfolyam:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Osztály:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Név:";
            // 
            // tbOsztaly
            // 
            this.tbOsztaly.Location = new System.Drawing.Point(154, 140);
            this.tbOsztaly.Name = "tbOsztaly";
            this.tbOsztaly.Size = new System.Drawing.Size(267, 22);
            this.tbOsztaly.TabIndex = 7;
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(154, 50);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(267, 22);
            this.tbNev.TabIndex = 8;
            // 
            // cbEvfolyam
            // 
            this.cbEvfolyam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvfolyam.FormattingEnabled = true;
            this.cbEvfolyam.Items.AddRange(new object[] {
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.cbEvfolyam.Location = new System.Drawing.Point(154, 93);
            this.cbEvfolyam.Name = "cbEvfolyam";
            this.cbEvfolyam.Size = new System.Drawing.Size(267, 24);
            this.cbEvfolyam.TabIndex = 15;
            // 
            // FrmUjTanulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 297);
            this.Controls.Add(this.cbEvfolyam);
            this.Controls.Add(this.cbEvismetlo);
            this.Controls.Add(this.btnUjTanulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOsztaly);
            this.Controls.Add(this.tbNev);
            this.Name = "FrmUjTanulo";
            this.Text = "FrmUjTanulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEvismetlo;
        private System.Windows.Forms.Button btnUjTanulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOsztaly;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.ComboBox cbEvfolyam;
    }
}