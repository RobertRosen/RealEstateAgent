
namespace RealEstateAgent
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
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.lblEstateType = new System.Windows.Forms.Label();
            this.lstEstates = new System.Windows.Forms.ComboBox();
            this.tblRegister = new System.Windows.Forms.DataGridView();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.pnlEstateInfo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtboxID = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegister)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.pnlEstateInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.btnDelete);
            this.pnlRegister.Controls.Add(this.btnChange);
            this.pnlRegister.Controls.Add(this.tblRegister);
            this.pnlRegister.Controls.Add(this.lstEstates);
            this.pnlRegister.Controls.Add(this.lblEstateType);
            this.pnlRegister.Location = new System.Drawing.Point(3, 3);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(468, 625);
            this.pnlRegister.TabIndex = 0;
            // 
            // lblEstateType
            // 
            this.lblEstateType.AutoSize = true;
            this.lblEstateType.Location = new System.Drawing.Point(87, 44);
            this.lblEstateType.Name = "lblEstateType";
            this.lblEstateType.Size = new System.Drawing.Size(64, 15);
            this.lblEstateType.TabIndex = 0;
            this.lblEstateType.Text = "Estate type";
            // 
            // lstEstates
            // 
            this.lstEstates.FormattingEnabled = true;
            this.lstEstates.Location = new System.Drawing.Point(172, 41);
            this.lstEstates.Name = "lstEstates";
            this.lstEstates.Size = new System.Drawing.Size(121, 23);
            this.lstEstates.TabIndex = 1;
            this.lstEstates.Text = "Select....";
            // 
            // tblRegister
            // 
            this.tblRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRegister.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmID,
            this.colType,
            this.colAddress,
            this.colSeller,
            this.colBuyer,
            this.colPayment});
            this.tblRegister.Location = new System.Drawing.Point(0, 116);
            this.tblRegister.Name = "tblRegister";
            this.tblRegister.RowTemplate.Height = 25;
            this.tblRegister.Size = new System.Drawing.Size(467, 337);
            this.tblRegister.TabIndex = 2;
            this.tblRegister.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(45, 523);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(106, 36);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Accept Changes";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(296, 523);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 36);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.Name = "clmID";
            this.clmID.Width = 50;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.Width = 75;
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Width = 75;
            // 
            // colSeller
            // 
            this.colSeller.HeaderText = "Seller";
            this.colSeller.Name = "colSeller";
            this.colSeller.Width = 75;
            // 
            // colBuyer
            // 
            this.colBuyer.HeaderText = "Buyer";
            this.colBuyer.Name = "colBuyer";
            this.colBuyer.Width = 75;
            // 
            // colPayment
            // 
            this.colPayment.HeaderText = "Payment";
            this.colPayment.Name = "colPayment";
            this.colPayment.Width = 75;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.pnlEstateInfo);
            this.pnlInfo.Controls.Add(this.lblCountry);
            this.pnlInfo.Controls.Add(this.lblCity);
            this.pnlInfo.Controls.Add(this.lblAddress);
            this.pnlInfo.Location = new System.Drawing.Point(476, 3);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(300, 625);
            this.pnlInfo.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(46, 329);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 15);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(67, 354);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 15);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(56, 396);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(38, 15);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "label1";
            // 
            // pnlEstateInfo
            // 
            this.pnlEstateInfo.Controls.Add(this.radioButton3);
            this.pnlEstateInfo.Controls.Add(this.radioButton2);
            this.pnlEstateInfo.Controls.Add(this.radioButton1);
            this.pnlEstateInfo.Controls.Add(this.button1);
            this.pnlEstateInfo.Controls.Add(this.lblPayment);
            this.pnlEstateInfo.Controls.Add(this.lblImage);
            this.pnlEstateInfo.Controls.Add(this.txtboxID);
            this.pnlEstateInfo.Controls.Add(this.lblID);
            this.pnlEstateInfo.Controls.Add(this.label1);
            this.pnlEstateInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlEstateInfo.Name = "pnlEstateInfo";
            this.pnlEstateInfo.Size = new System.Drawing.Size(297, 174);
            this.pnlEstateInfo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estate Information";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(164, 6);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 15);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // txtboxID
            // 
            this.txtboxID.Location = new System.Drawing.Point(188, 3);
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.Size = new System.Drawing.Size(65, 23);
            this.txtboxID.TabIndex = 2;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(20, 44);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(40, 15);
            this.lblImage.TabIndex = 3;
            this.lblImage.Text = "Image";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(188, 44);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(54, 15);
            this.lblPayment.TabIndex = 4;
            this.lblPayment.Text = "Payment";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Select Image";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(187, 78);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 19);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(187, 103);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(94, 19);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(187, 128);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(94, 19);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 630);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlRegister);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegister)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlEstateInfo.ResumeLayout(false);
            this.pnlEstateInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.DataGridView tblRegister;
        private System.Windows.Forms.ComboBox lstEstates;
        private System.Windows.Forms.Label lblEstateType;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeller;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayment;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel pnlEstateInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.TextBox txtboxID;
    }
}

