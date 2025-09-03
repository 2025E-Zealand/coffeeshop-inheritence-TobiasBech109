using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

public class Latte : Coffee, IMilk
{

	public int MlMilk()
	{
		return 200;
	}
	public Latte()
	{
		Description = "Latte";
	}

	public override double Cost()
	{
		return 40.0; 
	}

	public override string Strength()
	{
		return "Weak";
	}
}
