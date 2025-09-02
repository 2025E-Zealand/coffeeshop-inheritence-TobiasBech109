using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Coffee
{
	public string Description { get; set; }

	public string 
	public Coffee()
	{
		Description = "Unknown Coffee";
	}

	public virtual double Cost()
	{
		return 0.0;
	}

	public abstract string Strength()
	{
		if (Description == Latte)
			return "Weak";
		else if (Description == Cortado)
			return "Medium";
		else if (Description == BlackCoffe)
			return "Strong";
		else
			return "Unknown Strength";
	}
}
