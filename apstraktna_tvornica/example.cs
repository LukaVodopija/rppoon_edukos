using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apstraktna_tvornica
{
	public abstract class Wizard
	{
		public abstract void DoMagic();
	}
	public abstract class Goblin
	{
		public abstract void DoDamage();
	}
	public class FireWizard : Wizard
	{
		public override void DoMagic()
		{
			Console.WriteLine("Do Fire Magic");
		}
	}

	public class WaterWizard : Wizard
	{
		public override void DoMagic()
		{
			Console.WriteLine("Do Water Magic");
		}
	}

	public class FireGoblin : Goblin
	{
		public override void DoDamage()
		{
			Console.WriteLine("Do Fire Damage");
		}
	}

	public class WaterGoblin : Goblin
	{
		public override void DoDamage()
		{
			Console.WriteLine("Do Water Damage");
		}
	}

	public abstract class CharacterFactory
	{
		public abstract Wizard CreateWizard();
		public abstract Goblin CreateGoblin();
	}

	public class CreateFireCharacter : CharacterFactory
	{
		public override Wizard CreateWizard()
		{
			return new FireWizard();
		}
		public override Goblin CreateGoblin()
		{
			return new FireGoblin();
		}
	}

	public class CreateWaterCharacter : CharacterFactory
	{
		public override Wizard CreateWizard()
		{
			return new WaterWizard();
		}
		public override Goblin CreateGoblin()
		{
			return new WaterGoblin();
		}
	}

	public class GameManager
	{
		public void PlayWaterLevel()
		{
			WaterGoblin waterGoblin = new WaterGoblin();
			WaterWizard waterWizard = new WaterWizard();
			waterGoblin.DoDamage();
			waterWizard.DoMagic();
		}

		public void PlayFireLevel()
		{
			FireGoblin fireGoblin = new FireGoblin();
			FireWizard fireWizard = new FireWizard();
			fireGoblin.DoDamage();
			fireWizard.DoMagic();
		}
	}
}
