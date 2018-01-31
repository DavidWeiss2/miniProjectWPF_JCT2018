
using System;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
[assembly: CLSCompliant(true)]
namespace dotNet5778_Project_5337_7178
{
    namespace MyConsole
    {
        static class Program
        {
            static void Main(string[] args)
            {
                Dal.DChild dChild = new Dal.DChild();
                Dal.DMother dMother = new Dal.DMother();
                Dal.DContract dContract = new Dal.DContract();
                Dal.DNanny dNanny = new Dal.DNanny();

                for (int i = 1; i < 100; i++)
                {
                    dNanny.Add(new BE.Nanny(i));
                    dMother.Add(new BE.Mother(i));
                    dChild.Add(new BE.Child(i));
                    dContract.Add(new BE.Contract(i));
                }
                int r = 1;
                dChild.Add(new BE.Child(r));
            }
        }
    }
}
