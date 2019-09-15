using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebDownload
{
	class Program
	{
		static void Main(string[] args)
		{
			string sTargetURI = "https://www.gismeteo.ua/weather-sievierodonetsk-11875/";
			WebClient wc = new WebClient();
			//wc.DownloadFile("http://dkws.org.ua/proxy/proxy.zip","c:\\temp\\proxy.zip");

			Stream str = wc.OpenRead(sTargetURI);
			StreamReader sr = new StreamReader(str);

			string sTemp;
			while ((sTemp = sr.ReadLine()) != null)
				Console.WriteLine(sTemp);

			Console.ReadKey();
		}
	}
}
