
namespace TaxViewer
{
    partial class organizationWindow
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
            this.orgTable = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.addressStNumber = new System.Windows.Forms.TextBox();
            this.addressStreet = new System.Windows.Forms.TextBox();
            this.addressCity = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.orgName = new System.Windows.Forms.TextBox();
            this.orgAccPatron = new System.Windows.Forms.TextBox();
            this.orgAccName = new System.Windows.Forms.TextBox();
            this.orgAccSurname = new System.Windows.Forms.TextBox();
            this.orgTIN = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.printButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.orgTINfield = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.collapseButton = new System.Windows.Forms.Label();
            this.minmaxButton = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orgTable)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1264, 604);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.orgTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1264, 441);
            this.panel3.TabIndex = 8;
            // 
            // orgTable
            // 
            this.orgTable.AllowUserToAddRows = false;
            this.orgTable.AllowUserToDeleteRows = false;
            this.orgTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orgTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orgTable.Location = new System.Drawing.Point(0, 0);
            this.orgTable.Name = "orgTable";
            this.orgTable.Size = new System.Drawing.Size(1264, 441);
            this.orgTable.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.addButton);
            this.panel4.Controls.Add(this.addressStNumber);
            this.panel4.Controls.Add(this.addressStreet);
            this.panel4.Controls.Add(this.addressCity);
            this.panel4.Controls.Add(this.phoneNumber);
            this.panel4.Controls.Add(this.orgName);
            this.panel4.Controls.Add(this.orgAccPatron);
            this.panel4.Controls.Add(this.orgAccName);
            this.panel4.Controls.Add(this.orgAccSurname);
            this.panel4.Controls.Add(this.orgTIN);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 515);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1264, 32);
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
            this.addButton.Location = new System.Drawing.Point(1235, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(31, 32);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addressStNumber
            // 
            this.addressStNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.addressStNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressStNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.addressStNumber.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressStNumber.ForeColor = System.Drawing.Color.Black;
            this.addressStNumber.Location = new System.Drawing.Point(1206, 0);
            this.addressStNumber.Multiline = true;
            this.addressStNumber.Name = "addressStNumber";
            this.addressStNumber.Size = new System.Drawing.Size(29, 32);
            this.addressStNumber.TabIndex = 12;
            this.addressStNumber.Enter += new System.EventHandler(this.addressStNumber_Enter);
            this.addressStNumber.Leave += new System.EventHandler(this.addressStNumber_Leave);
            // 
            // addressStreet
            // 
            this.addressStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.addressStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressStreet.Dock = System.Windows.Forms.DockStyle.Left;
            this.addressStreet.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressStreet.ForeColor = System.Drawing.Color.Black;
            this.addressStreet.Location = new System.Drawing.Point(1077, 0);
            this.addressStreet.Multiline = true;
            this.addressStreet.Name = "addressStreet";
            this.addressStreet.Size = new System.Drawing.Size(129, 32);
            this.addressStreet.TabIndex = 11;
            this.addressStreet.Enter += new System.EventHandler(this.addressStreet_Enter);
            this.addressStreet.Leave += new System.EventHandler(this.addressStreet_Leave);
            // 
            // addressCity
            // 
            this.addressCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.addressCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addressCity.Dock = System.Windows.Forms.DockStyle.Left;
            this.addressCity.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressCity.ForeColor = System.Drawing.Color.Black;
            this.addressCity.Location = new System.Drawing.Point(948, 0);
            this.addressCity.Multiline = true;
            this.addressCity.Name = "addressCity";
            this.addressCity.Size = new System.Drawing.Size(129, 32);
            this.addressCity.TabIndex = 10;
            this.addressCity.Enter += new System.EventHandler(this.addressCity_Enter);
            this.addressCity.Leave += new System.EventHandler(this.addressCity_Leave);
            // 
            // phoneNumber
            // 
            this.phoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.phoneNumber.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumber.ForeColor = System.Drawing.Color.Black;
            this.phoneNumber.Location = new System.Drawing.Point(819, 0);
            this.phoneNumber.Multiline = true;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(129, 32);
            this.phoneNumber.TabIndex = 9;
            this.phoneNumber.Enter += new System.EventHandler(this.phoneNumber_Enter);
            this.phoneNumber.Leave += new System.EventHandler(this.phoneNumber_Leave);
            // 
            // orgName
            // 
            this.orgName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.orgName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orgName.Dock = System.Windows.Forms.DockStyle.Left;
            this.orgName.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgName.ForeColor = System.Drawing.Color.Black;
            this.orgName.Location = new System.Drawing.Point(690, 0);
            this.orgName.Multiline = true;
            this.orgName.Name = "orgName";
            this.orgName.Size = new System.Drawing.Size(129, 32);
            this.orgName.TabIndex = 8;
            this.orgName.Enter += new System.EventHandler(this.orgName_Enter);
            this.orgName.Leave += new System.EventHandler(this.orgName_Leave);
            // 
            // orgAccPatron
            // 
            this.orgAccPatron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.orgAccPatron.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orgAccPatron.Dock = System.Windows.Forms.DockStyle.Left;
            this.orgAccPatron.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgAccPatron.ForeColor = System.Drawing.Color.Black;
            this.orgAccPatron.Location = new System.Drawing.Point(521, 0);
            this.orgAccPatron.Multiline = true;
            this.orgAccPatron.Name = "orgAccPatron";
            this.orgAccPatron.Size = new System.Drawing.Size(169, 32);
            this.orgAccPatron.TabIndex = 7;
            this.orgAccPatron.Enter += new System.EventHandler(this.orgAccPatron_Enter);
            this.orgAccPatron.Leave += new System.EventHandler(this.orgAccPatron_Leave);
            // 
            // orgAccName
            // 
            this.orgAccName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.orgAccName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orgAccName.Dock = System.Windows.Forms.DockStyle.Left;
            this.orgAccName.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgAccName.ForeColor = System.Drawing.Color.Black;
            this.orgAccName.Location = new System.Drawing.Point(330, 0);
            this.orgAccName.Multiline = true;
            this.orgAccName.Name = "orgAccName";
            this.orgAccName.Size = new System.Drawing.Size(191, 32);
            this.orgAccName.TabIndex = 6;
            this.orgAccName.Enter += new System.EventHandler(this.orgAccName_Enter);
            this.orgAccName.Leave += new System.EventHandler(this.orgAccName_Leave);
            // 
            // orgAccSurname
            // 
            this.orgAccSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.orgAccSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orgAccSurname.Dock = System.Windows.Forms.DockStyle.Left;
            this.orgAccSurname.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgAccSurname.ForeColor = System.Drawing.Color.Black;
            this.orgAccSurname.Location = new System.Drawing.Point(143, 0);
            this.orgAccSurname.Multiline = true;
            this.orgAccSurname.Name = "orgAccSurname";
            this.orgAccSurname.Size = new System.Drawing.Size(187, 32);
            this.orgAccSurname.TabIndex = 5;
            this.orgAccSurname.Enter += new System.EventHandler(this.orgAccSurname_Enter);
            this.orgAccSurname.Leave += new System.EventHandler(this.orgAccSurname_Leave);
            // 
            // orgTIN
            // 
            this.orgTIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.orgTIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orgTIN.Dock = System.Windows.Forms.DockStyle.Left;
            this.orgTIN.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgTIN.ForeColor = System.Drawing.Color.Black;
            this.orgTIN.Location = new System.Drawing.Point(0, 0);
            this.orgTIN.Multiline = true;
            this.orgTIN.Name = "orgTIN";
            this.orgTIN.Size = new System.Drawing.Size(143, 32);
            this.orgTIN.TabIndex = 4;
            this.orgTIN.Enter += new System.EventHandler(this.orgTIN_Enter);
            this.orgTIN.Leave += new System.EventHandler(this.orgTIN_Leave);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.printButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 547);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1264, 57);
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
            this.printButton.Location = new System.Drawing.Point(1065, 0);
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
            this.panel5.Controls.Add(this.orgTINfield);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1264, 32);
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
            this.deleteButton.Size = new System.Drawing.Size(194, 32);
            this.deleteButton.TabIndex = 8;
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
            // orgTINfield
            // 
            this.orgTINfield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.orgTINfield.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orgTINfield.Dock = System.Windows.Forms.DockStyle.Left;
            this.orgTINfield.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orgTINfield.ForeColor = System.Drawing.Color.Black;
            this.orgTINfield.Location = new System.Drawing.Point(0, 0);
            this.orgTINfield.Multiline = true;
            this.orgTINfield.Name = "orgTINfield";
            this.orgTINfield.Size = new System.Drawing.Size(177, 32);
            this.orgTINfield.TabIndex = 3;
            this.orgTINfield.Enter += new System.EventHandler(this.orgTINfield_Enter);
            this.orgTINfield.Leave += new System.EventHandler(this.orgTINfield_Leave);
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
            this.panel2.Size = new System.Drawing.Size(1264, 42);
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
            this.collapseButton.Location = new System.Drawing.Point(1165, 0);
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
            this.minmaxButton.Location = new System.Drawing.Point(1198, 0);
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
            this.CloseButton.Location = new System.Drawing.Point(1231, 0);
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
            this.label1.Size = new System.Drawing.Size(193, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Организации";
            // 
            // organizationWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 604);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "organizationWindow";
            this.Text = "organizationWindow";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orgTable)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public string orgAccess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView orgTable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox orgTIN;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox orgTINfield;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label collapseButton;
        private System.Windows.Forms.Label minmaxButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox addressStNumber;
        private System.Windows.Forms.TextBox addressStreet;
        private System.Windows.Forms.TextBox addressCity;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox orgName;
        private System.Windows.Forms.TextBox orgAccPatron;
        private System.Windows.Forms.TextBox orgAccName;
        private System.Windows.Forms.TextBox orgAccSurname;
        private System.Windows.Forms.Button deleteButton;
    }
}