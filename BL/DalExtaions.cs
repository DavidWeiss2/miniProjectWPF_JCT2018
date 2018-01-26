namespace dotNet5778_Project_5337_7178
{
    namespace BL
    {
        using System;
        using System.Globalization;

        #region Classes

        /// <summary>
        /// Defines the <see cref="DalExtaions" />
        /// </summary>
        public static class DalExtaions
        {
            #region Methods

            public static DateTime FromYYYYMMDD(this string str) => DateTime.ParseExact(str, "yyyyMMdd",
                CultureInfo.InvariantCulture);

            public static BE.Child GetChild(this DS.Dal_imp dal_imp, string id) => dal_imp.Child.GetListOfT.Find(cid => cid == id.ToChild());

            public static BE.Contract GetContract(this DS.Dal_imp dal_imp, string id) => dal_imp.Contract.GetListOfT.Find(cid => cid == id.ToContract());

            public static BE.Mother GetMother(this DS.Dal_imp dal_imp, long id) => dal_imp.GetMother(id.ToString());

            public static BE.Mother GetMother(this DS.Dal_imp dal_imp, string id) => dal_imp.Mother.GetListOfT.Find(cid => cid == id.ToMother());

            public static BE.Nanny GetNanny(this DS.Dal_imp dal_imp, string id) => dal_imp.Nanny.GetListOfT.Find(cid => cid == id.ToNanny());

            #endregion
        }

        #endregion
    }
}
