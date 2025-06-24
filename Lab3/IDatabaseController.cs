using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public interface IDatabaseController
    {
        public bool tryConnectDB();
        public bool tryCreateAccount(string login, string password);
        public IDoctorEntry getNewDoctorEntry();
        public bool login(string login, string password);
    }
}

