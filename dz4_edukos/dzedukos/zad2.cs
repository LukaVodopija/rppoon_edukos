using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzedukos
{
	public class WebElement
	{
		string name;
		public WebElement(string name)
		{
			Console.WriteLine($"Found {name}");
			this.name = name;
		}
		public void Click()
		{
			Console.WriteLine($"Clicked {name}");
		}
	}

	public interface LoginPage
	{
		public WebElement loginButton();
		public WebElement usernameInput();
		public WebElement passwordInput();
	}

	public class ChromeLoginPage : LoginPage
	{
		public WebElement loginButton()
		{
			return new WebElement("button");
		}
		public WebElement usernameInput()
		{
			return new WebElement("button");
		}
		public WebElement passwordInput()
		{
			return new WebElement("button");
		}
	}

	public abstract class LoginPageFactory
	{
		public abstract LoginPage CreatePage();
	}

	public class ChromeLoginPageFactory:LoginPageFactory
	{
		public override LoginPage CreatePage()
		{
			return new ChromeLoginPage();
		}
	}
}
