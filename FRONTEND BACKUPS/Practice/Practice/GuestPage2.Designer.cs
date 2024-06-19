namespace Practice
{
    partial class Guest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest));
            panel1 = new Panel();
            panel2 = new Panel();
            labelGM = new Label();
            label2 = new Label();
            panel4 = new Panel();
            panelBaseTable = new Panel();
            panelFilters = new Panel();
            comboBoxFilterRoomNo = new ComboBox();
            dataGridView1 = new DataGridView();
            panelSearch = new Panel();
            buttonMore = new Button();
            buttonSearchIcon = new Button();
            textBoxAddressSearch = new TextBox();
            label1 = new Label();
            panelAddaGuest = new Panel();
            label3 = new Label();
            labelAddGuest = new Label();
            ColumnGuestID = new DataGridViewTextBoxColumn();
            ColumnLastName = new DataGridViewTextBoxColumn();
            ColumnFirstName = new DataGridViewTextBoxColumn();
            ColumnMI = new DataGridViewTextBoxColumn();
            ColumnGender = new DataGridViewTextBoxColumn();
            ColumnBirthDate = new DataGridViewTextBoxColumn();
            ColumnAge = new DataGridViewTextBoxColumn();
            ColumnNationality = new DataGridViewTextBoxColumn();
            ColumnAddress = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panelBaseTable.SuspendLayout();
            panelFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelSearch.SuspendLayout();
            panelAddaGuest.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(45, 106, 79);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 749);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 250);
            panel2.TabIndex = 0;
            // 
            // labelGM
            // 
            labelGM.AutoSize = true;
            labelGM.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGM.Location = new Point(68, -104);
            labelGM.Name = "labelGM";
            labelGM.Size = new Size(328, 42);
            labelGM.TabIndex = 7;
            labelGM.Text = "Guest Management";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 5);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 9;
            label2.Text = "List of Guests";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(76, 149, 108);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(514, 84);
            panel4.Name = "panel4";
            panel4.Size = new Size(153, 32);
            panel4.TabIndex = 9;
            // 
            // panelBaseTable
            // 
            panelBaseTable.BackColor = Color.FromArgb(76, 149, 108);
            panelBaseTable.BackgroundImageLayout = ImageLayout.Zoom;
            panelBaseTable.Controls.Add(panelFilters);
            panelBaseTable.Controls.Add(dataGridView1);
            panelBaseTable.Controls.Add(panelSearch);
            panelBaseTable.Location = new Point(355, 115);
            panelBaseTable.Name = "panelBaseTable";
            panelBaseTable.Size = new Size(971, 593);
            panelBaseTable.TabIndex = 8;
            // 
            // panelFilters
            // 
            panelFilters.Controls.Add(comboBoxFilterRoomNo);
            panelFilters.Location = new Point(104, 105);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(742, 50);
            panelFilters.TabIndex = 15;
            // 
            // comboBoxFilterRoomNo
            // 
            comboBoxFilterRoomNo.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterRoomNo.FormattingEnabled = true;
            comboBoxFilterRoomNo.Location = new Point(13, 10);
            comboBoxFilterRoomNo.Name = "comboBoxFilterRoomNo";
            comboBoxFilterRoomNo.Size = new Size(112, 27);
            comboBoxFilterRoomNo.TabIndex = 9;
            comboBoxFilterRoomNo.Text = "[template]";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnGuestID, ColumnLastName, ColumnFirstName, ColumnMI, ColumnGender, ColumnBirthDate, ColumnAge, ColumnNationality, ColumnAddress });
            dataGridView1.Location = new Point(8, 180);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(957, 260);
            dataGridView1.TabIndex = 14;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(buttonMore);
            panelSearch.Controls.Add(buttonSearchIcon);
            panelSearch.Controls.Add(textBoxAddressSearch);
            panelSearch.Location = new Point(150, 43);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(624, 53);
            panelSearch.TabIndex = 13;
            // 
            // buttonMore
            // 
            buttonMore.BackgroundImage = (Image)resources.GetObject("buttonMore.BackgroundImage");
            buttonMore.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMore.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMore.Location = new Point(569, 12);
            buttonMore.Name = "buttonMore";
            buttonMore.Size = new Size(28, 27);
            buttonMore.TabIndex = 4;
            buttonMore.UseVisualStyleBackColor = true;
            // 
            // buttonSearchIcon
            // 
            buttonSearchIcon.BackgroundImage = (Image)resources.GetObject("buttonSearchIcon.BackgroundImage");
            buttonSearchIcon.BackgroundImageLayout = ImageLayout.Zoom;
            buttonSearchIcon.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearchIcon.Location = new Point(535, 12);
            buttonSearchIcon.Name = "buttonSearchIcon";
            buttonSearchIcon.Size = new Size(28, 27);
            buttonSearchIcon.TabIndex = 3;
            buttonSearchIcon.UseVisualStyleBackColor = true;
            // 
            // textBoxAddressSearch
            // 
            textBoxAddressSearch.Enabled = false;
            textBoxAddressSearch.Font = new Font("SF Pro Display", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxAddressSearch.ForeColor = SystemColors.WindowFrame;
            textBoxAddressSearch.Location = new Point(9, 12);
            textBoxAddressSearch.Name = "textBoxAddressSearch";
            textBoxAddressSearch.Size = new Size(508, 27);
            textBoxAddressSearch.TabIndex = 2;
            textBoxAddressSearch.Text = "Search";
            textBoxAddressSearch.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 25);
            label1.Name = "label1";
            label1.Size = new Size(328, 42);
            label1.TabIndex = 10;
            label1.Text = "Guest Management";
            // 
            // panelAddaGuest
            // 
            panelAddaGuest.BackColor = Color.MediumSeaGreen;
            panelAddaGuest.Controls.Add(label3);
            panelAddaGuest.Controls.Add(labelAddGuest);
            panelAddaGuest.Location = new Point(355, 84);
            panelAddaGuest.Name = "panelAddaGuest";
            panelAddaGuest.Size = new Size(153, 32);
            panelAddaGuest.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 6);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 8;
            label3.Text = "Add a Guest";
            // 
            // labelAddGuest
            // 
            labelAddGuest.AutoSize = true;
            labelAddGuest.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelAddGuest.Location = new Point(17, 5);
            labelAddGuest.Name = "labelAddGuest";
            labelAddGuest.Size = new Size(116, 23);
            labelAddGuest.TabIndex = 7;
            labelAddGuest.Text = "Add a Guest";
            // 
            // ColumnGuestID
            // 
            ColumnGuestID.HeaderText = "Guest ID";
            ColumnGuestID.Name = "ColumnGuestID";
            ColumnGuestID.ReadOnly = true;
            ColumnGuestID.Resizable = DataGridViewTriState.True;
            ColumnGuestID.Width = 110;
            // 
            // ColumnLastName
            // 
            ColumnLastName.HeaderText = "Last Name";
            ColumnLastName.Name = "ColumnLastName";
            ColumnLastName.ReadOnly = true;
            ColumnLastName.Resizable = DataGridViewTriState.True;
            ColumnLastName.Width = 130;
            // 
            // ColumnFirstName
            // 
            ColumnFirstName.HeaderText = "First Name";
            ColumnFirstName.Name = "ColumnFirstName";
            ColumnFirstName.ReadOnly = true;
            ColumnFirstName.Width = 130;
            // 
            // ColumnMI
            // 
            ColumnMI.HeaderText = "M.I.";
            ColumnMI.Name = "ColumnMI";
            ColumnMI.ReadOnly = true;
            ColumnMI.Width = 40;
            // 
            // ColumnGender
            // 
            ColumnGender.HeaderText = "Gender";
            ColumnGender.Name = "ColumnGender";
            ColumnGender.ReadOnly = true;
            ColumnGender.Width = 90;
            // 
            // ColumnBirthDate
            // 
            ColumnBirthDate.HeaderText = "Birth Date";
            ColumnBirthDate.Name = "ColumnBirthDate";
            ColumnBirthDate.ReadOnly = true;
            ColumnBirthDate.Resizable = DataGridViewTriState.True;
            ColumnBirthDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnBirthDate.Width = 90;
            // 
            // ColumnAge
            // 
            ColumnAge.HeaderText = "Age";
            ColumnAge.Name = "ColumnAge";
            ColumnAge.ReadOnly = true;
            ColumnAge.Width = 40;
            // 
            // ColumnNationality
            // 
            ColumnNationality.HeaderText = "Nationality";
            ColumnNationality.Name = "ColumnNationality";
            ColumnNationality.ReadOnly = true;
            ColumnNationality.Width = 110;
            // 
            // ColumnAddress
            // 
            ColumnAddress.HeaderText = "Address";
            ColumnAddress.Name = "ColumnAddress";
            ColumnAddress.ReadOnly = true;
            ColumnAddress.Width = 190;
            // 
            // Guest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panelAddaGuest);
            Controls.Add(label1);
            Controls.Add(panel4);
            Controls.Add(panelBaseTable);
            Controls.Add(panel1);
            Controls.Add(labelGM);
            Name = "Guest";
            Text = "Guest";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelBaseTable.ResumeLayout(false);
            panelFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelAddaGuest.ResumeLayout(false);
            panelAddaGuest.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label labelGM;
        private Label label2;
        private Panel panel4;
        private Panel panelBaseTable;
        private Label label1;
        private Panel panelAddaGuest;
        private Label label3;
        private Label labelAddGuest;
        private DataGridView dataGridView1;
        private Panel panelSearch;
        private Button buttonMore;
        private Button buttonSearchIcon;
        private TextBox textBoxAddressSearch;
        private Panel panelFilters;
        private ComboBox comboBoxFilterRoomNo;
        private DataGridViewTextBoxColumn ColumnGuestID;
        private DataGridViewTextBoxColumn ColumnLastName;
        private DataGridViewTextBoxColumn ColumnFirstName;
        private DataGridViewTextBoxColumn ColumnMI;
        private DataGridViewTextBoxColumn ColumnGender;
        private DataGridViewTextBoxColumn ColumnBirthDate;
        private DataGridViewTextBoxColumn ColumnAge;
        private DataGridViewTextBoxColumn ColumnNationality;
        private DataGridViewTextBoxColumn ColumnAddress;
    }
}