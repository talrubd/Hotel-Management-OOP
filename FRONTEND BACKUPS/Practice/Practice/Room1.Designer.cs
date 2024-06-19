namespace Practice
{
    partial class Room1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room1));
            panelRoomNo = new Panel();
            textBoxRoomNo = new TextBox();
            panelAddRoom = new Panel();
            labelAddRoom = new Label();
            labelListOfRooms = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panelBaseTable = new Panel();
            buttonAddRoom = new Button();
            panelRoomType = new Panel();
            comboBoxRoomType = new ComboBox();
            labelRoomType = new Label();
            labelRM = new Label();
            panelListOfRooms = new Panel();
            labelRoomNo = new Label();
            panelRoomStatus = new Panel();
            comboBoxRoomStatus = new ComboBox();
            labelRoomStatus = new Label();
            panelRoomRate = new Panel();
            textBoxRoomRate = new TextBox();
            labelRoomRate = new Label();
            panelFloorNo = new Panel();
            textBoxFloorNo = new TextBox();
            labelFloorNo = new Label();
            panelMaxCapacity = new Panel();
            textBoxMaxCapacity = new TextBox();
            labelMaxCapacity = new Label();
            panelRoomNo.SuspendLayout();
            panelAddRoom.SuspendLayout();
            panel1.SuspendLayout();
            panelBaseTable.SuspendLayout();
            panelRoomType.SuspendLayout();
            panelListOfRooms.SuspendLayout();
            panelRoomStatus.SuspendLayout();
            panelRoomRate.SuspendLayout();
            panelFloorNo.SuspendLayout();
            panelMaxCapacity.SuspendLayout();
            SuspendLayout();
            // 
            // panelRoomNo
            // 
            panelRoomNo.Controls.Add(textBoxRoomNo);
            panelRoomNo.Controls.Add(labelRoomNo);
            panelRoomNo.Location = new Point(130, 98);
            panelRoomNo.Name = "panelRoomNo";
            panelRoomNo.Size = new Size(226, 67);
            panelRoomNo.TabIndex = 2;
            // 
            // textBoxRoomNo
            // 
            textBoxRoomNo.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxRoomNo.Location = new Point(9, 34);
            textBoxRoomNo.Name = "textBoxRoomNo";
            textBoxRoomNo.Size = new Size(199, 27);
            textBoxRoomNo.TabIndex = 1;
            // 
            // panelAddRoom
            // 
            panelAddRoom.BackColor = Color.FromArgb(76, 149, 108);
            panelAddRoom.Controls.Add(labelAddRoom);
            panelAddRoom.Location = new Point(356, 113);
            panelAddRoom.Name = "panelAddRoom";
            panelAddRoom.Size = new Size(153, 32);
            panelAddRoom.TabIndex = 9;
            // 
            // labelAddRoom
            // 
            labelAddRoom.AutoSize = true;
            labelAddRoom.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelAddRoom.Location = new Point(16, 5);
            labelAddRoom.Name = "labelAddRoom";
            labelAddRoom.Size = new Size(113, 23);
            labelAddRoom.TabIndex = 7;
            labelAddRoom.Text = "Add a Room";
            // 
            // labelListOfRooms
            // 
            labelListOfRooms.AutoSize = true;
            labelListOfRooms.BackColor = Color.Transparent;
            labelListOfRooms.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelListOfRooms.Location = new Point(10, 5);
            labelListOfRooms.Name = "labelListOfRooms";
            labelListOfRooms.Size = new Size(128, 23);
            labelListOfRooms.TabIndex = 9;
            labelListOfRooms.Text = "List of Rooms";
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
            // panelBaseTable
            // 
            panelBaseTable.BackColor = Color.FromArgb(76, 149, 108);
            panelBaseTable.Controls.Add(panelMaxCapacity);
            panelBaseTable.Controls.Add(panelFloorNo);
            panelBaseTable.Controls.Add(panelRoomRate);
            panelBaseTable.Controls.Add(panelRoomStatus);
            panelBaseTable.Controls.Add(buttonAddRoom);
            panelBaseTable.Controls.Add(panelRoomType);
            panelBaseTable.Controls.Add(panelRoomNo);
            panelBaseTable.Location = new Point(356, 144);
            panelBaseTable.Name = "panelBaseTable";
            panelBaseTable.Size = new Size(948, 560);
            panelBaseTable.TabIndex = 8;
            // 
            // buttonAddRoom
            // 
            buttonAddRoom.BackColor = Color.FromArgb(45, 106, 79);
            buttonAddRoom.FlatStyle = FlatStyle.System;
            buttonAddRoom.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddRoom.Location = new Point(769, 487);
            buttonAddRoom.Name = "buttonAddRoom";
            buttonAddRoom.Size = new Size(134, 41);
            buttonAddRoom.TabIndex = 2;
            buttonAddRoom.Text = "Add Room";
            buttonAddRoom.UseVisualStyleBackColor = false;
            // 
            // panelRoomType
            // 
            panelRoomType.Controls.Add(comboBoxRoomType);
            panelRoomType.Controls.Add(labelRoomType);
            panelRoomType.Location = new Point(130, 193);
            panelRoomType.Name = "panelRoomType";
            panelRoomType.Size = new Size(247, 67);
            panelRoomType.TabIndex = 5;
            // 
            // comboBoxRoomType
            // 
            comboBoxRoomType.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxRoomType.FormattingEnabled = true;
            comboBoxRoomType.Location = new Point(9, 36);
            comboBoxRoomType.Name = "comboBoxRoomType";
            comboBoxRoomType.Size = new Size(199, 27);
            comboBoxRoomType.TabIndex = 6;
            // 
            // labelRoomType
            // 
            labelRoomType.AutoSize = true;
            labelRoomType.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRoomType.Location = new Point(9, 6);
            labelRoomType.Name = "labelRoomType";
            labelRoomType.Size = new Size(106, 23);
            labelRoomType.TabIndex = 0;
            labelRoomType.Text = "Room Type";
            // 
            // labelRM
            // 
            labelRM.AutoSize = true;
            labelRM.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRM.Location = new Point(354, 53);
            labelRM.Name = "labelRM";
            labelRM.Size = new Size(326, 42);
            labelRM.TabIndex = 7;
            labelRM.Text = "Room Management";
            // 
            // panelListOfRooms
            // 
            panelListOfRooms.BackColor = Color.MediumSeaGreen;
            panelListOfRooms.Controls.Add(labelListOfRooms);
            panelListOfRooms.Location = new Point(515, 113);
            panelListOfRooms.Name = "panelListOfRooms";
            panelListOfRooms.Size = new Size(153, 32);
            panelListOfRooms.TabIndex = 10;
            // 
            // labelRoomNo
            // 
            labelRoomNo.AutoSize = true;
            labelRoomNo.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRoomNo.Location = new Point(9, 6);
            labelRoomNo.Name = "labelRoomNo";
            labelRoomNo.Size = new Size(94, 23);
            labelRoomNo.TabIndex = 0;
            labelRoomNo.Text = "Room No.";
            // 
            // panelRoomStatus
            // 
            panelRoomStatus.Controls.Add(comboBoxRoomStatus);
            panelRoomStatus.Controls.Add(labelRoomStatus);
            panelRoomStatus.Location = new Point(130, 287);
            panelRoomStatus.Name = "panelRoomStatus";
            panelRoomStatus.Size = new Size(247, 67);
            panelRoomStatus.TabIndex = 7;
            // 
            // comboBoxRoomStatus
            // 
            comboBoxRoomStatus.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxRoomStatus.FormattingEnabled = true;
            comboBoxRoomStatus.Location = new Point(9, 36);
            comboBoxRoomStatus.Name = "comboBoxRoomStatus";
            comboBoxRoomStatus.Size = new Size(199, 27);
            comboBoxRoomStatus.TabIndex = 6;
            // 
            // labelRoomStatus
            // 
            labelRoomStatus.AutoSize = true;
            labelRoomStatus.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRoomStatus.Location = new Point(9, 6);
            labelRoomStatus.Name = "labelRoomStatus";
            labelRoomStatus.Size = new Size(121, 23);
            labelRoomStatus.TabIndex = 0;
            labelRoomStatus.Text = "Room Status";
            // 
            // panelRoomRate
            // 
            panelRoomRate.Controls.Add(textBoxRoomRate);
            panelRoomRate.Controls.Add(labelRoomRate);
            panelRoomRate.Location = new Point(130, 386);
            panelRoomRate.Name = "panelRoomRate";
            panelRoomRate.Size = new Size(226, 67);
            panelRoomRate.TabIndex = 3;
            // 
            // textBoxRoomRate
            // 
            textBoxRoomRate.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxRoomRate.Location = new Point(9, 34);
            textBoxRoomRate.Name = "textBoxRoomRate";
            textBoxRoomRate.Size = new Size(199, 27);
            textBoxRoomRate.TabIndex = 1;
            // 
            // labelRoomRate
            // 
            labelRoomRate.AutoSize = true;
            labelRoomRate.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRoomRate.Location = new Point(9, 6);
            labelRoomRate.Name = "labelRoomRate";
            labelRoomRate.Size = new Size(104, 23);
            labelRoomRate.TabIndex = 0;
            labelRoomRate.Text = "Room Rate";
            // 
            // panelFloorNo
            // 
            panelFloorNo.Controls.Add(textBoxFloorNo);
            panelFloorNo.Controls.Add(labelFloorNo);
            panelFloorNo.Location = new Point(585, 193);
            panelFloorNo.Name = "panelFloorNo";
            panelFloorNo.Size = new Size(226, 67);
            panelFloorNo.TabIndex = 4;
            // 
            // textBoxFloorNo
            // 
            textBoxFloorNo.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFloorNo.Location = new Point(9, 34);
            textBoxFloorNo.Name = "textBoxFloorNo";
            textBoxFloorNo.Size = new Size(199, 27);
            textBoxFloorNo.TabIndex = 1;
            // 
            // labelFloorNo
            // 
            labelFloorNo.AutoSize = true;
            labelFloorNo.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFloorNo.Location = new Point(9, 6);
            labelFloorNo.Name = "labelFloorNo";
            labelFloorNo.Size = new Size(88, 23);
            labelFloorNo.TabIndex = 0;
            labelFloorNo.Text = "Floor No.";
            // 
            // panelMaxCapacity
            // 
            panelMaxCapacity.Controls.Add(textBoxMaxCapacity);
            panelMaxCapacity.Controls.Add(labelMaxCapacity);
            panelMaxCapacity.Location = new Point(585, 287);
            panelMaxCapacity.Name = "panelMaxCapacity";
            panelMaxCapacity.Size = new Size(226, 67);
            panelMaxCapacity.TabIndex = 4;
            // 
            // textBoxMaxCapacity
            // 
            textBoxMaxCapacity.Font = new Font("SF Pro Display", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMaxCapacity.Location = new Point(9, 34);
            textBoxMaxCapacity.Name = "textBoxMaxCapacity";
            textBoxMaxCapacity.Size = new Size(199, 27);
            textBoxMaxCapacity.TabIndex = 1;
            // 
            // labelMaxCapacity
            // 
            labelMaxCapacity.AutoSize = true;
            labelMaxCapacity.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMaxCapacity.Location = new Point(9, 6);
            labelMaxCapacity.Name = "labelMaxCapacity";
            labelMaxCapacity.Size = new Size(131, 23);
            labelMaxCapacity.TabIndex = 0;
            labelMaxCapacity.Text = "Max. Capacity";
            // 
            // Room1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panelAddRoom);
            Controls.Add(panel1);
            Controls.Add(panelBaseTable);
            Controls.Add(labelRM);
            Controls.Add(panelListOfRooms);
            Name = "Room1";
            Text = "Room1";
            panelRoomNo.ResumeLayout(false);
            panelRoomNo.PerformLayout();
            panelAddRoom.ResumeLayout(false);
            panelAddRoom.PerformLayout();
            panel1.ResumeLayout(false);
            panelBaseTable.ResumeLayout(false);
            panelRoomType.ResumeLayout(false);
            panelRoomType.PerformLayout();
            panelListOfRooms.ResumeLayout(false);
            panelListOfRooms.PerformLayout();
            panelRoomStatus.ResumeLayout(false);
            panelRoomStatus.PerformLayout();
            panelRoomRate.ResumeLayout(false);
            panelRoomRate.PerformLayout();
            panelFloorNo.ResumeLayout(false);
            panelFloorNo.PerformLayout();
            panelMaxCapacity.ResumeLayout(false);
            panelMaxCapacity.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelRoomNo;
        private TextBox textBoxRoomNo;
        private Panel panelAddRoom;
        private Label labelAddRoom;
        private Label labelListOfRooms;
        private Panel panel1;
        private Panel panel2;
        private Panel panelBaseTable;
        private Button buttonAddRoom;
        private Panel panelRoomType;
        private ComboBox comboBoxRoomType;
        private Label labelRoomType;
        private Label labelRM;
        private Panel panelListOfRooms;
        private Label labelRoomNo;
        private Panel panelMaxCapacity;
        private TextBox textBoxMaxCapacity;
        private Label labelMaxCapacity;
        private Panel panelFloorNo;
        private TextBox textBoxFloorNo;
        private Label labelFloorNo;
        private Panel panelRoomRate;
        private TextBox textBoxRoomRate;
        private Label labelRoomRate;
        private Panel panelRoomStatus;
        private ComboBox comboBoxRoomStatus;
        private Label labelRoomStatus;
    }
}