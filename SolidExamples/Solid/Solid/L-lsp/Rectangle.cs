using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.L_lsp
{
    // Yomon dizayn: Square voris sinfi Rectangle bazaviy sinfining xatti-harakatlarini buzadi
    public class Rectangle
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }

        public double GetArea()
        {
            return Width * Height;
        }
    }

    public class Square : Rectangle
    {
        public override double Width
        {
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override double Height
        {
            set
            {
                base.Height = value;
                base.Width = value;
            }
        }
    }

    // Yaxshi dizayn: Square va Rectangle sinflar alohida-alohida bo‘ladi, umumiy interfeys yoki bazaviy sinfdan foydalaniladi
    public interface IShape
    {
        double GetArea();
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public double GetArea()
        {
            return Width * Height;
        }
    }

    public class Square : IShape
    {
        public double Side { get; set; }

        public double GetArea()
        {
            return Side * Side;
        }
    }

}
