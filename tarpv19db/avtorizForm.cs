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

namespace tarpv19db
{
    public partial class avtorizForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\andmed.mdf; Integrated Security = True");
        private SqlCommand command;
        private SqlDataAdapter adapter;
        public avtorizForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login.Text != "" && passo.Text != "")
            {
                string login_ = login.Text;
                string password_ = passo.Text;

                connect.Open();

                DataTable table = new DataTable();//выделяем память для таблицы 

                adapter = new SqlDataAdapter();//память выделяем для адаптера

                command = new SqlCommand("SELECT * FROM avtorizatsija WHERE Login = @loginsi AND Password = @passvirdi", connect);//запрос в котором будут браться логин и пароль если в таблице такие имеются

                command.Parameters.AddWithValue("@loginsi", login_);//заглушки
                command.Parameters.AddWithValue("@passvirdi", password_);

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)//проверка сколько там строк и существует ли пользователь
                {
                    Form1 mainForm = new Form1();//другую форму открываем 
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sisselogimine ebaõnnestus");
                }

                connect.Close();
            }
        }
    }
}