using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagokApplication
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server = localhost; Database = latvanyossagokdb; Uid = root; Pwd =;");
            conn.Open();
            AdatokListazasa();
            lakossagSzamModosit.Enabled = false;
            varosNevModosit.Enabled = false;
            latvanyossagNevModosit.Enabled = false;
            latvanyossagArModosit.Enabled = false;
            latvanyossagLeirasModosit.Enabled = false;
            latvanyossagModosit.Enabled = false;
            varosModosit.Enabled = false;
            latvanyossagLista.Enabled = false;
            latvanyossagTorles.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        void AdatokListazasa()
        {

            varosLista.Items.Clear();
           
            latvanyossagLista.Items.Clear();

            var command = conn.CreateCommand();
            command.CommandText = @"SELECT id,nev,lakossag FROM varosok ORDER BY nev";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var lakossag = reader.GetInt32("lakossag");


                    var varosok = new Varosok(id, nev, lakossag);
                    varosLista.Items.Add(varosok);
                    
                }
            }
            
        }

        private void varosHozzaad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(varosNev.Text) || lakosokSzama.Value < 0)
            {
                MessageBox.Show("Minden mezőt ki kell tölteni, és a lakosok számának nagyobbank kell lennie mint nulla!");
                return;
            }
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO varosok (nev, lakossag) VALUES (@nev,@lakossag)";
            cmd.Parameters.AddWithValue("@nev", varosNev.Text);
            cmd.Parameters.AddWithValue("@lakossag", lakosokSzama.Value);

            cmd.ExecuteNonQuery();

            AdatokListazasa();
            varosNev.Text = "";
            lakosokSzama.Value = 1;
        }

        private void latvanyossagHozzaad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(latvanyossagNev.Text) || string.IsNullOrWhiteSpace(latvanyossagLeiras.Text) || latvanyossagAr.Value < 0)
            {
                MessageBox.Show("Minden mezőt ki kell tölteni, és az ár nem lehet kisebb mint nulla!");
                return;
            }
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO latvanyossagok(nev, leiras, ar, varos_id) VALUES (@nev,@leiras,@ar,@varos_id)";
            cmd.Parameters.AddWithValue("@nev", latvanyossagNev.Text);
            cmd.Parameters.AddWithValue("@leiras", latvanyossagLeiras.Text);
            cmd.Parameters.AddWithValue("@ar", latvanyossagAr.Value);
            var varosok = (Varosok)varosLista.SelectedItem;
            cmd.Parameters.AddWithValue("@varos_id", varosok.Id);

            cmd.ExecuteNonQuery();
            AdatokListazasa();
        }


        private void varosTorol_Click(object sender, EventArgs e)
        {
            try
            {
                if (varosLista.SelectedIndex == -1)
                {
                    MessageBox.Show("Válasszon ki egy elemet a törléshez!");
                    return;
                }
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"DELETE FROM varosok WHERE id = @id";
                var varosok = (Varosok)varosLista.SelectedItem;
                cmd.Parameters.AddWithValue("@id", varosok.Id);
                cmd.ExecuteNonQuery();
                AdatokListazasa();
            }
            catch (Exception)
            {

                MessageBox.Show("A kiválasztott városhoz tartozik látványosság, ezért azt nem lehet törölni!");
            }
        }

        private void latvanyossagTorles_Click(object sender, EventArgs e)
        {
            if (latvanyossagLista.SelectedIndex == -1)
            {
                MessageBox.Show("Válasszon ki egy elemet a törléshez!");
                return;
            }
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"DELETE FROM latvanyossagok WHERE id = @id";
            var latvanyossag = (latvanyossagok)latvanyossagLista.SelectedItem;
            cmd.Parameters.AddWithValue(@"id", latvanyossag.Id);
            cmd.ExecuteNonQuery();

            latvanyossagListaz();


        }

        private void latvanyossagLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            latvanyossagTorles.Enabled = true;
            latvanyossagNevModosit.Enabled = true;
            latvanyossagLeirasModosit.Enabled = true;
            latvanyossagArModosit.Enabled = true;
            latvanyossagModosit.Enabled = true;
            var latvanyossagok = (latvanyossagok)latvanyossagLista.SelectedItem;
            latvanyossagNevModosit.Text = latvanyossagok.Nev;
            latvanyossagLeirasModosit.Text = latvanyossagok.Leiras;
            latvanyossagArModosit.Value = latvanyossagok.Ar;
        }

        private void varosLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            latvanyossagListaz();
            varosListaz();
            latvanyossagNevModosit.Enabled = false;
            latvanyossagLeirasModosit.Enabled = false;
            latvanyossagArModosit.Enabled = false;
            latvanyossagModosit.Enabled = false;
            varosNevModosit.Enabled = true;
            lakossagSzamModosit.Enabled = true;
            varosModosit.Enabled = true;
            latvanyossagLista.Enabled = true;

            var varosok = (Varosok)varosLista.SelectedItem;
            varosNevModosit.Text = varosok.Nev;
            lakossagSzamModosit.Value = varosok.Lakossag;

        }
        private void latvanyossagListaz()
        {
            latvanyossagLista.Items.Clear();
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT id,nev,leiras,ar,varos_id FROM latvanyossagok WHERE varos_id=@varos_id ORDER BY nev";
            var varos = (Varosok)varosLista.SelectedItem;
            cmd.Parameters.AddWithValue("@varos_id",varos.Id);
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var leiras = reader.GetString("leiras");
                    var ar = reader.GetInt32("ar");
                    var varos_id = reader.GetInt32("varos_id");

                    var latvanyossagok = new latvanyossagok(id, nev, leiras, ar, varos_id);
                    latvanyossagLista.Items.Add(latvanyossagok);

                }

            }
        }
        private void varosListaz()
        {
            var command = conn.CreateCommand();
            command.CommandText = @"SELECT id,nev,lakossag FROM varosok ORDER BY nev";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var id = reader.GetInt32("id");
                    var nev = reader.GetString("nev");
                    var lakossag = reader.GetInt32("lakossag");
                }
            }
        }

        

        private void varosModosit_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(varosNevModosit.Text) || lakossagSzamModosit.Value < 0)
            {
                MessageBox.Show("Minden mezőt ki kell tölteni, és a lakosok számának nagyobbank kell lennie mint nulla!");
                return;
            }
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"UPDATE varosok SET nev=@nev,lakossag=@lakossag WHERE id=@id";
            cmd.Parameters.AddWithValue("@nev", varosNevModosit.Text);
            cmd.Parameters.AddWithValue("@lakossag", lakossagSzamModosit.Value);
            var varosok = (Varosok)varosLista.SelectedItem;
            cmd.Parameters.AddWithValue("@id",varosok.Id);

            cmd.ExecuteNonQuery();
            AdatokListazasa();
            varosNevModosit.Text = "";
            lakossagSzamModosit.Value = 0;
            varosNevModosit.Enabled = false;
            lakossagSzamModosit.Enabled = false;
            varosModosit.Enabled = false;
        }

        private void latvanyossagModosit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(latvanyossagNevModosit.Text) || string.IsNullOrWhiteSpace(latvanyossagLeirasModosit.Text) ||  latvanyossagArModosit.Value < 0)
            {
                MessageBox.Show("Minden mezőt ki kell tölteni, és az árnak nagyobbank kell lennie mint nulla!");
                return;
            }
            var cmd = conn.CreateCommand();
            cmd.CommandText = @"UPDATE latvanyossagok SET nev=@nev,leiras=@leiras,ar=@ar WHERE id=@id";
            cmd.Parameters.AddWithValue("@nev",latvanyossagNevModosit.Text);
            cmd.Parameters.AddWithValue("@leiras", latvanyossagLeirasModosit.Text);
            cmd.Parameters.AddWithValue("@ar",latvanyossagArModosit.Value);
            var latvanyossagok = (latvanyossagok)latvanyossagLista.SelectedItem;
            cmd.Parameters.AddWithValue("@id", latvanyossagok.Id);

            cmd.ExecuteNonQuery();
            latvanyossagListaz();
            latvanyossagNevModosit.Text = "";
            latvanyossagLeirasModosit.Text = "";
            latvanyossagArModosit.Value = 0;
            latvanyossagNevModosit.Enabled = false;
            latvanyossagLeirasModosit.Enabled = false;
            latvanyossagArModosit.Enabled = false;
            latvanyossagModosit.Enabled = false;
        }
    }
}
