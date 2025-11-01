using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Insurance
    {
        public int DiscountPercentage (int age)
        {
            switch (age)
            {
                case >= 65: return 5;
                case >= 45: return 10;
                case >= 25: return 20;
                case >= 18: return 5;
                default: throw new InvalidDataContractException();
            }
        }

        public int InteresRate => 10;
    }

    public class Customer(Insurance insurance, int age)
    {
        public virtual int Discount => insurance.DiscountPercentage(age);
    }

    public class LoyalCustomer(Insurance insurance, int age) : Customer(insurance, age)
    {
        private readonly Insurance _insurance = insurance;

        public override int Discount => _insurance.DiscountPercentage(age) + 10;
    }

    public static class CustomerFactory
    {
        public static Customer GetInstance(int yearsWithCompany, int age)
        {
            var insurance = new Insurance();
            return yearsWithCompany >= 5 ? new LoyalCustomer(insurance, age) : new Customer(insurance, age);
        }
    }

}
