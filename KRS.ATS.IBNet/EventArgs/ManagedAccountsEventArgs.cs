using System;
using System.Collections.Generic;
using System.Text;

namespace Krs.Ats.IBNet
{
    public class ManagedAccountsEventArgs : EventArgs
    {
        private readonly string accountsList;
        public string AccountsList
        {
            get
            {
                return accountsList;
            }
        }
        public ManagedAccountsEventArgs(string accountsList)
        {
            this.accountsList = accountsList;
        }
    }
}
