using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cortado : Coffee, IMilk
{

	public int MlMilk()
	{
		return 40;
	}
	public Cortado()
	{
		Description = "Cortado";
	}
	public override double Cost()
	{
		return 25.0;
	}

	public override string Strength()
	{
		return "Medium";
	}
}
