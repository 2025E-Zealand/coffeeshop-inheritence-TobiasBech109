using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BlackCoffe : Coffee
{
	public BlackCoffe()
	{
		Description = "Black Coffee";
	}

	public override double Cost()
	{;
		return 20; 
	}
}
