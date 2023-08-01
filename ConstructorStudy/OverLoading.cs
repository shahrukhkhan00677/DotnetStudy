using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorStudy
{
    internal class OverLoading
    {
        public OverLoading()
        {
            int A; int B; int C; 
            Console.WriteLine("Enter number one ");
            A=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number second");
            B=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number Third");
            C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add Two Number="+(A+B));
            Console.WriteLine("Add Three Number=" + (A + B + C));
        }
    }
}
