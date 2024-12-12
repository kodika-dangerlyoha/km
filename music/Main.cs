using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using conditerskaya;

namespace music
{
    public partial class Main : Form
    {
        database database = new database();
        public Main()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            
        }

        public void check_user(int a)
        {
            if (a == 2)
            {
                button_remoove_albom.Visible = false;
                button_change_albom.Visible = false;
                button_add_albom.Visible = false;
            }
        }

        // переменная в которую будет вписываться номер выделенной строки датаГридВью
        int selected_row_album;
        //int selected_row_track; ЭТ НЕ НАДО
        //int selected_row_author; ЭТ НЕ НАДО

        // переменная в которую будет вписываться выделенная строка со всеми ее данными
        DataGridViewRow row;

        // функции которые запускаются, когда кликаем по строке в датаГридВью
        private void grid_albums_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grid_albums.Rows.Count - 1)
            {
                // присваеваем номер выделенной строки в переменную selected_row_album
                selected_row_album = e.RowIndex;
                // присваеваем всю выделенную строку с данными в переменную row
                row = grid_albums.Rows[selected_row_album];
            }
        }

        private void grid_song_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grid_song.Rows.Count - 1)
            {
                // присваеваем номер выделенной строки в переменную selected_row_album
                selected_row_album = e.RowIndex;
                // присваеваем всю выделенную строку с данными в переменную row
                row = grid_song.Rows[selected_row_album];
            }
        }

        private void grid_authors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grid_authors.Rows.Count - 1)
            {
                // присваеваем номер выделенной строки в переменную selected_row_album
                selected_row_album = e.RowIndex;
                // присваеваем всю выделенную строку с данными в переменную row
                row = grid_authors.Rows[selected_row_album];
            }
        }


        public void Create_colums()
        {
            // создание колонок в таблице(датаГридВью) grid_authors
            grid_authors.Columns.Add("id_author", "id");
            grid_authors.Columns.Add("nickname", "Ник");
            grid_authors.Columns.Add("proslushivane", "Прослушивания");

            // создание колонок в таблице(датаГридВью) grid_song
            grid_song.Columns.Add("id_song", "id");
            grid_song.Columns.Add("title", "Название");
            grid_song.Columns.Add("id_style", "Стиль");

            // создание колонок в таблице(датаГридВью) grid_albums
            grid_albums.Columns.Add("id_album", "id");
            grid_albums.Columns.Add("title", "Название");
            grid_albums.Columns.Add("id_style", "Стиль");
        }

        public void Read_single_row(DataGridView dgw, IDataRecord record, int n)
        {
            if (n == 0) dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetInt32(2));
            else if (n == 1) dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(3));
            else if (n == 2) dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2));
            else if (n == 3) dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2));
        }

        public void Refresh_data_grid(DataGridView dgw, string table, int n)
        {
            dgw.Rows.Clear();

            string query_string = "null";
            if (n == 0) query_string = $"select * from author";
            else if (n == 1) query_string = $"select song.id_song, song.title, song.data_drop, style.title from song join style ON song.id_style = style.id_style";
            else if (n == 2) query_string = $"select Album.id_album, Album.title, style.title from album join style ON album.id_style = style.id_style";

            SqlCommand command = new SqlCommand(query_string, database.getSqlConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Read_single_row(dgw, reader, n);
            }
            reader.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Create_colums();
            Refresh_data_grid(grid_authors, "author", 0);
            Refresh_data_grid(grid_song, "song", 1);
            Refresh_data_grid(grid_albums, "album", 2);

            grid_authors.Visible = false;
            grid_albums.Visible = false;
            grid_song.Visible = true;

            grid_name = grid_song;
        }

        private void button_authors_Click(object sender, EventArgs e)
        {
            lbl_title_main.Text = "Исполнители";
            grid_song.Visible = false;
            grid_albums.Visible = false;
            grid_authors.Visible = true;
            check_open = "authors";
            grid_name = grid_authors;
            Search(grid_name);
        }

        private void button_songs_Click(object sender, EventArgs e)
        {
            lbl_title_main.Text = "Треки";
            grid_authors.Visible = false;
            grid_albums.Visible = false;
            grid_song.Visible = true;
            check_open = "songs";
            grid_name = grid_song;
            Search(grid_name);
        }

        private void button_albums_Click(object sender, EventArgs e)
        {
            lbl_title_main.Text = "Альбомы";
            grid_authors.Visible = false;
            grid_song.Visible = false;
            grid_albums.Visible = true;
            check_open = "albums";
            grid_name = grid_albums;
            Search(grid_name);
        }

        string check_open = "songs";
        DataGridView grid_name;
        private void Search(DataGridView dgw)
        {   
            try
            {
                if (TB_search.Text != "Поиск")
                {
                    dgw.Rows.Clear();
                    string search_string = "songs";
                    int z = 1;
                    if (check_open == "albums")
                    {
                        search_string = $"select album.id_album, album.title, style.title from album join style ON album.id_style = style.id_style where concat (id_album, album.title, style.title) like '%" + TB_search.Text + "%'";
                        z = 2;
                    }
                    else if (check_open == "songs")
                    {
                        search_string = $"select song.id_song, song.title, style.title from song join style ON song.id_style = style.id_style where concat (id_song, song.title, style.title) like '%" + TB_search.Text + "%'";
                        z = 3;
                    }
                    else if (check_open == "authors")
                    {
                        search_string = $"select * from [author] where concat (id_author, nickname) like '%" + TB_search.Text + "%'";
                        z = 0;
                    }

                    SqlCommand command = new SqlCommand(search_string, database.getSqlConnection());
                    database.openConnection();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Read_single_row(dgw, reader, z);
                    }

                    reader.Close();
                }
                else
                {
                    Refresh_data_grid(grid_authors, "author", 0);
                    Refresh_data_grid(grid_song, "song", 1);
                    Refresh_data_grid(grid_albums, "album", 2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TB_search_TextChanged(object sender, EventArgs e)
        {
            Search(grid_name);
        }

        private void button_smena_akka_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth();
            this.Hide();
            auth.ShowDialog();
        }

        private void TB_search_Click(object sender, EventArgs e)
        {
            if (TB_search.Text == "Поиск")
            {
                TB_search.Text = "";
            }
        }

        private void TB_search_Leave(object sender, EventArgs e)
        {
            if (TB_search.Text == "")
            {
                TB_search.Text = "Поиск";
            }
        }

        private void button_remoove_albom_Click(object sender, EventArgs e)
        {
            Delete_Row();
        }

        public void Delete_Row()
        {
            //DataGridViewRow row = grid_albums.Rows[selected_row_album];
            string value_id = row.Cells[0].Value.ToString();
            string query_string = "";
            string query_string_2 = "";
            string query_string_3 = "";
            string query_string_4 = "";
            if (check_open == "albums")
            {
                query_string = $"delete from album_author where id_album={value_id}";
                query_string_2 = $"delete from album_song where id_album={value_id}";
                query_string_3 = $"delete from album where id_album={value_id}";
                SqlCommand command = new SqlCommand(query_string, database.getSqlConnection());
                SqlCommand command_2 = new SqlCommand(query_string_2, database.getSqlConnection());
                SqlCommand command_3 = new SqlCommand(query_string_3, database.getSqlConnection());
                database.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                reader = command_2.ExecuteReader();
                reader.Close();
                reader = command_3.ExecuteReader();
                reader.Close();

                Refresh_data_grid(grid_albums, "album", 2);
            }
            else if (check_open == "songs")
            {
                query_string = $"delete from song_prod where id_song={value_id}";
                query_string_2 = $"delete from song_author_list where id_song={value_id}";
                query_string_3 = $"delete from album_song where id_song={value_id}";
                query_string_4 = $"delete from song where id_song={value_id}";
                SqlCommand command = new SqlCommand(query_string, database.getSqlConnection());
                SqlCommand command_2 = new SqlCommand(query_string_2, database.getSqlConnection());
                SqlCommand command_3 = new SqlCommand(query_string_3, database.getSqlConnection());
                SqlCommand command_4 = new SqlCommand(query_string_4, database.getSqlConnection());
                database.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                reader = command_2.ExecuteReader();
                reader.Close();
                reader = command_3.ExecuteReader();
                reader.Close();
                reader = command_4.ExecuteReader();
                reader.Close();

                Refresh_data_grid(grid_song, "song", 1);
            }
            else if (check_open == "authors")
            {
                query_string = $"delete from album_author where id_author={value_id}";
                query_string_2 = $"delete from song_author_list where id_author={value_id}";
                query_string_3 = $"delete from author where id_author={value_id}";
                SqlCommand command = new SqlCommand(query_string, database.getSqlConnection());
                SqlCommand command_2 = new SqlCommand(query_string_2, database.getSqlConnection());
                SqlCommand command_3 = new SqlCommand(query_string_3, database.getSqlConnection());
                database.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();
                reader = command_2.ExecuteReader();
                reader.Close();
                reader = command_3.ExecuteReader();
                reader.Close();

                Refresh_data_grid(grid_authors, "author", 0);
            }
            
            //if (check_open == "albums") Refresh_data_grid(grid_albums, "album", 2);
            //if (check_open == "songs") Refresh_data_grid(grid_song, "song", 1);
            //if (check_open == "authors") Refresh_data_grid(grid_authors, "author", 0);
        }

        private void button_songs_MouseEnter(object sender, EventArgs e)
        {
            ico_music.BackColor = ColorTranslator.FromHtml("#D1D1D7");
        }

        private void button_songs_MouseLeave(object sender, EventArgs e)
        {
            ico_music.BackColor = Color.Transparent;
        }

        private void button_albums_MouseEnter(object sender, EventArgs e)
        {
            ico_album.BackColor = ColorTranslator.FromHtml("#D1D1D7");
        }

        private void button_albums_MouseLeave(object sender, EventArgs e)
        {
            ico_album.BackColor = Color.Transparent;
        }

        private void button_authors_MouseEnter(object sender, EventArgs e)
        {
            ico_author.BackColor = ColorTranslator.FromHtml("#D1D1D7");
        }

        private void button_authors_MouseLeave(object sender, EventArgs e)
        {
            ico_author.BackColor = Color.Transparent;
        }

        private void button_change_albom_Click(object sender, EventArgs e)
        {
            //DataGridViewRow row = grid_albums.Rows[selected_row_album];
            change_table_album change_table_album_ = new change_table_album(row, check_open);
            change_table_album_.Show();
            this.Hide();
        }

        private void button_add_albom_Click(object sender, EventArgs e)
        {
            add_table_album add_table_album = new add_table_album(check_open);
            add_table_album.Show();
            this.Hide();
        }
    }
}
