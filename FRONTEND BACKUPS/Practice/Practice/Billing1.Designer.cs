namespace Practice
{
    partial class Billing1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing1));
            panel1 = new Panel();
            panel2 = new Panel();
            labelGM = new Label();
            panelBaseTable = new Panel();
            labelGuestInvoice = new Label();
            panelAddaGuest = new Panel();
            labelTableGuestInvoice = new Label();
            dataGridView1 = new DataGridView();
            ColumnGuestID = new DataGridViewTextBoxColumn();
            ColumnBookingID = new DataGridViewTextBoxColumn();
            ColumnInvoiceNumber = new DataGridViewTextBoxColumn();
            ColumnIssueDate = new DataGridViewTextBoxColumn();
            ColumnDueDate = new DataGridViewTextBoxColumn();
            ColumnPaymentStatus = new DataGridViewComboBoxColumn();
            ColumnPaymentMethod = new DataGridViewComboBoxColumn();
            panelFilters = new Panel();
            comboBoxFilterRoomNo = new ComboBox();
            panelSearch = new Panel();
            buttonMore = new Button();
            buttonSearchIcon = new Button();
            textBoxAddressSearch = new TextBox();
            panel1.SuspendLayout();
            panelBaseTable.SuspendLayout();
            panelAddaGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelFilters.SuspendLayout();
            panelSearch.SuspendLayout();
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
            // labelGM
            // 
            labelGM.AutoSize = true;
            labelGM.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGM.Location = new Point(90, -52);
            labelGM.Name = "labelGM";
            labelGM.Size = new Size(328, 42);
            labelGM.TabIndex = 13;
            labelGM.Text = "Guest Management";
            // 
            // panelBaseTable
            // 
            panelBaseTable.BackColor = Color.FromArgb(76, 149, 108);
            panelBaseTable.BackgroundImageLayout = ImageLayout.Zoom;
            panelBaseTable.Controls.Add(panelFilters);
            panelBaseTable.Controls.Add(panelSearch);
            panelBaseTable.Controls.Add(dataGridView1);
            panelBaseTable.Location = new Point(357, 139);
            panelBaseTable.Name = "panelBaseTable";
            panelBaseTable.Size = new Size(927, 577);
            panelBaseTable.TabIndex = 14;
            // 
            // labelGuestInvoice
            // 
            labelGuestInvoice.AutoSize = true;
            labelGuestInvoice.Font = new Font("SF Pro Display", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGuestInvoice.Location = new Point(355, 49);
            labelGuestInvoice.Name = "labelGuestInvoice";
            labelGuestInvoice.Size = new Size(231, 42);
            labelGuestInvoice.TabIndex = 16;
            labelGuestInvoice.Text = "Guest Invoice";
            // 
            // panelAddaGuest
            // 
            panelAddaGuest.BackColor = Color.FromArgb(76, 149, 108);
            panelAddaGuest.Controls.Add(labelTableGuestInvoice);
            panelAddaGuest.Location = new Point(357, 108);
            panelAddaGuest.Name = "panelAddaGuest";
            panelAddaGuest.Size = new Size(153, 32);
            panelAddaGuest.TabIndex = 17;
            // 
            // labelTableGuestInvoice
            // 
            labelTableGuestInvoice.AutoSize = true;
            labelTableGuestInvoice.Font = new Font("SF Pro Display", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTableGuestInvoice.Location = new Point(12, 5);
            labelTableGuestInvoice.Name = "labelTableGuestInvoice";
            labelTableGuestInvoice.Size = new Size(130, 23);
            labelTableGuestInvoice.TabIndex = 9;
            labelTableGuestInvoice.Text = "Guest Invoice";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnGuestID, ColumnBookingID, ColumnInvoiceNumber, ColumnIssueDate, ColumnDueDate, ColumnPaymentStatus, ColumnPaymentMethod });
            dataGridView1.Location = new Point(16, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(894, 260);
            dataGridView1.TabIndex = 18;
            // 
            // ColumnGuestID
            // 
            ColumnGuestID.HeaderText = "Guest ID";
            ColumnGuestID.Name = "ColumnGuestID";
            ColumnGuestID.ReadOnly = true;
            ColumnGuestID.Resizable = DataGridViewTriState.True;
            ColumnGuestID.Width = 120;
            // 
            // ColumnBookingID
            // 
            ColumnBookingID.HeaderText = "Booking ID";
            ColumnBookingID.Name = "ColumnBookingID";
            ColumnBookingID.Width = 120;
            // 
            // ColumnInvoiceNumber
            // 
            ColumnInvoiceNumber.HeaderText = "Invoice Number";
            ColumnInvoiceNumber.Name = "ColumnInvoiceNumber";
            ColumnInvoiceNumber.Width = 120;
            // 
            // ColumnIssueDate
            // 
            ColumnIssueDate.HeaderText = "Issue Date";
            ColumnIssueDate.Name = "ColumnIssueDate";
            ColumnIssueDate.ReadOnly = true;
            ColumnIssueDate.Resizable = DataGridViewTriState.True;
            ColumnIssueDate.Width = 120;
            // 
            // ColumnDueDate
            // 
            ColumnDueDate.HeaderText = "Due Date";
            ColumnDueDate.Name = "ColumnDueDate";
            ColumnDueDate.Resizable = DataGridViewTriState.True;
            ColumnDueDate.SortMode = DataGridViewColumnSortMode.NotSortable;
            ColumnDueDate.Width = 120;
            // 
            // ColumnPaymentStatus
            // 
            ColumnPaymentStatus.HeaderText = "Payment Status";
            ColumnPaymentStatus.Name = "ColumnPaymentStatus";
            ColumnPaymentStatus.ReadOnly = true;
            ColumnPaymentStatus.Resizable = DataGridViewTriState.True;
            ColumnPaymentStatus.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnPaymentStatus.Width = 120;
            // 
            // ColumnPaymentMethod
            // 
            ColumnPaymentMethod.HeaderText = "Payment Method";
            ColumnPaymentMethod.Name = "ColumnPaymentMethod";
            ColumnPaymentMethod.ReadOnly = true;
            ColumnPaymentMethod.Resizable = DataGridViewTriState.True;
            ColumnPaymentMethod.SortMode = DataGridViewColumnSortMode.Automatic;
            ColumnPaymentMethod.Width = 130;
            // 
            // panelFilters
            // 
            panelFilters.Controls.Add(comboBoxFilterRoomNo);
            panelFilters.Location = new Point(89, 91);
            panelFilters.Name = "panelFilters";
            panelFilters.Size = new Size(742, 50);
            panelFilters.TabIndex = 20;
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
            // panelSearch
            // 
            panelSearch.Controls.Add(buttonMore);
            panelSearch.Controls.Add(buttonSearchIcon);
            panelSearch.Controls.Add(textBoxAddressSearch);
            panelSearch.Location = new Point(139, 29);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(624, 53);
            panelSearch.TabIndex = 19;
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
            textBoxAddressSearch.Location = new Point(1, 12);
            textBoxAddressSearch.Name = "textBoxAddressSearch";
            textBoxAddressSearch.Size = new Size(508, 27);
            textBoxAddressSearch.TabIndex = 2;
            textBoxAddressSearch.Text = "Search";
            textBoxAddressSearch.WordWrap = false;
            // 
            // Billing1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel1);
            Controls.Add(labelGM);
            Controls.Add(panelBaseTable);
            Controls.Add(panelAddaGuest);
            Controls.Add(labelGuestInvoice);
            Name = "Billing1";
            Text = "Billing";
            panel1.ResumeLayout(false);
            panelBaseTable.ResumeLayout(false);
            panelAddaGuest.ResumeLayout(false);
            panelAddaGuest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelFilters.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label labelGM;
        private Panel panelBaseTable;
        private Label labelGuestInvoice;
        private Panel panelAddaGuest;
        private Label labelTableGuestInvoice;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnGuestID;
        private DataGridViewTextBoxColumn ColumnBookingID;
        private DataGridViewTextBoxColumn ColumnInvoiceNumber;
        private DataGridViewTextBoxColumn ColumnIssueDate;
        private DataGridViewTextBoxColumn ColumnDueDate;
        private DataGridViewComboBoxColumn ColumnPaymentStatus;
        private DataGridViewComboBoxColumn ColumnPaymentMethod;
        private Panel panelFilters;
        private ComboBox comboBoxFilterRoomNo;
        private Panel panelSearch;
        private Button buttonMore;
        private Button buttonSearchIcon;
        private TextBox textBoxAddressSearch;
    }
}