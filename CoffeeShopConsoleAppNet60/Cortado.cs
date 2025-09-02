using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cortado : Coffee
{
	public Cortado()
	{
		Description = "Cortado";
	}


	public override double Cost()
	{
		return 25.0;
	}
}
