using System;
[assembly: CLSCompliant(true)]
namespace BL
{
    using DAL;

    /// <summary>
    /// Defines the <see cref="Bl" />
    /// </summary>
    public class Bl : IBl
    {

        #region Methods

        /// <summary>
        /// args[0] need to be name of class upper cased
        /// for every arg the odd number n is the arg name
        /// and the n+1 is the value.
        /// availble args are:
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public string Add(string[] args)
        {
            switch (args[0])
            {
                case "Child":
                    return AddChild(args);
                case "Mother":
                    return AddMother(args);
                case "Nanny":
                    return AddNanny(args);
                case "Contract":
                    return AddContract(args);
                default:
                    return ErrorInvaildMassege(args[0]);
            }
        }

        private string AddChild(string[] args)
        {
            throw new NotImplementedException();
        }

        private string AddContract(string[] args)
        {
            throw new NotImplementedException();
        }

        private string AddMother(string[] args)
        {
            throw new NotImplementedException();
        }

        private string AddNanny(string[] args)
        {
            throw new NotImplementedException();
        }

        public string Edit(string[] args)
        {
            switch (args[0])
            {
                case "Child":
                    return EditChild(args);
                case "Mother":
                    return EditMother(args);
                case "Nanny":
                    return EditNanny(args);
                case "Contract":
                    return EditContract(args);
                default:
                    return ErrorInvaildMassege(args[0]);
            }
        }

        private string EditChild(string[] args)
        {
            throw new NotImplementedException();
        }

        private string EditContract(string[] args)
        {
            throw new NotImplementedException();
        }

        private string EditMother(string[] args)
        {
            throw new NotImplementedException();
        }

        private string EditNanny(string[] args)
        {
            throw new NotImplementedException();
        }

        private static string ErrorInvaildMassege(string arg0) => $"I dont know what {arg0} is. please check the wiki, or spelling.";

        private string GetChild(string[] args)
        {
            throw new NotImplementedException();
        }

        private string GetContract(string[] args)
        {
            throw new NotImplementedException();
        }

        public string GetList(string[] args)
        {
            switch (args[0])
            {
                case "Child":
                    return GetChild(args);
                case "Mother":
                    return GetMother(args);
                case "Nanny":
                    return GetNanny(args);
                case "Contract":
                    return GetContract(args);
                default:
                    return ErrorInvaildMassege(args[0]);
            }
        }

        private string GetMother(string[] args)
        {
            throw new NotImplementedException();
        }

        private string GetNanny(string[] args)
        {
            throw new NotImplementedException();
        }

        public string Group(string[] args)
        {
            switch (args[0])
            {
                case "Child":
                    return GroupChild(args);
                case "Mother":
                    return GroupMother(args);
                case "Nanny":
                    return GroupNanny(args);
                case "Contract":
                    return GroupContract(args);
                default:
                    return ErrorInvaildMassege(args[0]);
            }
        }

        private string GroupChild(string[] args)
        {
            throw new NotImplementedException();
        }

        private string GroupContract(string[] args)
        {
            throw new NotImplementedException();
        }

        private string GroupMother(string[] args)
        {
            throw new NotImplementedException();
        }

        private string GroupNanny(string[] args)
        {
            throw new NotImplementedException();
        }

        public string Remove(string[] args)
        {
            switch (args[0])
            {
                case "Child":
                    return RemoveChild(args);
                case "Mother":
                    return RemoveMother(args);
                case "Nanny":
                    return RemoveNanny(args);
                case "Contract":
                    return RemoveContract(args);
                default:
                    return ErrorInvaildMassege(args[0]);
            }
        }

        private string RemoveChild(string[] args)
        {
            throw new NotImplementedException();
        }

        private string RemoveContract(string[] args)
        {
            throw new NotImplementedException();
        }

        private string RemoveMother(string[] args)
        {
            throw new NotImplementedException();
        }

        private string RemoveNanny(string[] args)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
