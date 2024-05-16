using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.S_srp
{
    // Yomon dizayn: User sinfi foydalanuvchini ham boshqaradi, ham ma'lumotlarni saqlaydi
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public void SaveToDatabase()
        {
            // Ma'lumotlarni bazaga saqlash
        }
    }

    // Yaxshi dizayn: User sinfi faqat foydalanuvchi ma'lumotlarini saqlaydi, UserRepository esa ma'lumotlarni boshqaradi

    public class UserRepository
    {
        public void SaveToDatabase(User user)
        {
            // Ma'lumotlarni bazaga saqlash
        }
    }

}
