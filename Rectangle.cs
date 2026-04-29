using System;

namespace RectangleApp
{
    public class Rectangle
    {
        private double width;
        private double height;

        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0)
                    height = value;
                else
                    height = 1;
            }
        }

        public void Init(double w, double h)
        {
            if (w > 0 && h > 0)
            {
                width = w;
                height = h;
            }
            else
            {
                width = 2;
                height = 1;
            }
        }

        public double Area()
        {
            return width * height;
        }

        public static Rectangle Add(Rectangle r1, Rectangle r2)
        {
            Rectangle result = new Rectangle();
            result.Init(r1.width + r2.width, r1.height + r2.height);
            return result;
        }
    }
}