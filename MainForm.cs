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
    public partial class MainForm : Form
    {
        private List<IEstate> lstEstates = new List<IEstate>();
        private IEstate estate = null;
        private int estateIDCounter = 0;

        public MainForm()
        {
            InitializeComponent();
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

            ShowApartmentComponents(false); // Show Legal form...

            EnableInfoFields(false);
        }

        private void ShowApartmentComponents(bool show)
        {
            if (show)
                bxLegalForm.Show();
            else
                bxLegalForm.Hide();
        }

        private IEstate AddEstateToRegister()
        {
            if (estate != null)
            {
                for (int i = 0; i<lstEstates.Count; i++)
                {
                    if (lstEstates[i].EstateID == estate.EstateID)
                    {
                        lstEstates[i] = estate;
                        return estate;
                    }
                }
                lstEstates.Add(estate);
                estateIDCounter++;
            }
            return estate;
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
                ((Apartment)estate).LegalForm = enumLegalForm;
            }
            else bxLegalForm.Hide();

            estate.Address = address;
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

            estate.Seller = new Seller();
            ((Seller)estate.Seller).FirstName = strFName;
            ((Seller)estate.Seller).LastName = strLName;
            ((Seller)estate.Seller).Address = address;
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

            estate.Buyer = new Buyer();
            ((Buyer)estate.Buyer).FirstName = strFName;
            ((Buyer)estate.Buyer).LastName = strLName;
            ((Buyer)estate.Buyer).Address = address;
        }

        private void ReadPaymentInfo()
        {
            PaymentMethods enumPayment = (PaymentMethods)bxPaymentMethod.SelectedItem;
            String amount = txtAmount.Text;
            String comment = txtComment.Text;

            Payment payment = null;
            switch (enumPayment)
            {
                case PaymentMethods.Bank:
                    {
                        payment = new Bank();
                        ((Bank)payment).Name = "Hardcoded Name";
                        ((Bank)payment).Accountnumber = "123456789-0";
                        break;
                    }
                case PaymentMethods.Western_Union:
                    {
                        payment = new WesternUnion();
                        ((WesternUnion)payment).Name = "Hardcoded Name";
                        ((WesternUnion)payment).Email = "hardcoded@email.com";
                        break;
                    }
                case PaymentMethods.PayPal:
                    {
                        payment = new PayPal();
                        ((PayPal)payment).Email = "hardcoded@email.com";
                        break;
                    }
                default: break;
            }

            payment.Amount = Convert.ToDouble(amount);
            payment.Comment = comment;

            estate.Payment = payment;
        }

        private void ReadEstateTypeToAdd()
        {
            EstateType enumEstateType = (EstateType)bxEstateType.SelectedItem;

            if (enumEstateType is EstateType.Apartment)
                ShowApartmentComponents(true);
            else
                ShowApartmentComponents(false);

            IEstate estate = CreateEstate(enumEstateType);
            estate.EstateID = estateIDCounter + 1;

            lblShowEstateID.Text = estate.EstateID.ToString();
        }

        public IEstate CreateEstate(EstateType estateType) => estateType switch
        {
            EstateType.Apartment    => estate = new Apartment(),
            EstateType.School       => estate = new School(),
            EstateType.Store        => estate = new Store(),
            EstateType.University   => estate = new University(),
            EstateType.Villa        => estate = new Villa(),
            EstateType.Warehouse    => estate = new Warehouse(),
            _                       => throw new ArgumentException(message: "Invalid enum value", paramName: nameof(estateType))
        };

        private void EnableInfoFields(bool enabled)
        {
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

            bxEstateType.Enabled = !enabled;
            bxBuyerCountry.Enabled = enabled;
            bxEstateCountry.Enabled = enabled;
            bxLegalForm.Enabled = enabled;
            bxPaymentMethod.Enabled = enabled;
            bxSellerCountry.Enabled = enabled;

            btnConfirm.Enabled = enabled;
            btnCancel.Enabled = enabled;
            btnBrowseImg.Enabled = enabled;
            btnAdd.Enabled = !enabled;
            btnChange.Enabled = !enabled;
            btnDelete.Enabled = !enabled;

            lstbxRegister.Enabled = !enabled;
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
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
                }
            };
            func(Controls);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
            ReadEstateTypeToAdd();
            EnableInfoFields(true);

            testValues();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            EnableInfoFields(false);

            ReadEstateInfo();
            ReadBuyerInfo();
            ReadSellerInfo();
            ReadPaymentInfo();

            AddEstateToRegister();
            lstbxRegister.Items.Clear();
            lstbxRegister.Items.AddRange(lstEstates.ToArray());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ShowApartmentComponents(false);
            EnableInfoFields(false);
            ClearFields();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            EnableInfoFields(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selIndex = lstbxRegister.SelectedIndex;
            lstbxRegister.Items.RemoveAt(selIndex);
            lstEstates.RemoveAt(selIndex);
            ClearFields();
        }

        private void lstbxRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = lstbxRegister.SelectedIndex;
            if (selIndex > -1)
            {
                IEstate selItem = (IEstate)lstbxRegister.SelectedItem;
                estate = selItem;

                if (selItem.GetType() == typeof(Apartment))
                {
                    bxLegalForm.SelectedItem = ((Apartment)selItem).LegalForm;
                    ShowApartmentComponents(true);
                }
                else
                {
                    bxLegalForm.SelectedIndex = -1;
                    ShowApartmentComponents(false);
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

        private void testValues()
        {
            bxEstateCountry.SelectedIndex = 0;
            bxSellerCountry.SelectedIndex = 0;
            bxBuyerCountry.SelectedIndex = 0;
            //bxLegalForm.SelectedIndex = 0;
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
    }
}
