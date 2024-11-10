using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BYT_project
{
    class Payment
    {
        private DateTime date;
        enum PaymentType {
        Cash,
        Card
        }

        private PaymentType type;
        private int amount;

        public Payment(string date, string type, int amount ) {
            if (DateTime.TryParse(date, out this.date))
            {
                Console.WriteLine("Successfully coverted " + date);
            }
            else
            {
                Console.WriteLine("Couldn't convert " + date);
                throw new Exception("Error when convering date to DateTime");
            }

            switch (type)
            {
                case "Cash":
                    this.type = PaymentType.Cash;
                    break;
                case "Card":
                    this.type = PaymentType.Card;
                    break;
            }

            this.amount = amount;
        }
    }
}
