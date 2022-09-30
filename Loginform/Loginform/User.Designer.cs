namespace Loginform
{
    partial class User
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
            this.cb_dob = new System.Windows.Forms.DateTimePicker();
            this.tb_exit = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_gmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_cid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_delete = new System.Windows.Forms.Button();
            this.tb_edit = new System.Windows.Forms.Button();
            this.tb_add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_dob
            // 
            this.cb_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cb_dob.Location = new System.Drawing.Point(158, 400);
            this.cb_dob.Name = "cb_dob";
            this.cb_dob.Size = new System.Drawing.Size(147, 22);
            this.cb_dob.TabIndex = 53;
            // 
            // tb_exit
            // 
            this.tb_exit.Location = new System.Drawing.Point(617, 442);
            this.tb_exit.Name = "tb_exit";
            this.tb_exit.Size = new System.Drawing.Size(95, 40);
            this.tb_exit.TabIndex = 52;
            this.tb_exit.Text = "Exit";
            this.tb_exit.UseVisualStyleBackColor = true;
            this.tb_exit.Click += new System.EventHandler(this.tb_exit_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(22, 23);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(756, 193);
            this.dgv.TabIndex = 51;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(158, 347);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(197, 22);
            this.tb_name.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Name";
            // 
            // tb_gmail
            // 
            this.tb_gmail.Location = new System.Drawing.Point(468, 335);
            this.tb_gmail.Name = "tb_gmail";
            this.tb_gmail.Size = new System.Drawing.Size(271, 22);
            this.tb_gmail.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Gmail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "DOB";
            // 
            // tb_pay
            // 
            this.tb_pay.Location = new System.Drawing.Point(158, 451);
            this.tb_pay.Name = "tb_pay";
            this.tb_pay.Size = new System.Drawing.Size(105, 22);
            this.tb_pay.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Payment";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(468, 298);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(160, 22);
            this.tb_phone.TabIndex = 49;
            // 
            // tb_cid
            // 
            this.tb_cid.Location = new System.Drawing.Point(158, 298);
            this.tb_cid.Name = "tb_cid";
            this.tb_cid.Size = new System.Drawing.Size(105, 22);
            this.tb_cid.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "CID";
            // 
            // tb_delete
            // 
            this.tb_delete.Location = new System.Drawing.Point(617, 380);
            this.tb_delete.Name = "tb_delete";
            this.tb_delete.Size = new System.Drawing.Size(95, 42);
            this.tb_delete.TabIndex = 37;
            this.tb_delete.Text = "Delete";
            this.tb_delete.UseVisualStyleBackColor = true;
            this.tb_delete.Click += new System.EventHandler(this.tb_delete_Click);
            // 
            // tb_edit
            // 
            this.tb_edit.Location = new System.Drawing.Point(458, 380);
            this.tb_edit.Name = "tb_edit";
            this.tb_edit.Size = new System.Drawing.Size(95, 42);
            this.tb_edit.TabIndex = 38;
            this.tb_edit.Text = "Edit";
            this.tb_edit.UseVisualStyleBackColor = true;
            this.tb_edit.Click += new System.EventHandler(this.tb_edit_Click);
            // 
            // tb_add
            // 
            this.tb_add.Location = new System.Drawing.Point(458, 442);
            this.tb_add.Name = "tb_add";
            this.tb_add.Size = new System.Drawing.Size(95, 42);
            this.tb_add.TabIndex = 39;
            this.tb_add.Text = "Add";
            this.tb_add.UseVisualStyleBackColor = true;
            this.tb_add.Click += new System.EventHandler(this.tb_add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(84, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 56;
            this.label7.Text = "Input Name";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(420, 239);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(102, 23);
            this.tb_search.TabIndex = 55;
            this.tb_search.Text = "Search";
            this.tb_search.UseVisualStyleBackColor = true;
            this.tb_search.Click += new System.EventHandler(this.tb_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(183, 239);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(210, 22);
            this.txt_search.TabIndex = 54;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
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
            this.Controls.Add(this.tb_pay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.tb_cid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_delete);
            this.Controls.Add(this.tb_edit);
            this.Controls.Add(this.tb_add);
            this.Name = "User";
            this.Text = "User";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker cb_dob;
        private System.Windows.Forms.Button tb_exit;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_gmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_pay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.TextBox tb_cid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tb_delete;
        private System.Windows.Forms.Button tb_edit;
        private System.Windows.Forms.Button tb_add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button tb_search;
        private System.Windows.Forms.TextBox txt_search;
    }
}