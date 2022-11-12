using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OracleHelper : DBHelper
    {
		public OracleHelper()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
		}

		~OracleHelper()
		{
			Console.ResetColor();
		}

		public override void Connect()
		{
			Console.WriteLine("Oracle bağlantısı oluştu");
		}

		public override void Disconnect()
		{
			Console.WriteLine("Oracle bağlantısı kapatıldı");
		}

		/// 
		/// <param name="commandText">sql komut içeriği</param>
		public override void Run(string commandText)
		{
			Console.WriteLine($"{commandText}\tPL/SQL completed...");
		}
	}
}
