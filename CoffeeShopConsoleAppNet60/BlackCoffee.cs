using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BlackCoffee : Coffee
{
	public BlackCoffee()
	{
		Description = "Black Coffee";
	}

	public override double Cost()
	{;
		return 20; 
	}

	public override string Strength()
	{
		return "Strong";
	}
}
