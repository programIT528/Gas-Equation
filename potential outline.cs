using System
using System.IO

/*header file
private string[] gasNames = {""};
private double[] molecularWeights = {""};
private countGas;
*/

class GasEquation {
	static void Main(string[] args){
		getMolecularWeights(ref gasNames[], ref molecularWeights[], out countGas);
		displayGasNames(ref gasNames, ref countGas);
	}
	
	private static void getMolecularWeights(ref string[] gasNames, ref double[] molecularWeights, out countGas){
		string file = File.ReadAllText("<<filelocation>>");
		
		string[] lines = File.ReadAllLines("<<filelocation>>");
		
		foreach (string line in lines){
			gasNames = 
			
		}
		
	}
	
	public static void displayGasNames(ref string[] gasNames, ref countGas){
		for(int i = 0; i < 3; i ++){
			for(int j = 1; j < 30; j++){
				Console.WriteLine(countGas + "." + gasNames[j][i]);
			}
		}
	}
}