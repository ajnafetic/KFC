using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace KFC.Modals
{
    public class Token
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string access_token { get; set; }
        public string error_descripion { get; set; }
        public DateTime exp_Date { get; set; }

        public Token() { }
    }
}
