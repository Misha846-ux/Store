using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class CreditCardPayment : IPaymentMethod
    {
        public string CardNumber { get; set; }

        public CreditCardPayment(string cardNumber) => CardNumber = cardNumber;

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Оплата {amount} руб. произведена с карты {CardNumber}");
        }
    }
}
