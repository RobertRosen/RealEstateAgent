using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateAgent
{
    class EstateManager
    {
        private IEstate estate = null;
        private List<IEstate> lstEstates = new List<IEstate>();
        private int estateIDCounter = 0;

        public IEstate CreateEstate(EstateType estateType)
        {
            //Dynamic binding.
            switch (estateType)
            {
                case EstateType.Apartment:
                    {
                        estate = new Apartment();
                        break;
                    }
                case EstateType.School:
                    {
                        estate = new School();
                        break;
                    }
                case EstateType.Store:
                    {
                        estate = new Store();
                        break;
                    }
                case EstateType.University:
                    {
                        estate = new University();
                        break;
                    }
                case EstateType.Villa:
                    {
                        estate = new Villa();
                        break;
                    }
                case EstateType.Warehouse:
                    {
                        estate = new Warehouse();
                        break;
                    }
                default: break;
            }
           
            estate.EstateID = estateIDCounter + 1;

            return estate;
        }

        public List<IEstate> AddEstateToRegister()
        {
            if (estate != null)
            {
                lstEstates.Add(estate);
                estateIDCounter++;
            }

            return lstEstates;
        }

        public void SetEstateInfo(Address estateAddress, LegalForm legalForm)
        {
            if (estate.GetType() == typeof(Apartment))
            {
                ((Apartment)estate).LegalForm = legalForm;
            }

            estate.Address = estateAddress;
        }
        
        public void SetBuyerInfo(Address buyerAddress, string name)
        {
            estate.Buyer = new Buyer();
            ((Buyer)estate.Buyer).Name = name;
            ((Buyer)estate.Buyer).Address = buyerAddress;
        }

        public void SetSellerInfo(Address sellerAddress, string name)
        {
            estate.Seller = new Seller();
            ((Seller)estate.Seller).Name = name;
            ((Seller)estate.Seller).Address = sellerAddress;
        }

         public void SetPaymentInfo(PaymentMethods paymentMethod, string amount, string comment)
        {
            Payment payment = null;

            switch (paymentMethod)
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

        public void DeleteFromRegister(int index)
        {
            lstEstates.RemoveAt(index);
        }
    }
}
