using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Coffee
{
	public string Description { get; set; }

	
	public Coffee()
	{
		Description = "Unknown Coffee";
	}

	public virtual double Cost()
	{
		return 0.0;
	}


	public virtual string Strength()
	{
		return "Mild";
	}
	
}
