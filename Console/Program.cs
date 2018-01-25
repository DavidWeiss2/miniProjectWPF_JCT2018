using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dotNet5778_Project_5337_7178
{
    namespace MyConsole
    {
        class Program
        {
            static void Main(string[] args)
            {
                DS.Dal_imp.DChild dChild = new DS.Dal_imp.DChild();
                DS.Dal_imp.DMother dMother = new DS.Dal_imp.DMother();
                DS.Dal_imp.DContract dContract = new DS.Dal_imp.DContract();
                DS.Dal_imp.DNanny dNanny = new DS.Dal_imp.DNanny();

                for (int i = 1; i < 100; i++)
                {
                    dMother.Add(new BE.Mother(i + 50));
                    dChild.Add(new BE.Child(i, dateOfBirth: DateTime.Now, firstName: "f" + $"{(i + 50) % 100}", lastName: $"{i%4+1}", isFemale: i % 2 == 1, mother: new BE.Mother(i + 50), address: $"{100 - i}", isDisabled: i % 3 == 1, disableInfo: $"{i}"));
                    (dChild.GetListOfT()).ForEach(j => Console.Write("{0}\n", j));
                    Console.WriteLine("\n");
                    dChild.GetListofTByKeyField("LastName").ForEach(j => Console.Write("{0}\n", j));
                    Console.WriteLine("\n\n");
                    System.Threading.Thread.Sleep(100);
                }
                int r = 1;
                dChild.Add(new BE.Child(r, dateOfBirth: DateTime.Now, firstName: "f" + $"{(r + 50) % 100}", lastName: $"{r % 4 + 1}", isFemale: r % 2 == 1, mother: new BE.Mother(r + 50), address: $"{100 - r}", isDisabled: r % 3 == 1, disableInfo: $"{r}"));
            }
        }
    }
}
