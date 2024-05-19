using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kava
{
	public interface Coffee
	{
		public double GetCost();
		public String GetDescription();
	}

	public class Espresso : Coffee
	{

		public double GetCost()
		{
			return 1.99;
		}

		public String GetDescription()
		{
			return "Espresso";
		}
	}

	public abstract class CoffeeDecorator : Coffee
	{
		protected Coffee coffee;

		public CoffeeDecorator(Coffee coffee)
		{
			this.coffee = coffee;
		}
		public double GetCost()
		{
			return coffee.GetCost();
		}
		public String GetDescription()
		{
			return coffee.GetDescription();
		}
	}

	public class Milk : CoffeeDecorator
	{

		public Milk(Coffee coffee) : base(coffee) { }

		public double GetCost()
		{
			return base.GetCost() + 1;
		}

		public String GetDescription()
		{
			return base.GetDescription() + "milk";
		}
	}
}
