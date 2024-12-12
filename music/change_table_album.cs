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
    public partial class change_table_album : Form
    {
        database database = new database();
        public change_table_album(DataGridViewRow row, string s)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            r = row;
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
            } else text_style.Visible = false;
        }

        string check_open;

        DataGridViewRow r;

        private void change_table_album_Load(object sender, EventArgs e)
        {

        }

        private void button_chang_Click(object sender, EventArgs e)
        {
            try
            {

                string[] inp_text_value;
                string query_string = "";
                if (check_open == "albums")
                {
                    inp_text_value = new string[] { text_title.Text, text_date_drop.Text, CB_style.Text };
                    query_string = $"Update album set title = '{inp_text_value[0]}', id_style = '{inp_text_value[2]}', data_drop = '{inp_text_value[1]}' where id_album='{r.Cells[0].Value.ToString()}'";
                    MessageBox.Show(CB_style.ValueMember);
                }
                if (check_open == "songs")
                {
                    inp_text_value = new string[] { text_title.Text, text_date_drop.Text, CB_style.Text };
                    query_string = $"Update song set title = '{inp_text_value[0]}', id_style = '{inp_text_value[2]}', data_drop = '{inp_text_value[1]}' where id_song='{r.Cells[0].Value.ToString()}'";
                }
                if (check_open == "authors")
                {
                    inp_text_value = new string[] { text_title.Text, text_style.Text };
                    query_string = $"Update author set nickname = '{inp_text_value[0]}', proslushivane = '{inp_text_value[1]}' where id_author='{r.Cells[0].Value.ToString()}'";
                }

                //string[] inp_text_value = { text_title.Text, text_style.Text, text_date_drop.Text };
                //for (int i = 0; i < 3; i++)
                //{
                //    if (inp_text_value[i] == "")
                //    {
                //        inp_text_value[i] = r.Cells[i + 1].Value.ToString();
                //    }
                //}
                ///string query_string = "";
                //if (check_open == "albums") query_string = $"Update album set title = '{inp_text_value[0]}', id_style = '{inp_text_value[1]}', data_drop = '{inp_text_value[2]}' where id_album='{r.Cells[0].Value.ToString()}'";
                //if (check_open == "songs") query_string = $"Update song set title = '{inp_text_value[0]}', id_style = '{inp_text_value[1]}', data_drop = '{inp_text_value[2]}' where id_song='{r.Cells[0].Value.ToString()}'";
                //if (check_open == "authors") query_string = $"Update author set nickname = '{inp_text_value[0]}', proslushivane = '{inp_text_value[1]}' where id_author='{r.Cells[0].Value.ToString()}'";
                SqlCommand command = new SqlCommand(query_string, database.getSqlConnection());
                database.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                MessageBox.Show("Строка изменена!");
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

        private void text_style_TextChanged(object sender, EventArgs e)
        {

        }

        //public void Change_Row()
        //{
        //    string[] inp_text_value = { text_title.Text, text_style.Text, text_date_drop.Text };

        //    for (int i = 0; i < 3; i++)
        //    {
        //        if (inp_text_value[i] == "")
        //        {
        //            inp_text_value[i] = r.Cells[i + 1].Value.ToString();
        //        }
        //    }
        //    string query_string = $"Update album set title = '{inp_text_value[0]}', id_style = '{inp_text_value[1]}', data_drop = '{inp_text_value[2]}' where id_album='{r.Cells[0].Value.ToString()}'";
        //    SqlCommand command = new SqlCommand(query_string, database.getSqlConnection());
        //    database.openConnection();
        //    SqlDataReader reader = command.ExecuteReader();
        //    reader.Close();
        //}
    }
}
