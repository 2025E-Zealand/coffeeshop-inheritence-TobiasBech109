using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Latte : Coffee
{
	public Latte()
	{
		Description = "Latte";
	}

	public override double Cost()
	{
		return 40.0; 
	}
}
