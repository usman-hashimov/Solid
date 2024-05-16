using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.I_isp
{
    // Yomon dizayn: Barcha funksiyalar bitta interfeysda to'plangan
    public interface IWorker
    {
        void Work();
        void Eat();
    }

    // Yaxshi dizayn: Har bir sinf faqat unga kerak bo‘lgan interfeysdan foydalanadi
    public interface IWorkable
    {
        void Work();
    }

    public interface IEatable
    {
        void Eat();
    }

    public class Worker : IWorkable, IEatable
    {
        public void Work()
        {
            // Ishlaydi
        }

        public void Eat()
        {
            // Ovqatlanadi
        }
    }

    public class Robot : IWorkable
    {
        public void Work()
        {
            // Ishlaydi
        }
    }

}
