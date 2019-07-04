static void GetMolecularWeights(ref string[] gasNames, ref double[] molecularWeights, out int count)
{
	
}

private static void DisplayGasNames(string[] gasNames, int countGases)
{
	for(int i = 0; i < 3; i ++)
	{
		for(int j = 1; j < 30; j++)
		{
			Console.WriteLine(countGas + "." + gasNames[j][i]);
		}
	}
}

private static double GetMolecularWeightFromName(string gasNames, string[] gasNames, double[] molecularWeights, int countGases) 
{
	
}

static double Pressure(double mass, double vol, double temp, double molecularWeights)
{
	private double n = NumberOfMoles(mass, molecularWeights);
	private double finalPressure = (n * R * temp) / vol; 
	return finalPressure;
}

static double NumberOfMoles(double mass, double molecularWeights)
{
	double n = mass / molecularWeights;
	return n;
}

static double CelciusToKelvin(double celcius)
{
	celcius -= 273.15;
	return celcius;
}

private static void DisplayPressure(double pressure)
{
	double pascals = PaToPSI(pressure);	
	Console.WriteLine("Pressure: " + pressure +  "\nPascals: " + pascals);
	Console.WriteLine();
}

static double PaToPSI(double pascals)
{
	double pressure = pascals * 0.0001450377;
	return pressure;
}
