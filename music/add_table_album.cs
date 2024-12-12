using conditerskaya;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace music
{
    public partial class add_table_album : Form
    {
        database database = new database();
        public add_table_album(string s)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            check_open = s;
            if (s == "authors")
            {
                text_date_drop.Visible = false;
                lbl_for_datedrop.Visible = false;
                button_for_datedrop.Visible = false;
                lbl_for_pros.Text = "Прослушивания";
                lbl_for_pros.Location = new Point(94, 148);
                lbl_for_nick.Location = new Point(121, 105);
                lbl_for_nick.Text = "Псевдоним";
                CB_style.Visible = false;
            }
            else text_style.Visible = false;
        }

        string check_open;

        private void add_table_album_Load(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string[] inp_text_value;
                string query_string = "";
                if (check_open == "albums")
                {
                    inp_text_value = new string[] { text_title.Text, text_date_drop.Text, CB_style.Text };
                    query_string = $"insert into album(title, id_style, data_drop) values ('{inp_text_value[0]}', '{inp_text_value[2]}', '{inp_text_value[1]}')";
                }
                if (check_open == "songs")
                {
                    inp_text_value = new string[] { text_title.Text, text_date_drop.Text, CB_style.Text };
                    query_string = $"insert into song(title, id_style, data_drop) values ('{inp_text_value[0]}', '{inp_text_value[2]}', '{inp_text_value[1]}')";
                }
                if (check_open == "authors")
                {
                    inp_text_value = new string[] { text_title.Text, text_style.Text };
                    query_string = $"insert into author(nickname, proslushivane) values ('{inp_text_value[0]}', '{inp_text_value[1]}')";
                }

                //string[] inp_text_value = { text_title.Text, text_date_drop.Text, text_style.Text };
                //string query_string = $"insert into album(title, id_style, data_drop) values ('{inp_text_value[0]}', '{inp_text_value[2]}', '{inp_text_value[1]}')";
                SqlCommand command = new SqlCommand(query_string, database.getSqlConnection());
                database.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                MessageBox.Show("Строка добавлена!");
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
    }
}
