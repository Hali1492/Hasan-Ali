using System;
using DAL;

namespace BL
{
    public class EnvanterRepository
    {
        private DBHelper dbHelper;

        public EnvanterRepository(DBHelper db)
        {
            this.dbHelper = db;
        }

        public object GetStoklar()
        {
            dbHelper.Connect();
            dbHelper.Run("Select * from Stoklar");
            dbHelper.Disconnect();
            return new Object();
        }

    }
}
