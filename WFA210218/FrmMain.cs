using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA210218
{
    public partial class FrmMain : Form
    {
        readonly SqlConnection conn;
        string selectedID = "-1";

        public FrmMain()
        {
            conn = new SqlConnection(
                @"Server = (localdb)\MSSQLLocalDB;" +
                //"Database = kozossegiSzolgalat;");
                $"AttachDbFileName = {Program.dbFileLocation}");
            InitializeComponent();
            cbEvismetlo.SelectedIndex = 0;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DgvFeltolt();
        }


        private void DgvFeltolt()
        {
            dgvTanulok.Rows.Clear();
            conn.Open();
            var r = new SqlCommand("SELECT * FROM gyak_tanulo;", conn)
                .ExecuteReader();
            while (r.Read())
            {
                dgvTanulok.Rows.Add(
                    r[0], r[1], r[2], r[3], 
                    r.GetBoolean(4) ? "IGEN" : "NEM");
            }
            conn.Close();
            dgvTanulok.ClearSelection();

            foreach (var ctrl in this.Controls)
                if (ctrl is TextBox) (ctrl as TextBox).Text = "";
            btnAdatokModositasa.Enabled = false;
            rtbKSzAdatok.Text = "Szervezetek, ahol teljesítette (név és óra):\n";
        }

        #region connTeszt
        //private void ConnectionTest()
        //{
        //    conn.Open();
        //    var r = new SqlCommand(
        //        "SELECT TOP 1 nev FROM gyak_tanulo;", conn)
        //        .ExecuteReader();
        //    r.Read();
        //    Debug.WriteLine(r[0]);
        //    conn.Close();
        //}
        #endregion

        private void DgvTanulok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdatokModositasa.Enabled = true;

            #region modositas
            selectedID = dgvTanulok.SelectedRows[0].Cells[0].Value.ToString();

            tbNev.Text = dgvTanulok.SelectedRows[0].Cells[1].Value.ToString();
            tbEvfolyam.Text = dgvTanulok.SelectedRows[0].Cells[2].Value.ToString();
            tbOsztaly.Text = dgvTanulok.SelectedRows[0].Cells[3].Value.ToString();
            cbEvismetlo.SelectedIndex = dgvTanulok.SelectedRows[0].Cells[4].Value.ToString() == "IGEN" ? 1 : 0;
            #endregion

            #region statisztika
            rtbKSzAdatok.Text = "Szervezetek, ahol teljesítette (név és óra):\n";

            conn.Open();
            var r = new SqlCommand(
                "SELECT szervezet, oraszam FROM gyak_munka " +
                $"WHERE tanuloId = {selectedID};", conn)
                .ExecuteReader();

            int osszOra = 0;
            while (r.Read())
            {
                osszOra += r.GetInt32(1);
                rtbKSzAdatok.Text += $"{r[0]} ({r[1]} óra)\n";
            }
            conn.Close();

            tbOsszOra.Text = $"{osszOra}";
            tbMegvan50.Text = osszOra >= 50 ? "IGEN" : "NEM";
            #endregion
        }

        private void BtnAdatokModositasa_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(
                "Biztosan végre szeretnéd hajtani a módisítást?",
                "MEGERŐSÍTÉS",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if(res == DialogResult.Yes)
            {
                conn.Open();
                new SqlCommand(
                    "UPDATE gyak_tanulo SET " +
                    $"nev = '{tbNev.Text}', " +
                    $"evfolyam = '{tbEvfolyam.Text}', " +
                    $"osztaly = '{tbOsztaly.Text}', " +
                    $"evismetlo = {cbEvismetlo.SelectedIndex} " +
                    $"WHERE id = {selectedID};", conn)
                    .ExecuteNonQuery();
                conn.Close();
                DgvFeltolt();

            }
        }

        private void BtnUjTanulo_Click(object sender, EventArgs e)
        {
            var frm = new FrmUjTanulo(conn);
            frm.ShowDialog();
            DgvFeltolt();
        }
    }
}
