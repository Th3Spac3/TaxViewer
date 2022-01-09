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
    public partial class taxpayerWindow : Form
    {
        public taxpayerWindow()
        {
            InitializeComponent();
            searchTIN.Text = "ИНН";
            tpTIN.Text = "ИНН";
            orgTIN.Text = "ИНН работодателя";
            tTIN.Text = "ИНН ИФНС";
            tpSurname.Text = "Фамилия";
            tpName.Text = "Имя";
            tpPatron.Text = "Отчество";
            tpDoc.Text = "Документ";
            tpIssueOrg.Text = "Документ выдан в";
            tpSer.Text = "Серия";
            tpNum.Text = "Номер";
            city.Text = "Город";
            district.Text = "Район";
            street.Text = "Улица";
            stNum.Text = "№";

            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT taxpayer.TIN, organization.orgName, tax.taxName, taxpayer.LName, taxpayer.FName, taxpayer.Patron, taxpayer.documentName, taxpayer.issueOrg, concat(taxpayer.series) AS Placeholder, concat(taxpayer.number) AS Placeholder, taxpayer.issueDate, concat(taxpayer.addressCity, ', ', taxpayer.district, ' район, ', taxpayer.addressStreet, ' ', taxpayer.addressStNumber) AS Placeholder FROM `taxpayer`, `tax`, `organization` WHERE taxpayer.taxID = tax.taxID AND taxpayer.orgID = organization.orgID", db.getConnection());

            adapter.SelectCommand = command;

            adapter.Fill(table);

            taxpayerTable.DataSource = table;
            taxpayerTable.Columns[0].HeaderText = "ИНН";
            taxpayerTable.Columns[0].Width = 100;
            taxpayerTable.Columns[1].HeaderText = "Работодатель";
            taxpayerTable.Columns[1].Width = 150;
            taxpayerTable.Columns[2].HeaderText = "Состоит на учете в налоговой";
            taxpayerTable.Columns[2].Width = 200;
            taxpayerTable.Columns[3].HeaderText = "Фамилия";
            taxpayerTable.Columns[3].Width = 80;
            taxpayerTable.Columns[4].HeaderText = "Имя";
            taxpayerTable.Columns[4].Width = 80;
            taxpayerTable.Columns[5].HeaderText = "Отчество";
            taxpayerTable.Columns[5].Width = 80;
            taxpayerTable.Columns[6].HeaderText = "Название документа, удостоверяющего личность";
            taxpayerTable.Columns[6].Width = 150;
            taxpayerTable.Columns[7].HeaderText = "Кем выдан документ";
            taxpayerTable.Columns[7].Width = 350;
            taxpayerTable.Columns[8].HeaderText = "Серия";
            taxpayerTable.Columns[8].Width = 50;
            taxpayerTable.Columns[9].HeaderText = "Номер";
            taxpayerTable.Columns[9].Width = 80;
            taxpayerTable.Columns[10].HeaderText = "Дата выдачи";
            taxpayerTable.Columns[10].Width = 100;
            taxpayerTable.Columns[11].HeaderText = "Адрес";
            taxpayerTable.Columns[11].Width = 300;

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

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            this.CloseButton.ForeColor = Color.White;
            this.CloseButton.BackColor = Color.FromArgb(219, 171, 4);
        }


        private void minmaxButton_MouseEnter(object sender, EventArgs e)
        {
            this.minmaxButton.ForeColor = Color.White;
            this.minmaxButton.BackColor = Color.FromArgb(219, 171, 4);
        }

        private void collapseButton_MouseEnter(object sender, EventArgs e)
        {
            this.collapseButton.ForeColor = Color.White;
            this.collapseButton.BackColor = Color.FromArgb(219, 171, 4);
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            this.CloseButton.ForeColor = Color.FromArgb(219, 171, 4);
            this.CloseButton.BackColor = Color.FromArgb(139, 4, 28);
        }

        private void minmaxButton_MouseLeave(object sender, EventArgs e)
        {
            this.minmaxButton.ForeColor = Color.FromArgb(219, 171, 4);
            this.minmaxButton.BackColor = Color.FromArgb(139, 4, 28);
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
        private void tpTIN_Enter(object sender, EventArgs e)
        {
            if (tpTIN.Text == "ИНН")
                tpTIN.Text = "";
        }

        private void tpTIN_Leave(object sender, EventArgs e)
        {
            if (tpTIN.Text == "")
                tpTIN.Text = "ИНН";
        }

        private void tTIN_Enter(object sender, EventArgs e)
        {
            if (tTIN.Text == "ИНН ИФНС")
                tTIN.Text = "";
        }

        private void tTIN_Leave(object sender, EventArgs e)
        {
            if (tTIN.Text == "")
                tTIN.Text = "ИНН ИФНС";
        }

        private void orgTIN_Enter(object sender, EventArgs e)
        {
            if (orgTIN.Text == "ИНН работодателя")
                orgTIN.Text = "";
        }

        private void orgTIN_Leave(object sender, EventArgs e)
        {
            if (orgTIN.Text == "")
                orgTIN.Text = "ИНН работодателя";
        }

        private void tpSurname_Enter(object sender, EventArgs e)
        {
            if (tpSurname.Text == "Фамилия")
                tpSurname.Text = "";
        }

        private void tpSurname_Leave(object sender, EventArgs e)
        {
            if (tpSurname.Text == "")
                tpSurname.Text = "Фамилия";
        }

        private void tpName_Enter(object sender, EventArgs e)
        {
            if (tpName.Text == "Имя")
                tpName.Text = "";
        }

        private void tpName_Leave(object sender, EventArgs e)
        {
            if (tpName.Text == "")
                tpName.Text = "Имя";
        }

        private void tpPatron_Enter(object sender, EventArgs e)
        {
            if (tpPatron.Text == "Отчество")
                tpPatron.Text = "";
        }

        private void tpPatron_Leave(object sender, EventArgs e)
        {
            if (tpPatron.Text == "")
                tpPatron.Text = "Отчество";
        }

        private void tpDoc_Enter(object sender, EventArgs e)
        {
            if (tpDoc.Text == "Документ")
                tpDoc.Text = "";
        }

        private void tpDoc_Leave(object sender, EventArgs e)
        {
            if (tpDoc.Text == "")
                tpDoc.Text = "Документ";
        }

        private void tpIssueOrg_Enter(object sender, EventArgs e)
        {
            if (tpIssueOrg.Text == "Документ выдан в")
                tpIssueOrg.Text = "";
        }

        private void tpIssueOrg_Leave(object sender, EventArgs e)
        {
            if (tpIssueOrg.Text == "")
                tpIssueOrg.Text = "Документ выдан в";
        }

        private void tpSer_Enter(object sender, EventArgs e)
        {
            if (tpSer.Text == "Серия")
                tpSer.Text = "";
        }

        private void tpSer_Leave(object sender, EventArgs e)
        {
            if (tpSer.Text == "")
                tpSer.Text = "Серия";
        }

        private void tpNum_Enter(object sender, EventArgs e)
        {
            if (tpNum.Text == "Номер")
                tpNum.Text = "";
        }

        private void tpNum_Leave(object sender, EventArgs e)
        {
            if (tpNum.Text == "")
                tpNum.Text = "Номер";
        }

        private void city_Enter(object sender, EventArgs e)
        {
            if (city.Text == "Город")
                city.Text = "";
        }

        private void city_Leave(object sender, EventArgs e)
        {
            if (city.Text == "")
                city.Text = "Город";
        }

        private void district_Enter(object sender, EventArgs e)
        {
            if (district.Text == "Район")
                district.Text = "";
        }

        private void district_Leave(object sender, EventArgs e)
        {
            if (district.Text == "")
                district.Text = "Район";
        }

        private void street_Enter(object sender, EventArgs e)
        {
            if (street.Text == "Улица")
                street.Text = "";
        }

        private void street_Leave(object sender, EventArgs e)
        {
            if (street.Text == "")
                street.Text = "Улица";
        }

        private void stNum_Enter(object sender, EventArgs e)
        {
            if (stNum.Text == "№")
                stNum.Text = "";
        }

        private void stNum_Leave(object sender, EventArgs e)
        {
            if (stNum.Text == "")
                stNum.Text = "№";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTIN.Text == "ИНН")
            {
                DataBase db = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT taxpayer.TIN, organization.orgName, tax.taxName, taxpayer.LName, taxpayer.FName, taxpayer.Patron, taxpayer.documentName, taxpayer.issueOrg, concat(taxpayer.series) AS Placeholder, concat(taxpayer.number) AS Placeholder, taxpayer.issueDate, concat(taxpayer.addressCity, ', ', taxpayer.district, ' район, ', taxpayer.addressStreet, ' ', taxpayer.addressStNumber) AS Placeholder FROM `taxpayer`, `tax`, `organization` WHERE taxpayer.taxID = tax.taxID AND taxpayer.orgID = organization.orgID", db.getConnection());

                adapter.SelectCommand = command;

                adapter.Fill(table);

                taxpayerTable.DataSource = table;
                taxpayerTable.Columns[0].HeaderText = "ИНН";
                taxpayerTable.Columns[0].Width = 100;
                taxpayerTable.Columns[1].HeaderText = "Работодатель";
                taxpayerTable.Columns[1].Width = 150;
                taxpayerTable.Columns[2].HeaderText = "Состоит на учете в налоговой";
                taxpayerTable.Columns[2].Width = 200;
                taxpayerTable.Columns[3].HeaderText = "Фамилия";
                taxpayerTable.Columns[3].Width = 80;
                taxpayerTable.Columns[4].HeaderText = "Имя";
                taxpayerTable.Columns[4].Width = 80;
                taxpayerTable.Columns[5].HeaderText = "Отчество";
                taxpayerTable.Columns[5].Width = 80;
                taxpayerTable.Columns[6].HeaderText = "Название документа, удостоверяющего личность";
                taxpayerTable.Columns[6].Width = 150;
                taxpayerTable.Columns[7].HeaderText = "Кем выдан документ";
                taxpayerTable.Columns[7].Width = 350;
                taxpayerTable.Columns[8].HeaderText = "Серия";
                taxpayerTable.Columns[8].Width = 50;
                taxpayerTable.Columns[9].HeaderText = "Номер";
                taxpayerTable.Columns[9].Width = 80;
                taxpayerTable.Columns[10].HeaderText = "Дата выдачи";
                taxpayerTable.Columns[10].Width = 100;
                taxpayerTable.Columns[11].HeaderText = "Адрес";
                taxpayerTable.Columns[11].Width = 300;
            }
            else
            {
                DataBase db = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT taxpayer.TIN, organization.orgName, tax.taxName, taxpayer.LName, taxpayer.FName, taxpayer.Patron, taxpayer.documentName, taxpayer.issueOrg, concat(taxpayer.series) AS Placeholder, concat(taxpayer.number) AS Placeholder, taxpayer.issueDate, concat(taxpayer.addressCity, ', ', taxpayer.district, ' район, ', taxpayer.addressStreet, ' ', taxpayer.addressStNumber) AS Placeholder FROM `taxpayer`, `tax`, `organization` WHERE taxpayer.TIN = @TIN AND taxpayer.taxID = tax.taxID AND taxpayer.orgID = organization.orgID", db.getConnection());
                command.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = searchTIN.Text;
                adapter.SelectCommand = command;

                adapter.Fill(table);

                taxpayerTable.DataSource = table;
                taxpayerTable.Columns[0].HeaderText = "ИНН";
                taxpayerTable.Columns[0].Width = 100;
                taxpayerTable.Columns[1].HeaderText = "Работодатель";
                taxpayerTable.Columns[1].Width = 150;
                taxpayerTable.Columns[2].HeaderText = "Состоит на учете в налоговой";
                taxpayerTable.Columns[2].Width = 200;
                taxpayerTable.Columns[3].HeaderText = "Фамилия";
                taxpayerTable.Columns[3].Width = 80;
                taxpayerTable.Columns[4].HeaderText = "Имя";
                taxpayerTable.Columns[4].Width = 80;
                taxpayerTable.Columns[5].HeaderText = "Отчество";
                taxpayerTable.Columns[5].Width = 80;
                taxpayerTable.Columns[6].HeaderText = "Название документа, удостоверяющего личность";
                taxpayerTable.Columns[6].Width = 150;
                taxpayerTable.Columns[7].HeaderText = "Кем выдан документ";
                taxpayerTable.Columns[7].Width = 350;
                taxpayerTable.Columns[8].HeaderText = "Серия";
                taxpayerTable.Columns[8].Width = 50;
                taxpayerTable.Columns[9].HeaderText = "Номер";
                taxpayerTable.Columns[9].Width = 80;
                taxpayerTable.Columns[10].HeaderText = "Дата выдачи";
                taxpayerTable.Columns[10].Width = 100;
                taxpayerTable.Columns[11].HeaderText = "Адрес";
                taxpayerTable.Columns[11].Width = 300;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `taxpayer` WHERE `TIN` = @TIN", db.getConnection());
            command.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = tpTIN.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Налогоплательщик с таким ИНН уже существует");
            }
            else
            {
                DataTable table1 = new DataTable();
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                MySqlCommand command1 = new MySqlCommand("SELECT * FROM `tax` WHERE `taxID` = @taxID", db.getConnection());
                command1.Parameters.Add("@taxID", MySqlDbType.VarChar).Value = tTIN.Text;
                adapter1.SelectCommand = command1;
                adapter1.Fill(table1);
                if (table1.Rows.Count > 0)
                {
                    DataTable table2 = new DataTable();
                    MySqlDataAdapter adapter2 = new MySqlDataAdapter();
                    MySqlCommand command2 = new MySqlCommand("SELECT * FROM `organization` WHERE `orgID` = @orgID", db.getConnection());
                    command2.Parameters.Add("@orgID", MySqlDbType.VarChar).Value = orgTIN.Text;
                    adapter2.SelectCommand = command2;
                    adapter2.Fill(table2);
                    if (table2.Rows.Count > 0)
                    {
                        MySqlCommand addCommand = new MySqlCommand("INSERT INTO `taxpayer` (`TIN`, `taxID`, `orgID`, `FName`, `LName`, `Patron`, `documentName`, `issueOrg`, `series`, `number`, `issueDate`, `district`, `addressCity`, `addressStreet`, `addressStNumber`) VALUES (@TIN, @tTIN, @oTIN, @Name, @Surname, @Patron, @dName, @iOrg, @ser, @num, @iDate, @dis, @city, @street, @stNum)", db.getConnection());
                        addCommand.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = tpTIN.Text;
                        addCommand.Parameters.Add("@tTIN", MySqlDbType.VarChar).Value = tTIN.Text;
                        addCommand.Parameters.Add("@oTIN", MySqlDbType.VarChar).Value = orgTIN.Text;
                        addCommand.Parameters.Add("@Name", MySqlDbType.VarChar).Value = tpName.Text;
                        addCommand.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = tpSurname.Text;
                        addCommand.Parameters.Add("@Patron", MySqlDbType.VarChar).Value = tpPatron.Text;
                        addCommand.Parameters.Add("@dName", MySqlDbType.VarChar).Value = tpDoc.Text;
                        addCommand.Parameters.Add("@iOrg", MySqlDbType.VarChar).Value = tpIssueOrg.Text;
                        addCommand.Parameters.Add("@ser", MySqlDbType.UInt32).Value = UInt32.Parse(tpSer.Text);
                        addCommand.Parameters.Add("@num", MySqlDbType.UInt32).Value = UInt32.Parse(tpNum.Text);
                        addCommand.Parameters.Add("@iDate", MySqlDbType.Date).Value = tpIssueDate.Value;
                        addCommand.Parameters.Add("@dis", MySqlDbType.VarChar).Value = district.Text;
                        addCommand.Parameters.Add("@city", MySqlDbType.VarChar).Value = city.Text;
                        addCommand.Parameters.Add("@street", MySqlDbType.VarChar).Value = street.Text;
                        addCommand.Parameters.Add("@stNum", MySqlDbType.UInt32).Value = UInt32.Parse(stNum.Text);

                        db.openConnection();

                        if (addCommand.ExecuteNonQuery() == 1)
                            MessageBox.Show("Запись успешно добавлена");
                        else
                            MessageBox.Show("Не удалось добавить запись");

                        db.closeConnection();

                        DataTable table3 = new DataTable();

                        MySqlDataAdapter adapter3 = new MySqlDataAdapter();
                        MySqlCommand command3 = new MySqlCommand("SELECT taxpayer.TIN, organization.orgName, tax.taxName, taxpayer.LName, taxpayer.FName, taxpayer.Patron, taxpayer.documentName, taxpayer.issueOrg, concat(taxpayer.series) AS Placeholder, concat(taxpayer.number) AS Placeholder, taxpayer.issueDate, concat(taxpayer.addressCity, ', ', taxpayer.district, ' район, ', taxpayer.addressStreet, ' ', taxpayer.addressStNumber) AS Placeholder FROM `taxpayer`, `tax`, `organization` WHERE taxpayer.taxID = tax.taxID AND taxpayer.orgID = organization.orgID", db.getConnection());

                        adapter3.SelectCommand = command3;

                        adapter3.Fill(table3);

                        taxpayerTable.DataSource = table3;
                        taxpayerTable.Columns[0].HeaderText = "ИНН";
                        taxpayerTable.Columns[0].Width = 100;
                        taxpayerTable.Columns[1].HeaderText = "Работодатель";
                        taxpayerTable.Columns[1].Width = 150;
                        taxpayerTable.Columns[2].HeaderText = "Состоит на учете в налоговой";
                        taxpayerTable.Columns[2].Width = 200;
                        taxpayerTable.Columns[3].HeaderText = "Фамилия";
                        taxpayerTable.Columns[3].Width = 80;
                        taxpayerTable.Columns[4].HeaderText = "Имя";
                        taxpayerTable.Columns[4].Width = 80;
                        taxpayerTable.Columns[5].HeaderText = "Отчество";
                        taxpayerTable.Columns[5].Width = 80;
                        taxpayerTable.Columns[6].HeaderText = "Название документа, удостоверяющего личность";
                        taxpayerTable.Columns[6].Width = 150;
                        taxpayerTable.Columns[7].HeaderText = "Кем выдан документ";
                        taxpayerTable.Columns[7].Width = 350;
                        taxpayerTable.Columns[8].HeaderText = "Серия";
                        taxpayerTable.Columns[8].Width = 50;
                        taxpayerTable.Columns[9].HeaderText = "Номер";
                        taxpayerTable.Columns[9].Width = 80;
                        taxpayerTable.Columns[10].HeaderText = "Дата выдачи";
                        taxpayerTable.Columns[10].Width = 100;
                        taxpayerTable.Columns[11].HeaderText = "Адрес";
                        taxpayerTable.Columns[11].Width = 300;

                    }
                    else
                    {
                        MessageBox.Show("Организаций с таким ИНН не существует");
                    }
                }
                else
                {
                    MessageBox.Show("Налоговой инспекции с таким ИНН не существует");
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `taxpayer` WHERE `TIN` = @TIN", db.getConnection());
            command.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = searchTIN.Text;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MySqlCommand command1 = new MySqlCommand("DELETE FROM `declaration` WHERE `TIN` = @TIN", db.getConnection());
                command1.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = searchTIN.Text;

                db.openConnection();

                if (command1.ExecuteNonQuery() == 1)
                {
                    
                }
                else
                {

                }

                db.closeConnection();

                MySqlCommand command2 = new MySqlCommand("DELETE FROM `taxpayer` WHERE `TIN` = @TIN", db.getConnection());
                command2.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = searchTIN.Text;

                db.openConnection();

                if (command2.ExecuteNonQuery() == 1)
                    MessageBox.Show("Запись успешно удалена");
                else
                    MessageBox.Show("Не удалось удалить запись");

                db.closeConnection();

                DataTable table3 = new DataTable();

                MySqlDataAdapter adapter3 = new MySqlDataAdapter();
                MySqlCommand command3 = new MySqlCommand("SELECT taxpayer.TIN, organization.orgName, tax.taxName, taxpayer.LName, taxpayer.FName, taxpayer.Patron, taxpayer.documentName, taxpayer.issueOrg, concat(taxpayer.series) AS Placeholder, concat(taxpayer.number) AS Placeholder, taxpayer.issueDate, concat(taxpayer.addressCity, ', ', taxpayer.district, ' район, ', taxpayer.addressStreet, ' ', taxpayer.addressStNumber) AS Placeholder FROM `taxpayer`, `tax`, `organization` WHERE taxpayer.taxID = tax.taxID AND taxpayer.orgID = organization.orgID", db.getConnection());

                adapter3.SelectCommand = command3;

                adapter3.Fill(table3);

                taxpayerTable.DataSource = table3;
                taxpayerTable.Columns[0].HeaderText = "ИНН";
                taxpayerTable.Columns[0].Width = 100;
                taxpayerTable.Columns[1].HeaderText = "Работодатель";
                taxpayerTable.Columns[1].Width = 150;
                taxpayerTable.Columns[2].HeaderText = "Состоит на учете в налоговой";
                taxpayerTable.Columns[2].Width = 200;
                taxpayerTable.Columns[3].HeaderText = "Фамилия";
                taxpayerTable.Columns[3].Width = 80;
                taxpayerTable.Columns[4].HeaderText = "Имя";
                taxpayerTable.Columns[4].Width = 80;
                taxpayerTable.Columns[5].HeaderText = "Отчество";
                taxpayerTable.Columns[5].Width = 80;
                taxpayerTable.Columns[6].HeaderText = "Название документа, удостоверяющего личность";
                taxpayerTable.Columns[6].Width = 150;
                taxpayerTable.Columns[7].HeaderText = "Кем выдан документ";
                taxpayerTable.Columns[7].Width = 350;
                taxpayerTable.Columns[8].HeaderText = "Серия";
                taxpayerTable.Columns[8].Width = 50;
                taxpayerTable.Columns[9].HeaderText = "Номер";
                taxpayerTable.Columns[9].Width = 80;
                taxpayerTable.Columns[10].HeaderText = "Дата выдачи";
                taxpayerTable.Columns[10].Width = 100;
                taxpayerTable.Columns[11].HeaderText = "Адрес";
                taxpayerTable.Columns[11].Width = 300;
            }
            else
            {
                MessageBox.Show("Записей с указанными данными не существует");
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (taxpayerTable.Rows.Count > 0)

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

                            PdfPTable pTable = new PdfPTable(taxpayerTable.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in taxpayerTable.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in taxpayerTable.Rows)

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
    
