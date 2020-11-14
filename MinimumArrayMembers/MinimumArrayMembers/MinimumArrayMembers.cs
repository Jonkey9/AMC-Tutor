using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace MinimumArrayMembers {
	class MinimumArrayMembers {
		static void Main(string[] args) {
			int S, flag = -1,i=1;
			string input;
			string[] InputArray;
			List<int> numbers = new List<int>();

			input = Console.ReadLine();
			InputArray = input.Split(new char[] { ' ' });
			S = Convert.ToInt32(InputArray[0]);

			while (i!=(InputArray.Length-1)) {
				numbers.Add(Convert.ToInt32(InputArray[i]));
				++i;
			}
			
			numbers.Sort();
			numbers.Reverse();

			for (i = 0; i < numbers.Count; i++) {
				S = S - numbers[i];
				if (S < 0) {
					S = i + 1;
					flag = 1;
					break;
				}
			}
			if (flag == -1) {
				Console.Write(-1);
			} else Console.Write(S);
		}
	}
}