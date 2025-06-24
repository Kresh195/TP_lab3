using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class DummyDatabaseController_OK : IDatabaseController
    {
        public IDoctorEntry getNewDoctorEntry()
        {
            return new DummyDoctorEntry()
            {
                ID = "1",
                Login = "myname_doctor",
                Password = "DoctorSuperBest123!"
            };
        }
        public bool login(string login, string password) { return true; }
        public bool tryConnectDB() { return true; }
        public bool tryCreateAccount(string login, string password) { return true; }
    }

}
