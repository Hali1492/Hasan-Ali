using System;
using BL;
using DAL;

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            DBHelper db = new OracleHelper();

            EnvanterRepository r = new EnvanterRepository(db);

            r.GetStoklar();

        }
    }
}
