using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace sentral
{
    internal class SQLConnection
    {
        static string host = "20.56.240.122";
        static string username = "h116036";
        static string password = "p0stgr3s!";
        static string database = "h116036";

        public static string connection = $"host={host};username={username};password={password};database={database}";





        public static async Task<List<Users>>DisplayUsers()
        {
            List<Users> users = new List<Users>();
            try
            {
                using var con = new NpgsqlConnection(connection);
                await con.OpenAsync();
                await using (var cmd = new NpgsqlCommand("SELECT * FROM brukar", con))
                await using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        users.Add(new Users(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4), reader.GetDateTime(5)));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"ERROR\n\n{e}");
            }
            return users.ToList();
        }






        /*
        public async void DisplayUserlist()
        {
            var connection = "Host=20.56.240.122;Username=h116036;Password=p0stgr3s!;Database=h116036";
            using (var con = new NpgsqlConnection(connection))
            {
                await con.OpenAsync();

                try
                {
                    await using (var cmd = new NpgsqlCommand($"SELECT * FROM brukar", con))
                    await using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            DataGridViewRow newRow = new DataGridViewRow();

                            newRow.CreateCells(Sentral.dgwBrukere);
                            newRow.Cells[0].Value = reader.GetInt32(0);
                            newRow.Cells[1].Value = reader.GetString(1);
                            newRow.Cells[2].Value = reader.GetString(2);
                            newRow.Cells[3].Value = reader.GetString(3);
                            newRow.Cells[4].Value = reader.GetInt32(4);
                            newRow.Cells[5].Value = reader.GetDate(5);
                            Sentral.dgwBrukere.Rows.Add(newRow);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Feilmelding:\n\n{ex.Message}");
                }
            }
        }*/
    }
}