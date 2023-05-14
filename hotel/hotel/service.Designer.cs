﻿namespace hotel
{
    partial class service
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel4 = new Panel();
            txt_price = new TextBox();
            txt_name = new TextBox();
            btn_search = new Button();
            textBox6 = new TextBox();
            btn_delete = new Button();
            btn_add = new Button();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            panel3 = new Panel();
            textBox2 = new TextBox();
            panel1 = new Panel();
            txt_id = new TextBox();
            dgv_service = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_service).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(21, 318);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(219, 2);
            panel4.TabIndex = 82;
            panel4.Paint += panel4_Paint;
            // 
            // txt_price
            // 
            txt_price.BackColor = Color.FromArgb(0, 1, 0);
            txt_price.BorderStyle = BorderStyle.None;
            txt_price.Cursor = Cursors.IBeam;
            txt_price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_price.ForeColor = Color.White;
            txt_price.Location = new Point(20, 294);
            txt_price.Margin = new Padding(3, 2, 3, 2);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(219, 22);
            txt_price.TabIndex = 81;
            txt_price.TextChanged += textBox8_TextChanged;
            // 
            // txt_name
            // 
            txt_name.BackColor = Color.FromArgb(0, 1, 0);
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.Cursor = Cursors.IBeam;
            txt_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.ForeColor = Color.White;
            txt_name.Location = new Point(20, 226);
            txt_name.Margin = new Padding(3, 2, 3, 2);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(219, 22);
            txt_name.TabIndex = 80;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.Black;
            btn_search.BackgroundImage = Properties.Resources.search_1_5;
            btn_search.Cursor = Cursors.Hand;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Location = new Point(925, 154);
            btn_search.Margin = new Padding(3, 2, 3, 2);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(24, 20);
            btn_search.TabIndex = 78;
            btn_search.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.Black;
            textBox6.Cursor = Cursors.IBeam;
            textBox6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.ForeColor = Color.White;
            textBox6.Location = new Point(681, 148);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Search";
            textBox6.Size = new Size(274, 32);
            textBox6.TabIndex = 77;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Black;
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.White;
            btn_delete.Image = Properties.Resources.x_5;
            btn_delete.ImageAlign = ContentAlignment.MiddleRight;
            btn_delete.Location = new Point(425, 284);
            btn_delete.Margin = new Padding(3, 2, 3, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(102, 41);
            btn_delete.TabIndex = 76;
            btn_delete.Text = "Delete";
            btn_delete.TextAlign = ContentAlignment.MiddleLeft;
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Black;
            btn_add.Cursor = Cursors.Hand;
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add.ForeColor = Color.White;
            btn_add.Image = Properties.Resources.plus_1_1_5;
            btn_add.ImageAlign = ContentAlignment.MiddleRight;
            btn_add.Location = new Point(425, 215);
            btn_add.Margin = new Padding(3, 2, 3, 2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(102, 43);
            btn_add.TabIndex = 74;
            btn_add.Text = "Add";
            btn_add.TextAlign = ContentAlignment.MiddleLeft;
            btn_add.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(0, 1, 0);
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.ForeColor = Color.White;
            textBox7.Location = new Point(20, 269);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(109, 22);
            textBox7.TabIndex = 72;
            textBox7.Text = "Price";
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(0, 1, 0);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(19, 202);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(109, 22);
            textBox5.TabIndex = 71;
            textBox5.Text = "Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(20, 250);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 2);
            panel3.TabIndex = 70;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(0, 1, 0);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(19, 132);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(109, 22);
            textBox2.TabIndex = 67;
            textBox2.Text = "ID ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(20, 181);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 2);
            panel1.TabIndex = 66;
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.FromArgb(0, 1, 0);
            txt_id.BorderStyle = BorderStyle.None;
            txt_id.Cursor = Cursors.IBeam;
            txt_id.Enabled = false;
            txt_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_id.ForeColor = Color.White;
            txt_id.Location = new Point(19, 157);
            txt_id.Margin = new Padding(3, 2, 3, 2);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(219, 22);
            txt_id.TabIndex = 65;
            // 
            // dgv_service
            // 
            dgv_service.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_service.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_service.BackgroundColor = Color.FromArgb(0, 1, 0);
            dgv_service.BorderStyle = BorderStyle.Fixed3D;
            dgv_service.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_service.GridColor = Color.White;
            dgv_service.Location = new Point(21, 375);
            dgv_service.Margin = new Padding(3, 2, 3, 2);
            dgv_service.Name = "dgv_service";
            dgv_service.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 1, 0);
            dataGridViewCellStyle2.Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkGray;
            dgv_service.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_service.RowTemplate.Height = 29;
            dgv_service.Size = new Size(942, 216);
            dgv_service.TabIndex = 64;
            dgv_service.CellClick += dgv_service_CellClick;
            // 
            // service
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Midnight_Inn__5_;
            Controls.Add(panel4);
            Controls.Add(txt_price);
            Controls.Add(txt_name);
            Controls.Add(btn_search);
            Controls.Add(textBox6);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(panel3);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(txt_id);
            Controls.Add(dgv_service);
            Margin = new Padding(3, 2, 3, 2);
            Name = "service";
            Size = new Size(1437, 625);
            Load += service_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_service).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel4;
        private TextBox txt_price;
        private TextBox txt_name;
        private Button btn_search;
        private TextBox textBox6;
        private Button btn_delete;
        private Button btn_add;
        private TextBox textBox7;
        private TextBox textBox5;
        private Panel panel3;
        private TextBox textBox2;
        private Panel panel1;
        private TextBox txt_id;
        private DataGridView dgv_service;
    }
}
