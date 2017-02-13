using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZubarskaOrd.Repos
{
    class PatientRepository
    {
        private static SqlCeConnection connection = DbConnection.Instance.Connection;
    }
}
