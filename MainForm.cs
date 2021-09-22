// Joakim Tell & Robert Rosencrantz

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
using System.IO;

namespace RealEstateAgent
{
    public partial class MainForm : Form
    {
        //private List<IEstate> lstEstates = new List<IEstate>();
        private IEstate estate = null;
        //private int estateIDCounter = 0;

        private EstateManager estateManager;

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
            estateManager = new EstateManager();
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
            bxEstateType.SelectedIndex = 0;

            EnableInfoFields(false);
        }

        //private IEstate AddEstateToRegister()
        //{
        //    if (estate != null)
        //    {
        //        for (int i = 0; i < lstEstates.Count; i++)
        //        {
        //            if (lstEstates[i].EstateID == estate.EstateID)
        //            {
        //                lstEstates[i] = estate;
        //                return estate;
        //            }
        //        }
        //        lstEstates.Add(estate);
        //        estateIDCounter++;
        //    }
        //    return estate;
        //}

        public IEstate CreateEstateDynamic(EstateType estateType) => estateType switch
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

        public Payment CreatePaymentDynamic(PaymentMethods paymentMethod) => paymentMethod switch
        {
            PaymentMethods.Bank => estate.Payment = new Bank(),
            PaymentMethods.PayPal => estate.Payment = new PayPal(),
            PaymentMethods.Western_Union => estate.Payment = new WesternUnion(),
            _ => throw new ArgumentException(message: "Invalid enum value", paramName: nameof(paymentMethod))
        };

        //private void ReadEstateTypeAndAdd()
        //{
        //    EstateType enumEstateType = (EstateType)bxEstateType.SelectedItem;
        //    estate = CreateEstateDynamic(enumEstateType);
        //    SetEstateSpecificComponents(enumEstateType);
        //    //estate.EstateID = estateIDCounter + 1;

        //    lblShowEstateID.Text = estate.EstateID.ToString();
        //}

        private bool ReadEstateInfo()
        {
            bool inputOk;

            if (bxLegalForm.SelectedIndex > -1 && bxLegalForm.SelectedIndex > -1)
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

                inputOk = true;
            }
            else
            {
                inputOk = false;
            }
            return inputOk;
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

        private bool ReadPaymentInfo()
        {
            bool inputOk;

            if (bxPaymentMethod.SelectedIndex > -1)
            {
                PaymentMethods enumPayment = (PaymentMethods)bxPaymentMethod.SelectedItem;
                CreatePaymentDynamic(enumPayment);

                if (int.TryParse(txtAmount.Text, out int amount))
                {
                    estate.Payment.Amount = amount;

                    inputOk = true;
                }
                else
                {
                    inputOk = false;
                }
            }
            else
            {
                inputOk = false;
            }

            return inputOk;
        }

        private void ReadSpecificInfo()
        {
            string str1 = txtSpecific1.Text;
            string str2 = txtSpecific2.Text;
            string str3 = txtSpecific3.Text;

            bool inputOk;

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

        private void ReadPaymentSpecificInfo()
        {
            string str1 = txtPaySpecific1.Text;
            string str2 = txtPaySpecific2.Text;

            if (estate.Payment.GetType() == typeof(Bank))
            {
                ((Bank)estate.Payment).Accountnumber = str1;
                ((Bank)estate.Payment).Name = str2;
            }
            else if (estate.Payment.GetType() == typeof(WesternUnion))
            {
                ((WesternUnion)estate.Payment).Email = str1;
                ((WesternUnion)estate.Payment).Name = str2;
            }
            else if (estate.Payment.GetType() == typeof(PayPal))
            {
                ((PayPal)estate.Payment).Email = str1;
            }
            else
            {
                //Handle this...
            }
        }

        private void EnableInfoFields(bool enabled)
        {
            txtAmount.Enabled = enabled;
            txtBuyerCity.Enabled = enabled;
            txtBuyerFName.Enabled = enabled;
            txtBuyerLName.Enabled = enabled;
            txtBuyerStreet.Enabled = enabled;
            txtBuyerZip.Enabled = enabled;
            txtPaySpecific1.Enabled = enabled;
            txtPaySpecific2.Enabled = enabled;
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
            txtPaySpecific1.Clear();
            txtPaySpecific2.Clear();

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

        ///Summary
        /// Gets the info about the chosen estate from the register and puts the info on the fields to be read.
        ///Summary
        private void SetEstateCommonInfo()
        {
            lblShowEstateID.Text = estate.EstateID.ToString();
            bxLegalForm.SelectedItem = estate.LegalForm;
            txtEstateCity.Text = estate.Address.City;
            bxEstateCountry.SelectedItem = estate.Address.Country;
            txtEstateStreet.Text = estate.Address.Street;
            txtEstateZip.Text = estate.Address.ZipCode;
            bxPaymentMethod.SelectedItem = estate.Payment.Method;
            txtAmount.Text = estate.Payment.Amount.ToString();
            txtSellerFName.Text = estate.Seller.FirstName;
            txtSellerLName.Text = estate.Seller.LastName;
            txtSellerCity.Text = estate.Seller.Address.City;
            bxSellerCountry.SelectedItem = estate.Seller.Address.Country;
            txtSellerStreet.Text = estate.Seller.Address.Street;
            txtSellerZip.Text = estate.Seller.Address.ZipCode;
            txtBuyerFName.Text = estate.Buyer.FirstName;
            txtBuyerLName.Text = estate.Buyer.LastName;
            txtBuyerCity.Text = estate.Buyer.Address.City;
            bxBuyerCountry.SelectedItem = estate.Buyer.Address.Country;
            txtBuyerStreet.Text = estate.Buyer.Address.Street;
            txtBuyerZip.Text = estate.Buyer.Address.ZipCode;
            pctbxEstateImage.Image = estate.Image;
        }

        private void SetEstateSpecificLabels(string lbl1, string lbl2, string lbl3)
        {
            lblSpecific1.Text = lbl1;
            lblSpecific2.Text = lbl2;
            lblSpecific3.Text = lbl3;
        }

        ///Summary
        ///The wanted information changes based on the estatetype.
        ///Summary
        private void SetEstateSpecificComponentsDynamically(EstateType estateType)
        {
            switch (estateType)
            {
                case EstateType.Rental:
                    {
                        SetEstateSpecificLabels("Area (m²)", "Floor number", "Contract months");
                        txtSpecific3.Visible = true;
                        break;
                    }
                case EstateType.School:
                    {
                        SetEstateSpecificLabels("Number of cafeterias", "Number of classrooms", "Suitable school level");
                        txtSpecific3.Visible = true;
                        break;
                    }
                case EstateType.Store:
                    {
                        SetEstateSpecificLabels("Storage space (m²)", "Suitable business", "");
                        txtSpecific3.Visible = false;
                        break;
                    }
                case EstateType.Tenement:
                    {
                        SetEstateSpecificLabels("Area (m²)", "Floor number", "Tenants association");
                        txtSpecific3.Visible = true;
                        break;
                    }
                case EstateType.Townhouse:
                    {
                        SetEstateSpecificLabels("Area (m²)", "Garden area (m²)", "Number of connected villas");
                        txtSpecific3.Visible = true;
                        break;
                    }
                case EstateType.University:
                    {
                        SetEstateSpecificLabels("Number of cafeterias", "Number of classrooms", "Number of lecture halls");
                        txtSpecific3.Visible = true;
                        break;
                    }
                case EstateType.Villa:
                    {
                        SetEstateSpecificLabels("Area (m²)", "Garden area (m²)", "");
                        txtSpecific3.Visible = false;
                        break;
                    }
                case EstateType.Warehouse:
                    {
                        SetEstateSpecificLabels("Storage space (m²)", "Number of loading docks", "");
                        txtSpecific3.Visible = false;
                        break;
                    }
                default: break;
            }
        }

        private void SetEstateSpecificInfo()
        {
            if (estate.GetType() == typeof(Rental))
            {
                SetEstateSpecificComponentsDynamically(EstateType.Rental);
                txtSpecific1.Text = ((Rental)estate).SquareMeter.ToString();
                txtSpecific2.Text = ((Rental)estate).Floor.ToString();
                txtSpecific3.Text = ((Rental)estate).ContractMonths.ToString();
                bxEstateType.SelectedItem = EstateType.Rental;
            }
            else if (estate.GetType() == typeof(School))
            {
                SetEstateSpecificComponentsDynamically(EstateType.School);
                txtSpecific1.Text = ((School)estate).NumberOfCafeterias.ToString();
                txtSpecific2.Text = ((School)estate).NumberOfClassrooms.ToString();
                txtSpecific3.Text = ((School)estate).SuitableLevel.ToString();
                bxEstateType.SelectedItem = EstateType.School;
            }
            else if (estate.GetType() == typeof(Store))
            {
                SetEstateSpecificComponentsDynamically(EstateType.Store);
                txtSpecific1.Text = ((Store)estate).StorageSquareMeters.ToString();
                txtSpecific2.Text = ((Store)estate).SuitableBusiness.ToString();
                txtSpecific3.Text = "";
                bxEstateType.SelectedItem = EstateType.Store;
            }
            else if (estate.GetType() == typeof(Tenement))
            {
                SetEstateSpecificComponentsDynamically(EstateType.Tenement);
                txtSpecific1.Text = ((Tenement)estate).SquareMeter.ToString();
                txtSpecific2.Text = ((Tenement)estate).Floor.ToString();
                txtSpecific3.Text = ((Tenement)estate).TenantOwnersAssociationName.ToString();
                bxEstateType.SelectedItem = EstateType.Tenement;
            }
            else if (estate.GetType() == typeof(Townhouse))
            {
                SetEstateSpecificComponentsDynamically(EstateType.Townhouse);
                txtSpecific1.Text = ((Townhouse)estate).SquareMeter.ToString();
                txtSpecific2.Text = ((Townhouse)estate).GardenSquareMeters.ToString();
                txtSpecific3.Text = ((Townhouse)estate).NumberOfConnectedVillas.ToString();
                bxEstateType.SelectedItem = EstateType.Townhouse;
            }
            else if (estate.GetType() == typeof(University))
            {
                SetEstateSpecificComponentsDynamically(EstateType.University);
                txtSpecific1.Text = ((University)estate).NumberOfCafeterias.ToString();
                txtSpecific2.Text = ((University)estate).NumberOfClassrooms.ToString();
                txtSpecific3.Text = ((University)estate).NumberOfLectureHalls.ToString();
                bxEstateType.SelectedItem = EstateType.University;
            }
            else if (estate.GetType() == typeof(Villa))
            {
                SetEstateSpecificComponentsDynamically(EstateType.Villa);
                txtSpecific1.Text = ((Villa)estate).SquareMeter.ToString();
                txtSpecific2.Text = ((Villa)estate).GardenSquareMeters.ToString();
                txtSpecific3.Text = "";
                bxEstateType.SelectedItem = EstateType.Villa;
            }
            else if (estate.GetType() == typeof(Warehouse))
            {
                SetEstateSpecificComponentsDynamically(EstateType.Warehouse);
                txtSpecific1.Text = ((Warehouse)estate).StorageSquareMeters.ToString();
                txtSpecific2.Text = ((Warehouse)estate).NumberOfLoadingDocks.ToString();
                txtSpecific3.Text = "";
                bxEstateType.SelectedItem = EstateType.Warehouse;
            }
            else
            {
                //Handle this...
            }
        }

        private void SetPaymentSpecificComponents(PaymentMethods enumPayment)
        {
            switch (enumPayment)
            {
                case PaymentMethods.Bank:
                    {
                        lblPaySpecific1.Text = "Account number";
                        lblPaySpecific2.Text = "Name";
                        lblPaySpecific2.Visible = true;
                        txtPaySpecific2.Visible = true;
                        break;
                    }
                case PaymentMethods.Western_Union:
                    {
                        lblPaySpecific1.Text = "e-mail";
                        lblPaySpecific2.Text = "Name";
                        lblPaySpecific2.Visible = true;
                        txtPaySpecific2.Visible = true;
                        break;
                    }
                case PaymentMethods.PayPal:
                    {
                        lblPaySpecific1.Text = "e-mail";
                        lblPaySpecific2.Text = "";
                        lblPaySpecific2.Visible = false;
                        txtPaySpecific2.Visible = false;
                        break;
                    }
                default: break;
            }
        }

        private void SetPaymentSpecificInfo()
        {
            if (estate.Payment.GetType() == typeof(Bank))
            {
                SetPaymentSpecificComponents(PaymentMethods.Bank);
                txtPaySpecific1.Text = ((Bank)estate.Payment).Accountnumber;
                txtPaySpecific2.Text = ((Bank)estate.Payment).Name;
                bxPaymentMethod.SelectedItem = PaymentMethods.Bank;
            }
            else if (estate.Payment.GetType() == typeof(WesternUnion))
            {
                SetPaymentSpecificComponents(PaymentMethods.Western_Union);
                txtPaySpecific1.Text = ((WesternUnion)estate.Payment).Email;
                txtPaySpecific2.Text = ((WesternUnion)estate.Payment).Name;
                bxPaymentMethod.SelectedItem = PaymentMethods.Western_Union;
            }
            else if (estate.Payment.GetType() == typeof(PayPal))
            {
                SetPaymentSpecificComponents(PaymentMethods.PayPal);
                txtPaySpecific1.Text = ((PayPal)estate.Payment).Email;
                txtPaySpecific2.Text = "";
                bxPaymentMethod.SelectedItem = PaymentMethods.PayPal;
            }
            else
            {
                //Handle this...
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            EstateType enumEstateType = (EstateType)bxEstateType.SelectedItem;
            int selIndex = lstbxRegister.SelectedIndex;

            // Update GUI. 
            SetEstateSpecificComponentsDynamically(enumEstateType);
            EnableInfoFields(false);
            EnableButtons(true);

            // Read and controll if user input is valid.
            // TODO: Do controlls of input!
            bool inputOk;
            inputOk = ReadEstateInfo();
            ReadBuyerInfo();
            ReadSellerInfo();
            inputOk = ReadPaymentInfo();
            ReadImageInfo();
            ReadSpecificInfo();
            ReadPaymentSpecificInfo();

            if (inputOk)
            {
                if (selIndex > -1) // Change an existing estate, if any is selected from register.
                {
                    estateManager.ChangeAt(estate, selIndex);
                    ClearFields();
                    if (lstbxRegister.Items.Count > 0)
                    {
                        lstbxRegister.SelectedIndex = 0;
                        EnableInfoFields(true);
                        EnableButtons(false);
                    }
                }
                else // Add a new estate, if no estate is selected in register.
                {
                    estate = CreateEstateDynamic(enumEstateType);
                    estateManager.Add(estate);
                }           

                // Update items visible in register and select added/changed estate.
                lstbxRegister.Items.Clear();
                lstbxRegister.Items.AddRange(estateManager.ToStringArray());
                lstbxRegister.SelectedItem = estate;
            }
            else
            {
                MessageBox.Show("Fill all info.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //EnableInfoFields(false);
            //EnableButtons(true);

            //ClearFields();
        }

        private void ConfirmEstate()
        {
            EnableInfoFields(false);
            EnableButtons(true);

            bool inputOk;
            inputOk = ReadEstateInfo();
            ReadBuyerInfo();
            ReadSellerInfo();
            inputOk = ReadPaymentInfo();
            ReadImageInfo();
            ReadSpecificInfo();
            ReadPaymentSpecificInfo();

            var confirmResult = MessageBox.Show("Confirm?", "Confirm ", MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                

                if (inputOk)
                {
                    //AddEstateToRegister();
                    estateManager.Add(estate);

                    lstbxRegister.Items.Clear();
                    //lstbxRegister.Items.AddRange(lstEstates.ToArray());
                    lstbxRegister.Items.AddRange(estateManager.ToStringArray());
                    lstbxRegister.SelectedItem = estate;
                }
                else
                {
                    MessageBox.Show("Fill all info.");
                }
            }
            else
            {
                EnableInfoFields(false);
                EnableButtons(true);
                ClearFields();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            estate = null;

            lstbxRegister.SelectedIndex = -1; //Deselect from register.

            ClearFields();
            //ReadEstateTypeAndAdd();
            //EstateType enumEstateType = (EstateType)bxEstateType.SelectedItem;
            //estate = CreateEstateDynamic(enumEstateType);
            //SetEstateSpecificComponents(enumEstateType);
            //estate.EstateID = estateIDCounter + 1;

            lblShowEstateID.Text = estate.EstateID.ToString();

            EnableInfoFields(true);
            EnableButtons(false);

            testValues();



            lstbxRegister.SelectedIndex = -1;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int selIndex = lstbxRegister.SelectedIndex;

            estate = (IEstate)lstbxRegister.SelectedItem;

            //if (lstbxRegister.Items.Count > 0)
            //{
            //    EnableInfoFields(true);
            //    EnableButtons(false);
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selIndex = lstbxRegister.SelectedIndex;
            if (selIndex > -1)
            {
                lstbxRegister.Items.RemoveAt(selIndex);
                //lstEstates.RemoveAt(selIndex);
                estateManager.DeleteAt(selIndex);
                ClearFields();
                if (lstbxRegister.Items.Count > 0)
                    lstbxRegister.SelectedIndex = 0;
            }
        }

        private void btnBrowseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            Bitmap bitmap = null;
            try
            {
                bitmap = new Bitmap(openFile.FileName);
            }
            catch (Exception ex)
            {
                // Cancel ok.
            }
            pctbxEstateImage.Image = bitmap;
        }

        private void lstbxRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = lstbxRegister.SelectedIndex;
            if (selIndex > -1)
            {
                estate = (IEstate)lstbxRegister.SelectedItem;
                SetEstateCommonInfo();
                SetEstateSpecificInfo();
                SetPaymentSpecificInfo();
            }
        }

        private void bxEstateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (bxEstateType.SelectedIndex > -1)
            //{
            //    btnAdd.Enabled = true;
            //}
            //else
            //{
            //    btnAdd.Enabled = false;
            //}
        }
        private void bxEstateType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            EstateType enumEstateType = (EstateType)bxEstateType.SelectedItem;
            SetEstateSpecificComponentsDynamically(enumEstateType);
        }

        private void bxPaymentMethod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PaymentMethods enumPayment = (PaymentMethods)bxPaymentMethod.SelectedItem;
            SetPaymentSpecificComponents(enumPayment);
        }

        private void testValues()
        {
            bxEstateCountry.SelectedItem = Countries.Sverige;
            bxSellerCountry.SelectedItem = Countries.Sverige;
            bxBuyerCountry.SelectedItem = Countries.Sverige;
            bxLegalForm.SelectedItem = LegalForm.Ownership;
            bxPaymentMethod.SelectedIndex = 0;

            txtAmount.Text = "2000000";
            txtPaySpecific1.Text = "100";
            txtPaySpecific2.Text = "200";

            txtSpecific1.Text = "100";
            txtSpecific2.Text = "200";
            txtSpecific3.Text = "300";

            txtEstateCity.Text = "Malmö";
            txtEstateStreet.Text = "Trelleborgsgatan 10a";
            txtEstateZip.Text = "21435";

            txtSellerFName.Text = "Joakim";
            txtSellerLName.Text = "Tell";
            txtSellerCity.Text = "Skurup";
            txtSellerStreet.Text = "Hylteskogsvägen 1";
            txtSellerZip.Text = "25034";

            txtBuyerFName.Text = "Robert";
            txtBuyerLName.Text = "Rosencrantz";
            txtBuyerCity.Text = "Malmö";
            txtBuyerStreet.Text = "Trelleborgsgatan 8a";
            txtBuyerZip.Text = "21435";
        }
    }
}
