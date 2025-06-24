using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class DummyDoctorEntry : IDoctorEntry
    {
        public string ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
