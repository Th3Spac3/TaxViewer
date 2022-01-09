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

namespace TaxViewer
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.loginField.Size.Width, 34);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login window = new Login();
            window.Show();
        }


        private void regButton_Click(object sender, EventArgs e)
        {
            if(loginField.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (passField.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (isUserExists() == true)
                return;

            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `access`) VALUES (@uL, @uP, 'user')", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passField.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Регистрация заершена");
                this.Hide();
                Login window = new Login();
                window.Show();
            }
            else
                MessageBox.Show("Регистрация не удалась");

            db.closeConnection();
        }
        public Boolean isUserExists()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Данный логин уже существует, введите другой");
                return true;
            }
            else
                return false;

        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            this.CloseButton.ForeColor = Color.White;
            this.CloseButton.BackColor = Color.FromArgb(219, 171, 4);
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            this.CloseButton.ForeColor = Color.FromArgb(219, 171, 4);
            this.CloseButton.BackColor = Color.FromArgb(139, 4, 28);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
