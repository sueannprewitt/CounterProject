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
		//List numbers evenly divisible by 3 between 1 and 100
		bool IsDivisibleByThree (int nbr) {
			return (nbr % 3 == 0);
		}


		void Run() {
			//	Console.WriteLine($"The factorial of 5 is {factorial(5)}");
			for(var idx = 0; idx <= 100; idx++) {
				if(IsDivisibleByThree(idx)) {
					Console.WriteLine($"{idx} is divisible by 3");
				}
			}
		}

		
		static void Main(string[] args) {
			new Program().Run();
		}
	}
}
