
namespace TaxViewer
{
    partial class AdminWindow
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.workTable = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.fieldPatron = new System.Windows.Forms.TextBox();
            this.fieldLName = new System.Windows.Forms.TextBox();
            this.fieldFName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.exemptionField = new System.Windows.Forms.TextBox();
            this.sumField = new System.Windows.Forms.TextBox();
            this.dateField = new System.Windows.Forms.DateTimePicker();
            this.tinField = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.organizationButton = new System.Windows.Forms.Button();
            this.taxButton = new System.Windows.Forms.Button();
            this.taxpayerButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.collapseButton = new System.Windows.Forms.Label();
            this.minmaxButton = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workTable)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 609);
            this.panel1.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.workTable);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 74);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1031, 446);
            this.panel6.TabIndex = 11;
            // 
            // workTable
            // 
            this.workTable.AllowUserToAddRows = false;
            this.workTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workTable.Location = new System.Drawing.Point(0, 0);
            this.workTable.Name = "workTable";
            this.workTable.Size = new System.Drawing.Size(1031, 446);
            this.workTable.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.searchButton);
            this.panel5.Controls.Add(this.fieldPatron);
            this.panel5.Controls.Add(this.fieldLName);
            this.panel5.Controls.Add(this.fieldFName);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 42);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1031, 32);
            this.panel5.TabIndex = 10;
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
            this.searchButton.Location = new System.Drawing.Point(546, 0);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(155, 32);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // fieldPatron
            // 
            this.fieldPatron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.fieldPatron.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldPatron.Dock = System.Windows.Forms.DockStyle.Left;
            this.fieldPatron.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldPatron.Location = new System.Drawing.Point(364, 0);
            this.fieldPatron.Multiline = true;
            this.fieldPatron.Name = "fieldPatron";
            this.fieldPatron.Size = new System.Drawing.Size(182, 32);
            this.fieldPatron.TabIndex = 2;
            this.fieldPatron.Enter += new System.EventHandler(this.fieldPatron_Enter);
            this.fieldPatron.Leave += new System.EventHandler(this.fieldPatron_Leave);
            // 
            // fieldLName
            // 
            this.fieldLName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.fieldLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldLName.Dock = System.Windows.Forms.DockStyle.Left;
            this.fieldLName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldLName.Location = new System.Drawing.Point(182, 0);
            this.fieldLName.Multiline = true;
            this.fieldLName.Name = "fieldLName";
            this.fieldLName.Size = new System.Drawing.Size(182, 32);
            this.fieldLName.TabIndex = 1;
            this.fieldLName.Enter += new System.EventHandler(this.fieldLName_Enter);
            this.fieldLName.Leave += new System.EventHandler(this.fieldLName_Leave);
            // 
            // fieldFName
            // 
            this.fieldFName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.fieldFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldFName.Dock = System.Windows.Forms.DockStyle.Left;
            this.fieldFName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldFName.Location = new System.Drawing.Point(0, 0);
            this.fieldFName.Multiline = true;
            this.fieldFName.Name = "fieldFName";
            this.fieldFName.Size = new System.Drawing.Size(182, 32);
            this.fieldFName.TabIndex = 0;
            this.fieldFName.Enter += new System.EventHandler(this.fieldFName_Enter);
            this.fieldFName.Leave += new System.EventHandler(this.fieldFName_Leave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.addButton);
            this.panel4.Controls.Add(this.exemptionField);
            this.panel4.Controls.Add(this.sumField);
            this.panel4.Controls.Add(this.dateField);
            this.panel4.Controls.Add(this.tinField);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 520);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1031, 32);
            this.panel4.TabIndex = 9;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(4)))), ((int)(((byte)(28)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(20)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
            this.addButton.Location = new System.Drawing.Point(615, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(29, 32);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // exemptionField
            // 
            this.exemptionField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.exemptionField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exemptionField.Dock = System.Windows.Forms.DockStyle.Left;
            this.exemptionField.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exemptionField.Location = new System.Drawing.Point(383, 0);
            this.exemptionField.Multiline = true;
            this.exemptionField.Name = "exemptionField";
            this.exemptionField.Size = new System.Drawing.Size(232, 32);
            this.exemptionField.TabIndex = 16;
            this.exemptionField.Enter += new System.EventHandler(this.exemptionField_Enter);
            this.exemptionField.Leave += new System.EventHandler(this.exemptionField_Leave);
            // 
            // sumField
            // 
            this.sumField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.sumField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sumField.Dock = System.Windows.Forms.DockStyle.Left;
            this.sumField.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumField.Location = new System.Drawing.Point(151, 0);
            this.sumField.Multiline = true;
            this.sumField.Name = "sumField";
            this.sumField.Size = new System.Drawing.Size(232, 32);
            this.sumField.TabIndex = 15;
            this.sumField.Enter += new System.EventHandler(this.sumField_Enter);
            this.sumField.Leave += new System.EventHandler(this.sumField_Leave);
            // 
            // dateField
            // 
            this.dateField.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.dateField.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.dateField.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.dateField.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateField.Location = new System.Drawing.Point(139, 0);
            this.dateField.Name = "dateField";
            this.dateField.Size = new System.Drawing.Size(12, 20);
            this.dateField.TabIndex = 14;
            // 
            // tinField
            // 
            this.tinField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.tinField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tinField.Dock = System.Windows.Forms.DockStyle.Left;
            this.tinField.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tinField.Location = new System.Drawing.Point(0, 0);
            this.tinField.Multiline = true;
            this.tinField.Name = "tinField";
            this.tinField.Size = new System.Drawing.Size(139, 32);
            this.tinField.TabIndex = 9;
            this.tinField.Enter += new System.EventHandler(this.tinField_Enter);
            this.tinField.Leave += new System.EventHandler(this.tinField_Leave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.organizationButton);
            this.panel3.Controls.Add(this.taxButton);
            this.panel3.Controls.Add(this.taxpayerButton);
            this.panel3.Controls.Add(this.printButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 552);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1031, 57);
            this.panel3.TabIndex = 8;
            // 
            // organizationButton
            // 
            this.organizationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(4)))), ((int)(((byte)(28)))));
            this.organizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.organizationButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.organizationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(20)))));
            this.organizationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.organizationButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.organizationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
            this.organizationButton.Location = new System.Drawing.Point(459, 0);
            this.organizationButton.Name = "organizationButton";
            this.organizationButton.Size = new System.Drawing.Size(185, 57);
            this.organizationButton.TabIndex = 9;
            this.organizationButton.Text = "Организации";
            this.organizationButton.UseVisualStyleBackColor = false;
            this.organizationButton.Click += new System.EventHandler(this.organizationButton_Click);
            // 
            // taxButton
            // 
            this.taxButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(4)))), ((int)(((byte)(28)))));
            this.taxButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taxButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.taxButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(20)))));
            this.taxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taxButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taxButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
            this.taxButton.Location = new System.Drawing.Point(260, 0);
            this.taxButton.Name = "taxButton";
            this.taxButton.Size = new System.Drawing.Size(199, 57);
            this.taxButton.TabIndex = 8;
            this.taxButton.Text = "Налоговые";
            this.taxButton.UseVisualStyleBackColor = false;
            this.taxButton.Click += new System.EventHandler(this.taxButton_Click);
            // 
            // taxpayerButton
            // 
            this.taxpayerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(4)))), ((int)(((byte)(28)))));
            this.taxpayerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taxpayerButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.taxpayerButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(2)))), ((int)(((byte)(20)))));
            this.taxpayerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.taxpayerButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taxpayerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(171)))), ((int)(((byte)(4)))));
            this.taxpayerButton.Location = new System.Drawing.Point(0, 0);
            this.taxpayerButton.Name = "taxpayerButton";
            this.taxpayerButton.Size = new System.Drawing.Size(260, 57);
            this.taxpayerButton.TabIndex = 7;
            this.taxpayerButton.Text = "Налогоплательщики";
            this.taxpayerButton.UseVisualStyleBackColor = false;
            this.taxpayerButton.Click += new System.EventHandler(this.taxpayerButton_Click);
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
            this.printButton.Location = new System.Drawing.Point(832, 0);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(199, 57);
            this.printButton.TabIndex = 6;
            this.printButton.Text = "Печать";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
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
            this.panel2.Size = new System.Drawing.Size(1031, 42);
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
            this.collapseButton.Location = new System.Drawing.Point(932, 0);
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
            this.minmaxButton.Location = new System.Drawing.Point(965, 0);
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
            this.CloseButton.Location = new System.Drawing.Point(998, 0);
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
            this.label1.Size = new System.Drawing.Size(195, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tax Viewer";
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 609);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminWindow";
            this.Text = "AdminWindow";
            this.Load += new System.EventHandler(this.AdminWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workTable)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public string awAccess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label collapseButton;
        private System.Windows.Forms.Label minmaxButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button taxpayerButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox fieldFName;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox fieldPatron;
        private System.Windows.Forms.TextBox fieldLName;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView workTable;
        private System.Windows.Forms.TextBox tinField;
        private System.Windows.Forms.DateTimePicker dateField;
        private System.Windows.Forms.TextBox sumField;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox exemptionField;
        private System.Windows.Forms.Button organizationButton;
        private System.Windows.Forms.Button taxButton;
    }
}