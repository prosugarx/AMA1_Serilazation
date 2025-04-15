namespace AMA1_Serilazation
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtp1 = new DateTimePicker();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtDepatment = new TextBox();
            txtSalary = new TextBox();
            btnSerialization = new Button();
            btnDeserialization = new Button();
            btnJsonCreat = new Button();
            btnJsonRead = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            txtProductName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 51);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 95);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Telefon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 141);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Departman:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 185);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 3;
            label4.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 229);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 4;
            label5.Text = "Maaş:";
            // 
            // dtp1
            // 
            dtp1.Location = new Point(218, 180);
            dtp1.Name = "dtp1";
            dtp1.Size = new Size(250, 27);
            dtp1.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(218, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(218, 92);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 27);
            txtPhone.TabIndex = 7;
            // 
            // txtDepatment
            // 
            txtDepatment.Location = new Point(218, 134);
            txtDepatment.Name = "txtDepatment";
            txtDepatment.Size = new Size(250, 27);
            txtDepatment.TabIndex = 8;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(218, 222);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(250, 27);
            txtSalary.TabIndex = 9;
            // 
            // btnSerialization
            // 
            btnSerialization.Location = new Point(63, 288);
            btnSerialization.Name = "btnSerialization";
            btnSerialization.Size = new Size(179, 78);
            btnSerialization.TabIndex = 10;
            btnSerialization.Text = "Serialize Et";
            btnSerialization.UseVisualStyleBackColor = true;
            btnSerialization.Click += btnSerialization_Click;
            // 
            // btnDeserialization
            // 
            btnDeserialization.Location = new Point(276, 288);
            btnDeserialization.Name = "btnDeserialization";
            btnDeserialization.Size = new Size(179, 78);
            btnDeserialization.TabIndex = 11;
            btnDeserialization.Text = "Deserialize Et";
            btnDeserialization.UseVisualStyleBackColor = true;
            btnDeserialization.Click += btnDeserialization_Click;
            // 
            // btnJsonCreat
            // 
            btnJsonCreat.Location = new Point(514, 281);
            btnJsonCreat.Name = "btnJsonCreat";
            btnJsonCreat.Size = new Size(179, 85);
            btnJsonCreat.TabIndex = 12;
            btnJsonCreat.Text = "JSON Oluştur";
            btnJsonCreat.UseVisualStyleBackColor = true;
            btnJsonCreat.Click += btnJsonCreat_Click;
            // 
            // btnJsonRead
            // 
            btnJsonRead.Location = new Point(708, 281);
            btnJsonRead.Name = "btnJsonRead";
            btnJsonRead.Size = new Size(179, 85);
            btnJsonRead.TabIndex = 13;
            btnJsonRead.Text = "JSON Oku";
            btnJsonRead.UseVisualStyleBackColor = true;
            btnJsonRead.Click += btnJsonRead_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(514, 56);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 14;
            label6.Text = "Ürün Adı:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(502, 100);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 15;
            label7.Text = "Ürün Fiyatı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(511, 137);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 16;
            label8.Text = "Açıklama:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(605, 137);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 27);
            txtDescription.TabIndex = 17;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(605, 97);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(250, 27);
            txtPrice.TabIndex = 18;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(605, 51);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(250, 27);
            txtProductName.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 627);
            Controls.Add(txtProductName);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnJsonRead);
            Controls.Add(btnJsonCreat);
            Controls.Add(btnDeserialization);
            Controls.Add(btnSerialization);
            Controls.Add(txtSalary);
            Controls.Add(txtDepatment);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(dtp1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtp1;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtDepatment;
        private TextBox txtSalary;
        private Button btnSerialization;
        private Button btnDeserialization;
        private Button btnJsonCreat;
        private Button btnJsonRead;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private TextBox txtProductName;
    }
}
