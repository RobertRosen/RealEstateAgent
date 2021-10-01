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
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace RealEstateAgent
{
    public partial class MainForm : Form
    {
        #region Variables
        private EstateManager estateManager;
        private IEstate tempEstate; //A temorary estate object to pass to the estate manager.
        private string imageFilePath;
        private string imageFilePathRobert = "C:\\Users\\rober\\source\\repos\\RealEstateAgent\\Images\\noImage.jpg";
        private string imageFilePathJoakim = "C:\\Users\\Thell\\Source\\Repos\\RobertRosen\\RealEstateAgent\\Images\\noImage.jpg";
        private string saveFilePath = "";
        #endregion

        #region Constructors
        public MainForm()
        {
            InitializeComponent();
            estateManager = new EstateManager();
            InitializeGUI();
        }
        #endregion

        #region Initialization
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
            lstbxRegister.Items.Clear();
            ClearFields();
            EnableInfoFields(false);

            tempEstate = null;
            estateManager.EstateIDCounter = 0;
            //TODO: dynamic filepath for portability..
            imageFilePath = imageFilePathJoakim;
        }
        #endregion

        #region Instantiate entities
        public IEstate CreateEstateDynamic(EstateType estateType) => estateType switch
        {
            EstateType.Rental => tempEstate = new Rental(),
            EstateType.School => tempEstate = new School(),
            EstateType.Store => tempEstate = new Store(),
            EstateType.Tenement => tempEstate = new Tenement(),
            EstateType.Townhouse => tempEstate = new Townhouse(),
            EstateType.University => tempEstate = new University(),
            EstateType.Villa => tempEstate = new Villa(),
            EstateType.Warehouse => tempEstate = new Warehouse(),
            _ => throw new ArgumentException(message: "Invalid enum value", paramName: nameof(estateType))
        };


        public Payment CreatePaymentDynamic(PaymentMethods paymentMethod) => paymentMethod switch
        {
            PaymentMethods.Bank => tempEstate.Payment = new Bank(),
            PaymentMethods.PayPal => tempEstate.Payment = new PayPal(),
            PaymentMethods.Western_Union => tempEstate.Payment = new WesternUnion(),
            _ => throw new ArgumentException(message: "Invalid enum value", paramName: nameof(paymentMethod))
        };

        public Person CreatePersonDynamic(Persons person) => person switch
        {
            Persons.Buyer => tempEstate.Buyer = new Buyer(),
            Persons.Seller => tempEstate.Seller = new Seller(),
            _ => throw new ArgumentException(message: "Invalid enum value", paramName: nameof(person))
        };
        #endregion

        #region Read general info
        // TODO: Do validation of input!
        // Read and validate user input.
        private void ReadAndValidateInfo()
        {
            bool inputOk;
            inputOk = ReadEstateInfo();
            ReadBuyerInfo();
            ReadSellerInfo();
            inputOk = ReadPaymentInfo();
            ReadImageInfo();
            ReadSpecificInfo();
            ReadPaymentSpecificInfo();
        }

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

                tempEstate.LegalForm = legalForm;
                tempEstate.Address = address;

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
            tempEstate.ImagePath = imageFilePath;
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

            tempEstate.Seller = CreatePersonDynamic(Persons.Seller);
            ((Seller)tempEstate.Seller).FirstName = strFName;
            ((Seller)tempEstate.Seller).LastName = strLName;
            ((Seller)tempEstate.Seller).Address = address;
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

            tempEstate.Buyer = CreatePersonDynamic(Persons.Buyer);
            ((Buyer)tempEstate.Buyer).FirstName = strFName;
            ((Buyer)tempEstate.Buyer).LastName = strLName;
            ((Buyer)tempEstate.Buyer).Address = address;
        }

        private bool ReadPaymentInfo()
        {
            bool inputOk;
            if (bxPaymentMethod.SelectedIndex > -1 && int.TryParse(txtAmount.Text, out int amount))
            {
                PaymentMethods enumPayment = (PaymentMethods)bxPaymentMethod.SelectedItem;
                CreatePaymentDynamic(enumPayment);
                tempEstate.Payment.Amount = amount;
                inputOk = true;
            }
            else
            {
                inputOk = false;
            }
            return inputOk;
        }
        #endregion

        #region Read specific info
        private void ReadSpecificInfo()
        {
            string str1 = txtSpecific1.Text;
            string str2 = txtSpecific2.Text;
            string str3 = txtSpecific3.Text;

            bool inputOk;

            if (tempEstate.GetType() == typeof(Rental))
            {
                ((Rental)tempEstate).SquareMeter = Convert.ToInt32(str1);
                ((Rental)tempEstate).Floor = Convert.ToInt32(str2);
                ((Rental)tempEstate).ContractMonths = Convert.ToInt32(str3);
            }
            else if (tempEstate.GetType() == typeof(School))
            {
                ((School)tempEstate).NumberOfCafeterias = Convert.ToInt32(str1);
                ((School)tempEstate).NumberOfClassrooms = Convert.ToInt32(str2);
                ((School)tempEstate).SuitableLevel = str3;
            }
            else if (tempEstate.GetType() == typeof(Store))
            {
                ((Store)tempEstate).StorageSquareMeters = Convert.ToInt32(str1);
                ((Store)tempEstate).SuitableBusiness = str2;
            }
            else if (tempEstate.GetType() == typeof(Tenement))
            {
                ((Tenement)tempEstate).SquareMeter = Convert.ToInt32(str1);
                ((Tenement)tempEstate).Floor = Convert.ToInt32(str2);
                ((Tenement)tempEstate).TenantOwnersAssociationName = str3;
            }
            else if (tempEstate.GetType() == typeof(Townhouse))
            {
                ((Townhouse)tempEstate).SquareMeter = Convert.ToInt32(str1);
                ((Townhouse)tempEstate).GardenSquareMeters = Convert.ToInt32(str2);
                ((Townhouse)tempEstate).NumberOfConnectedVillas = Convert.ToInt32(str3);
            }
            else if (tempEstate.GetType() == typeof(University))
            {
                ((University)tempEstate).NumberOfCafeterias = Convert.ToInt32(str1);
                ((University)tempEstate).NumberOfClassrooms = Convert.ToInt32(str2);
                ((University)tempEstate).NumberOfLectureHalls = Convert.ToInt32(str3);
            }
            else if (tempEstate.GetType() == typeof(Villa))
            {
                ((Villa)tempEstate).SquareMeter = Convert.ToInt32(str1);
                ((Villa)tempEstate).GardenSquareMeters = Convert.ToInt32(str2);
            }
            else if (tempEstate.GetType() == typeof(Warehouse))
            {
                ((Warehouse)tempEstate).StorageSquareMeters = Convert.ToInt32(str1);
                ((Warehouse)tempEstate).NumberOfLoadingDocks = Convert.ToInt32(str2);
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

            if (tempEstate.Payment.GetType() == typeof(Bank))
            {
                ((Bank)tempEstate.Payment).Accountnumber = str1;
                ((Bank)tempEstate.Payment).Name = str2;
            }
            else if (tempEstate.Payment.GetType() == typeof(WesternUnion))
            {
                ((WesternUnion)tempEstate.Payment).Email = str1;
                ((WesternUnion)tempEstate.Payment).Name = str2;
            }
            else if (tempEstate.Payment.GetType() == typeof(PayPal))
            {
                ((PayPal)tempEstate.Payment).Email = str1;
            }
            else
            {
                //Handle this...
            }
        }
        #endregion

        #region Update GUI components
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
            bxEstateType.Enabled = enabled;
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
        #endregion

        #region Update GUI fields
        private void ClearFields()
        {
            lblShowEstateID.ResetText();

            bxEstateType.SelectedIndex = -1;
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

            imageFilePath = imageFilePathJoakim;
        }

        ///Summary
        /// Gets the info about the chosen estate from the register and puts the info on the fields to be read.
        ///Summary
        private void SetEstateCommonInfo()
        {
            lblShowEstateID.Text = tempEstate.EstateID.ToString();
            bxLegalForm.SelectedItem = tempEstate.LegalForm;
            txtEstateCity.Text = tempEstate.Address.City;
            bxEstateCountry.SelectedItem = tempEstate.Address.Country;
            txtEstateStreet.Text = tempEstate.Address.Street;
            txtEstateZip.Text = tempEstate.Address.ZipCode;
            bxPaymentMethod.SelectedItem = tempEstate.Payment.Method;
            txtAmount.Text = tempEstate.Payment.Amount.ToString();
            txtSellerFName.Text = tempEstate.Seller.FirstName;
            txtSellerLName.Text = tempEstate.Seller.LastName;
            txtSellerCity.Text = tempEstate.Seller.Address.City;
            bxSellerCountry.SelectedItem = tempEstate.Seller.Address.Country;
            txtSellerStreet.Text = tempEstate.Seller.Address.Street;
            txtSellerZip.Text = tempEstate.Seller.Address.ZipCode;
            txtBuyerFName.Text = tempEstate.Buyer.FirstName;
            txtBuyerLName.Text = tempEstate.Buyer.LastName;
            txtBuyerCity.Text = tempEstate.Buyer.Address.City;
            bxBuyerCountry.SelectedItem = tempEstate.Buyer.Address.Country;
            txtBuyerStreet.Text = tempEstate.Buyer.Address.Street;
            txtBuyerZip.Text = tempEstate.Buyer.Address.ZipCode;
            pctbxEstateImage.Image = new Bitmap(tempEstate.ImagePath);
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
            if (tempEstate.GetType() == typeof(Rental))
            {
                SetEstateSpecificComponentsDynamically(EstateType.Rental);
                txtSpecific1.Text = ((Rental)tempEstate).SquareMeter.ToString();
                txtSpecific2.Text = ((Rental)tempEstate).Floor.ToString();
                txtSpecific3.Text = ((Rental)tempEstate).ContractMonths.ToString();
                bxEstateType.SelectedItem = EstateType.Rental;
            }
            else if (tempEstate.GetType() == typeof(School))
            {
                SetEstateSpecificComponentsDynamically(EstateType.School);
                txtSpecific1.Text = ((School)tempEstate).NumberOfCafeterias.ToString();
                txtSpecific2.Text = ((School)tempEstate).NumberOfClassrooms.ToString();
                txtSpecific3.Text = ((School)tempEstate).SuitableLevel.ToString();
                bxEstateType.SelectedItem = EstateType.School;
            }
            else if (tempEstate.GetType() == typeof(Store))
            {
                SetEstateSpecificComponentsDynamically(EstateType.Store);
                txtSpecific1.Text = ((Store)tempEstate).StorageSquareMeters.ToString();
                txtSpecific2.Text = ((Store)tempEstate).SuitableBusiness.ToString();
                txtSpecific3.Text = "";
                bxEstateType.SelectedItem = EstateType.Store;
            }
            else if (tempEstate.GetType() == typeof(Tenement))
            {
                SetEstateSpecificComponentsDynamically(EstateType.Tenement);
                txtSpecific1.Text = ((Tenement)tempEstate).SquareMeter.ToString();
                txtSpecific2.Text = ((Tenement)tempEstate).Floor.ToString();
                txtSpecific3.Text = ((Tenement)tempEstate).TenantOwnersAssociationName.ToString();
                bxEstateType.SelectedItem = EstateType.Tenement;
            }
            else if (tempEstate.GetType() == typeof(Townhouse))
            {
                SetEstateSpecificComponentsDynamically(EstateType.Townhouse);
                txtSpecific1.Text = ((Townhouse)tempEstate).SquareMeter.ToString();
                txtSpecific2.Text = ((Townhouse)tempEstate).GardenSquareMeters.ToString();
                txtSpecific3.Text = ((Townhouse)tempEstate).NumberOfConnectedVillas.ToString();
                bxEstateType.SelectedItem = EstateType.Townhouse;
            }
            else if (tempEstate.GetType() == typeof(University))
            {
                SetEstateSpecificComponentsDynamically(EstateType.University);
                txtSpecific1.Text = ((University)tempEstate).NumberOfCafeterias.ToString();
                txtSpecific2.Text = ((University)tempEstate).NumberOfClassrooms.ToString();
                txtSpecific3.Text = ((University)tempEstate).NumberOfLectureHalls.ToString();
                bxEstateType.SelectedItem = EstateType.University;
            }
            else if (tempEstate.GetType() == typeof(Villa))
            {
                SetEstateSpecificComponentsDynamically(EstateType.Villa);
                txtSpecific1.Text = ((Villa)tempEstate).SquareMeter.ToString();
                txtSpecific2.Text = ((Villa)tempEstate).GardenSquareMeters.ToString();
                txtSpecific3.Text = "";
                bxEstateType.SelectedItem = EstateType.Villa;
            }
            else if (tempEstate.GetType() == typeof(Warehouse))
            {
                SetEstateSpecificComponentsDynamically(EstateType.Warehouse);
                txtSpecific1.Text = ((Warehouse)tempEstate).StorageSquareMeters.ToString();
                txtSpecific2.Text = ((Warehouse)tempEstate).NumberOfLoadingDocks.ToString();
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
            if (tempEstate.Payment.GetType() == typeof(Bank))
            {
                SetPaymentSpecificComponents(PaymentMethods.Bank);
                txtPaySpecific1.Text = ((Bank)tempEstate.Payment).Accountnumber;
                txtPaySpecific2.Text = ((Bank)tempEstate.Payment).Name;
                bxPaymentMethod.SelectedItem = PaymentMethods.Bank;
            }
            else if (tempEstate.Payment.GetType() == typeof(WesternUnion))
            {
                SetPaymentSpecificComponents(PaymentMethods.Western_Union);
                txtPaySpecific1.Text = ((WesternUnion)tempEstate.Payment).Email;
                txtPaySpecific2.Text = ((WesternUnion)tempEstate.Payment).Name;
                bxPaymentMethod.SelectedItem = PaymentMethods.Western_Union;
            }
            else if (tempEstate.Payment.GetType() == typeof(PayPal))
            {
                SetPaymentSpecificComponents(PaymentMethods.PayPal);
                txtPaySpecific1.Text = ((PayPal)tempEstate.Payment).Email;
                txtPaySpecific2.Text = "";
                bxPaymentMethod.SelectedItem = PaymentMethods.PayPal;
            }
            else
            {
                //Handle this...
            }
        }
        #endregion

        #region Button clicks
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            EstateType enumEstateType = (EstateType)bxEstateType.SelectedItem;
            int selIndex = lstbxRegister.SelectedIndex;

            // Update GUI.
            SetEstateSpecificComponentsDynamically(enumEstateType);
            EnableInfoFields(false);
            EnableButtons(true);
            DialogResult confirmResult = MessageBox.Show("Are you sure?", "Confirm dialog", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                if (selIndex > -1) // If any is selected from register.
                {
                    int estateIDToKeep = tempEstate.EstateID;
                    tempEstate = CreateEstateDynamic(enumEstateType);
                    ReadAndValidateInfo();

                    // Update estate.
                    tempEstate.EstateID = estateIDToKeep;
                    estateManager.ChangeAt(tempEstate, selIndex);

                    if (lstbxRegister.Items.Count > 0)
                    {
                        EnableInfoFields(false);
                        EnableButtons(true);
                    }
                }
                else // If no estate is selected in register.
                {
                    // Add new estate.
                    tempEstate = CreateEstateDynamic(enumEstateType);
                    ReadAndValidateInfo();
                    tempEstate.EstateID = estateManager.EstateIDCounter;
                    estateManager.Add(tempEstate);
                    selIndex = lstbxRegister.Items.Count;
                }
                // Update items visible in register and select added/changed estate.
                lstbxRegister.Items.Clear();
                lstbxRegister.Items.AddRange(estateManager.ToStringArray());
                lstbxRegister.SetSelected(selIndex, true);
            }
            else // Return to editing current estate.
            {
                EnableInfoFields(true);
                EnableButtons(false);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Update GUI.
            EnableInfoFields(false);
            EnableButtons(true);
            ClearFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstbxRegister.SelectedIndex = -1; //Deselect all from register.
            ClearFields();

            EnableInfoFields(true);
            EnableButtons(false);
            testValues();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int selIndex = lstbxRegister.SelectedIndex;
            tempEstate = estateManager.GetAt(selIndex); // Get an estate to modify.

            if (lstbxRegister.Items.Count > 0)
            {
                EnableInfoFields(true);
                EnableButtons(false);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete?", "Confirm dialog", MessageBoxButtons.YesNo);
            int selIndex = lstbxRegister.SelectedIndex;
            if (confirmResult == DialogResult.Yes)
            {
                if (selIndex > -1)
                {
                    lstbxRegister.Items.RemoveAt(selIndex);
                    estateManager.DeleteAt(selIndex);
                    ClearFields();
                    if (lstbxRegister.Items.Count > 0)
                        lstbxRegister.SelectedIndex = 0;
                }
            }
            else
            {
                // Return to editing current estate.
            }
        }

        private void btnBrowseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            Bitmap bitmap = null;
            try
            {
                imageFilePath = openFile.FileName;
                bitmap = new Bitmap(imageFilePath);
            }
            catch (Exception ex)
            {
                // Cancel ok.
            }
            pctbxEstateImage.Image = bitmap;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchCity = txtSearchCity.Text;
            string[] searchResults = estateManager.SearchEstate(searchCity);
            lstbxSearchResults.Items.Clear();

            if (searchResults != null)
            {
                foreach (string est in searchResults)
                {
                    Debug.WriteLine(est);
                }

                lstbxSearchResults.Items.AddRange(searchResults);
            }
            else
            {
                MessageBox.Show("No search results!");
            }

        }

        private void btnClearSearchResults_Click(object sender, EventArgs e)
        {
            lstbxSearchResults.Items.Clear();
        }
        #endregion

        #region Selection changes
        private void lstbxRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIndex = lstbxRegister.SelectedIndex;
            tempEstate = estateManager.GetAt(selIndex);
            if (selIndex > -1)
            {
                SetEstateCommonInfo();
                SetEstateSpecificInfo();
                SetPaymentSpecificInfo();
            }
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
        #endregion

        #region Menu clicks
        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Restart without saving?", "Confirm dialog", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                estateManager.DeleteAll();
                InitializeGUI();
                saveFilePath = "";
            }
            else
            {
                //Nothing
            }
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            //Ask user to save current data method?
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            string filepath = openFile.FileName;
            string extension = Path.GetExtension(filepath);

            if (extension == ".bin")
            {
                estateManager.BinaryDeSerialize(openFile.FileName);
                
               // estateManager.EstateIDCounter += estateManager.Count;
                lstbxRegister.Items.Clear();
                lstbxRegister.Items.AddRange(estateManager.ToStringArray());
                estateManager.EstateIDCounter += lstbxRegister.Items.Count;
            } 
            saveFilePath = filepath;
           
        }

       private void mnuFileSave_Click(object sender, EventArgs e)
        {
            if(saveFilePath == "")
            {
               mnuFileSaveAs_Click(sender, e);
            }
            else
            {
                SaveToFile(saveFilePath);
            }
        }

        private void SaveToFile(string fileName)
        {
            estateManager.BinarySerialize(fileName);
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.ShowDialog();
            saveFilePath = saveFile.FileName + ".bin";
            estateManager.BinarySerialize(saveFilePath);
        }

        private void mnuFileExportXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.ShowDialog();
            string saveFilePath = saveFile.FileName + ".xml";
            estateManager.XMLSerialize(saveFilePath);
        }

        private void mnuFileImportXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            estateManager.ReadEstateListFromXmlFile(openFile.FileName);
            lstbxRegister.Items.Clear();
            lstbxRegister.Items.AddRange(estateManager.ToStringArray());
            EnableButtons(true);
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            DialogResult confirmResult = MessageBox.Show("Do you want to exit without saving?", "Confirm dialog", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                mnuFileSaveAs_Click(sender, e);
            }
        }
        #endregion

        #region TEST VALUES
        private void testValues()
        {
            lblShowEstateID.Text = (estateManager.incrementEstateIDCounter()).ToString();

            bxEstateType.SelectedItem = EstateType.School;
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
            pctbxEstateImage.Image = new Bitmap(imageFilePathJoakim);
        }
        #endregion
    }
}
