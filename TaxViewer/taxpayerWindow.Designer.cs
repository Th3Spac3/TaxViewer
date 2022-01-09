
namespace TaxViewer
{
    partial class taxpayerWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.taxpayerTable = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.stNum = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.district = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.tpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.tpNum = new System.Windows.Forms.TextBox();
            this.tpSer = new System.Windows.Forms.TextBox();
            this.tpIssueOrg = new System.Windows.Forms.TextBox();
            this.tpDoc = new System.Windows.Forms.TextBox();
            this.tpPatron = new System.Windows.Forms.TextBox();
            this.tpName = new System.Windows.Forms.TextBox();
            this.tpSurname = new System.Windows.Forms.TextBox();
            this.orgTIN = new System.Windows.Forms.TextBox();
            this.tTIN = new System.Windows.Forms.TextBox();
            this.tpTIN = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.printButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTIN = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.collapseButton = new System.Windows.Forms.Label();
            this.minmaxButton = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxpayerTable)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1728, 782);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.taxpayerTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1728, 619);
            this.panel3.TabIndex = 8;
            // 
            // taxpayerTable
            // 
            this.taxpayerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taxpayerTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taxpayerTable.Location = new System.Drawing.Point(0, 0);
            this.taxpayerTable.Name = "taxpayerTable";
            this.taxpayerTable.Size = new System.Drawing.Size(1728, 619);
            this.taxpayerTable.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.addButton);
            this.panel4.Controls.Add(this.stNum);
            this.panel4.Controls.Add(this.street);
            this.panel4.Controls.Add(this.district);
            this.panel4.Controls.Add(this.city);
            this.panel4.Controls.Add(this.tpIssueDate);
            this.panel4.Controls.Add(this.tpNum);
            this.panel4.Controls.Add(this.tpSer);
            this.panel4.Controls.Add(this.tpIssueOrg);
            this.panel4.Controls.Add(this.tpDoc);
            this.panel4.Controls.Add(this.tpPatron);
            this.panel4.Controls.Add(this.tpName);
            this.panel4.Controls.Add(this.tpSurname);
            this.panel4.Controls.Add(this.orgTIN);
            this.panel4.Controls.Add(this.tTIN);
            this.panel4.Controls.Add(this.tpTIN);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 693);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1728, 32);
            this.panel4.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(4)))), ((int)(((byte)(28)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(20)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
            this.addButton.Location = new System.Drawing.Point(1697, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(36, 32);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // stNum
            // 
            this.stNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.stNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stNum.Dock = System.Windows.Forms.DockStyle.Left;
            this.stNum.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stNum.ForeColor = System.Drawing.Color.Black;
            this.stNum.Location = new System.Drawing.Point(1661, 0);
            this.stNum.Multiline = true;
            this.stNum.Name = "stNum";
            this.stNum.Size = new System.Drawing.Size(36, 32);
            this.stNum.TabIndex = 18;
            this.stNum.Enter += new System.EventHandler(this.stNum_Enter);
            this.stNum.Leave += new System.EventHandler(this.stNum_Leave);
            // 
            // street
            // 
            this.street.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.street.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.street.Dock = System.Windows.Forms.DockStyle.Left;
            this.street.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.street.ForeColor = System.Drawing.Color.Black;
            this.street.Location = new System.Drawing.Point(1555, 0);
            this.street.Multiline = true;
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(106, 32);
            this.street.TabIndex = 17;
            this.street.Enter += new System.EventHandler(this.street_Enter);
            this.street.Leave += new System.EventHandler(this.street_Leave);
            // 
            // district
            // 
            this.district.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.district.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.district.Dock = System.Windows.Forms.DockStyle.Left;
            this.district.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.district.ForeColor = System.Drawing.Color.Black;
            this.district.Location = new System.Drawing.Point(1448, 0);
            this.district.Multiline = true;
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(107, 32);
            this.district.TabIndex = 16;
            this.district.Enter += new System.EventHandler(this.district_Enter);
            this.district.Leave += new System.EventHandler(this.district_Leave);
            // 
            // city
            // 
            this.city.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.city.Dock = System.Windows.Forms.DockStyle.Left;
            this.city.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.city.ForeColor = System.Drawing.Color.Black;
            this.city.Location = new System.Drawing.Point(1339, 0);
            this.city.Multiline = true;
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(109, 32);
            this.city.TabIndex = 15;
            this.city.Enter += new System.EventHandler(this.city_Enter);
            this.city.Leave += new System.EventHandler(this.city_Leave);
            // 
            // tpIssueDate
            // 
            this.tpIssueDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.tpIssueDate.Location = new System.Drawing.Point(1325, 0);
            this.tpIssueDate.Name = "tpIssueDate";
            this.tpIssueDate.Size = new System.Drawing.Size(14, 20);
            this.tpIssueDate.TabIndex = 14;
            // 
            // tpNum
            // 
            this.tpNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.tpNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpNum.Dock = System.Windows.Forms.DockStyle.Left;
            this.tpNum.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpNum.ForeColor = System.Drawing.Color.Black;
            this.tpNum.Location = new System.Drawing.Point(1195, 0);
            this.tpNum.Multiline = true;
            this.tpNum.Name = "tpNum";
            this.tpNum.Size = new System.Drawing.Size(130, 32);
            this.tpNum.TabIndex = 13;
            this.tpNum.Enter += new System.EventHandler(this.tpNum_Enter);
            this.tpNum.Leave += new System.EventHandler(this.tpNum_Leave);
            // 
            // tpSer
            // 
            this.tpSer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.tpSer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpSer.Dock = System.Windows.Forms.DockStyle.Left;
            this.tpSer.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpSer.ForeColor = System.Drawing.Color.Black;
            this.tpSer.Location = new System.Drawing.Point(1065, 0);
            this.tpSer.Multiline = true;
            this.tpSer.Name = "tpSer";
            this.tpSer.Size = new System.Drawing.Size(130, 32);
            this.tpSer.TabIndex = 12;
            this.tpSer.Enter += new System.EventHandler(this.tpSer_Enter);
            this.tpSer.Leave += new System.EventHandler(this.tpSer_Leave);
            // 
            // tpIssueOrg
            // 
            this.tpIssueOrg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.tpIssueOrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpIssueOrg.Dock = System.Windows.Forms.DockStyle.Left;
            this.tpIssueOrg.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpIssueOrg.ForeColor = System.Drawing.Color.Black;
            this.tpIssueOrg.Location = new System.Drawing.Point(880, 0);
            this.tpIssueOrg.Multiline = true;
            this.tpIssueOrg.Name = "tpIssueOrg";
            this.tpIssueOrg.Size = new System.Drawing.Size(185, 32);
            this.tpIssueOrg.TabIndex = 11;
            this.tpIssueOrg.Enter += new System.EventHandler(this.tpIssueOrg_Enter);
            this.tpIssueOrg.Leave += new System.EventHandler(this.tpIssueOrg_Leave);
            // 
            // tpDoc
            // 
            this.tpDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.tpDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpDoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.tpDoc.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpDoc.ForeColor = System.Drawing.Color.Black;
            this.tpDoc.Location = new System.Drawing.Point(750, 0);
            this.tpDoc.Multiline = true;
            this.tpDoc.Name = "tpDoc";
            this.tpDoc.Size = new System.Drawing.Size(130, 32);
            this.tpDoc.TabIndex = 10;
            this.tpDoc.Enter += new System.EventHandler(this.tpDoc_Enter);
            this.tpDoc.Leave += new System.EventHandler(this.tpDoc_Leave);
            // 
            // tpPatron
            // 
            this.tpPatron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.tpPatron.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpPatron.Dock = System.Windows.Forms.DockStyle.Left;
            this.tpPatron.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpPatron.ForeColor = System.Drawing.Color.Black;
            this.tpPatron.Location = new System.Drawing.Point(639, 0);
            this.tpPatron.Multiline = true;
            this.tpPatron.Name = "tpPatron";
            this.tpPatron.Size = new System.Drawing.Size(111, 32);
            this.tpPatron.TabIndex = 9;
            this.tpPatron.Enter += new System.EventHandler(this.tpPatron_Enter);
            this.tpPatron.Leave += new System.EventHandler(this.tpPatron_Leave);
            // 
            // tpName
            // 
            this.tpName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.tpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpName.Dock = System.Windows.Forms.DockStyle.Left;
            this.tpName.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpName.ForeColor = System.Drawing.Color.Black;
            this.tpName.Location = new System.Drawing.Point(565, 0);
            this.tpName.Multiline = true;
            this.tpName.Name = "tpName";
            this.tpName.Size = new System.Drawing.Size(74, 32);
            this.tpName.TabIndex = 8;
            this.tpName.Enter += new System.EventHandler(this.tpName_Enter);
            this.tpName.Leave += new System.EventHandler(this.tpName_Leave);
            // 
            // tpSurname
            // 
            this.tpSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.tpSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpSurname.Dock = System.Windows.Forms.DockStyle.Left;
            this.tpSurname.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpSurname.ForeColor = System.Drawing.Color.Black;
            this.tpSurname.Location = new System.Drawing.Point(452, 0);
            this.tpSurname.Multiline = true;
            this.tpSurname.Name = "tpSurname";
            this.tpSurname.Size = new System.Drawing.Size(113, 32);
            this.tpSurname.TabIndex = 7;
            this.tpSurname.Enter += new System.EventHandler(this.tpSurname_Enter);
            this.tpSurname.Leave += new System.EventHandler(this.tpSurname_Leave);
            // 
            // orgTIN
            // 
            this.orgTIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.orgTIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orgTIN.Dock = System.Windows.Forms.DockStyle.Left;
            this.orgTIN.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgTIN.ForeColor = System.Drawing.Color.Black;
            this.orgTIN.Location = new System.Drawing.Point(269, 0);
            this.orgTIN.Multiline = true;
            this.orgTIN.Name = "orgTIN";
            this.orgTIN.Size = new System.Drawing.Size(183, 32);
            this.orgTIN.TabIndex = 6;
            this.orgTIN.Enter += new System.EventHandler(this.orgTIN_Enter);
            this.orgTIN.Leave += new System.EventHandler(this.orgTIN_Leave);
            // 
            // tTIN
            // 
            this.tTIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.tTIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tTIN.Dock = System.Windows.Forms.DockStyle.Left;
            this.tTIN.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tTIN.ForeColor = System.Drawing.Color.Black;
            this.tTIN.Location = new System.Drawing.Point(148, 0);
            this.tTIN.Multiline = true;
            this.tTIN.Name = "tTIN";
            this.tTIN.Size = new System.Drawing.Size(121, 32);
            this.tTIN.TabIndex = 5;
            this.tTIN.Enter += new System.EventHandler(this.tTIN_Enter);
            this.tTIN.Leave += new System.EventHandler(this.tTIN_Leave);
            // 
            // tpTIN
            // 
            this.tpTIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.tpTIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpTIN.Dock = System.Windows.Forms.DockStyle.Left;
            this.tpTIN.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tpTIN.ForeColor = System.Drawing.Color.Black;
            this.tpTIN.Location = new System.Drawing.Point(0, 0);
            this.tpTIN.Multiline = true;
            this.tpTIN.Name = "tpTIN";
            this.tpTIN.Size = new System.Drawing.Size(148, 32);
            this.tpTIN.TabIndex = 4;
            this.tpTIN.Enter += new System.EventHandler(this.tpTIN_Enter);
            this.tpTIN.Leave += new System.EventHandler(this.tpTIN_Leave);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.printButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 725);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1728, 57);
            this.panel6.TabIndex = 8;
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(4)))), ((int)(((byte)(28)))));
            this.printButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.printButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(20)))));
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
            this.printButton.Location = new System.Drawing.Point(1529, 0);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(199, 57);
            this.printButton.TabIndex = 5;
            this.printButton.Text = "Печать";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.deleteButton);
            this.panel5.Controls.Add(this.searchButton);
            this.panel5.Controls.Add(this.searchTIN);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1728, 32);
            this.panel5.TabIndex = 7;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(4)))), ((int)(((byte)(28)))));
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(20)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
            this.deleteButton.Location = new System.Drawing.Point(301, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(182, 32);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Удалить запись";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(4)))), ((int)(((byte)(28)))));
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(20)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
            this.searchButton.Location = new System.Drawing.Point(177, 0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(124, 32);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTIN
            // 
            this.searchTIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.searchTIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTIN.Dock = System.Windows.Forms.DockStyle.Left;
            this.searchTIN.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTIN.ForeColor = System.Drawing.Color.Black;
            this.searchTIN.Location = new System.Drawing.Point(0, 0);
            this.searchTIN.Multiline = true;
            this.searchTIN.Name = "searchTIN";
            this.searchTIN.Size = new System.Drawing.Size(177, 32);
            this.searchTIN.TabIndex = 3;
            this.searchTIN.Enter += new System.EventHandler(this.searchTIN_Enter);
            this.searchTIN.Leave += new System.EventHandler(this.searchTIN_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(4)))), ((int)(((byte)(28)))));
            this.panel2.Controls.Add(this.collapseButton);
            this.panel2.Controls.Add(this.minmaxButton);
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1728, 42);
            this.panel2.TabIndex = 0;
            this.panel2.DoubleClick += new System.EventHandler(this.panel2_DoubleClick);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // collapseButton
            // 
            this.collapseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.collapseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.collapseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.collapseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
            this.collapseButton.Location = new System.Drawing.Point(1629, 0);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(33, 42);
            this.collapseButton.TabIndex = 3;
            this.collapseButton.Text = "─";
            this.collapseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.collapseButton.Click += new System.EventHandler(this.collapseButton_Click);
            this.collapseButton.MouseEnter += new System.EventHandler(this.collapseButton_MouseEnter);
            this.collapseButton.MouseLeave += new System.EventHandler(this.collapseButton_MouseLeave);
            // 
            // minmaxButton
            // 
            this.minmaxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minmaxButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minmaxButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minmaxButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
            this.minmaxButton.Location = new System.Drawing.Point(1662, 0);
            this.minmaxButton.Name = "minmaxButton";
            this.minmaxButton.Size = new System.Drawing.Size(33, 42);
            this.minmaxButton.TabIndex = 2;
            this.minmaxButton.Text = "▭";
            this.minmaxButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minmaxButton.Click += new System.EventHandler(this.minmaxButton_Click);
            this.minmaxButton.MouseEnter += new System.EventHandler(this.minmaxButton_MouseEnter);
            this.minmaxButton.MouseLeave += new System.EventHandler(this.minmaxButton_MouseLeave);
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
            this.CloseButton.Location = new System.Drawing.Point(1695, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(33, 42);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Налогоплательщики";
            // 
            // taxpayerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 782);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "taxpayerWindow";
            this.Text = "taxpayer";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taxpayerTable)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public string tpAccess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.TextBox searchTIN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tpTIN;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView taxpayerTable;
        private System.Windows.Forms.Label collapseButton;
        private System.Windows.Forms.Label minmaxButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox street;
        private System.Windows.Forms.TextBox district;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.DateTimePicker tpIssueDate;
        private System.Windows.Forms.TextBox tpNum;
        private System.Windows.Forms.TextBox tpSer;
        private System.Windows.Forms.TextBox tpIssueOrg;
        private System.Windows.Forms.TextBox tpDoc;
        private System.Windows.Forms.TextBox tpPatron;
        private System.Windows.Forms.TextBox tpName;
        private System.Windows.Forms.TextBox tpSurname;
        private System.Windows.Forms.TextBox orgTIN;
        private System.Windows.Forms.TextBox tTIN;
        private System.Windows.Forms.TextBox stNum;
        private System.Windows.Forms.Button addButton;
    }
}