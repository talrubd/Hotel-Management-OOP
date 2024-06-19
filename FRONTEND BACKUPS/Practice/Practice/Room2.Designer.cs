namespace Practice
{
    partial class Room2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room2));
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            labelListOfRooms = new Label();
            labelAddRoom = new Label();
            panelBaseTable = new Panel();
            comboBoxFilterFloorNo = new ComboBox();
            comboBoxFilterRoomNo = new ComboBox();
            comboBoxFilterMaxCap = new ComboBox();
            comboBoxFilterRoomType = new ComboBox();
            comboBoxRoomStatus = new ComboBox();
            dataGridView1 = new DataGridView();
            ColumnRoomNo = new DataGridViewTextBoxColumn();
            ColumnRoomType = new DataGridViewComboBoxColumn();
            ColumnFloorNo = new DataGridViewTextBoxColumn();
            ColumnMaxCap = new DataGridViewTextBoxColumn();
            ColumnRoomRate = new DataGridViewTextBoxColumn();
            ColumnRoomStatus = new DataGridViewComboBoxColumn();
            panelSearch = new Panel();
            buttonMore = new Button();
            buttonSearchIcon = new Button();
            textBoxAddressSearch = new TextBox();
            panelAddaGuest = new Panel();
            label2 = new Label();
            label1 = new Label();
            comboBoxFilterRoomRate = new ComboBox();
            panelFilters = new Panel();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panelBaseTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelSearch.SuspendLayout();
            panelAddaGuest.SuspendLayout();
            panelFilters.SuspendLayout();
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
            panel1.TabIndex = 12;
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
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(76, 149, 108);
            panel4.Controls.Add(labelListOfRooms);
            panel4.Controls.Add(labelAddRoom);
            panel4.Location = new Point(513, 111);
            panel4.Name = "panel4";
            panel4.Size = new Size(153, 32);
            panel4.TabIndex = 15;
            // 
            // labelListOfRooms
            // 
            labelListOfRooms.AutoSize = true;
            labelListOfRooms.BackColor = Color.Transparent;
            labelListOfRooms.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelListOfRooms.Location = new Point(13, 5);
            labelListOfRooms.Name = "labelListOfRooms";
            labelListOfRooms.Size = new Size(128, 23);
            labelListOfRooms.TabIndex = 11;
            labelListOfRooms.Text = "List of Rooms";
            // 
            // labelAddRoom
            // 
            labelAddRoom.AutoSize = true;
            labelAddRoom.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelAddRoom.Location = new Point(19, 5);
            labelAddRoom.Name = "labelAddRoom";
            labelAddRoom.Size = new Size(113, 23);
            labelAddRoom.TabIndex = 10;
            labelAddRoom.Text = "Add a Room";
            // 
            // panelBaseTable
            // 
            panelBaseTable.BackColor = Color.FromArgb(76, 149, 108);
            panelBaseTable.BackgroundImageLayout = ImageLayout.Zoom;
            panelBaseTable.Controls.Add(panelFilters);
            panelBaseTable.Controls.Add(dataGridView1);
            panelBaseTable.Controls.Add(panelSearch);
            panelBaseTable.Location = new Point(354, 142);
            panelBaseTable.Name = "panelBaseTable";
            panelBaseTable.Size = new Size(956, 551);
            panelBaseTable.TabIndex = 14;
            // 
            // comboBoxFilterFloorNo
            // 
            comboBoxFilterFloorNo.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterFloorNo.FormattingEnabled = true;
            comboBoxFilterFloorNo.Location = new Point(267, 10);
            comboBoxFilterFloorNo.Name = "comboBoxFilterFloorNo";
            comboBoxFilterFloorNo.Size = new Size(101, 27);
            comboBoxFilterFloorNo.TabIndex = 10;
            comboBoxFilterFloorNo.Text = " Floor No.";
            // 
            // comboBoxFilterRoomNo
            // 
            comboBoxFilterRoomNo.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterRoomNo.FormattingEnabled = true;
            comboBoxFilterRoomNo.Location = new Point(13, 10);
            comboBoxFilterRoomNo.Name = "comboBoxFilterRoomNo";
            comboBoxFilterRoomNo.Size = new Size(112, 27);
            comboBoxFilterRoomNo.TabIndex = 9;
            comboBoxFilterRoomNo.Text = " Room No.";
            // 
            // comboBoxFilterMaxCap
            // 
            comboBoxFilterMaxCap.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterMaxCap.FormattingEnabled = true;
            comboBoxFilterMaxCap.Location = new Point(376, 10);
            comboBoxFilterMaxCap.Name = "comboBoxFilterMaxCap";
            comboBoxFilterMaxCap.Size = new Size(128, 27);
            comboBoxFilterMaxCap.TabIndex = 8;
            comboBoxFilterMaxCap.Text = " Max. Capacity";
            // 
            // comboBoxFilterRoomType
            // 
            comboBoxFilterRoomType.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterRoomType.FormattingEnabled = true;
            comboBoxFilterRoomType.Location = new Point(133, 10);
            comboBoxFilterRoomType.Name = "comboBoxFilterRoomType";
            comboBoxFilterRoomType.Size = new Size(124, 27);
            comboBoxFilterRoomType.TabIndex = 7;
            comboBoxFilterRoomType.Text = " Room Type";
            // 
            // comboBoxRoomStatus
            // 
            comboBoxRoomStatus.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxRoomStatus.FormattingEnabled = true;
            comboBoxRoomStatus.Location = new Point(615, 10);
            comboBoxRoomStatus.Margin = new Padding(5);
            comboBoxRoomStatus.Name = "comboBoxRoomStatus";
            comboBoxRoomStatus.Size = new Size(121, 27);
            comboBoxRoomStatus.TabIndex = 6;
            comboBoxRoomStatus.Text = " Room Status";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnRoomNo, ColumnRoomType, ColumnFloorNo, ColumnMaxCap, ColumnRoomRate, ColumnRoomStatus });
            dataGridView1.Location = new Point(88, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(763, 260);
            dataGridView1.TabIndex = 5;
            // 
            // ColumnRoomNo
            // 
            ColumnRoomNo.HeaderText = "Room No.";
            ColumnRoomNo.Name = "ColumnRoomNo";
            ColumnRoomNo.ReadOnly = true;
            ColumnRoomNo.Resizable = DataGridViewTriState.True;
            ColumnRoomNo.Width = 120;
            // 
            // ColumnRoomType
            // 
            ColumnRoomType.HeaderText = "Room Type";
            ColumnRoomType.Name = "ColumnRoomType";
            ColumnRoomType.ReadOnly = true;
            ColumnRoomType.Resizable = DataGridViewTriState.True;
            ColumnRoomType.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnRoomType.Width = 120;
            // 
            // ColumnFloorNo
            // 
            ColumnFloorNo.HeaderText = "Floor No.";
            ColumnFloorNo.Name = "ColumnFloorNo";
            ColumnFloorNo.ReadOnly = true;
            ColumnFloorNo.Width = 120;
            // 
            // ColumnMaxCap
            // 
            ColumnMaxCap.HeaderText = "Max. Capacity";
            ColumnMaxCap.Name = "ColumnMaxCap";
            ColumnMaxCap.ReadOnly = true;
            ColumnMaxCap.Width = 120;
            // 
            // ColumnRoomRate
            // 
            ColumnRoomRate.HeaderText = "Room Rate";
            ColumnRoomRate.Name = "ColumnRoomRate";
            ColumnRoomRate.Width = 120;
            // 
            // ColumnRoomStatus
            // 
            ColumnRoomStatus.HeaderText = "Room Status";
            ColumnRoomStatus.Name = "ColumnRoomStatus";
            ColumnRoomStatus.Resizable = DataGridViewTriState.True;
            ColumnRoomStatus.Width = 120;
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(buttonMore);
            panelSearch.Controls.Add(buttonSearchIcon);
            panelSearch.Controls.Add(textBoxAddressSearch);
            panelSearch.Location = new Point(145, 27);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(624, 53);
            panelSearch.TabIndex = 4;
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
            // panelAddaGuest
            // 
            panelAddaGuest.BackColor = Color.MediumSeaGreen;
            panelAddaGuest.Controls.Add(label2);
            panelAddaGuest.Location = new Point(354, 111);
            panelAddaGuest.Name = "panelAddaGuest";
            panelAddaGuest.Size = new Size(153, 32);
            panelAddaGuest.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 5);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 12;
            label2.Text = "Add a Room";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(354, 35);
            label1.Name = "label1";
            label1.Size = new Size(326, 42);
            label1.TabIndex = 16;
            label1.Text = "Room Management";
            // 
            // comboBoxFilterRoomRate
            // 
            comboBoxFilterRoomRate.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFilterRoomRate.FormattingEnabled = true;
            comboBoxFilterRoomRate.Location = new Point(508, 10);
            comboBoxFilterRoomRate.Name = "comboBoxFilterRoomRate";
            comboBoxFilterRoomRate.Size = new Size(101, 27);
            comboBoxFilterRoomRate.TabIndex = 11;
            comboBoxFilterRoomRate.Text = " Room Rate";
            // 
            // panelFilters
            // 
            panelFilters.Controls.Add(comboBoxFilterRoomRate);
            panelFilters.Controls.Add(comboBoxFilterFloorNo);
            panelFilters.Controls.Add(comboBoxFilterRoomNo);
            panelFilters.Controls.Add(comboBoxFilterMaxCap);
            panelFilters.Controls.Add(comboBoxFilterRoomType);
            panelFilters.Controls.Add(comboBoxRoomStatus);
            panelFilters.Location = new Point(99, 89);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(742, 50);
            panelFilters.TabIndex = 12;
            // 
            // Room2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panelBaseTable);
            Controls.Add(panelAddaGuest);
            Controls.Add(label1);
            Name = "Room2";
            Text = "Room2";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelBaseTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelAddaGuest.ResumeLayout(false);
            panelAddaGuest.PerformLayout();
            panelFilters.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panelBaseTable;
        private Panel panelSearch;
        private Button buttonSearchIcon;
        private TextBox textBoxAddressSearch;
        private Panel panelAddaGuest;
        private Label label1;
        private Label labelListOfRooms;
        private Label labelAddRoom;
        private Label label2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnRoomNo;
        private DataGridViewComboBoxColumn ColumnRoomType;
        private DataGridViewTextBoxColumn ColumnFloorNo;
        private DataGridViewTextBoxColumn ColumnMaxCap;
        private DataGridViewTextBoxColumn ColumnRoomRate;
        private DataGridViewComboBoxColumn ColumnRoomStatus;
        private Button buttonMore;
        private ComboBox comboBoxRoomStatus;
        private ComboBox comboBoxFilterRoomType;
        private ComboBox comboBoxFilterFloorNo;
        private ComboBox comboBoxFilterRoomNo;
        private ComboBox comboBoxFilterMaxCap;
        private ComboBox comboBoxFilterRoomRate;
        private Panel panelFilters;
    }
}