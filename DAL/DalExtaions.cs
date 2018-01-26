
namespace DAL
{
    using System;
    using System.Globalization;
    using BE;

    #region Classes

    /// <summary>
    /// Defines the <see cref="DalExtaions" />
    /// </summary>
    public static class DalExtaions
    {
        #region Methods

        public static DateTime FromYYYYMMDD(this string str) => DateTime.ParseExact(str, "yyyyMMdd",
            CultureInfo.InvariantCulture);

        public static Child GetChild(this Dal dal, string id) => dal.Child.GetGetListOfT().Find(cid => cid == id.ToChild());

        public static Contract GetContract(this Dal dal, string id) => dal.Contract.GetGetListOfT().Find(cid => cid == id.ToContract());

        public static Mother GetMother(this Dal dal, long id) => dal.GetMother(id.ToString());

        public static Mother GetMother(this Dal dal, string id) => dal.Mother.GetGetListOfT().Find(cid => cid == id.ToMother());

        public static Nanny GetNanny(this Dal dal, string id) => dal.Nanny.GetGetListOfT().Find(cid => cid == id.ToNanny());

        #endregion
    }

    #endregion
}
