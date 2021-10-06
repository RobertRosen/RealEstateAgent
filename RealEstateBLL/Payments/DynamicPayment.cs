using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL
{
    public class DynamicPayment
    {
        public Payment CreatePaymentDynamic(PaymentMethods paymentMethod, int amount) => paymentMethod switch
        {
            PaymentMethods.Bank => new Bank(amount),
            PaymentMethods.PayPal => new PayPal(amount),
            PaymentMethods.Western_Union => new WesternUnion(amount),
            _ => throw new ArgumentException(message: "Invalid enum value", paramName: nameof(paymentMethod))
        };
    }
}
