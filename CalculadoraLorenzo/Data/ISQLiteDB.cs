using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLorenzo.Data
{
    public interface ISQLiteDB
    {
        string SQLiteLocalPath(string bancoDados);
    }
}
