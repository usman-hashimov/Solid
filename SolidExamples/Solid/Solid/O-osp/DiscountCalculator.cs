using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.O_osp
{
    // Yomon dizayn: DiscountCalculator turli turdagi chegirmalarni qo‘shish uchun o‘zgartirilishi kerak
    public class DiscountCalculator
    {
        public double CalculateDiscount(Customer customer)
        {
            if (customer.Type == "Regular")
            {
                return 0.1; // 10% chegirma
            }
            else if (customer.Type == "VIP")
            {
                return 0.2; // 20% chegirma
            }
            return 0;
        }
    }

    // Yaxshi dizayn: Yangi chegirma turlari qo'shish uchun sinflarni kengaytirish orqali amalga oshiriladi
    public abstract class Customer
    {
        public abstract double GetDiscount();
    }

    public class RegularCustomer : Customer
    {
        public override double GetDiscount()
        {
            return 0.1; // 10% chegirma
        }
    }

    public class VIPCustomer : Customer
    {
        public override double GetDiscount()
        {
            return 0.2; // 20% chegirma
        }
    }

    public class DiscountCalculator
    {
        public double CalculateDiscount(Customer customer)
        {
            return customer.GetDiscount();
        }
    }

}
