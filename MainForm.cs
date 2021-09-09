using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RealEstateAgent
{
    /// <summary>
    /// MVC
    /// 1. The form is the view. It sends commands to the model, raises events which the controller can subscribe to, and subscribes to events from the model.
    /// 2. The controller is a class that subscribes to the view's events and sends commands to the view and to the model.
    /// 3. The model raises events that the view subscribes to.
    /// </summary>
    public partial class MainForm : Form
    {
        private EstateManager estateManager = new EstateManager(this);
        public MainForm()
        {
            InitializeComponent();

            //Our Code
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            bxEstateCountry.DataSource = Enum.GetValues(typeof(Countries));
            bxSellerCountry.DataSource = Enum.GetValues(typeof(Countries));
            bxBuyerCountry.DataSource = Enum.GetValues(typeof(Countries));
            bxLegalForm.DataSource = Enum.GetValues(typeof(LegalForm));
            bxPaymentMethod.DataSource = Enum.GetValues(typeof(PaymentMethods));
            bxEstateType.DataSource = Enum.GetValues(typeof(EstateType));

            bxEstateCountry.SelectedIndex = -1;
            bxSellerCountry.SelectedIndex = -1;
            bxBuyerCountry.SelectedIndex = -1;
            bxLegalForm.SelectedIndex = -1;
            bxPaymentMethod.SelectedIndex = -1;
            bxEstateType.SelectedIndex = -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadEstateAdd();
            //Read Input
            bool ok = ReadInput();
        }

        private bool ReadInput()
        {
            bool ok = true;
            ReadEstateInfo();

            return ok;
        }

        private void ReadEstateInfo()
        {
            LegalForm enumLegalForm = (LegalForm)bxLegalForm.SelectedItem;
            Countries enumCountry = (Countries)bxEstateCountry.SelectedItem;
            String strCity = txtEstateCity.Text;
            String strStreet = txtEstateStreet.Text;
            String strZipCode = txtEstateZip.Text;
        }

        private void ReadSellerInfo()
        {
            Countries enumCountry = (Countries)bxSellerCountry.SelectedItem;
            String strFName = txtSellerFName.Text;
            String strLName = txtSellerLName.Text;
            String strCity = txtSellerCity.Text;
            String strStreet = txtSellerStreet.Text;
            String strZipCode = txtSellerZip.Text;
        }

        private void ReadBuyerInfo()
        {
            Countries enumCountry = (Countries)bxBuyerCountry.SelectedItem;
            String strFName = txtBuyerFName.Text;
            String strLName = txtBuyerLName.Text;
            String strCity = txtBuyerCity.Text;
            String strStreet = txtBuyerStreet.Text;
            String strZipCode = txtBuyerZip.Text;
        }

        private void ReadPaymentInfo()
        {
            PaymentMethods enumPayment = (PaymentMethods)bxPaymentMethod.SelectedItem;
            String strAmount = bxPaymentMethod.Text;
            String strComment = bxPaymentMethod.Text;
        }

        private void ReadEstateAdd()
        {
            EstateType enumEstateType = (EstateType)bxEstateType.SelectedItem;
            estateManager.CreateEstate(enumEstateType);
        }
        
        public void SetEstateID(int ID)
        {
            lblPresentID.Text = ID.ToString();
        }
    }
}
