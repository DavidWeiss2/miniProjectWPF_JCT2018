
using System;
[assembly: CLSCompliant(true)]
namespace DS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using BE;

    /// <summary>
    /// Defines the <see cref="DataSource" />
    /// </summary>
    public class DataSource
    {
        #region Fields

        private static List<Child> childList;
        private static List<Contract> contractList;
        private static List<Mother> motherList;
        private static List<Nanny> nannyList;

        public static List<Child> ChildList
        {
            get {
                if (null == childList)
                    childList = new List<Child>();
                return childList;
            }
        }
        public static List<Contract> ContractList
        {
            get
            {
                if (null == contractList)
                    contractList = new List<Contract>();
                return contractList;
            }
        }
        public static List<Mother> MotherList
        {
            get
            {
                if (null == motherList)
                    motherList = new List<Mother>();
                return motherList;
            }
        }
        public static List<Nanny> NannyList
        {
            get
            {
                if (null == nannyList)
                    nannyList = new List<Nanny>();
                return nannyList;
            }
        }
        private DataSource() { }

        #endregion
    }
}

