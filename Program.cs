using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Alex = new Student("Alex ");
            var MrsAnn = new Teachers("Ann", "English");

            var school = new PrivateAcademy( 2, MrsAnn, Alex);

            var Dandelion = new Student("Dandelion");
            var MrDon = new Teachers("Don", "IT");

            var school1 = new PrivateAcademy( 3, MrsAnn, Dandelion);

            var shcool2 = new PrivateAcademy(1, MrDon, Alex);

            school.Print();
            school1.Print();
            shcool2.Print();

        }
    }
}
