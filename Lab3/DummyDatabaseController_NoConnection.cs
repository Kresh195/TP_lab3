using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class DummyDatabaseController_NoConnection : IDatabaseController
    {
        public IDoctorEntry getNewDoctorEntry() { throw new NotImplementedException(); }
        public bool login(string login, string password) { throw new NotImplementedException(); }
        public bool tryConnectDB() { return false; }
        public bool tryCreateAccount(string login, string password)
        {
            throw new NotImplementedException();
        }
    }

}
