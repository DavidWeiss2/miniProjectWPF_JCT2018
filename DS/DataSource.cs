
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
    public static class DataSource
    {
        #region Fields

        private static List<Child> childList = new List<Child>();
        private static List<Contract> contractList = new List<Contract>();
        private static List<Mother> motherList = new List<Mother>();
        private static List<Nanny> nannyList = new List<Nanny>();

        public static List<Child> ChildList
        {
            get => childList;
            set => childList = value;
        }
        public static List<Contract> ContractList
        {
            get => contractList;
            set => contractList = value;
        }
        public static List<Mother> MotherList
        {
            get => motherList;
            set => motherList = value;
        }
        public static List<Nanny> NannyList
        {
            get => nannyList;
            set => nannyList = value;
        }

        #endregion
    }
}

