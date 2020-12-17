using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarpv19db
{
    
    
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\andmed.mdf; Integrated Security = True");
        private SqlCommand command;
        private SqlDataAdapter adapter;
        int Id = 0;
        private void lisa_Data_Click(object sender, EventArgs e)
        {
            if (name_txt.Text != "" && surname_txt.Text != "" && tel_txt.Text != "" && gm_txt.Text != "")
            {
                command = new SqlCommand("insert into opilane(Nimi,Eesnimi,Foto,Telefon,Gmail) values(@nim,@ees,@foto,@tel,@gm)", connect);
                connect.Open();
                command.Parameters.AddWithValue("@nim", name_txt.Text);
                command.Parameters.AddWithValue("@ees", surname_txt.Text);
                command.Parameters.AddWithValue("@tel", surname_txt.Text);
                command.Parameters.AddWithValue("@gm", surname_txt.Text);
                string file_pilt = name_txt.Text + ".jpg";
                command.Parameters.AddWithValue("@foto", file_pilt);
                command.ExecuteNonQuery();
                connect.Close();
                ClearData();
                DisplayData();
                MessageBox.Show("Andmed on lisatud");

            }
            else
            {
                MessageBox.Show("Viga");
            }
        }

        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }
        private void ClearData()
        {
            Id = 0;
            name_txt.Text = "";
            surname_txt.Text = "";
            tel_txt.Text = "";

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            name_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            surname_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            pictureBox1.Image = Image.FromFile(@"C:\Users\Admin\source\repos\tarpv19db\tarpv19db\Image\" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            tel_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            gm_txt.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void DisplayData()
        {
            connect.Open();
            DataTable table = new DataTable();
            adapter = new SqlDataAdapter("SELECT * FROM opilane", connect);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            pictureBox1.Image = Image.FromFile("../../Image/kartinka.jpg");

            connect.Close();
        }

        private void delete_Data_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                command = new SqlCommand("DELETE opilane WHERE Id=@id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);

                command.ExecuteNonQuery();
                connect.Close();
                DisplayData();
                ClearData();

                MessageBox.Show("Andmed on lisatud");

            }
            else
            {
                MessageBox.Show("Viga kustutamisega");
            }
        }
        
        private void choose_Foto_Click(object sender, EventArgs e)
        {
            Bitmap image;
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    //вместо pictureBox1 укажите pictureBox, в который нужно загрузить изображение 
                    this.pictureBox1.Size = image.Size;
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void update_Data_Click(object sender, EventArgs e)
        {

            if (name_txt.Text != "" && surname_txt.Text != "" && tel_txt.Text != "")
            {
                command = new SqlCommand("UPDATE opilane SET Nimi=@nimi,Eesnimi=@ees,Foto=@foto,Telefon=@tel,Gmail=@gm WHERE Id=@id", connect);
                connect.Open();
                command.Parameters.AddWithValue("@id", Id);
                command.Parameters.AddWithValue("@nimi", name_txt.Text);
                command.Parameters.AddWithValue("@ees", surname_txt.Text);
                command.Parameters.AddWithValue("@tel", surname_txt.Text);
                command.Parameters.AddWithValue("@gm", surname_txt.Text);
                string file_pilt = name_txt.Text + ".jpg";
                command.Parameters.AddWithValue("@foto", file_pilt);
                command.ExecuteNonQuery();
                connect.Close();
                ClearData();
                DisplayData();
                MessageBox.Show("Andmed on muudetud");

            }
            else
            {
                MessageBox.Show("Viga!");
            }
        }
    }
    
}
