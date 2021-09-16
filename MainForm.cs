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

            EnableInfoFields(false);
            EnableButtons(false);
        }

        private IEstate AddEstateToRegister()
        {
            if (estate != null)
            {
                for (int i = 0; i < lstEstates.Count; i++)
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
            LegalForm legalForm = (LegalForm)bxLegalForm.SelectedItem;

            Countries enumCountry = (Countries)bxEstateCountry.SelectedItem;
            String strCity = txtEstateCity.Text;
            String strStreet = txtEstateStreet.Text;
            String strZipCode = txtEstateZip.Text;

            Address address = new Address();
            address.Country = enumCountry;
            address.City = strCity;
            address.Street = strStreet;
            address.ZipCode = strZipCode;

            estate.LegalForm = legalForm;
            estate.Address = address;
        }

        private void ReadSpecificInfo()
        {
            string str1 = txtSpecific1.Text;
            string str2 = txtSpecific2.Text;
            string str3 = txtSpecific3.Text;

            if (estate.GetType() == typeof(Rental))
            {
                ((Rental)estate).SquareMeter = Convert.ToInt32(str1);
                ((Rental)estate).Floor = Convert.ToInt32(str2);
                ((Rental)estate).ContractMonths = Convert.ToInt32(str3);
            }
            else if (estate.GetType() == typeof(School))
            {
                ((School)estate).NumberOfCafeterias = Convert.ToInt32(str1);
                ((School)estate).NumberOfClassrooms = Convert.ToInt32(str2);
                ((School)estate).SuitableLevel = str3;
            }
            else if (estate.GetType() == typeof(Store))
            {
                ((Store)estate).StorageSquareMeters = Convert.ToInt32(str1);
                ((Store)estate).SuitableBusiness = str2;
            }
            else if (estate.GetType() == typeof(Tenement))
            {
                ((Tenement)estate).SquareMeter = Convert.ToInt32(str1);
                ((Tenement)estate).Floor = Convert.ToInt32(str2);
                ((Tenement)estate).TenantOwnersAssociationName = str3;
            }
            else if (estate.GetType() == typeof(Townhouse))
            {
                ((Townhouse)estate).SquareMeter = Convert.ToInt32(str1);
                ((Townhouse)estate).GardenSquareMeters = Convert.ToInt32(str2);
                ((Townhouse)estate).NumberOfConnectedVillas = Convert.ToInt32(str3);
            }
            else if (estate.GetType() == typeof(University))
            {
                ((University)estate).NumberOfCafeterias = Convert.ToInt32(str1);
                ((University)estate).NumberOfClassrooms = Convert.ToInt32(str2);
                ((University)estate).NumberOfLectureHalls = Convert.ToInt32(str3);
            }
            else if (estate.GetType() == typeof(Villa))
            {
                ((Villa)estate).SquareMeter = Convert.ToInt32(str1);
                ((Villa)estate).GardenSquareMeters = Convert.ToInt32(str2);
            }
            else if (estate.GetType() == typeof(Warehouse))
            {
                ((Warehouse)estate).StorageSquareMeters = Convert.ToInt32(str1);
                ((Warehouse)estate).NumberOfLoadingDocks = Convert.ToInt32(str2);
            }
            else
            {
                //Handle this...
            }
        }

        private void ReadImageInfo()
        {
            estate.Image = pctbxEstateImage.Image;
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
            estate = CreateEstate(enumEstateType);
            SetSpecificInfo(enumEstateType);
            estate.EstateID = estateIDCounter + 1;

            lblShowEstateID.Text = estate.EstateID.ToString();
        }

        public IEstate CreateEstate(EstateType estateType) => estateType switch
        {
            EstateType.Rental => estate = new Rental(),
            EstateType.School => estate = new School(),
            EstateType.Store => estate = new Store(),
            EstateType.Tenement => estate = new Tenement(),
            EstateType.Townhouse => estate = new Townhouse(),
            EstateType.University => estate = new University(),
            EstateType.Villa => estate = new Villa(),
            EstateType.Warehouse => estate = new Warehouse(),
            _ => throw new ArgumentException(message: "Invalid enum value", paramName: nameof(estateType))
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

            btnBrowseImg.Enabled = enabled;

            txtSpecific1.Enabled = enabled;
            txtSpecific2.Enabled = enabled;
            txtSpecific3.Enabled = enabled;

            lstbxRegister.Enabled = !enabled;
        }

        private void EnableButtons(bool enabled)
        {
            btnConfirm.Enabled = !enabled;
            btnCancel.Enabled = !enabled;

            btnAdd.Enabled = enabled;
            btnChange.Enabled = enabled;
            btnDelete.Enabled = enabled;
        }

        private void ClearFields()
        {
            lblShowEstateID.ResetText();

            bxEstateCountry.SelectedIndex = -1;
            bxSellerCountry.SelectedIndex = -1;
            bxBuyerCountry.SelectedIndex = -1;
            bxLegalForm.SelectedIndex = -1;
            bxPaymentMethod.SelectedIndex = -1;

            pctbxEstateImage.Image = null;

            txtAmount.Clear();
            txtComment.Clear();

            txtEstateCity.Clear();
            txtEstateStreet.Clear();
            txtEstateZip.Clear();

            txtSellerFName.Clear();
            txtSellerLName.Clear();
            txtSellerCity.Clear();
            txtSellerStreet.Clear();
            txtSellerZip.Clear();

            txtBuyerFName.Clear();
            txtBuyerLName.Clear();
            txtBuyerCity.Clear();
            txtBuyerStreet.Clear();
            txtBuyerZip.Clear();

            txtSpecific1.Clear();
            txtSpecific2.Clear();
            txtSpecific3.Clear();
        }

        private void SetSpecificLabels(string lbl1, string lbl2, string lbl3)
        {
            lblSpecific1.Text = lbl1;
            lblSpecific2.Text = lbl2;
            lblSpecific3.Text = lbl3;
        }

        private void SetSpecificInfo(EstateType estateType)
        {
            switch (estateType)
            {
                case EstateType.Rental:
                    {
                        SetSpecificLabels("Area (m²)", "Floor number", "Contract months");
                        txtSpecific3.Visible = true;
                        break;
                    }
                case EstateType.School:
                    {
                        SetSpecificLabels("Number of cafeterias", "Number of classrooms", "Suitable school level");
                        txtSpecific3.Visible = true;
                        break;
                    }
                case EstateType.Store:
                    {
                        SetSpecificLabels("Storage space (m²)", "Suitable business", "");
                        txtSpecific3.Visible = false;
                        break;
                    }
                case EstateType.Tenement:
                    {
                        SetSpecificLabels("Area (m²)", "Floor number", "Tenants association");
                        txtSpecific3.Visible = true;
                        break;
                    }
                case EstateType.Townhouse:
                    {
                        SetSpecificLabels("Area (m²)", "Garden area (m²)", "Number of connected villas");
                        txtSpecific3.Visible = true;
                        break;
                    }
                case EstateType.University:
                    {
                        SetSpecificLabels("Number of cafeterias", "Number of classrooms", "Number of lecture halls");
                        txtSpecific3.Visible = true;
                        break;
                    }
                case EstateType.Villa:
                    {
                        SetSpecificLabels("Area (m²)", "Garden area (m²)", "");
                        txtSpecific3.Visible = false;
                        break;
                    }
                case EstateType.Warehouse:
                    {
                        SetSpecificLabels("Storage space (m²)", "Number of loading docks", "");
                        txtSpecific3.Visible = false;
                        break;
                    }
                default: break;
            }
        }

        private void SetSpecificInfoText(IEstate estate)
        {
            if (estate.GetType() == typeof(Rental))
            {
                SetSpecificInfo(EstateType.Rental);
                txtSpecific1.Text = ((Rental)estate).SquareMeter.ToString();
                txtSpecific2.Text = ((Rental)estate).Floor.ToString();
                txtSpecific3.Text = ((Rental)estate).ContractMonths.ToString();
            }
            else if (estate.GetType() == typeof(School))
            {
                SetSpecificInfo(EstateType.School);
                txtSpecific1.Text = ((School)estate).NumberOfCafeterias.ToString();
                txtSpecific2.Text = ((School)estate).NumberOfClassrooms.ToString();
                txtSpecific3.Text = ((School)estate).SuitableLevel.ToString();
            }
            else if (estate.GetType() == typeof(Store))
            {
                SetSpecificInfo(EstateType.Store);
                txtSpecific1.Text = ((Store)estate).StorageSquareMeters.ToString();
                txtSpecific2.Text = ((Store)estate).SuitableBusiness.ToString();
                txtSpecific3.Text = "";
            }
            else if (estate.GetType() == typeof(Tenement))
            {
                SetSpecificInfo(EstateType.Tenement);
                txtSpecific1.Text = ((Tenement)estate).SquareMeter.ToString();
                txtSpecific2.Text = ((Tenement)estate).Floor.ToString();
                txtSpecific3.Text = ((Tenement)estate).TenantOwnersAssociationName.ToString();
            }
            else if (estate.GetType() == typeof(Townhouse))
            {
                SetSpecificInfo(EstateType.Townhouse);
                txtSpecific1.Text = ((Townhouse)estate).SquareMeter.ToString();
                txtSpecific2.Text = ((Townhouse)estate).GardenSquareMeters.ToString();
                txtSpecific3.Text = ((Townhouse)estate).NumberOfConnectedVillas.ToString();
            }
            else if (estate.GetType() == typeof(University))
            {
                SetSpecificInfo(EstateType.University);
                txtSpecific1.Text = ((University)estate).NumberOfCafeterias.ToString();
                txtSpecific2.Text = ((University)estate).NumberOfClassrooms.ToString();
                txtSpecific3.Text = ((University)estate).NumberOfLectureHalls.ToString();
            }
            else if (estate.GetType() == typeof(Villa))
            {
                SetSpecificInfo(EstateType.Villa);
                txtSpecific1.Text = ((Villa)estate).SquareMeter.ToString();
                txtSpecific2.Text = ((Villa)estate).GardenSquareMeters.ToString();
                txtSpecific3.Text = "";
            }
            else if (estate.GetType() == typeof(Warehouse))
            {
                SetSpecificInfo(EstateType.Warehouse);
                txtSpecific1.Text = ((Warehouse)estate).StorageSquareMeters.ToString();
                txtSpecific2.Text = ((Warehouse)estate).NumberOfLoadingDocks.ToString();
                txtSpecific3.Text = "";
            }
            else
            {
                //Handle this...
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearFields();
            ReadEstateTypeToAdd();
            EnableInfoFields(true);
            EnableButtons(false);

            testValues();

            lstbxRegister.SelectedIndex = -1;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            EnableInfoFields(false);
            EnableButtons(true);

            ReadEstateInfo();
            ReadBuyerInfo();
            ReadSellerInfo();
            ReadPaymentInfo();
            ReadImageInfo();
            ReadSpecificInfo();

            AddEstateToRegister();
            lstbxRegister.Items.Clear();
            lstbxRegister.Items.AddRange(lstEstates.ToArray());

            lstbxRegister.SelectedItem = estate;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnableInfoFields(false);
            EnableButtons(true);

            ClearFields();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            EnableInfoFields(true);
            EnableButtons(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selIndex = lstbxRegister.SelectedIndex;
            lstbxRegister.Items.RemoveAt(selIndex);
            lstEstates.RemoveAt(selIndex);
            ClearFields();
            lstbxRegister.SelectedIndex = 0;
        }

        private void btnBrowseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            pctbxEstateImage.Image = new Bitmap(openFile.FileName);
        }

        private void lstbxRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = lstbxRegister.SelectedIndex;
            if (selIndex > -1)
            {
                IEstate selItem = (IEstate)lstbxRegister.SelectedItem;
                estate = selItem;

                lblShowEstateID.Text = selItem.EstateID.ToString();
                bxLegalForm.SelectedItem = selItem.LegalForm;

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

                pctbxEstateImage.Image = selItem.Image;

                SetSpecificInfoText(selItem);
            }
        }

        private void bxEstateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bxEstateType.SelectedIndex > -1)
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
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
    }
}
