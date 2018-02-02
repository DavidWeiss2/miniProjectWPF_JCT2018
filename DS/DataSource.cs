
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

        private static List<Id> list;

        public static List<Id> List
        {
            get {
                if (null == list)
                    list = new List<Id>();
                return list;
            }
        }
        private DataSource() { }

        #endregion
    }
}

