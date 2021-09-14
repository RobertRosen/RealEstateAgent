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
            ClearFields();
            ReadEstateAdd();

            testValues();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            EnabledInfoFields(false);
            ReadEstateInfo();
            ReadBuyerInfo();
            ReadSellerInfo();
            ReadPaymentInfo();
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
            Countries enumCountry = (Countries)bxEstateCountry.SelectedItem;
            String strCity = txtEstateCity.Text;
            String strStreet = txtEstateStreet.Text;
            String strZipCode = txtEstateZip.Text;

            Address address = new Address();
            address.Country = enumCountry;
            address.City = strCity;
            address.Street = strStreet;
            address.ZipCode = strZipCode;

            int selIndex = lstbxRegister.SelectedIndex;
            if ((selIndex > -1) && (lstbxRegister.SelectedItem.GetType() == typeof(Apartment)))
            {
                bxLegalForm.Show();
                LegalForm enumLegalForm = (LegalForm)bxLegalForm.SelectedItem;
                estateManager.SetEstateInfo(address, enumLegalForm);
            }
            else
            {
                bxLegalForm.Hide();
                estateManager.SetEstateInfo(address);
            }
        }

        private void ReadSellerInfo()
        {
            Countries enumCountry = (Countries)bxSellerCountry.SelectedItem;
            String strFName = txtSellerFName.Text;
            String strLName = txtSellerLName.Text;
            String strCity = txtSellerCity.Text;
            String strStreet = txtSellerStreet.Text;
            String strZipCode = txtSellerZip.Text;

            Address address = new Address();
            address.Country = enumCountry;
            address.City = strCity;
            address.Street = strStreet;
            address.ZipCode = strZipCode;

            estateManager.SetSellerInfo(address, strFName, strLName);
        }

        private void ReadBuyerInfo()
        {
            Countries enumCountry = (Countries)bxBuyerCountry.SelectedItem;
            String strFName = txtBuyerFName.Text;
            String strLName = txtBuyerLName.Text;
            String strCity = txtBuyerCity.Text;
            String strStreet = txtBuyerStreet.Text;
            String strZipCode = txtBuyerZip.Text;

            Address address = new Address();
            address.Country = enumCountry;
            address.City = strCity;
            address.Street = strStreet;
            address.ZipCode = strZipCode;

            estateManager.SetBuyerInfo(address, strFName, strLName);
        }

        private void ReadPaymentInfo()
        {
            PaymentMethods enumPayment = (PaymentMethods)bxPaymentMethod.SelectedItem;
            String amount = txtAmount.Text;
            String comment = txtComment.Text;

            estateManager.SetPaymentInfo(enumPayment, amount, comment);
        }

        private void ReadEstateAdd()
        {
            //int selIndex = lstbxRegister.SelectedIndex;
            //if (bxEstateType.SelectedItem.GetType() == typeof(Apartment))
            //{
            //    bxLegalForm.Show();
            //}
            //else
            //{
            //    bxLegalForm.Hide();
            //}

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
            lblShowEstateID.ResetText();

            bxEstateCountry.SelectedIndex = -1;
            bxSellerCountry.SelectedIndex = -1;
            bxBuyerCountry.SelectedIndex = -1;
            bxLegalForm.SelectedIndex = -1;
            bxPaymentMethod.SelectedIndex = -1;

            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                    else
                    {
                        func(control.Controls);
                    }
                }
            };

            func(Controls);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            EnabledInfoFields(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selIndex = lstbxRegister.SelectedIndex;
            lstbxRegister.Items.RemoveAt(selIndex);
            estateManager.DeleteFromRegister(selIndex);
            ClearFields();
        }

        private void testValues()
        {
            bxEstateCountry.SelectedIndex = 0;
            bxSellerCountry.SelectedIndex = 0;
            bxBuyerCountry.SelectedIndex = 0;
            bxLegalForm.SelectedIndex = 0;
            bxPaymentMethod.SelectedIndex = 0;

            txtAmount.Text = "1";
            txtComment.Text = "Hej";

            txtEstateCity.Text = "Malmö";
            txtEstateStreet.Text = "HEJVägen";
            txtEstateZip.Text = "12345";

            txtSellerFName.Text = "Joakim";
            txtSellerLName.Text = "Tell";
            txtSellerCity.Text = "Skurup";
            txtSellerStreet.Text = "Byvägen 1234";
            txtSellerZip.Text = "09876";

            txtBuyerFName.Text = "Farid";
            txtBuyerLName.Text = "Farid";
            txtBuyerCity.Text = "SKURUP";
            txtBuyerStreet.Text = "Dåvägen 2";
            txtBuyerZip.Text = "54321";
        }

        private void lstbxRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = lstbxRegister.SelectedIndex;
            if (selIndex > -1)
            {
                IEstate selItem = (IEstate)lstbxRegister.SelectedItem;

                if (selItem.GetType() == typeof(Apartment))
                {
                    bxLegalForm.SelectedItem = ((Apartment)selItem).LegalForm;
                }
                else
                {
                    bxLegalForm.SelectedIndex = -1;
                }

                lblShowEstateID.Text = selItem.EstateID.ToString();

                txtEstateCity.Text = selItem.Address.City;
                bxEstateCountry.SelectedItem = selItem.Address.Country;
                txtEstateStreet.Text = selItem.Address.Street;
                txtEstateZip.Text = selItem.Address.ZipCode;

                bxPaymentMethod.SelectedItem = selItem.Payment.Method;
                txtAmount.Text = selItem.Payment.Amount.ToString();
                txtComment.Text = selItem.Payment.Comment;

                txtSellerFName.Text = selItem.Seller.FirstName;
                txtSellerLName.Text = selItem.Seller.LastName;
                txtSellerCity.Text = selItem.Seller.Address.City;
                bxSellerCountry.SelectedItem = selItem.Seller.Address.Country;
                txtSellerStreet.Text = selItem.Seller.Address.Street;
                txtSellerZip.Text = selItem.Seller.Address.ZipCode;

                txtBuyerFName.Text = selItem.Buyer.FirstName;
                txtBuyerLName.Text = selItem.Buyer.LastName;
                txtBuyerCity.Text = selItem.Buyer.Address.City;
                bxBuyerCountry.SelectedItem = selItem.Buyer.Address.Country;
                txtBuyerStreet.Text = selItem.Buyer.Address.Street;
                txtBuyerZip.Text = selItem.Buyer.Address.ZipCode;
            }
        }

        private void btnBrowseImg_Click(object sender, EventArgs e)
        {

        }
    }
}
