namespace OOP_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            Base = new Panel();
            panelReport = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            noOfGuests = new Label();
            lblNoOfGuests = new Label();
            panelTotRevThisMonth = new Panel();
            lblTotRevThisMonth = new Label();
            panelResThisMonth = new Panel();
            totRevThisMonth = new Label();
            lblPesoSign1 = new Label();
            panelTotRevLastMonth = new Panel();
            lblTotRevLastMonth = new Label();
            lblLastMonth = new Label();
            panelResLastMonth = new Panel();
            totRevLastMonth = new Label();
            lblPesoSign = new Label();
            panelOccupancyRate = new Panel();
            occRate = new Label();
            roomsAvail = new Label();
            roomsOcc = new Label();
            totRooms = new Label();
            lblOccRate = new Label();
            lblRoomsAvail = new Label();
            lblRoomsOcc = new Label();
            lblTotRooms = new Label();
            panelNavBar = new Panel();
            navBar = new Panel();
            picDashboard = new PictureBox();
            lblSettings = new Label();
            picSettings = new PictureBox();
            lblBilling = new Label();
            picBilling = new PictureBox();
            lblBooking = new Label();
            picBooking = new PictureBox();
            lblRooms = new Label();
            picRooms = new PictureBox();
            lblGuests = new Label();
            picGuests = new PictureBox();
            lblDashboard = new Label();
            btnLogout = new Button();
            panelHotel = new Panel();
            label1 = new Label();
            hotelName = new Label();
            hotelLogo = new PictureBox();
            Base.SuspendLayout();
            panelReport.SuspendLayout();
            panelTotRevThisMonth.SuspendLayout();
            panelResThisMonth.SuspendLayout();
            panelTotRevLastMonth.SuspendLayout();
            panelResLastMonth.SuspendLayout();
            panelOccupancyRate.SuspendLayout();
            panelNavBar.SuspendLayout();
            navBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSettings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBilling).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBooking).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGuests).BeginInit();
            panelHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hotelLogo).BeginInit();
            SuspendLayout();
            // 
            // Base
            // 
            Base.Controls.Add(panelReport);
            Base.Controls.Add(panelNavBar);
            Base.Dock = DockStyle.Fill;
            Base.Location = new Point(0, 0);
            Base.Name = "Base";
            Base.Size = new Size(1924, 1055);
            Base.TabIndex = 0;
            // 
            // panelReport
            // 
            panelReport.Controls.Add(label5);
            panelReport.Controls.Add(label4);
            panelReport.Controls.Add(label3);
            panelReport.Controls.Add(label2);
            panelReport.Controls.Add(noOfGuests);
            panelReport.Controls.Add(lblNoOfGuests);
            panelReport.Controls.Add(panelTotRevThisMonth);
            panelReport.Controls.Add(panelTotRevLastMonth);
            panelReport.Controls.Add(panelOccupancyRate);
            panelReport.Dock = DockStyle.Fill;
            panelReport.Location = new Point(393, 0);
            panelReport.Name = "panelReport";
            panelReport.Size = new Size(1531, 1055);
            panelReport.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 16F);
            label5.Location = new Point(863, 897);
            label5.Name = "label5";
            label5.Size = new Size(158, 32);
            label5.TabIndex = 15;
            label5.Text = "Nationality";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 16F);
            label4.Location = new Point(83, 645);
            label4.Name = "label4";
            label4.Size = new Size(65, 32);
            label4.TabIndex = 14;
            label4.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 16F);
            label3.Location = new Point(863, 654);
            label3.Name = "label3";
            label3.Size = new Size(113, 32);
            label3.TabIndex = 13;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 16F);
            label2.Location = new Point(83, 897);
            label2.Name = "label2";
            label2.Size = new Size(67, 32);
            label2.TabIndex = 12;
            label2.Text = "City";
            // 
            // noOfGuests
            // 
            noOfGuests.AutoSize = true;
            noOfGuests.Font = new Font("Verdana", 16F);
            noOfGuests.Location = new Point(218, 563);
            noOfGuests.Name = "noOfGuests";
            noOfGuests.Size = new Size(80, 32);
            noOfGuests.TabIndex = 11;
            noOfGuests.Text = "###";
            // 
            // lblNoOfGuests
            // 
            lblNoOfGuests.AutoSize = true;
            lblNoOfGuests.Font = new Font("Verdana", 16F);
            lblNoOfGuests.Location = new Point(83, 563);
            lblNoOfGuests.Name = "lblNoOfGuests";
            lblNoOfGuests.Size = new Size(129, 32);
            lblNoOfGuests.TabIndex = 10;
            lblNoOfGuests.Text = "Guests: ";
            // 
            // panelTotRevThisMonth
            // 
            panelTotRevThisMonth.Controls.Add(lblTotRevThisMonth);
            panelTotRevThisMonth.Controls.Add(panelResThisMonth);
            panelTotRevThisMonth.Location = new Point(863, 302);
            panelTotRevThisMonth.Name = "panelTotRevThisMonth";
            panelTotRevThisMonth.Size = new Size(460, 202);
            panelTotRevThisMonth.TabIndex = 9;
            // 
            // lblTotRevThisMonth
            // 
            lblTotRevThisMonth.AutoSize = true;
            lblTotRevThisMonth.Font = new Font("Verdana", 16F);
            lblTotRevThisMonth.Location = new Point(0, 0);
            lblTotRevThisMonth.Name = "lblTotRevThisMonth";
            lblTotRevThisMonth.Size = new Size(408, 32);
            lblTotRevThisMonth.TabIndex = 4;
            lblTotRevThisMonth.Text = "Total Revenue for this month";
            // 
            // panelResThisMonth
            // 
            panelResThisMonth.BackColor = SystemColors.ActiveCaption;
            panelResThisMonth.Controls.Add(totRevThisMonth);
            panelResThisMonth.Controls.Add(lblPesoSign1);
            panelResThisMonth.Location = new Point(0, 45);
            panelResThisMonth.Name = "panelResThisMonth";
            panelResThisMonth.Size = new Size(423, 145);
            panelResThisMonth.TabIndex = 6;
            // 
            // totRevThisMonth
            // 
            totRevThisMonth.AutoSize = true;
            totRevThisMonth.Font = new Font("Verdana", 25F);
            totRevThisMonth.Location = new Point(97, 49);
            totRevThisMonth.Name = "totRevThisMonth";
            totRevThisMonth.Size = new Size(241, 51);
            totRevThisMonth.TabIndex = 8;
            totRevThisMonth.Text = "###,###";
            // 
            // lblPesoSign1
            // 
            lblPesoSign1.AutoSize = true;
            lblPesoSign1.Font = new Font("Verdana", 35F);
            lblPesoSign1.Location = new Point(25, 40);
            lblPesoSign1.Name = "lblPesoSign1";
            lblPesoSign1.Size = new Size(66, 72);
            lblPesoSign1.TabIndex = 10;
            lblPesoSign1.Text = "₱";
            // 
            // panelTotRevLastMonth
            // 
            panelTotRevLastMonth.Controls.Add(lblTotRevLastMonth);
            panelTotRevLastMonth.Controls.Add(lblLastMonth);
            panelTotRevLastMonth.Controls.Add(panelResLastMonth);
            panelTotRevLastMonth.Location = new Point(83, 302);
            panelTotRevLastMonth.Name = "panelTotRevLastMonth";
            panelTotRevLastMonth.Size = new Size(431, 202);
            panelTotRevLastMonth.TabIndex = 8;
            // 
            // lblTotRevLastMonth
            // 
            lblTotRevLastMonth.AutoSize = true;
            lblTotRevLastMonth.Font = new Font("Verdana", 16F);
            lblTotRevLastMonth.Location = new Point(0, 0);
            lblTotRevLastMonth.Name = "lblTotRevLastMonth";
            lblTotRevLastMonth.Size = new Size(252, 32);
            lblTotRevLastMonth.TabIndex = 3;
            lblTotRevLastMonth.Text = "Total Revenue for";
            // 
            // lblLastMonth
            // 
            lblLastMonth.AutoSize = true;
            lblLastMonth.Font = new Font("Verdana", 16F);
            lblLastMonth.Location = new Point(249, 0);
            lblLastMonth.Name = "lblLastMonth";
            lblLastMonth.Size = new Size(183, 32);
            lblLastMonth.TabIndex = 7;
            lblLastMonth.Text = "[last month]";
            // 
            // panelResLastMonth
            // 
            panelResLastMonth.BackColor = SystemColors.ActiveCaption;
            panelResLastMonth.Controls.Add(totRevLastMonth);
            panelResLastMonth.Controls.Add(lblPesoSign);
            panelResLastMonth.Location = new Point(0, 45);
            panelResLastMonth.Name = "panelResLastMonth";
            panelResLastMonth.Size = new Size(423, 145);
            panelResLastMonth.TabIndex = 5;
            // 
            // totRevLastMonth
            // 
            totRevLastMonth.AutoSize = true;
            totRevLastMonth.Font = new Font("Verdana", 25F);
            totRevLastMonth.Location = new Point(95, 53);
            totRevLastMonth.Name = "totRevLastMonth";
            totRevLastMonth.Size = new Size(241, 51);
            totRevLastMonth.TabIndex = 8;
            totRevLastMonth.Text = "###,###";
            // 
            // lblPesoSign
            // 
            lblPesoSign.AutoSize = true;
            lblPesoSign.Font = new Font("Verdana", 35F);
            lblPesoSign.Location = new Point(23, 40);
            lblPesoSign.Name = "lblPesoSign";
            lblPesoSign.Size = new Size(66, 72);
            lblPesoSign.TabIndex = 9;
            lblPesoSign.Text = "₱";
            // 
            // panelOccupancyRate
            // 
            panelOccupancyRate.BackColor = SystemColors.ActiveCaption;
            panelOccupancyRate.Controls.Add(occRate);
            panelOccupancyRate.Controls.Add(roomsAvail);
            panelOccupancyRate.Controls.Add(roomsOcc);
            panelOccupancyRate.Controls.Add(totRooms);
            panelOccupancyRate.Controls.Add(lblOccRate);
            panelOccupancyRate.Controls.Add(lblRoomsAvail);
            panelOccupancyRate.Controls.Add(lblRoomsOcc);
            panelOccupancyRate.Controls.Add(lblTotRooms);
            panelOccupancyRate.Location = new Point(41, 48);
            panelOccupancyRate.Name = "panelOccupancyRate";
            panelOccupancyRate.Size = new Size(1448, 210);
            panelOccupancyRate.TabIndex = 0;
            // 
            // occRate
            // 
            occRate.AutoSize = true;
            occRate.Font = new Font("Verdana", 25F);
            occRate.Location = new Point(1223, 101);
            occRate.Name = "occRate";
            occRate.Size = new Size(124, 51);
            occRate.TabIndex = 9;
            occRate.Text = "###";
            // 
            // roomsAvail
            // 
            roomsAvail.AutoSize = true;
            roomsAvail.Font = new Font("Verdana", 25F);
            roomsAvail.Location = new Point(878, 101);
            roomsAvail.Name = "roomsAvail";
            roomsAvail.Size = new Size(124, 51);
            roomsAvail.TabIndex = 8;
            roomsAvail.Text = "###";
            // 
            // roomsOcc
            // 
            roomsOcc.AutoSize = true;
            roomsOcc.Font = new Font("Verdana", 25F);
            roomsOcc.Location = new Point(524, 101);
            roomsOcc.Name = "roomsOcc";
            roomsOcc.Size = new Size(124, 51);
            roomsOcc.TabIndex = 7;
            roomsOcc.Text = "###";
            // 
            // totRooms
            // 
            totRooms.AutoSize = true;
            totRooms.Font = new Font("Verdana", 25F);
            totRooms.Location = new Point(139, 101);
            totRooms.Name = "totRooms";
            totRooms.Size = new Size(124, 51);
            totRooms.TabIndex = 6;
            totRooms.Text = "###";
            // 
            // lblOccRate
            // 
            lblOccRate.AutoSize = true;
            lblOccRate.Font = new Font("Verdana", 16F);
            lblOccRate.Location = new Point(1167, 17);
            lblOccRate.Name = "lblOccRate";
            lblOccRate.Size = new Size(231, 32);
            lblOccRate.TabIndex = 5;
            lblOccRate.Text = "Occupancy Rate";
            // 
            // lblRoomsAvail
            // 
            lblRoomsAvail.AutoSize = true;
            lblRoomsAvail.Font = new Font("Verdana", 16F);
            lblRoomsAvail.Location = new Point(822, 17);
            lblRoomsAvail.Name = "lblRoomsAvail";
            lblRoomsAvail.Size = new Size(232, 32);
            lblRoomsAvail.TabIndex = 4;
            lblRoomsAvail.Text = "Rooms Available";
            // 
            // lblRoomsOcc
            // 
            lblRoomsOcc.AutoSize = true;
            lblRoomsOcc.Font = new Font("Verdana", 16F);
            lblRoomsOcc.Location = new Point(467, 17);
            lblRoomsOcc.Name = "lblRoomsOcc";
            lblRoomsOcc.Size = new Size(237, 32);
            lblRoomsOcc.TabIndex = 3;
            lblRoomsOcc.Text = "Rooms Occupied";
            // 
            // lblTotRooms
            // 
            lblTotRooms.AutoSize = true;
            lblTotRooms.Font = new Font("Verdana", 16F);
            lblTotRooms.Location = new Point(42, 17);
            lblTotRooms.Name = "lblTotRooms";
            lblTotRooms.Size = new Size(332, 32);
            lblTotRooms.TabIndex = 2;
            lblTotRooms.Text = "Total Number of Rooms";
            // 
            // panelNavBar
            // 
            panelNavBar.BackColor = SystemColors.ActiveCaption;
            panelNavBar.Controls.Add(navBar);
            panelNavBar.Controls.Add(btnLogout);
            panelNavBar.Controls.Add(panelHotel);
            panelNavBar.Dock = DockStyle.Left;
            panelNavBar.Location = new Point(0, 0);
            panelNavBar.Name = "panelNavBar";
            panelNavBar.Size = new Size(393, 1055);
            panelNavBar.TabIndex = 0;
            // 
            // navBar
            // 
            navBar.Controls.Add(picDashboard);
            navBar.Controls.Add(lblSettings);
            navBar.Controls.Add(picSettings);
            navBar.Controls.Add(lblBilling);
            navBar.Controls.Add(picBilling);
            navBar.Controls.Add(lblBooking);
            navBar.Controls.Add(picBooking);
            navBar.Controls.Add(lblRooms);
            navBar.Controls.Add(picRooms);
            navBar.Controls.Add(lblGuests);
            navBar.Controls.Add(picGuests);
            navBar.Controls.Add(lblDashboard);
            navBar.Location = new Point(12, 387);
            navBar.Name = "navBar";
            navBar.Size = new Size(364, 493);
            navBar.TabIndex = 2;
            // 
            // picDashboard
            // 
            picDashboard.BackgroundImageLayout = ImageLayout.Stretch;
            picDashboard.Image = (Image)resources.GetObject("picDashboard.Image");
            picDashboard.Location = new Point(13, 13);
            picDashboard.Name = "picDashboard";
            picDashboard.Size = new Size(47, 47);
            picDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            picDashboard.TabIndex = 12;
            picDashboard.TabStop = false;
            // 
            // lblSettings
            // 
            lblSettings.AutoSize = true;
            lblSettings.Font = new Font("Verdana", 16F);
            lblSettings.Location = new Point(79, 431);
            lblSettings.Name = "lblSettings";
            lblSettings.Size = new Size(125, 32);
            lblSettings.TabIndex = 11;
            lblSettings.Text = "Settings";
            // 
            // picSettings
            // 
            picSettings.BackgroundImageLayout = ImageLayout.Stretch;
            picSettings.Image = (Image)resources.GetObject("picSettings.Image");
            picSettings.Location = new Point(13, 422);
            picSettings.Name = "picSettings";
            picSettings.Size = new Size(50, 50);
            picSettings.SizeMode = PictureBoxSizeMode.Zoom;
            picSettings.TabIndex = 10;
            picSettings.TabStop = false;
            // 
            // lblBilling
            // 
            lblBilling.AutoSize = true;
            lblBilling.Font = new Font("Verdana", 16F);
            lblBilling.Location = new Point(79, 348);
            lblBilling.Name = "lblBilling";
            lblBilling.Size = new Size(95, 32);
            lblBilling.TabIndex = 9;
            lblBilling.Text = "Billing";
            // 
            // picBilling
            // 
            picBilling.BackgroundImageLayout = ImageLayout.Stretch;
            picBilling.Image = (Image)resources.GetObject("picBilling.Image");
            picBilling.Location = new Point(13, 339);
            picBilling.Name = "picBilling";
            picBilling.Size = new Size(50, 50);
            picBilling.SizeMode = PictureBoxSizeMode.Zoom;
            picBilling.TabIndex = 8;
            picBilling.TabStop = false;
            // 
            // lblBooking
            // 
            lblBooking.AutoSize = true;
            lblBooking.Font = new Font("Verdana", 16F);
            lblBooking.Location = new Point(75, 267);
            lblBooking.Name = "lblBooking";
            lblBooking.Size = new Size(122, 32);
            lblBooking.TabIndex = 7;
            lblBooking.Text = "Booking";
            // 
            // picBooking
            // 
            picBooking.BackgroundImageLayout = ImageLayout.Stretch;
            picBooking.Image = (Image)resources.GetObject("picBooking.Image");
            picBooking.Location = new Point(13, 258);
            picBooking.Name = "picBooking";
            picBooking.Size = new Size(50, 50);
            picBooking.SizeMode = PictureBoxSizeMode.Zoom;
            picBooking.TabIndex = 6;
            picBooking.TabStop = false;
            // 
            // lblRooms
            // 
            lblRooms.AutoSize = true;
            lblRooms.Font = new Font("Verdana", 16F);
            lblRooms.Location = new Point(79, 185);
            lblRooms.Name = "lblRooms";
            lblRooms.Size = new Size(104, 32);
            lblRooms.TabIndex = 5;
            lblRooms.Text = "Rooms";
            // 
            // picRooms
            // 
            picRooms.BackgroundImageLayout = ImageLayout.Stretch;
            picRooms.Image = (Image)resources.GetObject("picRooms.Image");
            picRooms.Location = new Point(13, 176);
            picRooms.Name = "picRooms";
            picRooms.Size = new Size(50, 50);
            picRooms.SizeMode = PictureBoxSizeMode.Zoom;
            picRooms.TabIndex = 4;
            picRooms.TabStop = false;
            // 
            // lblGuests
            // 
            lblGuests.AutoSize = true;
            lblGuests.Font = new Font("Verdana", 16F);
            lblGuests.Location = new Point(79, 103);
            lblGuests.Name = "lblGuests";
            lblGuests.Size = new Size(107, 32);
            lblGuests.TabIndex = 3;
            lblGuests.Text = "Guests";
            // 
            // picGuests
            // 
            picGuests.BackgroundImageLayout = ImageLayout.Stretch;
            picGuests.Image = (Image)resources.GetObject("picGuests.Image");
            picGuests.Location = new Point(13, 94);
            picGuests.Name = "picGuests";
            picGuests.Size = new Size(50, 50);
            picGuests.SizeMode = PictureBoxSizeMode.Zoom;
            picGuests.TabIndex = 2;
            picGuests.TabStop = false;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Font = new Font("Verdana", 16F);
            lblDashboard.Location = new Point(79, 20);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new Size(160, 32);
            lblDashboard.TabIndex = 1;
            lblDashboard.Text = "Dashboard";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.RoyalBlue;
            btnLogout.BackgroundImageLayout = ImageLayout.Stretch;
            btnLogout.Location = new Point(262, 988);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 40);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // panelHotel
            // 
            panelHotel.Controls.Add(label1);
            panelHotel.Controls.Add(hotelName);
            panelHotel.Controls.Add(hotelLogo);
            panelHotel.Location = new Point(12, 48);
            panelHotel.Name = "panelHotel";
            panelHotel.Size = new Size(364, 333);
            panelHotel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 19F);
            label1.Location = new Point(7, 254);
            label1.Name = "label1";
            label1.Size = new Size(356, 38);
            label1.TabIndex = 3;
            label1.Text = "Management System";
            // 
            // hotelName
            // 
            hotelName.AutoSize = true;
            hotelName.Font = new Font("Verdana", 19F);
            hotelName.Location = new Point(129, 213);
            hotelName.Name = "hotelName";
            hotelName.Size = new Size(101, 38);
            hotelName.TabIndex = 2;
            hotelName.Text = "Hotel";
            // 
            // hotelLogo
            // 
            hotelLogo.BackgroundImage = (Image)resources.GetObject("hotelLogo.BackgroundImage");
            hotelLogo.BackgroundImageLayout = ImageLayout.Zoom;
            hotelLogo.Location = new Point(75, 0);
            hotelLogo.Name = "hotelLogo";
            hotelLogo.Size = new Size(219, 210);
            hotelLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            hotelLogo.TabIndex = 1;
            hotelLogo.TabStop = false;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1924, 1055);
            Controls.Add(Base);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Base.ResumeLayout(false);
            panelReport.ResumeLayout(false);
            panelReport.PerformLayout();
            panelTotRevThisMonth.ResumeLayout(false);
            panelTotRevThisMonth.PerformLayout();
            panelResThisMonth.ResumeLayout(false);
            panelResThisMonth.PerformLayout();
            panelTotRevLastMonth.ResumeLayout(false);
            panelTotRevLastMonth.PerformLayout();
            panelResLastMonth.ResumeLayout(false);
            panelResLastMonth.PerformLayout();
            panelOccupancyRate.ResumeLayout(false);
            panelOccupancyRate.PerformLayout();
            panelNavBar.ResumeLayout(false);
            navBar.ResumeLayout(false);
            navBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSettings).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBilling).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBooking).EndInit();
            ((System.ComponentModel.ISupportInitialize)picRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGuests).EndInit();
            panelHotel.ResumeLayout(false);
            panelHotel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hotelLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Base;
        private Panel panelNavBar;
        private Panel panelHotel;
        private Label hotelName;
        private PictureBox hotelLogo;
        private Panel navBar;
        private PictureBox picDashboard;
        private Label lblSettings;
        private PictureBox picSettings;
        private Label lblBilling;
        private PictureBox picBilling;
        private Label lblBooking;
        private PictureBox picBooking;
        private Label lblRooms;
        private PictureBox picRooms;
        private Label lblGuests;
        private PictureBox picGuests;
        private Label lblDashboard;
        private Button btnLogout;
        private Label label1;
        private Panel panelReport;
        private Panel panelOccupancyRate;
        private Label lblRoomsAvail;
        private Label lblRoomsOcc;
        private Label lblTotRooms;
        private Label lblOccRate;
        private Label occRate;
        private Label roomsAvail;
        private Label roomsOcc;
        private Label totRooms;
        private Label lblTotRevThisMonth;
        private Label lblTotRevLastMonth;
        private Label lblLastMonth;
        private Panel panelResThisMonth;
        private Panel panelResLastMonth;
        private Label lblPesoSign1;
        private Label lblPesoSign;
        private Label totRevThisMonth;
        private Label totRevLastMonth;
        private Panel panelTotRevLastMonth;
        private Panel panelTotRevThisMonth;
        private Label noOfGuests;
        private Label lblNoOfGuests;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}