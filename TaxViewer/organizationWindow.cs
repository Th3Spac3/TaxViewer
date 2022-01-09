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
    public partial class organizationWindow : Form
    {
        public organizationWindow()
        {
            InitializeComponent();
            orgTINfield.Text = "ИНН";
            orgTIN.Text = "ИНН";
            orgAccSurname.Text = "Фамилия гл. бух.";
            orgAccName.Text = "Имя гл. бух.";
            orgAccPatron.Text = "Отчество гл. бух.";
            orgName.Text = "Название";
            phoneNumber.Text = "Телефон";
            addressCity.Text = "Город";
            addressStNumber.Text = "№";
            addressStreet.Text = "Улица";

            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT organization.orgID, concat(`accLName`, ' ', `accFName`, ' ', `accPatron`) AS Accountant, organization.orgName, organization.phoneNumber, concat(organization.addressCity, ', ул.', organization.addressStreet, ' ', organization.addressSNumber) AS Address FROM `organization`", db.getConnection());

            adapter.SelectCommand = command;

            adapter.Fill(table);

            orgTable.DataSource = table;
            orgTable.Columns[0].HeaderText = "ИНН организации";
            orgTable.Columns[0].Width = 100;
            orgTable.Columns[1].HeaderText = "ФИО главного бухгалтера";
            orgTable.Columns[1].Width = 200;
            orgTable.Columns[2].HeaderText = "Название организации";
            orgTable.Columns[2].Width = 200;
            orgTable.Columns[3].HeaderText = "Телефон";
            orgTable.Columns[3].Width = 70;
            orgTable.Columns[4].HeaderText = "Адрес";
            orgTable.Columns[4].Width = 200;
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

        private void orgTINfield_Enter(object sender, EventArgs e)
        {
            if (orgTINfield.Text == "ИНН")
                orgTINfield.Text = "";
        }

        private void orgTINfield_Leave(object sender, EventArgs e)
        {
            if (orgTINfield.Text == "")
                orgTINfield.Text = "ИНН";
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

        private void orgTIN_Enter(object sender, EventArgs e)
        {
            if (orgTIN.Text == "ИНН")
                orgTIN.Text = "";
        }

        private void orgTIN_Leave(object sender, EventArgs e)
        {
            if (orgTIN.Text == "")
                orgTIN.Text = "ИНН";
        }

        private void orgAccSurname_Enter(object sender, EventArgs e)
        {
            if (orgAccSurname.Text == "Фамилия гл. бух.")
                orgAccSurname.Text = "";
        }

        private void orgAccSurname_Leave(object sender, EventArgs e)
        {
            if (orgAccSurname.Text == "")
                orgAccSurname.Text = "Фамилия гл. бух.";
        }

        private void orgAccName_Enter(object sender, EventArgs e)
        {
            if (orgAccName.Text == "Имя гл. бух.")
                orgAccName.Text = "";
        }

        private void orgAccName_Leave(object sender, EventArgs e)
        {
            if (orgAccName.Text == "")
                orgAccName.Text = "Имя гл. бух.";
        }

        private void orgAccPatron_Enter(object sender, EventArgs e)
        {
            if (orgAccPatron.Text == "Отчество гл. бух.")
                orgAccPatron.Text = "";
        }

        private void orgAccPatron_Leave(object sender, EventArgs e)
        {
            if (orgAccPatron.Text == "")
                orgAccPatron.Text = "Отчество гл. бух.";
        }

        private void orgName_Enter(object sender, EventArgs e)
        {
            if (orgName.Text == "Название")
                orgName.Text = "";
        }

        private void orgName_Leave(object sender, EventArgs e)
        {
            if (orgName.Text == "")
                orgName.Text = "Название";
        }

        private void phoneNumber_Enter(object sender, EventArgs e)
        {
            if (phoneNumber.Text == "Телефон")
                phoneNumber.Text = "";
        }

        private void phoneNumber_Leave(object sender, EventArgs e)
        {
            if (phoneNumber.Text == "")
                phoneNumber.Text = "Телефон";
        }

        private void addressCity_Enter(object sender, EventArgs e)
        {
            if (addressCity.Text == "Город")
                addressCity.Text = "";
        }

        private void addressCity_Leave(object sender, EventArgs e)
        {
            if (addressCity.Text == "")
                addressCity.Text = "Город";
        }

        private void addressStreet_Enter(object sender, EventArgs e)
        {
            if (addressStreet.Text == "Улица")
                addressStreet.Text = "";
        }

        private void addressStreet_Leave(object sender, EventArgs e)
        {
            if (addressStreet.Text == "")
                addressStreet.Text = "Улица";
        }

        private void addressStNumber_Enter(object sender, EventArgs e)
        {
            if (addressStNumber.Text == "№")
                addressStNumber.Text = "";
        }

        private void addressStNumber_Leave(object sender, EventArgs e)
        {
            if (addressStNumber.Text == "")
                addressStNumber.Text = "№";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (orgTINfield.Text == "ИНН")
            {
                DataBase db = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT organization.orgID, concat(`accLName`, ' ', `accFName`, ' ', `accPatron`) AS Accountant, organization.orgName, organization.phoneNumber, concat(organization.addressCity, ', ул.', organization.addressStreet, ' ', organization.addressSNumber) AS Address FROM `organization`", db.getConnection());

                adapter.SelectCommand = command;

                adapter.Fill(table);

                orgTable.DataSource = table;
                orgTable.Columns[0].HeaderText = "ИНН организации";
                orgTable.Columns[0].Width = 100;
                orgTable.Columns[1].HeaderText = "ФИО главного бухгалтера";
                orgTable.Columns[1].Width = 200;
                orgTable.Columns[2].HeaderText = "Название организации";
                orgTable.Columns[2].Width = 200;
                orgTable.Columns[3].HeaderText = "Телефон";
                orgTable.Columns[3].Width = 70;
                orgTable.Columns[4].HeaderText = "Адрес";
                orgTable.Columns[4].Width = 200;
            }
            else
            {
                DataBase db = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT organization.orgID, concat(`accLName`, ' ', `accFName`, ' ', `accPatron`) AS Accountant, organization.orgName, organization.phoneNumber, concat(organization.addressCity, ', ул.', organization.addressStreet, ' ', organization.addressSNumber) AS Address FROM `organization` WHERE `orgID` = @TIN", db.getConnection());
                command.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = orgTINfield.Text;

                adapter.SelectCommand = command;

                adapter.Fill(table);

                orgTable.DataSource = table;
                orgTable.Columns[0].HeaderText = "ИНН организации";
                orgTable.Columns[0].Width = 100;
                orgTable.Columns[1].HeaderText = "ФИО главного бухгалтера";
                orgTable.Columns[1].Width = 200;
                orgTable.Columns[2].HeaderText = "Название организации";
                orgTable.Columns[2].Width = 200;
                orgTable.Columns[3].HeaderText = "Телефон";
                orgTable.Columns[3].Width = 70;
                orgTable.Columns[4].HeaderText = "Адрес";
                orgTable.Columns[4].Width = 200;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (orgAccess != "user")
            {
                if (orgTIN.Text == "ИНН" || orgAccSurname.Text == "Фамилия гл. бух." || orgAccName.Text == "Имя гл. бух." || orgAccPatron.Text == "Отчество гл. бух" || orgName.Text == "Название" || phoneNumber.Text == "Телефон" || addressCity.Text == "Город" || addressStreet.Text == "Улица" || addressStNumber.Text == "№")
                {
                    MessageBox.Show("Введите недостающие данные");
                }
                else
                {
                    DataBase db = new DataBase();

                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command = new MySqlCommand("SELECT * FROM `organization` WHERE `orgID` = @TIN", db.getConnection());
                    command.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = orgTIN.Text;

                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        MessageBox.Show("Организация с таким ИНН уже существует");
                    }
                    else
                    {
                        DataBase db1 = new DataBase();
                        MySqlCommand command1 = new MySqlCommand("INSERT INTO `organization` (`orgID`, `accLName`, `accFName`, `accPatron`, `orgName`, `phoneNumber`, `addressCity`, `addressStreet`, `addressSNumber`) VALUES (@TIN, @LName, @FName, @Patron, @orgName, @Phone, @City, @Street, @SNumber)", db1.getConnection());
                        command1.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = orgTIN.Text;
                        command1.Parameters.Add("@LName", MySqlDbType.VarChar).Value = orgAccSurname.Text;
                        command1.Parameters.Add("@FName", MySqlDbType.VarChar).Value = orgAccName.Text;
                        command1.Parameters.Add("@Patron", MySqlDbType.VarChar).Value = orgAccPatron.Text;
                        command1.Parameters.Add("@orgName", MySqlDbType.VarChar).Value = orgName.Text;
                        command1.Parameters.Add("@Phone", MySqlDbType.UInt32).Value = UInt32.Parse(phoneNumber.Text);
                        command1.Parameters.Add("@City", MySqlDbType.VarChar).Value = addressCity.Text;
                        command1.Parameters.Add("@Street", MySqlDbType.VarChar).Value = addressStreet.Text;
                        command1.Parameters.Add("@SNumber", MySqlDbType.UInt32).Value = UInt32.Parse(addressStNumber.Text);

                        db1.openConnection();

                        if (command1.ExecuteNonQuery() == 1)
                            MessageBox.Show("Запись успешно добавлена");
                        else
                            MessageBox.Show("Не удалось добавить запись");

                        db1.closeConnection();

                        DataTable table1 = new DataTable();

                        MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                        MySqlCommand command2 = new MySqlCommand("SELECT organization.orgID, concat(`accLName`, ' ', `accFName`, ' ', `accPatron`) AS Accountant, organization.orgName, organization.phoneNumber, concat(organization.addressCity, ', ул.', organization.addressStreet, ' ', organization.addressSNumber) AS Address FROM `organization`", db1.getConnection());
                        command2.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = orgTINfield.Text;

                        adapter1.SelectCommand = command2;

                        adapter1.Fill(table1);

                        orgTable.DataSource = table1;
                        orgTable.Columns[0].HeaderText = "ИНН организации";
                        orgTable.Columns[0].Width = 100;
                        orgTable.Columns[1].HeaderText = "ФИО главного бухгалтера";
                        orgTable.Columns[1].Width = 200;
                        orgTable.Columns[2].HeaderText = "Название организации";
                        orgTable.Columns[2].Width = 200;
                        orgTable.Columns[3].HeaderText = "Телефон";
                        orgTable.Columns[3].Width = 70;
                        orgTable.Columns[4].HeaderText = "Адрес";
                        orgTable.Columns[4].Width = 200;
                    }
                }

            }
            else
                MessageBox.Show("Недостаточно прав", "info");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT organization.orgID, concat(`accLName`, ' ', `accFName`, ' ', `accPatron`) AS Accountant, organization.orgName, organization.phoneNumber, concat(organization.addressCity, ', ул.', organization.addressStreet, ' ', organization.addressSNumber) AS Address FROM `organization`", db.getConnection());

            adapter.SelectCommand = command;

            adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    MySqlCommand command1 = new MySqlCommand("DELETE FROM `organization` WHERE `orgID` = @TIN", db.getConnection());
                    command1.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = orgTINfield.Text;
                    
                    db.openConnection();

                    if (command1.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись успешно удалена");
                    else
                    MessageBox.Show("Не удалось удалить запись");

                    db.closeConnection();

                DataTable table1 = new DataTable();

                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                MySqlCommand command2 = new MySqlCommand("SELECT organization.orgID, concat(`accLName`, ' ', `accFName`, ' ', `accPatron`) AS Accountant, organization.orgName, organization.phoneNumber, concat(organization.addressCity, ', ул.', organization.addressStreet, ' ', organization.addressSNumber) AS Address FROM `organization`", db.getConnection());

                adapter1.SelectCommand = command2;

                adapter1.Fill(table1);

                orgTable.DataSource = table1;
                orgTable.Columns[0].HeaderText = "ИНН организации";
                orgTable.Columns[0].Width = 100;
                orgTable.Columns[1].HeaderText = "ФИО главного бухгалтера";
                orgTable.Columns[1].Width = 200;
                orgTable.Columns[2].HeaderText = "Название организации";
                orgTable.Columns[2].Width = 200;
                orgTable.Columns[3].HeaderText = "Телефон";
                orgTable.Columns[3].Width = 70;
                orgTable.Columns[4].HeaderText = "Адрес";
                orgTable.Columns[4].Width = 200;
            }
                else
                {
                    MessageBox.Show("Организации с таким ИНН не существует");
                }
            }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (orgTable.Rows.Count > 0)

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

                            PdfPTable pTable = new PdfPTable(orgTable.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in orgTable.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in orgTable.Rows)

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
