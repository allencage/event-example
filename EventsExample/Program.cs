using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var pacient = new Pacient();
			pacient.OnNameChanged += Write;
			pacient.Name = "Nea Ion";

			Console.Read();
		}


		static void Write(object sender, NameChangedEventArgs args)
		{
			Console.WriteLine($"The name was changed to {args.Name}");
		}
	}
}
