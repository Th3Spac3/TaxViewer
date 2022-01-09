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
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();

            fieldFName.Text = "Имя";
            fieldLName.Text = "Фамилия";
            fieldPatron.Text = "Отчество";
            tinField.Text = "ИНН";
            sumField.Text = "Полученная сумма";
            exemptionField.Text = "Название льготы";
            

            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT taxpayer.LName, taxpayer.FName, taxpayer.Patron, tax.taxName, organization.orgName, declaration.decDate, declaration.sumRecieved, declaration.taxValue, declaration.taxExm, declaration.deductions, declaration.exemptionName, declaration.exemptionSum FROM `tax`, `organization`,`taxpayer`,`declaration` WHERE declaration.TIN = taxpayer.TIN AND taxpayer.orgID = organization.orgID AND taxpayer.taxID = tax.taxID", db.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            workTable.DataSource = table;
            workTable.Columns[0].HeaderText = "Фамилия";
            workTable.Columns[1].HeaderText = "Имя";
            workTable.Columns[2].HeaderText = "Отчество";
            workTable.Columns[3].HeaderText = "Налоговая";
            workTable.Columns[4].HeaderText = "Работодатель";
            workTable.Columns[5].HeaderText = "Дата заполнения декларации";
            workTable.Columns[6].HeaderText = "Полученная сумма";
            workTable.Columns[7].HeaderText = "Налог";
            workTable.Columns[8].HeaderText = "Налог с учетом льготы";
            workTable.Columns[9].HeaderText = "Отчисления в ПФР";
            workTable.Columns[10].HeaderText = "Название льготы";
            workTable.Columns[11].HeaderText = "Сумма льготы";


        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void collapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
        Boolean isWindowMax = true;
        private void minmaxButton_Click(object sender, EventArgs e)
        {
            if(isWindowMax == true)
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

        private void refreshButton_Click(object sender, EventArgs e)
        {

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

        private void fieldFName_Enter(object sender, EventArgs e)
        {
            if(fieldFName.Text == "Имя")
            fieldFName.Text = "";
        }

        private void fieldFName_Leave(object sender, EventArgs e)
        {
            if (fieldFName.Text == "")
                fieldFName.Text = "Имя";
        }

        private void fieldLName_Enter(object sender, EventArgs e)
        {
            if (fieldLName.Text == "Фамилия")
                fieldLName.Text = "";
        }

        private void fieldLName_Leave(object sender, EventArgs e)
        {
            if (fieldLName.Text == "")
                fieldLName.Text = "Фамилия";
        }

        private void fieldPatron_Enter(object sender, EventArgs e)
        {
            if (fieldPatron.Text == "Отчество")
                fieldPatron.Text = "";
        }

        private void fieldPatron_Leave(object sender, EventArgs e)
        {
            if (fieldPatron.Text == "")
                fieldPatron.Text = "Отчество";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (fieldFName.Text == "Имя" || fieldLName.Text == "Фамилия" || fieldPatron.Text == "Отчество")
            {
                DataBase db = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT taxpayer.LName, taxpayer.FName, taxpayer.Patron, tax.taxName, organization.orgName, declaration.decDate, declaration.sumRecieved, declaration.taxValue, declaration.taxExm, declaration.deductions, declaration.exemptionName, declaration.exemptionSum FROM `tax`, `organization`,`taxpayer`,`declaration` WHERE declaration.TIN = taxpayer.TIN AND taxpayer.orgID = organization.orgID AND taxpayer.taxID = tax.taxID", db.getConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);

                workTable.DataSource = table;
                workTable.Columns[0].HeaderText = "Фамилия";
                workTable.Columns[1].HeaderText = "Имя";
                workTable.Columns[2].HeaderText = "Отчество";
                workTable.Columns[3].HeaderText = "Налоговая";
                workTable.Columns[4].HeaderText = "Работодатель";
                workTable.Columns[5].HeaderText = "Дата заполнения декларации";
                workTable.Columns[6].HeaderText = "Полученная сумма";
                workTable.Columns[7].HeaderText = "Налог";
                workTable.Columns[8].HeaderText = "Налог с учетом льготы";
                workTable.Columns[9].HeaderText = "Отчисления в ПФР";
                workTable.Columns[10].HeaderText = "Название льготы";
                workTable.Columns[11].HeaderText = "Сумма льготы";
            }
            else
            {
                DataBase db = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT taxpayer.LName, taxpayer.FName, taxpayer.Patron, tax.taxName, organization.orgName, declaration.decDate, declaration.sumRecieved, declaration.taxValue, declaration.taxExm, declaration.deductions, declaration.exemptionName, declaration.exemptionSum FROM `tax`, `organization`,`taxpayer`,`declaration` WHERE declaration.TIN = taxpayer.TIN AND taxpayer.orgID = organization.orgID AND taxpayer.taxID = tax.taxID AND taxpayer.FName = @FName AND taxpayer.LName = @LName AND taxpayer.Patron = @Patron", db.getConnection());
                command.Parameters.Add("@FName", MySqlDbType.VarChar).Value = fieldFName.Text;
                command.Parameters.Add("@LName", MySqlDbType.VarChar).Value = fieldLName.Text;
                command.Parameters.Add("@Patron", MySqlDbType.VarChar).Value = fieldPatron.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);

                workTable.DataSource = table;
                workTable.Columns[0].HeaderText = "Фамилия";
                workTable.Columns[1].HeaderText = "Имя";
                workTable.Columns[2].HeaderText = "Отчество";
                workTable.Columns[3].HeaderText = "Налоговая";
                workTable.Columns[4].HeaderText = "Работодатель";
                workTable.Columns[5].HeaderText = "Дата заполнения декларации";
                workTable.Columns[6].HeaderText = "Полученная сумма";
                workTable.Columns[7].HeaderText = "Налог";
                workTable.Columns[8].HeaderText = "Налог с учетом льготы";
                workTable.Columns[9].HeaderText = "Отчисления в ПФР";
                workTable.Columns[10].HeaderText = "Название льготы";
                workTable.Columns[11].HeaderText = "Сумма льготы";
            }
        }

        private void tinField_Enter(object sender, EventArgs e)
        {
            if (tinField.Text == "ИНН")
                tinField.Text = "";
        }

        private void tinField_Leave(object sender, EventArgs e)
        {
            if (tinField.Text == "")
                tinField.Text = "ИНН";
        }

        private void sumField_Enter(object sender, EventArgs e)
        {
            if (sumField.Text == "Полученная сумма")
                sumField.Text = "";
        }

        private void sumField_Leave(object sender, EventArgs e)
        {
            if (sumField.Text == "")
                sumField.Text = "Полученная сумма";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (tinField.Text == "ИНН" || sumField.Text == "Полученная сумма" || exemptionField.Text == "Название льготы")
                MessageBox.Show("Введите недостающие данные");
            else
            {
                DataBase db = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `taxpayer` WHERE `TIN` = @TIN", db.getConnection());
                command.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = tinField.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    uint sum;
                    uint tax = 0;
                    uint taxExm;
                    uint exm;
                    uint deductions;
                    sum = uint.Parse(sumField.Text);

                    if (dateField.Value.Year >= 2001)
                        tax = Convert.ToUInt32(Math.Round(sum * 0.13, MidpointRounding.AwayFromZero));
                    else
                    {
                        if (sum <= 20000)
                            tax = Convert.ToUInt32(Math.Round(sum * 0.12, MidpointRounding.AwayFromZero));
                        else if (sum >= 20001 && sum <= 40000)
                            tax = Convert.ToUInt32(Math.Round(sum * 0.15, MidpointRounding.AwayFromZero));
                        else if (sum >= 40001 && sum <= 60000)
                            tax = Convert.ToUInt32(Math.Round(sum * 0.2, MidpointRounding.AwayFromZero));
                        else if (sum >= 60001 && sum <= 80000)
                            tax = Convert.ToUInt32(Math.Round(sum * 0.25, MidpointRounding.AwayFromZero));
                        else if (sum >= 80001 && sum <= 100000)
                            tax = Convert.ToUInt32(Math.Round(sum * 0.3, MidpointRounding.AwayFromZero));
                        else if (sum > 100000)
                            tax = Convert.ToUInt32(Math.Round(sum * 0.35, MidpointRounding.AwayFromZero));
                    }

                    exm = Convert.ToUInt32(Math.Round(tax * 0.13, MidpointRounding.AwayFromZero));
                    if (exemptionField.Text == "-")
                        exm = 0;
                    taxExm = tax - exm;
                    deductions = Convert.ToUInt32(Math.Round(sum * 0.22, MidpointRounding.AwayFromZero));

                    DataBase db1 = new DataBase();
                    MySqlCommand command1 = new MySqlCommand("INSERT INTO `declaration` (`TIN`, `decDate`, `sumRecieved`, `taxExm`, `taxValue`, `deductions`, `exemptionName`, `exemptionSum`) VALUES (@TIN, @decDate, @sumRecieved, @taxExm, @taxValue, @deductions, @exemptionName, @exemptionSum)", db1.getConnection());
                    command1.Parameters.Add("@TIN", MySqlDbType.VarChar).Value = tinField.Text;
                    command1.Parameters.Add("@decDate", MySqlDbType.Date).Value = dateField.Value;
                    command1.Parameters.Add("@sumRecieved", MySqlDbType.UInt32).Value = sum;
                    command1.Parameters.Add("@taxExm", MySqlDbType.UInt32).Value = taxExm;
                    command1.Parameters.Add("@taxValue", MySqlDbType.UInt32).Value = tax;
                    command1.Parameters.Add("@deductions", MySqlDbType.UInt32).Value = deductions;
                    command1.Parameters.Add("@exemptionName", MySqlDbType.VarChar).Value = exemptionField.Text;
                    command1.Parameters.Add("@exemptionSum", MySqlDbType.UInt32).Value = exm;


                    db1.openConnection();

                    if (command1.ExecuteNonQuery() == 1)
                        MessageBox.Show("Запись успешно добавлена");
                    else
                        MessageBox.Show("Не удалось добавить запись");

                    db1.closeConnection();

                    DataTable table1 = new DataTable();

                    MySqlCommand command2 = new MySqlCommand("SELECT taxpayer.LName, taxpayer.FName, taxpayer.Patron, tax.taxName, organization.orgName, declaration.decDate, declaration.sumRecieved, declaration.taxValue, declaration.taxExm, declaration.deductions, declaration.exemptionName, declaration.exemptionSum FROM `tax`, `organization`,`taxpayer`,`declaration` WHERE declaration.TIN = taxpayer.TIN AND taxpayer.orgID = organization.orgID AND taxpayer.taxID = tax.taxID", db1.getConnection());
                    adapter.SelectCommand = command2;
                    adapter.Fill(table1);

                    workTable.DataSource = table1;
                    workTable.Columns[0].HeaderText = "Фамилия";
                    workTable.Columns[1].HeaderText = "Имя";
                    workTable.Columns[2].HeaderText = "Отчество";
                    workTable.Columns[3].HeaderText = "Налоговая";
                    workTable.Columns[4].HeaderText = "Работодатель";
                    workTable.Columns[5].HeaderText = "Дата заполнения декларации";
                    workTable.Columns[6].HeaderText = "Полученная сумма";
                    workTable.Columns[7].HeaderText = "Налог";
                    workTable.Columns[8].HeaderText = "Налог с учетом льготы";
                    workTable.Columns[9].HeaderText = "Отчисления в ПФР";
                    workTable.Columns[10].HeaderText = "Название льготы";
                    workTable.Columns[11].HeaderText = "Сумма льготы";

                }
                else
                    MessageBox.Show("Невозможно добавить налоговую декларацию на несуществующего налогоплательщика");
                
            }
        }

        private void exemptionField_Enter(object sender, EventArgs e)
        {
            if (exemptionField.Text == "Название льготы")
                exemptionField.Text = "";
        }

        private void exemptionField_Leave(object sender, EventArgs e)
        {
            if (exemptionField.Text == "")
                exemptionField.Text = "Название льготы";
        }

        private void taxpayerButton_Click(object sender, EventArgs e)
        {
            if (awAccess == "user")
                MessageBox.Show("Недостаточно прав", "info");
            else
            {
                taxpayerWindow window = new taxpayerWindow();
                window.Show();
            }
        }

        private void taxButton_Click(object sender, EventArgs e)
        {
            taxWindow window = new taxWindow();
            window.taxAccess = awAccess;
            window.Show();
        }

        private void organizationButton_Click(object sender, EventArgs e)
        {
            organizationWindow window = new organizationWindow();
            window.orgAccess = awAccess;
            window.Show();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (workTable.Rows.Count > 0)

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

                            PdfPTable pTable = new PdfPTable(workTable.Columns.Count);

                            pTable.DefaultCell.Padding = 2;

                            pTable.WidthPercentage = 100;

                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in workTable.Columns)

                            {

                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));

                                pTable.AddCell(pCell);

                            }

                            foreach (DataGridViewRow viewRow in workTable.Rows)

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
