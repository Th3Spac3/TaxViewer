
namespace TaxViewer
{
    partial class taxWindow
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
            this.taxTable = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.taxName = new System.Windows.Forms.TextBox();
            this.taxTIN = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.taxTable)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(494, 410);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.taxTable);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 247);
            this.panel3.TabIndex = 8;
            // 
            // taxTable
            // 
            this.taxTable.AllowUserToAddRows = false;
            this.taxTable.AllowUserToDeleteRows = false;
            this.taxTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taxTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taxTable.Location = new System.Drawing.Point(0, 0);
            this.taxTable.Name = "taxTable";
            this.taxTable.Size = new System.Drawing.Size(494, 247);
            this.taxTable.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.addButton);
            this.panel4.Controls.Add(this.taxName);
            this.panel4.Controls.Add(this.taxTIN);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 321);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(494, 32);
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
            this.addButton.Location = new System.Drawing.Point(312, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(31, 32);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // taxName
            // 
            this.taxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.taxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxName.Dock = System.Windows.Forms.DockStyle.Left;
            this.taxName.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taxName.ForeColor = System.Drawing.Color.Black;
            this.taxName.Location = new System.Drawing.Point(143, 0);
            this.taxName.Multiline = true;
            this.taxName.Name = "taxName";
            this.taxName.Size = new System.Drawing.Size(169, 32);
            this.taxName.TabIndex = 7;
            this.taxName.Enter += new System.EventHandler(this.taxName_Enter);
            this.taxName.Leave += new System.EventHandler(this.taxName_Leave);
            // 
            // taxTIN
            // 
            this.taxTIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.taxTIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxTIN.Dock = System.Windows.Forms.DockStyle.Left;
            this.taxTIN.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taxTIN.ForeColor = System.Drawing.Color.Black;
            this.taxTIN.Location = new System.Drawing.Point(0, 0);
            this.taxTIN.Multiline = true;
            this.taxTIN.Name = "taxTIN";
            this.taxTIN.Size = new System.Drawing.Size(143, 32);
            this.taxTIN.TabIndex = 4;
            this.taxTIN.Enter += new System.EventHandler(this.taxTIN_Enter);
            this.taxTIN.Leave += new System.EventHandler(this.taxTIN_Leave);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.printButton);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 353);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(494, 57);
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
            this.printButton.Location = new System.Drawing.Point(295, 0);
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
            this.panel5.Size = new System.Drawing.Size(494, 32);
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
            this.panel2.Size = new System.Drawing.Size(494, 42);
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
            this.collapseButton.Location = new System.Drawing.Point(395, 0);
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
            this.minmaxButton.Location = new System.Drawing.Point(428, 0);
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
            this.CloseButton.Location = new System.Drawing.Point(461, 0);
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
            this.label1.Size = new System.Drawing.Size(171, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Налоговые";
            // 
            // taxWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 410);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "taxWindow";
            this.Text = "taxWindow";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.taxTable)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public string taxAccess;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView taxTable;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox taxName;
        private System.Windows.Forms.TextBox taxTIN;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTIN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label collapseButton;
        private System.Windows.Forms.Label minmaxButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label label1;
    }
}