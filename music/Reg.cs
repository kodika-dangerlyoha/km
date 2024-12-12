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
    public partial class Reg : Form
    {
        // типо ссылка на класс с подключением к бд, чтоб использовать функции класса внутри данной формы
        database database = new database();
        public Reg()
        {
            InitializeComponent();
            // чтоб по центру форма открывалась 
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Reg_Load(object sender, EventArgs e)
        {
           // установка максимаьной длины вводимого значения для полей
            text_login.MaxLength = 50;
            text_password.MaxLength = 50;
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            try
            {
                // переменные в которые суем логин пароль и имя
                var login = text_login.Text;
                var password = text_password.Text;
                var name = text_name.Text;

                if (check_user(login) == false)
                {
                    // че-то с запросом
                    SqlCommand command = new SqlCommand($"insert into [user](name, familia, password, id_user_status) values('{name}', '{login}', '{password}', '2')", database.getSqlConnection());
                    database.openConnection();

                    // проверка все получилось или нет
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Пользователь зарегистрирован");
                        Auth auth = new Auth();
                        this.Hide();
                        auth.F_auth(login, password);
                    }
                    else MessageBox.Show("ERROR");
                }
                database.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Boolean check_user(string login)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();  
            DataTable dt = new DataTable();

            // запрос в бд кидаем
            SqlCommand command = new SqlCommand($"select familia from [user] where familia = '{login}'", database.getSqlConnection());

            // тоже кидаем запрос 
            adapter.SelectCommand = command;
            // адаптер че-то заполняет
            adapter.Fill(dt);

            // проверка найден ли пользователь с таким логином или нет
            if (dt.Rows.Count > 0) {
                MessageBox.Show("Пользователь уже существует");
                return true; // возвращает true 
            } 
            else return false; // иначе возвращает false
        }

        private void button_toAuth_Click(object sender, EventArgs e)
        {
            Auth a = new Auth();
            this.Hide();
            a.Show();
        }

        private void text_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void text_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_name_Click(object sender, EventArgs e)
        {
            if (text_name.Text == "Имя")
            {
                text_name.Text = "";
            }
        }

        private void text_name_Leave(object sender, EventArgs e)
        {
            if (text_name.Text == "")
            {
                text_name.Text = "Имя";
            }
        }

        private void text_login_Leave(object sender, EventArgs e)
        {
            if (text_login.Text == "")
            {
                text_login.Text = "Логин";
            }
        }

        private void text_login_Click(object sender, EventArgs e)
        {
            if (text_login.Text == "Логин")
            {
                text_login.Text = "";
            }
        }

        private void text_password_Leave(object sender, EventArgs e)
        {
            if (text_password.Text == "")
            {
                text_password.Text = "Пароль";
            }
        }

        private void text_password_Click(object sender, EventArgs e)
        {
            if (text_password.Text == "Пароль")
            {
                text_password.Text = "";
            }
        }
    }
}
