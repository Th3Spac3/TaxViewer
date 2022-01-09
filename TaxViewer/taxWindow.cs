using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;

namespace TaxViewer
{
    public partial class taxWindow : Form
    {
        public taxWindow()
        {
            InitializeComponent();
            searchTIN.Text = "ИНН";
            taxTIN.Text = "ИНН";
            taxName.Text = "Название";

            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `tax`",db.getConnection());

            adapter.SelectCommand = command;

            adapter.Fill(table);

            taxTable.DataSource = table;
            taxTable.Columns[0].HeaderText = "ИНН налоговой инспекции";
            taxTable.Columns[0].Width = 200;
            taxTable.Columns[1].HeaderText = "Название налоговой инспекции";
            taxTable.Columns[1].Width = 200;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        Boolean isWindowMax = true;
        private void minmaxButton_Click(object sender, EventArgs e)
        {
            if (isWindowMax == true)
            {
                this.WindowState = FormWindowState.Maximized;
                isWindowMax = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                isWindowMax = true;
            }
        }

        private void collapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            if (isWindowMax == true)
            {
                this.WindowState = FormWindowState.Maximized;
                isWindowMax = false;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                isWindowMax = true;
            }
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

        private void minmaxButton_MouseEnter(object sender, EventArgs e)
        {
            this.minmaxButton.ForeColor = Color.White;
            this.minmaxButton.BackColor = Color.FromArgb(219, 171, 4);
        }

        private void minmaxButton_MouseLeave(object sender, EventArgs e)
        {
            this.minmaxButton.ForeColor = Color.FromArgb(219, 171, 4);
            this.minmaxButton.BackColor = Color.FromArgb(139, 4, 28);
        }

        private void collapseButton_MouseEnter(object sender, EventArgs e)
        {
            this.collapseButton.ForeColor = Color.White;
            this.collapseButton.BackColor = Color.FromArgb(219, 171, 4);
        }

        private void collapseButton_MouseLeave(object sender, EventArgs e)
        {
            this.collapseButton.ForeColor = Color.FromArgb(219, 171, 4);
            this.collapseButton.BackColor = Color.FromArgb(139, 4, 28);
        }

        private void searchTIN_Enter(object sender, EventArgs e)
        {
            if (searchTIN.Text == "ИНН")
                searchTIN.Text = "";
        }

        private void searchTIN_Leave(object sender, EventArgs e)
        {
            if (searchTIN.Text == "")
                searchTIN.Text = "ИНН";
        }

        private void taxTIN_Enter(object sender, EventArgs e)
        {
            if (taxTIN.Text == "ИНН")
                taxTIN.Text = "";
        }

        private void taxTIN_Leave(object sender, EventArgs e)
        {
            if (taxTIN.Text == "")
                taxTIN.Text = "ИНН";
        }

        private void taxName_Enter(object sender, EventArgs e)
        {
            if (taxName.Text == "Название")
                taxName.Text = "";
        }

        private void taxName_Leave(object sender, EventArgs e)
        {
            if (taxName.Text == "")
                taxName.Text = "Название";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(searchTIN.Text == "ИНН")
            {
                DataBase db = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `tax`", db.getConnection());

                adapter.SelectCommand = command;

                adapter.Fill(table);

                taxTable.DataSource = table;
                taxTable.Columns[0].HeaderText = "ИНН налоговой инспекции";
                taxTable.Columns[0].Width = 200;
                taxTable.Columns[1].HeaderText = "Название налоговой инспекции";
                taxTable.Columns[1].Width = 200;
            }
            else
            {
                DataBase db = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `tax` WHERE `taxID` = @TIN", db.getConnection());
                command.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = searchTIN.Text;

                adapter.SelectCommand = command;

                adapter.Fill(table);

                taxTable.DataSource = table;
                taxTable.Columns[0].HeaderText = "ИНН налоговой инспекции";
                taxTable.Columns[0].Width = 200;
                taxTable.Columns[1].HeaderText = "Название налоговой инспекции";
                taxTable.Columns[1].Width = 200;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(taxAccess == "administrator")
            {
                DataBase db = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `tax` WHERE `taxID` = @TIN", db.getConnection());
                command.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = searchTIN.Text;

                adapter.SelectCommand = command;

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MySqlCommand command1 = new MySqlCommand("DELETE FROM `tax` WHERE `taxID` = @TIN", db.getConnection());
                    command1.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = searchTIN.Text;

                    db.openConnection();

                    if (command1.ExecuteNonQuery() == 1)
                        MessageBox.Show("Запись успешно удалена");
                    else
                        MessageBox.Show("Не удалось удалить запись");

                    db.closeConnection();

                    DataTable table1 = new DataTable();

                    MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                    MySqlCommand command2 = new MySqlCommand("SELECT * FROM `tax`", db.getConnection());

                    adapter1.SelectCommand = command2;

                    adapter1.Fill(table1);

                    taxTable.DataSource = table1;
                    taxTable.Columns[0].HeaderText = "ИНН налоговой инспекции";
                    taxTable.Columns[0].Width = 200;
                    taxTable.Columns[1].HeaderText = "Название налоговой инспекции";
                    taxTable.Columns[1].Width = 200;
                }
                else
                {
                    MessageBox.Show("Налоговой с таким ИНН не существует");
                }
            }
            else
            {
                MessageBox.Show("Недостаточно прав", "info");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (taxAccess == "administrator")
            {
                DataBase db = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `tax` WHERE `taxID` = @TIN", db.getConnection());
                command.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = taxTIN.Text;

                adapter.SelectCommand = command;

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Налоговая с таким ИНН уже существует");
                }
                else
                {
                    MySqlCommand command1 = new MySqlCommand("INSERT INTO `tax` (`taxID`, `taxName`) VALUES (@TIN, @Name)", db.getConnection());
                    command1.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = taxTIN.Text;
                    command1.Parameters.Add("@Name", MySqlDbType.VarChar).Value = taxName.Text;

                    db.openConnection();

                    if (command1.ExecuteNonQuery() == 1)
                        MessageBox.Show("Запись успешно удалена");
                    else
                        MessageBox.Show("Не удалось удалить запись");

                    db.closeConnection();

                    DataTable table1 = new DataTable();

                    MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                    MySqlCommand command2 = new MySqlCommand("SELECT * FROM `tax`", db.getConnection());

                    adapter1.SelectCommand = command2;

                    adapter1.Fill(table1);

                    taxTable.DataSource = table1;
                    taxTable.Columns[0].HeaderText = "ИНН налоговой инспекции";
                    taxTable.Columns[0].Width = 200;
                    taxTable.Columns[1].HeaderText = "Название налоговой инспекции";
                    taxTable.Columns[1].Width = 200;
                }
            }
            else
            {
                MessageBox.Show("Недостаточно прав", "info");
            }
        }
        Point lastPoint;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (taxTable.Rows.Count > 0)

            {

                SaveFileDialog save = new SaveFileDialog();

                save.Filter = "PDF (*.pdf)|*.pdf";

                save.FileName = ".pdf";

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)

                {

                    if (File.Exists(save.FileName))

                    {

                        try

                        {

                            File.Delete(save.FileName);

                        }

                        catch (Exception ex)

                        {

                            ErrorMessage = true;

                            MessageBox.Show("Не удалось записать данные на диск" + ex.Message);

                        }

                    }

                    if (!ErrorMessage)

                    {

                        try

                        {

                            PdfPTable pTable = new PdfPTable(taxTable.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in taxTable.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in taxTable.Rows)

                            {

                                foreach (DataGridViewCell dcell in viewRow.Cells)

                                {

                                    pTable.AddCell(dcell.Value.ToString());

                                }

                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))

                            {

                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);

                                PdfWriter.GetInstance(document, fileStream);

                                document.Open();

                                document.Add(pTable);

                                document.Close();

                                fileStream.Close();

                            }

                            MessageBox.Show("Данные успешно экспортированны", "info");

                        }

                        catch (Exception ex)

                        {

                            MessageBox.Show("Произошла ошибка во время экспорта данных" + ex.Message);

                        }

                    }

                }

            }

            else

            {

                MessageBox.Show("No Record Found", "Info");

            }
        }
    }
}
