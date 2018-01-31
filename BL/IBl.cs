using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    interface IBl
    {
        string Add(string[]args);
        string Remove(string[] args);
        string Edit(string[] args);
        string Group(string[] args);
        string GetList(string[] args);
    }
}
