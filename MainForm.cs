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
        private EstateManager estateManager = new EstateManager();
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

            EnabledInfoFields(false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReadEstateAdd();

            ClearFields();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            EnabledInfoFields(false);
            ReadEstateInfo();
            // Add estate to Register.
            List<IEstate> lstEstates = estateManager.AddEstateToRegister();
            lstbxRegister.Items.Clear();
            lstbxRegister.Items.AddRange(lstEstates.ToArray());
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnabledInfoFields(false);

            ClearFields();
        }

        private void ReadEstateInfo()
        {

            LegalForm enumLegalForm = (LegalForm)bxLegalForm.SelectedItem;

            Countries enumCountry = (Countries)bxEstateCountry.SelectedItem;
            String strCity = txtEstateCity.Text;
            String strStreet = txtEstateStreet.Text;
            String strZipCode = txtEstateZip.Text;

            Address address = new Address();
            address.Country = enumCountry;
            address.City = strCity;
            address.Street = strStreet;
            address.ZipCode = strZipCode;

            estateManager.SetAddress(address);
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
            IEstate estate = estateManager.CreateEstate(enumEstateType);

            lblShowEstateID.Text = estate.EstateID.ToString();

            EnabledInfoFields(true);
        }

        private bool EnabledInfoFields(bool inEnabled)
        {
            bool enabled = inEnabled;

            txtAmount.Enabled = enabled;
            txtBuyerCity.Enabled = enabled;
            txtBuyerFName.Enabled = enabled;
            txtBuyerLName.Enabled = enabled;
            txtBuyerStreet.Enabled = enabled;
            txtBuyerZip.Enabled = enabled;
            txtComment.Enabled = enabled;
            txtEstateCity.Enabled = enabled;
            txtEstateStreet.Enabled = enabled;
            txtEstateZip.Enabled = enabled;
            txtSellerCity.Enabled = enabled;
            txtSellerFName.Enabled = enabled;
            txtSellerLName.Enabled = enabled;
            txtSellerStreet.Enabled = enabled;
            txtSellerZip.Enabled = enabled;

            bxBuyerCountry.Enabled = enabled;
            bxEstateCountry.Enabled = enabled;
            bxLegalForm.Enabled = enabled;
            bxPaymentMethod.Enabled = enabled;
            bxSellerCountry.Enabled = enabled;

            btnConfirm.Enabled = enabled;
            btnCancel.Enabled = enabled;
            btnBrowseImg.Enabled = enabled;

            bxEstateType.Enabled = !enabled;

            btnAdd.Enabled = !enabled;
            btnChange.Enabled = !enabled;
            btnDelete.Enabled = !enabled;
            
            lstbxRegister.Enabled = !enabled;

            return enabled;
        }

        private void ClearFields()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);

                foreach (Control control in controls)
                    if (control is ComboBox)
                        (control as ComboBox).SelectedIndex = -1;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
    }
}
