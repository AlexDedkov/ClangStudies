using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class CallPlan
    {
        public enum PlanType
        {
            TimeBased,
            After10Minutes2TimesCheaper,
            PayLessUpTo5Minutes
        }

        public static double CalculateCallCost(PlanType planType, char callType, int minutes)
        {
            double costPerMinute = GetCostPerMinute(callType);
            double totalCost = 0;

            switch (planType)
            {
                case PlanType.TimeBased:
                    totalCost = costPerMinute * minutes;
                    break;

                case PlanType.After10Minutes2TimesCheaper:
                    if (minutes > 10)
                    {
                        int freeMinutes = minutes / 2;
                        totalCost = costPerMinute * (minutes - freeMinutes);
                    }
                    else
                    {
                        totalCost = costPerMinute * minutes;
                    }
                    break;

                case PlanType.PayLessUpTo5Minutes:
                    if (minutes <= 5)
                    {
                        totalCost = costPerMinute * 0.5 * minutes;
                    }
                    else
                    {
                        totalCost = costPerMinute * 2 * (minutes - 5) + costPerMinute * 0.5 * 5;
                    }
                    break;
            }

            return totalCost;
        }

        private static double GetCostPerMinute(char callType)
        {
            return (callType == 'Г') ? 5 : (callType == 'М') ? 1 : 0; // Urban: 5 rub./min, Mobile: 1 rub./min
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public double Balance { get; private set; }

        public Customer(string name, double balance = 100)
        {
            Name = name;
            Balance = balance;
        }

        public override string ToString()
        {
            return string.Format("Клиент: {0} имеет баланс: {1}", Name, Balance);
        }

        public void RecordPayment(double amountPaid)
        {
            if (amountPaid > 0)
                Balance += amountPaid;
        }

        public void RecordCall(CallPlan.PlanType planType, char callType, int minutes)
        {
            double callCost = CallPlan.CalculateCallCost(planType, callType, minutes);
            Balance -= callCost;
        }
    }

    class Customer1
    {
        static void Main(string[] args)
        {
            Customer Ivan = new Customer("Иван Петров", 500);
            Customer Elena = new Customer("Елена Иванова");
            Customer Peter = new Customer("Петр", 300);

            // RecordCall использует CallPlan чтобы вычислить стоимость с тарифом
            Ivan.RecordCall(CallPlan.PlanType.TimeBased, 'Г', 12);
            Elena.RecordCall(CallPlan.PlanType.After10Minutes2TimesCheaper, 'М', 25);
            Peter.RecordCall(CallPlan.PlanType.PayLessUpTo5Minutes, 'М', 50);

            Console.WriteLine(Ivan);
            Console.WriteLine(Elena);
            Console.WriteLine(Peter);
        }
    }
}