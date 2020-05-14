using System;
using System.Collections.Generic;
using System.Text;

namespace ProductKruume
{
    public interface ISQLite
    {
        string GetDatabasePath(string filename);
    }
}
