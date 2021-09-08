﻿
namespace RealEstateAgent
{
    partial class MainForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblRegister = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.tblRegister = new System.Windows.Forms.DataGridView();
            this.clmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstEstates = new System.Windows.Forms.ComboBox();
            this.lblEstateType = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.rbtnPP = new System.Windows.Forms.RadioButton();
            this.rbtnWU = new System.Windows.Forms.RadioButton();
            this.rbtnBank = new System.Windows.Forms.RadioButton();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBrowseImg = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblImage = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlSeller = new System.Windows.Forms.Panel();
            this.txtSellerFName = new System.Windows.Forms.TextBox();
            this.lblSellerFName = new System.Windows.Forms.Label();
            this.txtSellerLName = new System.Windows.Forms.TextBox();
            this.txtSellerZip = new System.Windows.Forms.TextBox();
            this.txtSellerStreet = new System.Windows.Forms.TextBox();
            this.txtSellerCity = new System.Windows.Forms.TextBox();
            this.lblSeller = new System.Windows.Forms.Label();
            this.lblSellerLName = new System.Windows.Forms.Label();
            this.lblSellerZip = new System.Windows.Forms.Label();
            this.lblSellerCity = new System.Windows.Forms.Label();
            this.lblSellerStreet = new System.Windows.Forms.Label();
            this.lblSellerCountry = new System.Windows.Forms.Label();
            this.pnlBuyer = new System.Windows.Forms.Panel();
            this.txtBuyerFName = new System.Windows.Forms.TextBox();
            this.lblBuyerFName = new System.Windows.Forms.Label();
            this.txtBuyerLName = new System.Windows.Forms.TextBox();
            this.txtBuyerZip = new System.Windows.Forms.TextBox();
            this.txtBuyerStreet = new System.Windows.Forms.TextBox();
            this.txtBuyerCity = new System.Windows.Forms.TextBox();
            this.lblBuyer = new System.Windows.Forms.Label();
            this.lblBuyerLName = new System.Windows.Forms.Label();
            this.lblBuyerZip = new System.Windows.Forms.Label();
            this.lblBuyerCity = new System.Windows.Forms.Label();
            this.lblBuyerStreet = new System.Windows.Forms.Label();
            this.lblBuyerCountry = new System.Windows.Forms.Label();
            this.pnlEstateInfo = new System.Windows.Forms.Panel();
            this.txtEstateZip = new System.Windows.Forms.TextBox();
            this.txtEstateStreet = new System.Windows.Forms.TextBox();
            this.txtEstateCity = new System.Windows.Forms.TextBox();
            this.lblPresentID = new System.Windows.Forms.Label();
            this.lblEstateZip = new System.Windows.Forms.Label();
            this.lblEstateCity = new System.Windows.Forms.Label();
            this.lblEstateStreet = new System.Windows.Forms.Label();
            this.lblEstateCountry = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEstate = new System.Windows.Forms.Label();
            this.bxEstateCountry = new System.Windows.Forms.ComboBox();
            this.bxSellerCountry = new System.Windows.Forms.ComboBox();
            this.bxBuyerCountry = new System.Windows.Forms.ComboBox();
            this.pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegister)).BeginInit();
            this.pnlInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSeller.SuspendLayout();
            this.pnlBuyer.SuspendLayout();
            this.pnlEstateInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRegister
            // 
            this.pnlRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRegister.Controls.Add(this.btnAdd);
            this.pnlRegister.Controls.Add(this.lblRegister);
            this.pnlRegister.Controls.Add(this.lblSearch);
            this.pnlRegister.Controls.Add(this.btnDelete);
            this.pnlRegister.Controls.Add(this.btnChange);
            this.pnlRegister.Controls.Add(this.tblRegister);
            this.pnlRegister.Controls.Add(this.lstEstates);
            this.pnlRegister.Controls.Add(this.lblEstateType);
            this.pnlRegister.Location = new System.Drawing.Point(4, 5);
            this.pnlRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(668, 958);
            this.pnlRegister.TabIndex = 0;
            this.pnlRegister.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRegister_Paint);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(61, 884);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(151, 55);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Location = new System.Drawing.Point(235, 19);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(85, 23);
            this.lblRegister.TabIndex = 6;
            this.lblRegister.Text = "REGISTER";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(178, 738);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 23);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(407, 884);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 55);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(235, 884);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(151, 55);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
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
            this.tblRegister.Location = new System.Drawing.Point(15, 63);
            this.tblRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tblRegister.Name = "tblRegister";
            this.tblRegister.RowHeadersWidth = 51;
            this.tblRegister.RowTemplate.Height = 25;
            this.tblRegister.Size = new System.Drawing.Size(622, 640);
            this.tblRegister.TabIndex = 2;
            this.tblRegister.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clmID
            // 
            this.clmID.HeaderText = "ID";
            this.clmID.MinimumWidth = 6;
            this.clmID.Name = "clmID";
            this.clmID.Width = 75;
            // 
            // colType
            // 
            this.colType.HeaderText = "Type";
            this.colType.MinimumWidth = 6;
            this.colType.Name = "colType";
            this.colType.Width = 125;
            // 
            // colAddress
            // 
            this.colAddress.HeaderText = "Address";
            this.colAddress.MinimumWidth = 6;
            this.colAddress.Name = "colAddress";
            this.colAddress.Width = 125;
            // 
            // colSeller
            // 
            this.colSeller.HeaderText = "Seller";
            this.colSeller.MinimumWidth = 6;
            this.colSeller.Name = "colSeller";
            this.colSeller.Width = 125;
            // 
            // colBuyer
            // 
            this.colBuyer.HeaderText = "Buyer";
            this.colBuyer.MinimumWidth = 6;
            this.colBuyer.Name = "colBuyer";
            this.colBuyer.Width = 125;
            // 
            // colPayment
            // 
            this.colPayment.HeaderText = "Payment";
            this.colPayment.MinimumWidth = 6;
            this.colPayment.Name = "colPayment";
            this.colPayment.Width = 125;
            // 
            // lstEstates
            // 
            this.lstEstates.FormattingEnabled = true;
            this.lstEstates.Location = new System.Drawing.Point(178, 777);
            this.lstEstates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstEstates.Name = "lstEstates";
            this.lstEstates.Size = new System.Drawing.Size(172, 31);
            this.lstEstates.TabIndex = 1;
            this.lstEstates.Text = "Select....";
            // 
            // lblEstateType
            // 
            this.lblEstateType.AutoSize = true;
            this.lblEstateType.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstateType.Location = new System.Drawing.Point(15, 780);
            this.lblEstateType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstateType.Name = "lblEstateType";
            this.lblEstateType.Size = new System.Drawing.Size(95, 23);
            this.lblEstateType.TabIndex = 0;
            this.lblEstateType.Text = "Estate type";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.btnCancel);
            this.pnlInfo.Controls.Add(this.panel2);
            this.pnlInfo.Controls.Add(this.lblInfo);
            this.pnlInfo.Controls.Add(this.panel1);
            this.pnlInfo.Controls.Add(this.btnConfirm);
            this.pnlInfo.Controls.Add(this.pnlSeller);
            this.pnlInfo.Controls.Add(this.pnlBuyer);
            this.pnlInfo.Controls.Add(this.pnlEstateInfo);
            this.pnlInfo.Location = new System.Drawing.Point(680, 5);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(902, 958);
            this.pnlInfo.TabIndex = 1;
            this.pnlInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInfo_Paint);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(463, 884);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 55);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblPaymentMethod);
            this.panel2.Controls.Add(this.rbtnPP);
            this.panel2.Controls.Add(this.rbtnWU);
            this.panel2.Controls.Add(this.rbtnBank);
            this.panel2.Controls.Add(this.lblPayment);
            this.panel2.Location = new System.Drawing.Point(18, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 184);
            this.panel2.TabIndex = 12;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Location = new System.Drawing.Point(11, 64);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(71, 23);
            this.lblPaymentMethod.TabIndex = 13;
            this.lblPaymentMethod.Text = "Method";
            // 
            // rbtnPP
            // 
            this.rbtnPP.AutoSize = true;
            this.rbtnPP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnPP.Location = new System.Drawing.Point(158, 132);
            this.rbtnPP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnPP.Name = "rbtnPP";
            this.rbtnPP.Size = new System.Drawing.Size(71, 24);
            this.rbtnPP.TabIndex = 12;
            this.rbtnPP.TabStop = true;
            this.rbtnPP.Text = "PayPal";
            this.rbtnPP.UseVisualStyleBackColor = true;
            // 
            // rbtnWU
            // 
            this.rbtnWU.AutoSize = true;
            this.rbtnWU.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnWU.Location = new System.Drawing.Point(158, 98);
            this.rbtnWU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnWU.Name = "rbtnWU";
            this.rbtnWU.Size = new System.Drawing.Size(126, 24);
            this.rbtnWU.TabIndex = 11;
            this.rbtnWU.TabStop = true;
            this.rbtnWU.Text = "Western Union";
            this.rbtnWU.UseVisualStyleBackColor = true;
            // 
            // rbtnBank
            // 
            this.rbtnBank.AutoSize = true;
            this.rbtnBank.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnBank.Location = new System.Drawing.Point(158, 64);
            this.rbtnBank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnBank.Name = "rbtnBank";
            this.rbtnBank.Size = new System.Drawing.Size(62, 24);
            this.rbtnBank.TabIndex = 10;
            this.rbtnBank.TabStop = true;
            this.rbtnBank.Text = "Bank";
            this.rbtnBank.UseVisualStyleBackColor = true;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPayment.Location = new System.Drawing.Point(11, 10);
            this.lblPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(78, 23);
            this.lblPayment.TabIndex = 9;
            this.lblPayment.Text = "Payment";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(409, 19);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(127, 23);
            this.lblInfo.TabIndex = 11;
            this.lblInfo.Text = "INFORMATION";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBrowseImg);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblImage);
            this.panel1.Location = new System.Drawing.Point(463, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 472);
            this.panel1.TabIndex = 10;
            // 
            // btnBrowseImg
            // 
            this.btnBrowseImg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBrowseImg.Location = new System.Drawing.Point(166, 393);
            this.btnBrowseImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowseImg.Name = "btnBrowseImg";
            this.btnBrowseImg.Size = new System.Drawing.Size(134, 36);
            this.btnBrowseImg.TabIndex = 8;
            this.btnBrowseImg.Text = "Browse";
            this.btnBrowseImg.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(16, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 316);
            this.panel3.TabIndex = 6;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblImage.Location = new System.Drawing.Point(16, 9);
            this.lblImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(58, 23);
            this.lblImage.TabIndex = 3;
            this.lblImage.Text = "Image";
            this.lblImage.Click += new System.EventHandler(this.lblImage_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(287, 884);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(151, 55);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            // 
            // pnlSeller
            // 
            this.pnlSeller.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSeller.Controls.Add(this.bxSellerCountry);
            this.pnlSeller.Controls.Add(this.txtSellerFName);
            this.pnlSeller.Controls.Add(this.lblSellerFName);
            this.pnlSeller.Controls.Add(this.txtSellerLName);
            this.pnlSeller.Controls.Add(this.txtSellerZip);
            this.pnlSeller.Controls.Add(this.txtSellerStreet);
            this.pnlSeller.Controls.Add(this.txtSellerCity);
            this.pnlSeller.Controls.Add(this.lblSeller);
            this.pnlSeller.Controls.Add(this.lblSellerLName);
            this.pnlSeller.Controls.Add(this.lblSellerZip);
            this.pnlSeller.Controls.Add(this.lblSellerCity);
            this.pnlSeller.Controls.Add(this.lblSellerStreet);
            this.pnlSeller.Controls.Add(this.lblSellerCountry);
            this.pnlSeller.Location = new System.Drawing.Point(18, 557);
            this.pnlSeller.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlSeller.Name = "pnlSeller";
            this.pnlSeller.Size = new System.Drawing.Size(420, 302);
            this.pnlSeller.TabIndex = 8;
            // 
            // txtSellerFName
            // 
            this.txtSellerFName.Location = new System.Drawing.Point(160, 73);
            this.txtSellerFName.Name = "txtSellerFName";
            this.txtSellerFName.Size = new System.Drawing.Size(233, 30);
            this.txtSellerFName.TabIndex = 25;
            // 
            // lblSellerFName
            // 
            this.lblSellerFName.AutoSize = true;
            this.lblSellerFName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSellerFName.Location = new System.Drawing.Point(12, 73);
            this.lblSellerFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSellerFName.Name = "lblSellerFName";
            this.lblSellerFName.Size = new System.Drawing.Size(93, 23);
            this.lblSellerFName.TabIndex = 24;
            this.lblSellerFName.Text = "First Name";
            // 
            // txtSellerLName
            // 
            this.txtSellerLName.Location = new System.Drawing.Point(160, 109);
            this.txtSellerLName.Name = "txtSellerLName";
            this.txtSellerLName.Size = new System.Drawing.Size(233, 30);
            this.txtSellerLName.TabIndex = 23;
            // 
            // txtSellerZip
            // 
            this.txtSellerZip.Location = new System.Drawing.Point(160, 257);
            this.txtSellerZip.Name = "txtSellerZip";
            this.txtSellerZip.Size = new System.Drawing.Size(233, 30);
            this.txtSellerZip.TabIndex = 22;
            // 
            // txtSellerStreet
            // 
            this.txtSellerStreet.Location = new System.Drawing.Point(160, 221);
            this.txtSellerStreet.Name = "txtSellerStreet";
            this.txtSellerStreet.Size = new System.Drawing.Size(233, 30);
            this.txtSellerStreet.TabIndex = 21;
            // 
            // txtSellerCity
            // 
            this.txtSellerCity.Location = new System.Drawing.Point(160, 149);
            this.txtSellerCity.Name = "txtSellerCity";
            this.txtSellerCity.Size = new System.Drawing.Size(233, 30);
            this.txtSellerCity.TabIndex = 19;
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            this.lblSeller.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeller.Location = new System.Drawing.Point(11, 12);
            this.lblSeller.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(51, 23);
            this.lblSeller.TabIndex = 6;
            this.lblSeller.Text = "Seller";
            // 
            // lblSellerLName
            // 
            this.lblSellerLName.AutoSize = true;
            this.lblSellerLName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSellerLName.Location = new System.Drawing.Point(12, 109);
            this.lblSellerLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSellerLName.Name = "lblSellerLName";
            this.lblSellerLName.Size = new System.Drawing.Size(91, 23);
            this.lblSellerLName.TabIndex = 0;
            this.lblSellerLName.Text = "Last Name";
            // 
            // lblSellerZip
            // 
            this.lblSellerZip.AutoSize = true;
            this.lblSellerZip.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSellerZip.Location = new System.Drawing.Point(15, 257);
            this.lblSellerZip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSellerZip.Name = "lblSellerZip";
            this.lblSellerZip.Size = new System.Drawing.Size(79, 23);
            this.lblSellerZip.TabIndex = 5;
            this.lblSellerZip.Text = "Zip Code";
            // 
            // lblSellerCity
            // 
            this.lblSellerCity.AutoSize = true;
            this.lblSellerCity.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSellerCity.Location = new System.Drawing.Point(12, 149);
            this.lblSellerCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSellerCity.Name = "lblSellerCity";
            this.lblSellerCity.Size = new System.Drawing.Size(40, 23);
            this.lblSellerCity.TabIndex = 1;
            this.lblSellerCity.Text = "City";
            // 
            // lblSellerStreet
            // 
            this.lblSellerStreet.AutoSize = true;
            this.lblSellerStreet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSellerStreet.Location = new System.Drawing.Point(12, 221);
            this.lblSellerStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSellerStreet.Name = "lblSellerStreet";
            this.lblSellerStreet.Size = new System.Drawing.Size(55, 23);
            this.lblSellerStreet.TabIndex = 4;
            this.lblSellerStreet.Text = "Street";
            // 
            // lblSellerCountry
            // 
            this.lblSellerCountry.AutoSize = true;
            this.lblSellerCountry.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSellerCountry.Location = new System.Drawing.Point(12, 185);
            this.lblSellerCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSellerCountry.Name = "lblSellerCountry";
            this.lblSellerCountry.Size = new System.Drawing.Size(73, 23);
            this.lblSellerCountry.TabIndex = 2;
            this.lblSellerCountry.Text = "Country";
            // 
            // pnlBuyer
            // 
            this.pnlBuyer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBuyer.Controls.Add(this.bxBuyerCountry);
            this.pnlBuyer.Controls.Add(this.txtBuyerFName);
            this.pnlBuyer.Controls.Add(this.lblBuyerFName);
            this.pnlBuyer.Controls.Add(this.txtBuyerLName);
            this.pnlBuyer.Controls.Add(this.txtBuyerZip);
            this.pnlBuyer.Controls.Add(this.txtBuyerStreet);
            this.pnlBuyer.Controls.Add(this.txtBuyerCity);
            this.pnlBuyer.Controls.Add(this.lblBuyer);
            this.pnlBuyer.Controls.Add(this.lblBuyerLName);
            this.pnlBuyer.Controls.Add(this.lblBuyerZip);
            this.pnlBuyer.Controls.Add(this.lblBuyerCity);
            this.pnlBuyer.Controls.Add(this.lblBuyerStreet);
            this.pnlBuyer.Controls.Add(this.lblBuyerCountry);
            this.pnlBuyer.Location = new System.Drawing.Point(463, 557);
            this.pnlBuyer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlBuyer.Name = "pnlBuyer";
            this.pnlBuyer.Size = new System.Drawing.Size(420, 302);
            this.pnlBuyer.TabIndex = 7;
            this.pnlBuyer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtBuyerFName
            // 
            this.txtBuyerFName.Location = new System.Drawing.Point(166, 70);
            this.txtBuyerFName.Name = "txtBuyerFName";
            this.txtBuyerFName.Size = new System.Drawing.Size(233, 30);
            this.txtBuyerFName.TabIndex = 27;
            // 
            // lblBuyerFName
            // 
            this.lblBuyerFName.AutoSize = true;
            this.lblBuyerFName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuyerFName.Location = new System.Drawing.Point(14, 70);
            this.lblBuyerFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuyerFName.Name = "lblBuyerFName";
            this.lblBuyerFName.Size = new System.Drawing.Size(93, 23);
            this.lblBuyerFName.TabIndex = 26;
            this.lblBuyerFName.Text = "First Name";
            // 
            // txtBuyerLName
            // 
            this.txtBuyerLName.Location = new System.Drawing.Point(166, 109);
            this.txtBuyerLName.Name = "txtBuyerLName";
            this.txtBuyerLName.Size = new System.Drawing.Size(233, 30);
            this.txtBuyerLName.TabIndex = 18;
            // 
            // txtBuyerZip
            // 
            this.txtBuyerZip.Location = new System.Drawing.Point(166, 257);
            this.txtBuyerZip.Name = "txtBuyerZip";
            this.txtBuyerZip.Size = new System.Drawing.Size(233, 30);
            this.txtBuyerZip.TabIndex = 17;
            // 
            // txtBuyerStreet
            // 
            this.txtBuyerStreet.Location = new System.Drawing.Point(166, 221);
            this.txtBuyerStreet.Name = "txtBuyerStreet";
            this.txtBuyerStreet.Size = new System.Drawing.Size(233, 30);
            this.txtBuyerStreet.TabIndex = 16;
            // 
            // txtBuyerCity
            // 
            this.txtBuyerCity.Location = new System.Drawing.Point(166, 149);
            this.txtBuyerCity.Name = "txtBuyerCity";
            this.txtBuyerCity.Size = new System.Drawing.Size(233, 30);
            this.txtBuyerCity.TabIndex = 14;
            // 
            // lblBuyer
            // 
            this.lblBuyer.AutoSize = true;
            this.lblBuyer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuyer.Location = new System.Drawing.Point(16, 12);
            this.lblBuyer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuyer.Name = "lblBuyer";
            this.lblBuyer.Size = new System.Drawing.Size(54, 23);
            this.lblBuyer.TabIndex = 6;
            this.lblBuyer.Text = "Buyer";
            this.lblBuyer.Click += new System.EventHandler(this.lblBuyer_Click);
            // 
            // lblBuyerLName
            // 
            this.lblBuyerLName.AutoSize = true;
            this.lblBuyerLName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuyerLName.Location = new System.Drawing.Point(13, 116);
            this.lblBuyerLName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuyerLName.Name = "lblBuyerLName";
            this.lblBuyerLName.Size = new System.Drawing.Size(91, 23);
            this.lblBuyerLName.TabIndex = 0;
            this.lblBuyerLName.Text = "Last Name";
            // 
            // lblBuyerZip
            // 
            this.lblBuyerZip.AutoSize = true;
            this.lblBuyerZip.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuyerZip.Location = new System.Drawing.Point(14, 264);
            this.lblBuyerZip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuyerZip.Name = "lblBuyerZip";
            this.lblBuyerZip.Size = new System.Drawing.Size(79, 23);
            this.lblBuyerZip.TabIndex = 5;
            this.lblBuyerZip.Text = "Zip Code";
            // 
            // lblBuyerCity
            // 
            this.lblBuyerCity.AutoSize = true;
            this.lblBuyerCity.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuyerCity.Location = new System.Drawing.Point(14, 156);
            this.lblBuyerCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuyerCity.Name = "lblBuyerCity";
            this.lblBuyerCity.Size = new System.Drawing.Size(40, 23);
            this.lblBuyerCity.TabIndex = 1;
            this.lblBuyerCity.Text = "City";
            // 
            // lblBuyerStreet
            // 
            this.lblBuyerStreet.AutoSize = true;
            this.lblBuyerStreet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuyerStreet.Location = new System.Drawing.Point(13, 228);
            this.lblBuyerStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuyerStreet.Name = "lblBuyerStreet";
            this.lblBuyerStreet.Size = new System.Drawing.Size(55, 23);
            this.lblBuyerStreet.TabIndex = 4;
            this.lblBuyerStreet.Text = "Street";
            // 
            // lblBuyerCountry
            // 
            this.lblBuyerCountry.AutoSize = true;
            this.lblBuyerCountry.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuyerCountry.Location = new System.Drawing.Point(14, 192);
            this.lblBuyerCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuyerCountry.Name = "lblBuyerCountry";
            this.lblBuyerCountry.Size = new System.Drawing.Size(73, 23);
            this.lblBuyerCountry.TabIndex = 2;
            this.lblBuyerCountry.Text = "Country";
            // 
            // pnlEstateInfo
            // 
            this.pnlEstateInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEstateInfo.Controls.Add(this.bxEstateCountry);
            this.pnlEstateInfo.Controls.Add(this.txtEstateZip);
            this.pnlEstateInfo.Controls.Add(this.txtEstateStreet);
            this.pnlEstateInfo.Controls.Add(this.txtEstateCity);
            this.pnlEstateInfo.Controls.Add(this.lblPresentID);
            this.pnlEstateInfo.Controls.Add(this.lblEstateZip);
            this.pnlEstateInfo.Controls.Add(this.lblEstateCity);
            this.pnlEstateInfo.Controls.Add(this.lblEstateStreet);
            this.pnlEstateInfo.Controls.Add(this.lblEstateCountry);
            this.pnlEstateInfo.Controls.Add(this.lblID);
            this.pnlEstateInfo.Controls.Add(this.lblEstate);
            this.pnlEstateInfo.Location = new System.Drawing.Point(18, 63);
            this.pnlEstateInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEstateInfo.Name = "pnlEstateInfo";
            this.pnlEstateInfo.Size = new System.Drawing.Size(420, 263);
            this.pnlEstateInfo.TabIndex = 3;
            // 
            // txtEstateZip
            // 
            this.txtEstateZip.Location = new System.Drawing.Point(160, 211);
            this.txtEstateZip.Name = "txtEstateZip";
            this.txtEstateZip.Size = new System.Drawing.Size(233, 30);
            this.txtEstateZip.TabIndex = 13;
            // 
            // txtEstateStreet
            // 
            this.txtEstateStreet.Location = new System.Drawing.Point(160, 175);
            this.txtEstateStreet.Name = "txtEstateStreet";
            this.txtEstateStreet.Size = new System.Drawing.Size(233, 30);
            this.txtEstateStreet.TabIndex = 12;
            // 
            // txtEstateCity
            // 
            this.txtEstateCity.Location = new System.Drawing.Point(160, 103);
            this.txtEstateCity.Name = "txtEstateCity";
            this.txtEstateCity.Size = new System.Drawing.Size(233, 30);
            this.txtEstateCity.TabIndex = 10;
            // 
            // lblPresentID
            // 
            this.lblPresentID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPresentID.Location = new System.Drawing.Point(161, 61);
            this.lblPresentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPresentID.Name = "lblPresentID";
            this.lblPresentID.Size = new System.Drawing.Size(233, 30);
            this.lblPresentID.TabIndex = 9;
            this.lblPresentID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEstateZip
            // 
            this.lblEstateZip.AutoSize = true;
            this.lblEstateZip.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstateZip.Location = new System.Drawing.Point(14, 211);
            this.lblEstateZip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstateZip.Name = "lblEstateZip";
            this.lblEstateZip.Size = new System.Drawing.Size(79, 23);
            this.lblEstateZip.TabIndex = 5;
            this.lblEstateZip.Text = "Zip Code";
            // 
            // lblEstateCity
            // 
            this.lblEstateCity.AutoSize = true;
            this.lblEstateCity.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstateCity.Location = new System.Drawing.Point(12, 103);
            this.lblEstateCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstateCity.Name = "lblEstateCity";
            this.lblEstateCity.Size = new System.Drawing.Size(40, 23);
            this.lblEstateCity.TabIndex = 1;
            this.lblEstateCity.Text = "City";
            // 
            // lblEstateStreet
            // 
            this.lblEstateStreet.AutoSize = true;
            this.lblEstateStreet.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstateStreet.Location = new System.Drawing.Point(14, 175);
            this.lblEstateStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstateStreet.Name = "lblEstateStreet";
            this.lblEstateStreet.Size = new System.Drawing.Size(55, 23);
            this.lblEstateStreet.TabIndex = 4;
            this.lblEstateStreet.Text = "Street";
            // 
            // lblEstateCountry
            // 
            this.lblEstateCountry.AutoSize = true;
            this.lblEstateCountry.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstateCountry.Location = new System.Drawing.Point(12, 139);
            this.lblEstateCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstateCountry.Name = "lblEstateCountry";
            this.lblEstateCountry.Size = new System.Drawing.Size(73, 23);
            this.lblEstateCountry.TabIndex = 2;
            this.lblEstateCountry.Text = "Country";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(12, 61);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 23);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // lblEstate
            // 
            this.lblEstate.AutoSize = true;
            this.lblEstate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstate.Location = new System.Drawing.Point(11, 9);
            this.lblEstate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstate.Name = "lblEstate";
            this.lblEstate.Size = new System.Drawing.Size(56, 23);
            this.lblEstate.TabIndex = 0;
            this.lblEstate.Text = "Estate";
            this.lblEstate.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // bxEstateCountry
            // 
            this.bxEstateCountry.FormattingEnabled = true;
            this.bxEstateCountry.Location = new System.Drawing.Point(160, 138);
            this.bxEstateCountry.Name = "bxEstateCountry";
            this.bxEstateCountry.Size = new System.Drawing.Size(234, 31);
            this.bxEstateCountry.TabIndex = 14;
            this.bxEstateCountry.Text = "Select...";
            // 
            // bxSellerCountry
            // 
            this.bxSellerCountry.FormattingEnabled = true;
            this.bxSellerCountry.Location = new System.Drawing.Point(159, 185);
            this.bxSellerCountry.Name = "bxSellerCountry";
            this.bxSellerCountry.Size = new System.Drawing.Size(234, 31);
            this.bxSellerCountry.TabIndex = 26;
            this.bxSellerCountry.Text = "Select...";
            // 
            // bxBuyerCountry
            // 
            this.bxBuyerCountry.FormattingEnabled = true;
            this.bxBuyerCountry.Location = new System.Drawing.Point(166, 184);
            this.bxBuyerCountry.Name = "bxBuyerCountry";
            this.bxBuyerCountry.Size = new System.Drawing.Size(234, 31);
            this.bxBuyerCountry.TabIndex = 28;
            this.bxBuyerCountry.Text = "Select...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 966);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlRegister);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Real Estate Agent";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRegister)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSeller.ResumeLayout(false);
            this.pnlSeller.PerformLayout();
            this.pnlBuyer.ResumeLayout(false);
            this.pnlBuyer.PerformLayout();
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
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlEstateInfo;
        private System.Windows.Forms.Label lblEstate;
        private System.Windows.Forms.Label lblEstateCountry;
        private System.Windows.Forms.Label lblEstateCity;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblPresentID;
        private System.Windows.Forms.Panel pnlBuyer;
        private System.Windows.Forms.Label lblBuyerLName;
        private System.Windows.Forms.Label lblBuyerZip;
        private System.Windows.Forms.Label lblBuyerCity;
        private System.Windows.Forms.Label lblBuyerStreet;
        private System.Windows.Forms.Label lblBuyerCountry;
        private System.Windows.Forms.Label lblEstateZip;
        private System.Windows.Forms.Label lblEstateStreet;
        private System.Windows.Forms.Label lblBuyer;
        private System.Windows.Forms.Panel pnlSeller;
        private System.Windows.Forms.Label lblSeller;
        private System.Windows.Forms.Label lblSellerLName;
        private System.Windows.Forms.Label lblSellerZip;
        private System.Windows.Forms.Label lblSellerCity;
        private System.Windows.Forms.Label lblSellerStreet;
        private System.Windows.Forms.Label lblSellerCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeller;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPayment;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtBuyerLName;
        private System.Windows.Forms.TextBox txtBuyerZip;
        private System.Windows.Forms.TextBox txtBuyerStreet;
        private System.Windows.Forms.TextBox txtBuyerCity;
        private System.Windows.Forms.TextBox txtEstateZip;
        private System.Windows.Forms.TextBox txtEstateStreet;
        private System.Windows.Forms.TextBox txtEstateCity;
        private System.Windows.Forms.TextBox txtSellerLName;
        private System.Windows.Forms.TextBox txtSellerZip;
        private System.Windows.Forms.TextBox txtSellerStreet;
        private System.Windows.Forms.TextBox txtSellerCity;
        private System.Windows.Forms.TextBox txtSellerFName;
        private System.Windows.Forms.Label lblSellerFName;
        private System.Windows.Forms.TextBox txtBuyerFName;
        private System.Windows.Forms.Label lblBuyerFName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.RadioButton rbtnPP;
        private System.Windows.Forms.RadioButton rbtnWU;
        private System.Windows.Forms.RadioButton rbtnBank;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnBrowseImg;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox bxSellerCountry;
        private System.Windows.Forms.ComboBox bxBuyerCountry;
        private System.Windows.Forms.ComboBox bxEstateCountry;
    }
}

