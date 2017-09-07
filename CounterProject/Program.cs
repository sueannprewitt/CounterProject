using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProject {
	class Program {
		int factorial (int number) {
			var total = 1; 
			for (var idx = 2; idx <= number; idx++)	{
				total = total * idx;
			}
			return total;
		}
		void Run() {
			Console.WriteLine($"The Factorial of 5 is {factorial(5)}");
		}

		
		static void Main(string[] args) {
			new Program().Run();
		}
	}
}
