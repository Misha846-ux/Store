using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class PayPalPayment : IPaymentMethod
    {
        public string Email { get; set; }

        public PayPalPayment(string email) => Email = email;
    }
}
