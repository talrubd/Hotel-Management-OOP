namespace Db_Crud
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Button_Add = new Button();
            Button_Read = new Button();
            Button_Update = new Button();
            Button_Delete = new Button();
            label_name = new Label();
            label_Address = new Label();
            checkBox_edit = new CheckBox();
            textBox_name = new TextBox();
            textBox_address = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(439, 196);
            dataGridView1.TabIndex = 0;
            // 
            // Button_Add
            // 
            Button_Add.Location = new Point(31, 379);
            Button_Add.Name = "Button_Add";
            Button_Add.Size = new Size(94, 29);
            Button_Add.TabIndex = 1;
            Button_Add.Text = "Add";
            Button_Add.UseVisualStyleBackColor = true;
            Button_Add.Click += Button_Add_Click;
            // 
            // Button_Read
            // 
            Button_Read.Location = new Point(152, 379);
            Button_Read.Name = "Button_Read";
            Button_Read.Size = new Size(94, 29);
            Button_Read.TabIndex = 2;
            Button_Read.Text = "Read";
            Button_Read.UseVisualStyleBackColor = true;
            Button_Read.Click += Button_Read_Click;
            // 
            // Button_Update
            // 
            Button_Update.Location = new Point(270, 379);
            Button_Update.Name = "Button_Update";
            Button_Update.Size = new Size(94, 29);
            Button_Update.TabIndex = 3;
            Button_Update.Text = "Update";
            Button_Update.UseVisualStyleBackColor = true;
            Button_Update.Click += Button_Update_Click;
            // 
            // Button_Delete
            // 
            Button_Delete.Location = new Point(389, 379);
            Button_Delete.Name = "Button_Delete";
            Button_Delete.Size = new Size(94, 29);
            Button_Delete.TabIndex = 4;
            Button_Delete.Text = "Delete";
            Button_Delete.UseVisualStyleBackColor = true;
            Button_Delete.Click += Button_Delete_Click;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(31, 274);
            label_name.Name = "label_name";
            label_name.Size = new Size(49, 20);
            label_name.TabIndex = 5;
            label_name.Text = "Name";
            // 
            // label_Address
            // 
            label_Address.AutoSize = true;
            label_Address.Location = new Point(31, 316);
            label_Address.Name = "label_Address";
            label_Address.Size = new Size(62, 20);
            label_Address.TabIndex = 6;
            label_Address.Text = "Address";
            // 
            // checkBox_edit
            // 
            checkBox_edit.AutoSize = true;
            checkBox_edit.Location = new Point(32, 238);
            checkBox_edit.Name = "checkBox_edit";
            checkBox_edit.Size = new Size(57, 24);
            checkBox_edit.TabIndex = 7;
            checkBox_edit.Text = "Edit";
            checkBox_edit.UseVisualStyleBackColor = true;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(121, 271);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(255, 27);
            textBox_name.TabIndex = 8;
            // 
            // textBox_address
            // 
            textBox_address.Location = new Point(121, 313);
            textBox_address.Name = "textBox_address";
            textBox_address.Size = new Size(255, 27);
            textBox_address.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 482);
            Controls.Add(textBox_address);
            Controls.Add(textBox_name);
            Controls.Add(checkBox_edit);
            Controls.Add(label_Address);
            Controls.Add(label_name);
            Controls.Add(Button_Delete);
            Controls.Add(Button_Update);
            Controls.Add(Button_Read);
            Controls.Add(Button_Add);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Button_Add;
        private Button Button_Read;
        private Button Button_Update;
        private Button Button_Delete;
        private Label label_name;
        private Label label_Address;
        private CheckBox checkBox_edit;
        private TextBox textBox_name;
        private TextBox textBox_address;

    }
}
