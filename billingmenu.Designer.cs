namespace medicare_hms
{
    partial class billingmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(billingmenu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.check = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.total = new System.Windows.Forms.Button();
            this.totalfee = new System.Windows.Forms.TextBox();
            this.miscefee = new System.Windows.Forms.TextBox();
            this.docfee = new System.Windows.Forms.TextBox();
            this.pathofee = new System.Windows.Forms.TextBox();
            this.roomcharges = new System.Windows.Forms.TextBox();
            this.datedischarge = new System.Windows.Forms.TextBox();
            this.dateadmission = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.pid = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.no = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 128);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.check);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update/Delete";
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(684, 32);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(88, 29);
            this.check.TabIndex = 2;
            this.check.Text = "select";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(554, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(185, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the patient name for updating or deleting  :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.BackgroundImage = global::medicare_hms.Properties.Resources.banner;
            this.groupBox2.Controls.Add(this.total);
            this.groupBox2.Controls.Add(this.totalfee);
            this.groupBox2.Controls.Add(this.miscefee);
            this.groupBox2.Controls.Add(this.docfee);
            this.groupBox2.Controls.Add(this.pathofee);
            this.groupBox2.Controls.Add(this.roomcharges);
            this.groupBox2.Controls.Add(this.datedischarge);
            this.groupBox2.Controls.Add(this.dateadmission);
            this.groupBox2.Controls.Add(this.sex);
            this.groupBox2.Controls.Add(this.age);
            this.groupBox2.Controls.Add(this.name);
            this.groupBox2.Controls.Add(this.pid);
            this.groupBox2.Controls.Add(this.date);
            this.groupBox2.Controls.Add(this.no);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.add);
            this.groupBox2.Controls.Add(this.update);
            this.groupBox2.Controls.Add(this.delete);
            this.groupBox2.Controls.Add(this.back);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 330);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add/Update/Delete";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(697, 229);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(75, 30);
            this.total.TabIndex = 33;
            this.total.Text = "Total";
            this.total.UseVisualStyleBackColor = true;
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // totalfee
            // 
            this.totalfee.Location = new System.Drawing.Point(569, 230);
            this.totalfee.Name = "totalfee";
            this.totalfee.Size = new System.Drawing.Size(100, 26);
            this.totalfee.TabIndex = 32;
            this.totalfee.TextChanged += new System.EventHandler(this.totalfee_TextChanged);
            // 
            // miscefee
            // 
            this.miscefee.Location = new System.Drawing.Point(575, 197);
            this.miscefee.Name = "miscefee";
            this.miscefee.Size = new System.Drawing.Size(100, 26);
            this.miscefee.TabIndex = 31;
            this.miscefee.TextChanged += new System.EventHandler(this.miscefee_TextChanged);
            // 
            // docfee
            // 
            this.docfee.Location = new System.Drawing.Point(575, 169);
            this.docfee.Name = "docfee";
            this.docfee.Size = new System.Drawing.Size(100, 26);
            this.docfee.TabIndex = 30;
            this.docfee.TextChanged += new System.EventHandler(this.docfee_TextChanged);
            // 
            // pathofee
            // 
            this.pathofee.Location = new System.Drawing.Point(575, 136);
            this.pathofee.Name = "pathofee";
            this.pathofee.Size = new System.Drawing.Size(100, 26);
            this.pathofee.TabIndex = 29;
            this.pathofee.TextChanged += new System.EventHandler(this.pathofee_TextChanged);
            // 
            // roomcharges
            // 
            this.roomcharges.Location = new System.Drawing.Point(575, 109);
            this.roomcharges.Name = "roomcharges";
            this.roomcharges.Size = new System.Drawing.Size(100, 26);
            this.roomcharges.TabIndex = 28;
            this.roomcharges.TextChanged += new System.EventHandler(this.roomcharges_TextChanged);
            // 
            // datedischarge
            // 
            this.datedischarge.Location = new System.Drawing.Point(575, 76);
            this.datedischarge.Name = "datedischarge";
            this.datedischarge.Size = new System.Drawing.Size(100, 26);
            this.datedischarge.TabIndex = 27;
            // 
            // dateadmission
            // 
            this.dateadmission.Location = new System.Drawing.Point(575, 43);
            this.dateadmission.Name = "dateadmission";
            this.dateadmission.Size = new System.Drawing.Size(100, 26);
            this.dateadmission.TabIndex = 26;
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(143, 233);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(100, 26);
            this.sex.TabIndex = 25;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(143, 194);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 26);
            this.age.TabIndex = 24;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(143, 156);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 26);
            this.name.TabIndex = 23;
            // 
            // pid
            // 
            this.pid.Location = new System.Drawing.Point(143, 119);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(100, 26);
            this.pid.TabIndex = 22;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(143, 79);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(100, 26);
            this.date.TabIndex = 21;
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(143, 40);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(100, 26);
            this.no.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(426, 233);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 20);
            this.label14.TabIndex = 19;
            this.label14.Text = "Total Amount  :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(426, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Miscellaneous Fee  :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(426, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Doctor Fees  :";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(426, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Pathology fees  :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(426, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Room Charges  :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(426, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Date of Discharge  :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(426, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Date of Admission  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(23, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gender  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(23, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Age  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(23, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Name  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(23, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Patient id  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(23, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(23, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bill No  :";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(526, 295);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(84, 31);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(616, 295);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 31);
            this.update.TabIndex = 5;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(697, 295);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 31);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(6, 295);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(80, 29);
            this.back.TabIndex = 3;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // billingmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "billingmenu";
            this.Text = "Bills And Payments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox totalfee;
        private System.Windows.Forms.TextBox miscefee;
        private System.Windows.Forms.TextBox docfee;
        private System.Windows.Forms.TextBox pathofee;
        private System.Windows.Forms.TextBox roomcharges;
        private System.Windows.Forms.TextBox datedischarge;
        private System.Windows.Forms.TextBox dateadmission;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox pid;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox no;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button total;
    }
}