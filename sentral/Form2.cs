using Npgsql;
using Npgsql.Internal.TypeHandlers.LTreeHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sentral
{
    public partial class LeggTilBruker : Form
    {
        public LeggTilBruker()
        {
            InitializeComponent();
        }

        private void txtEtternavn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFornavn_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEpost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKortID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGyldighet_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtPin_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnLeggTil_Click(object sender, EventArgs e)
        {
            var connection = "Host=20.56.240.122;Username=h116036;Password=p0stgr3s!;Database=h116036";
            using (var con = new NpgsqlConnection(connection))
            {
                await con.OpenAsync();

                int kortid = int.Parse(txtKortID.Text);
                string etternavn = txtEtternavn.Text;
                string fornavn = txtFornavn.Text;
                string epost = txtEpost.Text;
                int pin = int.Parse(txtPin.Text);
                DateTime gyldighet = dtPickDate.Value.Date;

                try
                {
                    await using var cmd = new NpgsqlCommand($"INSERT INTO brukar VALUES ({kortid}, '{fornavn}', '{etternavn}', '{epost}', {pin}, '{gyldighet}')", con);
                    await cmd.ExecuteNonQueryAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Feil:\n\n{ex.Message}");
                }
                MessageBox.Show("Bruker lagt til: OK");
            }
        }
        private void btnTom_Click(object sender, EventArgs e)
        {
            txtEtternavn.Clear();
            txtFornavn.Clear();
            txtEpost.Clear();
            txtKortID.Clear();
            txtPin.Clear();
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {   
            Close();
        }

        private void dtPickDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
