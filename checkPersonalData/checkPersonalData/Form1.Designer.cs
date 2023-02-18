namespace checkPersonalData
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.province = new System.Windows.Forms.TextBox();
            this.postalCode = new System.Windows.Forms.TextBox();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.checkFN = new System.Windows.Forms.Button();
            this.checkLN = new System.Windows.Forms.Button();
            this.checkAdd = new System.Windows.Forms.Button();
            this.checkCity = new System.Windows.Forms.Button();
            this.checkProvince = new System.Windows.Forms.Button();
            this.checkPC = new System.Windows.Forms.Button();
            this.checkPN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboProvince = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "&First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "&Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "&City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "&Province:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "P&ostal Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "&Phone Number:";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(151, 23);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(190, 26);
            this.firstName.TabIndex = 7;
            this.firstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(151, 65);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(190, 26);
            this.lastName.TabIndex = 8;
            this.lastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(151, 107);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(190, 26);
            this.address.TabIndex = 9;
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(151, 149);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(190, 26);
            this.city.TabIndex = 10;
            this.city.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // province
            // 
            this.province.Location = new System.Drawing.Point(151, 191);
            this.province.Name = "province";
            this.province.ReadOnly = true;
            this.province.Size = new System.Drawing.Size(190, 26);
            this.province.TabIndex = 11;
            this.province.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.province.TextChanged += new System.EventHandler(this.province_TextChanged);
            // 
            // postalCode
            // 
            this.postalCode.Location = new System.Drawing.Point(151, 233);
            this.postalCode.Name = "postalCode";
            this.postalCode.Size = new System.Drawing.Size(190, 26);
            this.postalCode.TabIndex = 12;
            this.postalCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(151, 275);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(190, 26);
            this.phoneNumber.TabIndex = 13;
            this.phoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkFN
            // 
            this.checkFN.Location = new System.Drawing.Point(363, 18);
            this.checkFN.Name = "checkFN";
            this.checkFN.Size = new System.Drawing.Size(197, 36);
            this.checkFN.TabIndex = 14;
            this.checkFN.Text = "Check First Name";
            this.checkFN.UseVisualStyleBackColor = true;
            this.checkFN.Click += new System.EventHandler(this.checkFN_Click);
            // 
            // checkLN
            // 
            this.checkLN.Location = new System.Drawing.Point(363, 60);
            this.checkLN.Name = "checkLN";
            this.checkLN.Size = new System.Drawing.Size(197, 36);
            this.checkLN.TabIndex = 15;
            this.checkLN.Text = "Check Last Name";
            this.checkLN.UseVisualStyleBackColor = true;
            this.checkLN.Click += new System.EventHandler(this.checkLN_Click);
            // 
            // checkAdd
            // 
            this.checkAdd.Location = new System.Drawing.Point(363, 102);
            this.checkAdd.Name = "checkAdd";
            this.checkAdd.Size = new System.Drawing.Size(197, 36);
            this.checkAdd.TabIndex = 16;
            this.checkAdd.Text = "Check Address";
            this.checkAdd.UseVisualStyleBackColor = true;
            this.checkAdd.Click += new System.EventHandler(this.checkAdd_Click);
            // 
            // checkCity
            // 
            this.checkCity.Location = new System.Drawing.Point(363, 144);
            this.checkCity.Name = "checkCity";
            this.checkCity.Size = new System.Drawing.Size(197, 36);
            this.checkCity.TabIndex = 17;
            this.checkCity.Text = "Check City";
            this.checkCity.UseVisualStyleBackColor = true;
            this.checkCity.Click += new System.EventHandler(this.checkCity_Click);
            // 
            // checkProvince
            // 
            this.checkProvince.Location = new System.Drawing.Point(363, 186);
            this.checkProvince.Name = "checkProvince";
            this.checkProvince.Size = new System.Drawing.Size(197, 36);
            this.checkProvince.TabIndex = 18;
            this.checkProvince.Text = "Check Province";
            this.checkProvince.UseVisualStyleBackColor = true;
            this.checkProvince.Click += new System.EventHandler(this.checkProvince_Click);
            // 
            // checkPC
            // 
            this.checkPC.Location = new System.Drawing.Point(363, 227);
            this.checkPC.Name = "checkPC";
            this.checkPC.Size = new System.Drawing.Size(197, 36);
            this.checkPC.TabIndex = 19;
            this.checkPC.Text = "Check Postal Code";
            this.checkPC.UseVisualStyleBackColor = true;
            this.checkPC.Click += new System.EventHandler(this.checkPC_Click);
            // 
            // checkPN
            // 
            this.checkPN.Location = new System.Drawing.Point(363, 269);
            this.checkPN.Name = "checkPN";
            this.checkPN.Size = new System.Drawing.Size(197, 36);
            this.checkPN.TabIndex = 20;
            this.checkPN.Text = "Check Phone Number";
            this.checkPN.UseVisualStyleBackColor = true;
            this.checkPN.Click += new System.EventHandler(this.checkPN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "Print All Information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(342, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 36);
            this.button2.TabIndex = 22;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboProvince
            // 
            this.comboProvince.FormattingEnabled = true;
            this.comboProvince.Location = new System.Drawing.Point(595, 192);
            this.comboProvince.Name = "comboProvince";
            this.comboProvince.Size = new System.Drawing.Size(161, 28);
            this.comboProvince.TabIndex = 23;
            this.comboProvince.Text = "Province";
            this.comboProvince.SelectedIndexChanged += new System.EventHandler(this.comboProvince_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 412);
            this.Controls.Add(this.comboProvince);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkPN);
            this.Controls.Add(this.checkPC);
            this.Controls.Add(this.checkProvince);
            this.Controls.Add(this.checkCity);
            this.Controls.Add(this.checkAdd);
            this.Controls.Add(this.checkLN);
            this.Controls.Add(this.checkFN);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.postalCode);
            this.Controls.Add(this.province);
            this.Controls.Add(this.city);
            this.Controls.Add(this.address);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Check personal data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox province;
        private System.Windows.Forms.TextBox postalCode;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.Button checkFN;
        private System.Windows.Forms.Button checkLN;
        private System.Windows.Forms.Button checkAdd;
        private System.Windows.Forms.Button checkCity;
        private System.Windows.Forms.Button checkProvince;
        private System.Windows.Forms.Button checkPC;
        private System.Windows.Forms.Button checkPN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboProvince;
    }
}

