namespace Loginform
{
    partial class Form2
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
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.cb_size = new System.Windows.Forms.ComboBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.tb_quantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_did = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_delete = new System.Windows.Forms.Button();
            this.tb_edit = new System.Windows.Forms.Button();
            this.tb_add = new System.Windows.Forms.Button();
            this.tb_exit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Tea",
            "Coffee",
            "Ice blended",
            "Juice",
            "Smoothie",
            "Milk tea"});
            this.cb_type.Location = new System.Drawing.Point(171, 419);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(126, 24);
            this.cb_type.TabIndex = 19;
            // 
            // cb_size
            // 
            this.cb_size.FormattingEnabled = true;
            this.cb_size.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.cb_size.Location = new System.Drawing.Point(171, 366);
            this.cb_size.Name = "cb_size";
            this.cb_size.Size = new System.Drawing.Size(126, 24);
            this.cb_size.TabIndex = 18;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(32, 22);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(736, 169);
            this.dgv.TabIndex = 17;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // tb_quantity
            // 
            this.tb_quantity.Location = new System.Drawing.Point(171, 466);
            this.tb_quantity.Name = "tb_quantity";
            this.tb_quantity.Size = new System.Drawing.Size(105, 22);
            this.tb_quantity.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Size";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(171, 319);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(105, 22);
            this.tb_price.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Price";
            // 
            // tb_did
            // 
            this.tb_did.Location = new System.Drawing.Point(171, 271);
            this.tb_did.Name = "tb_did";
            this.tb_did.Size = new System.Drawing.Size(105, 22);
            this.tb_did.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "DID";
            // 
            // tb_delete
            // 
            this.tb_delete.Location = new System.Drawing.Point(655, 294);
            this.tb_delete.Name = "tb_delete";
            this.tb_delete.Size = new System.Drawing.Size(95, 42);
            this.tb_delete.TabIndex = 6;
            this.tb_delete.Text = "Delete";
            this.tb_delete.UseVisualStyleBackColor = true;
            this.tb_delete.Click += new System.EventHandler(this.tb_delete_Click);
            // 
            // tb_edit
            // 
            this.tb_edit.Location = new System.Drawing.Point(509, 295);
            this.tb_edit.Name = "tb_edit";
            this.tb_edit.Size = new System.Drawing.Size(95, 42);
            this.tb_edit.TabIndex = 7;
            this.tb_edit.Text = "Edit";
            this.tb_edit.UseVisualStyleBackColor = true;
            this.tb_edit.Click += new System.EventHandler(this.tb_edit_Click);
            // 
            // tb_add
            // 
            this.tb_add.Location = new System.Drawing.Point(352, 295);
            this.tb_add.Name = "tb_add";
            this.tb_add.Size = new System.Drawing.Size(95, 42);
            this.tb_add.TabIndex = 8;
            this.tb_add.Text = "Add";
            this.tb_add.UseVisualStyleBackColor = true;
            this.tb_add.Click += new System.EventHandler(this.tb_add_Click);
            // 
            // tb_exit
            // 
            this.tb_exit.Location = new System.Drawing.Point(509, 367);
            this.tb_exit.Name = "tb_exit";
            this.tb_exit.Size = new System.Drawing.Size(95, 40);
            this.tb_exit.TabIndex = 20;
            this.tb_exit.Text = "Exit";
            this.tb_exit.UseVisualStyleBackColor = true;
            this.tb_exit.Click += new System.EventHandler(this.tb_exit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "Input Type";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(409, 216);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(102, 23);
            this.tb_search.TabIndex = 41;
            this.tb_search.Text = "Search";
            this.tb_search.UseVisualStyleBackColor = true;
            this.tb_search.Click += new System.EventHandler(this.tb_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(172, 216);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(210, 22);
            this.txt_search.TabIndex = 40;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.tb_exit);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.cb_size);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.tb_quantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_did);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_delete);
            this.Controls.Add(this.tb_edit);
            this.Controls.Add(this.tb_add);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.ComboBox cb_size;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox tb_quantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_did;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tb_delete;
        private System.Windows.Forms.Button tb_edit;
        private System.Windows.Forms.Button tb_add;
        private System.Windows.Forms.Button tb_exit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button tb_search;
        private System.Windows.Forms.TextBox txt_search;
    }
}