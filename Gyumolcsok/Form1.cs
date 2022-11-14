using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Gyumolcsok
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "gyumolcsok";
            conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                //-- terv szerint
                conn.Open();
                cmd = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                //-- váratlan hiba!
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!!");
                Environment.Exit(0);

            }
            finally
            {
                //-- Hiba és terv szerinti esetén is lefut
                conn.Close();
            }
            
        }
        private void gyumolcs_update()
        {
            listBox_gyum.Items.Clear();
            cmd.CommandText = "SELECT `id`,`nev`,`egysegar`,`mennyiseg` FROM `gyumolcsok` WHERE 1";
            conn.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    gyumolcs uj = new gyumolcs(dr.GetInt32("id"), dr.GetString("nev"), dr.GetInt32("egysegar"), dr.GetInt32("mennyiseg"));
                    listBox_gyum.Items.Add(uj);
                }
            }
            conn.Close();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            //-- szükséges adatok ellenőrzése
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Adjon meg egy gyümölcs nevet!");
                textBox_nev.Focus();
                return;
            }
            if (numericUpDown_mennyiseg.Value > 1000)
            {
                MessageBox.Show("Érvénytelen mennyiség!!!");
                numericUpDown_mennyiseg.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox_egysegar.Text))
            {
                MessageBox.Show("Nem adott meg egyséárat!!");
                textBox_egysegar.Focus();
                return;
            }
            //-- Kiírjuk az adatbázisba --------
            cmd.CommandText = "INSERT INTO `gyumolcsok` (`id`, `nev`, `egysegar`, `mennyiseg`) VALUES (NULL, @nev, @egysegar, @mennyiseg)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nev", textBox_nev.Text);
            cmd.Parameters.AddWithValue("@egysegar", numericUpDown_mennyiseg.Value.ToString());
            cmd.Parameters.AddWithValue("@mennyiseg", textBox_egysegar.Text);
            conn.Open();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzítve!");
                    textBox_id.Text = "";
                    textBox_nev.Text = "";
                    numericUpDown_mennyiseg.Value = numericUpDown_mennyiseg.Minimum;
                    textBox_egysegar.Text = "";
                }
                else
                {
                    MessageBox.Show("Sikertelen rögzítés!");
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            gyumolcs_update();
        }
    }
}
