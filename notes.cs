using System;

namespace GasEquation
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] gasNames = { };
			double[] molWeights = { };
			int count;
			
			getMolecularWeights(ref gasNames, ref molWeights, out count);
			for(int i = 0; i < count; ++i)
			{
				console.WriteLine(gasNames[i] + molWeights[i]);
			}
		}
		GetMolecularWeights(ref string[] gasNames, ref double[] molecularWeights, out in count)
		{
			// Read the file and display it line by line.  
			System.IO.StreamReader file =   
				new System.IO.StreamReader(@"c:\test.txt");  
			while((line = file.ReadLine()) != null)  
			{  
				string words = line;

				string [] split = words.Split(new Char [] {','});

				/*foreach (string s in split) {

					if (s.Trim() != "")
						Console.WriteLine(s);
				}*/
			}  

			file.Close();  
			System.Console.WriteLine("There were {0} lines.", counter);  
			// Suspend the screen.  
			System.Console.ReadLine();  
		}
	}
}