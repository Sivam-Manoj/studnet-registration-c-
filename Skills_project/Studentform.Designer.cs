namespace Skills_project
{
    partial class Studentform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Studentform));
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            txt_lastname = new TextBox();
            txt_firstname = new TextBox();
            female = new RadioButton();
            male = new RadioButton();
            dob = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            txt_phonenum = new TextBox();
            txt_homenum = new TextBox();
            txt_gmail = new TextBox();
            txt_address = new RichTextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txt_reg = new ComboBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            txt_contact = new TextBox();
            txt_nic = new TextBox();
            txt_parentname = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label13 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 23);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(62, 20);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log Out";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.Location = new Point(1798, 939);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(55, 25);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Exit";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(txt_reg);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Location = new Point(12, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1856, 871);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Registration";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button4
            // 
            button4.Location = new Point(1651, 810);
            button4.Name = "button4";
            button4.Size = new Size(147, 50);
            button4.TabIndex = 11;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1475, 811);
            button3.Name = "button3";
            button3.Size = new Size(147, 52);
            button3.TabIndex = 10;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(193, 811);
            button2.Name = "button2";
            button2.Size = new Size(147, 51);
            button2.TabIndex = 9;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(17, 810);
            button1.Name = "button1";
            button1.Size = new Size(147, 52);
            button1.TabIndex = 8;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_lastname);
            groupBox2.Controls.Add(txt_firstname);
            groupBox2.Controls.Add(female);
            groupBox2.Controls.Add(male);
            groupBox2.Controls.Add(dob);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(17, 57);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1781, 254);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Basic Details";
            // 
            // txt_lastname
            // 
            txt_lastname.Location = new Point(121, 100);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new Size(1609, 27);
            txt_lastname.TabIndex = 7;
            // 
            // txt_firstname
            // 
            txt_firstname.Location = new Point(121, 41);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.Size = new Size(1609, 27);
            txt_firstname.TabIndex = 8;
            txt_firstname.TextChanged += textBox2_TextChanged;
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(322, 205);
            female.Name = "female";
            female.Size = new Size(78, 24);
            female.TabIndex = 11;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(126, 205);
            male.Name = "male";
            male.Size = new Size(63, 24);
            male.TabIndex = 10;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = true;
            // 
            // dob
            // 
            dob.Location = new Point(126, 154);
            dob.Name = "dob";
            dob.Size = new Size(489, 27);
            dob.TabIndex = 9;
            dob.Value = new DateTime(2024, 1, 24, 17, 43, 5, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 205);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 3;
            label5.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 161);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 6;
            label4.Text = "Date Of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 107);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 6;
            label3.Text = "Last Name";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 48);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 6;
            label2.Text = "First Name";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txt_phonenum);
            groupBox3.Controls.Add(txt_homenum);
            groupBox3.Controls.Add(txt_gmail);
            groupBox3.Controls.Add(txt_address);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(17, 328);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1781, 255);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Contact Details";
            // 
            // txt_phonenum
            // 
            txt_phonenum.Location = new Point(130, 195);
            txt_phonenum.Name = "txt_phonenum";
            txt_phonenum.Size = new Size(782, 27);
            txt_phonenum.TabIndex = 14;
            // 
            // txt_homenum
            // 
            txt_homenum.Location = new Point(1126, 195);
            txt_homenum.Name = "txt_homenum";
            txt_homenum.Size = new Size(604, 27);
            txt_homenum.TabIndex = 13;
            // 
            // txt_gmail
            // 
            txt_gmail.Location = new Point(130, 134);
            txt_gmail.Name = "txt_gmail";
            txt_gmail.Size = new Size(1600, 27);
            txt_gmail.TabIndex = 12;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(130, 34);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(1600, 81);
            txt_address.TabIndex = 3;
            txt_address.Text = "";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(970, 195);
            label9.Name = "label9";
            label9.Size = new Size(119, 20);
            label9.TabIndex = 10;
            label9.Text = "Home Phone No";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 195);
            label8.Name = "label8";
            label8.Size = new Size(125, 20);
            label8.TabIndex = 9;
            label8.Text = "Mobile Phone No";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 134);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 8;
            label7.Text = "Gmail";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 34);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 7;
            label6.Text = "Address";
            // 
            // txt_reg
            // 
            txt_reg.FormattingEnabled = true;
            txt_reg.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            txt_reg.Location = new Point(832, 20);
            txt_reg.Name = "txt_reg";
            txt_reg.Size = new Size(438, 28);
            txt_reg.TabIndex = 4;
            txt_reg.SelectedIndexChanged += txt_reg_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(764, 20);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 3;
            label1.Text = "Reg No:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txt_contact);
            groupBox4.Controls.Add(txt_nic);
            groupBox4.Controls.Add(txt_parentname);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label10);
            groupBox4.Location = new Point(17, 602);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1781, 202);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Parent Details";
            // 
            // txt_contact
            // 
            txt_contact.Location = new Point(130, 148);
            txt_contact.Name = "txt_contact";
            txt_contact.Size = new Size(895, 27);
            txt_contact.TabIndex = 5;
            txt_contact.TextChanged += textBox8_TextChanged;
            // 
            // txt_nic
            // 
            txt_nic.Location = new Point(130, 99);
            txt_nic.Name = "txt_nic";
            txt_nic.Size = new Size(895, 27);
            txt_nic.TabIndex = 4;
            // 
            // txt_parentname
            // 
            txt_parentname.Location = new Point(130, 46);
            txt_parentname.Name = "txt_parentname";
            txt_parentname.Size = new Size(1600, 27);
            txt_parentname.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 155);
            label12.Name = "label12";
            label12.Size = new Size(84, 20);
            label12.TabIndex = 2;
            label12.Text = "Contact No";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 106);
            label11.Name = "label11";
            label11.Size = new Size(33, 20);
            label11.TabIndex = 1;
            label11.Text = "NIC";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 53);
            label10.Name = "label10";
            label10.Size = new Size(94, 20);
            label10.TabIndex = 0;
            label10.Text = "Parent Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Palatino Linotype", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(805, -8);
            label13.Name = "label13";
            label13.Size = new Size(559, 80);
            label13.TabIndex = 4;
            label13.Text = "Skills International";
            // 
            // Studentform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(label13);
            Controls.Add(linkLabel1);
            Controls.Add(linkLabel2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Studentform";
            Text = "Student Registration - Skills International";
            Load += Studentform_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox txt_reg;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private RadioButton female;
        private RadioButton male;
        private DateTimePicker dob;
        private TextBox txt_firstname;
        private TextBox txt_lastname;
        private GroupBox groupBox3;
        private Label label7;
        private Label label6;
        private TextBox txt_phonenum;
        private TextBox txt_homenum;
        private TextBox txt_gmail;
        private RichTextBox txt_address;
        private Label label9;
        private Label label8;
        private GroupBox groupBox4;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txt_contact;
        private TextBox txt_nic;
        private TextBox txt_parentname;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label13;
    }
}