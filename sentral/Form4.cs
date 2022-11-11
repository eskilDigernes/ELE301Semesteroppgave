using Npgsql;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            FyllICB();
        }

        private void cbKortID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRomNr_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLeggTil_Click(object sender, EventArgs e)
        {

        }

        private void btnEndre_Click(object sender, EventArgs e)
        {

        }

        private void btnSlett_Click(object sender, EventArgs e)
        {

        }

        private void btnAvslutt_Click(object sender, EventArgs e)
        {

        }

        private async void FyllICB()
        {
            var connection = "Host=20.56.240.122;Username=h116036;Password=p0stgr3s!;Database=h116036";
            using (var con = new NpgsqlConnection(connection))
            {
                await con.OpenAsync();

                try
                {
                    await using (var cmd = new NpgsqlCommand($"SELECT kortid FROM brukar", con))
                    await using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            cbKortID.Items.Add(reader.GetInt32(0));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Feil:\n\n{ex.Message}");
                }
                con.CloseAsync();
            }
        }
    }
}
