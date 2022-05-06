namespace test
{
    partial class mobile_shop
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.CombNat = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rdf = new System.Windows.Forms.RadioButton();
            this.Rdm = new System.Windows.Forms.RadioButton();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.des = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Pname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Select_img = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Select_img);
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.CombNat);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rdf);
            this.groupBox1.Controls.Add(this.Rdm);
            this.groupBox1.Controls.Add(this.DOB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.des);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Pname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1176, 333);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(735, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 30);
            this.button3.TabIndex = 21;
            this.button3.Text = "deleate";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(735, 147);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(88, 30);
            this.btnupdate.TabIndex = 20;
            this.btnupdate.Text = "update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(735, 88);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(88, 29);
            this.btnadd.TabIndex = 19;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // CombNat
            // 
            this.CombNat.FormattingEnabled = true;
            this.CombNat.Location = new System.Drawing.Point(86, 101);
            this.CombNat.Name = "CombNat";
            this.CombNat.Size = new System.Drawing.Size(186, 31);
            this.CombNat.TabIndex = 15;
            this.CombNat.SelectedIndexChanged += new System.EventHandler(this.CombNat_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "brand";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Status";
            // 
            // rdf
            // 
            this.rdf.AutoSize = true;
            this.rdf.Location = new System.Drawing.Point(189, 149);
            this.rdf.Name = "rdf";
            this.rdf.Size = new System.Drawing.Size(118, 27);
            this.rdf.TabIndex = 12;
            this.rdf.TabStop = true;
            this.rdf.Text = "Unavailable";
            this.rdf.UseVisualStyleBackColor = true;
            // 
            // Rdm
            // 
            this.Rdm.AutoSize = true;
            this.Rdm.Location = new System.Drawing.Point(86, 149);
            this.Rdm.Name = "Rdm";
            this.Rdm.Size = new System.Drawing.Size(97, 27);
            this.Rdm.TabIndex = 11;
            this.Rdm.TabStop = true;
            this.Rdm.Text = "Available";
            this.Rdm.UseVisualStyleBackColor = true;
            // 
            // DOB
            // 
            this.DOB.Location = new System.Drawing.Point(107, 226);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(200, 28);
            this.DOB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Time";
            // 
            // des
            // 
            this.des.Location = new System.Drawing.Point(469, 101);
            this.des.Multiline = true;
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(206, 192);
            this.des.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descriptions";
            // 
            // Pname
            // 
            this.Pname.Location = new System.Drawing.Point(281, 37);
            this.Pname.Name = "Pname";
            this.Pname.Size = new System.Drawing.Size(284, 28);
            this.Pname.TabIndex = 4;
            this.Pname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prodect";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(65, 42);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(72, 28);
            this.textID.TabIndex = 2;
            this.textID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(128, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(884, 256);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(908, 37);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(196, 217);
            this.pictureBox.TabIndex = 22;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // Select_img
            // 
            this.Select_img.Location = new System.Drawing.Point(908, 264);
            this.Select_img.Name = "Select_img";
            this.Select_img.Size = new System.Drawing.Size(196, 52);
            this.Select_img.TabIndex = 23;
            this.Select_img.Text = "Select Img";
            this.Select_img.UseVisualStyleBackColor = true;
            this.Select_img.Click += new System.EventHandler(this.Select_img_Click);
            // 
            // mobile_shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1173, 606);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "mobile_shop";
            this.Text = "Mo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Employees_info_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox des;
        private Label label3;
        private TextBox Pname;
        private Label label2;
        private TextBox textID;
        private Label label1;
        private ComboBox CombNat;
        private Label label7;
        private Label label6;
        private RadioButton rdf;
        private RadioButton Rdm;
        private DateTimePicker DOB;
        private Label label5;
        private Button button3;
        private Button btnupdate;
        private Button btnadd;
        private DataGridView dataGridView1;
        private Button Select_img;
        private PictureBox pictureBox;
    }
}