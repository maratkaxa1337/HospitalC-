using Bank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Context
{
    public class ConnectContext
    {
        public static dbBankEntities db = new dbBankEntities();
    }
}
