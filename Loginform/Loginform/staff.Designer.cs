namespace Loginform
{
    partial class staff
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
            this.tb_add = new System.Windows.Forms.Button();
            this.tb_edit = new System.Windows.Forms.Button();
            this.tb_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_sid = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_gmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tb_exit = new System.Windows.Forms.Button();
            this.cb_dob = new System.Windows.Forms.DateTimePicker();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.tb_search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_add
            // 
            this.tb_add.Location = new System.Drawing.Point(460, 455);
            this.tb_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_add.Name = "tb_add";
            this.tb_add.Size = new System.Drawing.Size(95, 42);
            this.tb_add.TabIndex = 23;
            this.tb_add.Text = "Add";
            this.tb_add.UseVisualStyleBackColor = true;
            this.tb_add.Click += new System.EventHandler(this.tb_add_Click);
            // 
            // tb_edit
            // 
            this.tb_edit.Location = new System.Drawing.Point(460, 393);
            this.tb_edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_edit.Name = "tb_edit";
            this.tb_edit.Size = new System.Drawing.Size(95, 42);
            this.tb_edit.TabIndex = 22;
            this.tb_edit.Text = "Edit";
            this.tb_edit.UseVisualStyleBackColor = true;
            this.tb_edit.Click += new System.EventHandler(this.tb_edit_Click);
            // 
            // tb_delete
            // 
            this.tb_delete.Location = new System.Drawing.Point(619, 393);
            this.tb_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_delete.Name = "tb_delete";
            this.tb_delete.Size = new System.Drawing.Size(95, 42);
            this.tb_delete.TabIndex = 21;
            this.tb_delete.Text = "Delete";
            this.tb_delete.UseVisualStyleBackColor = true;
            this.tb_delete.Click += new System.EventHandler(this.tb_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "SID";
            // 
            // tb_sid
            // 
            this.tb_sid.Location = new System.Drawing.Point(160, 311);
            this.tb_sid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_sid.Name = "tb_sid";
            this.tb_sid.Size = new System.Drawing.Size(105, 22);
            this.tb_sid.TabIndex = 31;
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(160, 459);
            this.tb_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(160, 22);
            this.tb_phone.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Salary";
            // 
            // tb_salary
            // 
            this.tb_salary.Location = new System.Drawing.Point(160, 414);
            this.tb_salary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(147, 22);
            this.tb_salary.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Gmail";
            // 
            // tb_gmail
            // 
            this.tb_gmail.Location = new System.Drawing.Point(424, 348);
            this.tb_gmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_gmail.Name = "tb_gmail";
            this.tb_gmail.Size = new System.Drawing.Size(271, 22);
            this.tb_gmail.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Name";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(424, 308);
            this.tb_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(271, 22);
            this.tb_name.TabIndex = 29;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(21, 25);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(756, 193);
            this.dgv.TabIndex = 32;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick_1);
            // 
            // tb_exit
            // 
            this.tb_exit.Location = new System.Drawing.Point(619, 455);
            this.tb_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_exit.Name = "tb_exit";
            this.tb_exit.Size = new System.Drawing.Size(95, 39);
            this.tb_exit.TabIndex = 35;
            this.tb_exit.Text = "Exit";
            this.tb_exit.UseVisualStyleBackColor = true;
            this.tb_exit.Click += new System.EventHandler(this.tb_exit_Click);
            // 
            // cb_dob
            // 
            this.cb_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cb_dob.Location = new System.Drawing.Point(160, 361);
            this.cb_dob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_dob.Name = "cb_dob";
            this.cb_dob.Size = new System.Drawing.Size(147, 22);
            this.cb_dob.TabIndex = 36;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(187, 252);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(209, 22);
            this.txt_search.TabIndex = 37;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(424, 252);
            this.tb_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(101, 23);
            this.tb_search.TabIndex = 38;
            this.tb_search.Text = "Search";
            this.tb_search.UseVisualStyleBackColor = true;
            this.tb_search.Click += new System.EventHandler(this.tb_search_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Input Name";
            // 
            // staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.cb_dob);
            this.Controls.Add(this.tb_exit);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_gmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_salary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_sid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_delete);
            this.Controls.Add(this.tb_edit);
            this.Controls.Add(this.tb_add);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "staff";
            this.Text = "staff";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tb_add;
        private System.Windows.Forms.Button tb_edit;
        private System.Windows.Forms.Button tb_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_sid;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_gmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button tb_exit;
        private System.Windows.Forms.DateTimePicker cb_dob;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button tb_search;
        private System.Windows.Forms.Label label7;
    }
}