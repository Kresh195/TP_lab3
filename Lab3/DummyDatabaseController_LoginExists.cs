using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class DummyDatabaseController_LoginExists : IDatabaseController
    {
        public IDoctorEntry getNewDoctorEntry() { throw new NotImplementedException(); }
        public bool login(string login, string password) { return true; }
        public bool tryConnectDB() { return true; }
        public bool tryCreateAccount(string login, string password) { return false; }
    }

}
