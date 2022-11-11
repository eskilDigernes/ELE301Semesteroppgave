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
    public partial class SlettBruker : Form
    {
        public SlettBruker()
        {
            InitializeComponent();
            FyllICB();
        }

        private async void cbKortID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int kortid = Convert.ToInt32(cbKortID.SelectedItem);
            var connection = "Host=20.56.240.122;Username=h116036;Password=p0stgr3s!;Database=h116036";
            using (var con = new NpgsqlConnection(connection))
            {
                await con.OpenAsync();

                try
                {
                    await using (var cmd = new NpgsqlCommand($"SELECT * FROM brukar WHERE kortid = {kortid}", con))
                    await using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            txtFornavn.Text = reader.GetString(1);
                            txtEtternavn.Text = reader.GetString(2);
                            txtEpost.Text = reader.GetString(3);
                            txtPin.Text = Convert.ToString(reader.GetInt32(4));
                            dtPickDate.Value = DateTime.Parse(Convert.ToString(reader.GetDate(5)));
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

        public async void FyllICB()
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

        private async void btnSlett_Click(object sender, EventArgs e)
        {
            int kortid = Convert.ToInt32(cbKortID.SelectedItem);
            var connection = "Host=20.56.240.122;Username=h116036;Password=p0stgr3s!;Database=h116036";
            using (var con = new NpgsqlConnection(connection))
            {
                await con.OpenAsync();

                try
                {
                    await using (var cmd = new NpgsqlCommand($"DELETE FROM brukar WHERE kortid = {kortid}", con))
                        await cmd.ExecuteNonQueryAsync();
                    MessageBox.Show("Bruker sletta: OK");
                    cbKortID.Items.Clear();
                    FyllICB();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Feil:\n\n{ex.Message}");
                }
                con.CloseAsync();
            }
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnEndre_Click(object sender, EventArgs e)
        {
            int kortid = Convert.ToInt32(cbKortID.SelectedItem);
            var connection = "Host=20.56.240.122;Username=h116036;Password=p0stgr3s!;Database=h116036";
            using (var con = new NpgsqlConnection(connection))
            {
                await con.OpenAsync();

                string etternavn = txtEtternavn.Text;
                string fornavn = txtFornavn.Text;
                string epost = txtEpost.Text;
                int pin = int.Parse(txtPin.Text);
                DateTime gyldighet = dtPickDate.Value.Date;

                try
                {
                    await using var cmd = new NpgsqlCommand($"UPDATE brukar SET etternavn = '{etternavn}', fornavn = '{fornavn}', " +
                        $"epost = '{epost}', pin = {pin}, gyldighet = '{gyldighet}' WHERE kortid = {kortid}", con);
                    await cmd.ExecuteNonQueryAsync();
                    //cbKortID.Items.Clear();
                    //FyllICB();
                    MessageBox.Show("Bruker endra: OK");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Feil:\n\n{ex}");
                }
                con.CloseAsync();
            }
        }
    }
}
