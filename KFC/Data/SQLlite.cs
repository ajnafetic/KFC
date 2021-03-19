using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace KFC.Data
{
    public interface SQLlite
    {
        SQLiteConnection GetConnection();
    }
}
