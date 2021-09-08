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
            String strLegalForm = bxLegalForm.Text;
            String strCity = txtEstateCity.Text;
            String strCountry = bxEstateCountry.Text;
            String strStreet = txtEstateStreet.Text;
            String strZipCode = txtEstateZip.Text;
        }



        //  private bool ReadSellerInfo()
        //{

        //}

        //private bool ReadBuyerInfo()
        //{

        //        }
    }
}
