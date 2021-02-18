using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WFA210218
{
    public partial class FrmUjTanulo : Form
    {
        readonly SqlConnection conn;
        public FrmUjTanulo(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void BtnUjTanulo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNev.Text) ||
                string.IsNullOrWhiteSpace(tbOsztaly.Text) ||
                cbEvfolyam.SelectedIndex == -1 ||
                cbEvismetlo.SelectedIndex == -1)
            {
                MessageBox.Show("Az űrlap kitöltése hiányos!");
            }

            else
            {
                var res = MessageBox.Show(
                "Biztosan szeretnéd rögzíteni az új tanulót?",
                "MEGERŐSÍTÉS",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    conn.Open();
                    new SqlCommand(
                        "INSERT INTO gyak_tanulo VALUES " +
                        $"('{tbNev.Text}', {cbEvfolyam.Text}, '{tbOsztaly.Text}', {cbEvismetlo.SelectedIndex});", conn)
                        .ExecuteNonQuery();
                    conn.Close();
                    this.Dispose();
                }
            }
            
        }
    }
}
