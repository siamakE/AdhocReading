using System.Collections.Generic;

namespace AdhocReading
{
    [TestClass]
    public class CovarianceTest
    {
        public abstract class Shape
        {
            public virtual double Area => 0;
        }
        public class Cirlcle : Shape
        {
            private double r;
            public double Radious => r;

            public Cirlcle(double r)
            {
                this.r = r;
            }

            public override double Area => Math.PI * r * r;
        }
        class ShapeAreaComparer : IComparer<Shape>
        {
            int IComparer<Shape>.Compare(Shape a, Shape b)
            {
                if (a == null) return b == null ? 0 : -1;
                return b == null ? 1 : a.Area.CompareTo(b.Area);
            }
        }

        [TestMethod]
        public void Method1()
        {

        }
    }
}