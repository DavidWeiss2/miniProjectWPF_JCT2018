using System;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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
                dChild.Add(new BE.Child(r, dateOfBirth: DateTime.Now, firstName: "f" + $"{(r + 50) % 100}", lastName: $"{r % 4 + 1}", isFemale: r % 2 == 1, mother: new BE.Mother(r + 50), address: $"{100 - r}", isDisabled: r % 3 == 1, disableInfo: $"{r}"));
            }
        }
    }
}
