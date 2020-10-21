using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UrisSort
{
	class Program
	{
		static void Main(string[] args)
		{
			var urls = new[]
			{
				"http://1ad3ddcf-08b0-427e-835a-0192b13a37bb.tv/adabda97-1383-4d10-9e1c-4012fa1c1e7c",
				"http://87457dca-b688-4265-b9e3-4821cb76b753.en/ed5a0c0a-4b1c-49c9-be41-d054de4db917",
				
			};

			var urls1 = new[]
			{
				"http://www.google.en/?x=jsdfkj",
				"http://www.google.de/?x=jsdfkj",
				"http://www.google.com/?x=jsdfkj",
				"http://www.google.com/?x=jsdfkj",
				"http://www.google.org/?x=jsdfkj",
				"http://www.google.gov/?x=jsdfkj",
			};


			var result = urls.OrderByDomainNew();
			foreach (var url in result)
				Console.WriteLine(url);

			Console.WriteLine();

			var x = new Uri("http://www.google.com/?x=jsdfkj");

			Console.WriteLine(x.Host);
			Console.ReadKey();
		}
	}
}
