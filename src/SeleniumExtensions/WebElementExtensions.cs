using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumExtensions
{
	public static class WebElementExtensions
	{
		public static WebDriverWait SendKeysAndWait(this IWebElement element, IWebDriver driver, string content, int seconds = 3)
		{
			element.SendKeys(content);
			return new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
		}

		public static WebDriverWait ClickAndWait(this IWebElement element, IWebDriver driver, int seconds = 3)
		{
			element.Click();
			return new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
		}

	}
}
