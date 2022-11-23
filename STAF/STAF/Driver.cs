using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace STAF
{
    public static class Driver
	{
		public static IWebDriver Instance { get; private set; }

		public static IJavaScriptExecutor JSInstance { get; private set; }

		public static Actions ActionsInstance { get; private set; }

		public static void Initialize(Browser browserType)
		{
			if (browserType == Browser.Chrome)
			{
				var chromeOptions = (ChromeOptions)getChromeOptions().BrowserOptions;
				chromeOptions.AddArgument("--no-sandbox");
				Instance = new ChromeDriver(ChromeDriverService.CreateDefaultService(), chromeOptions ?? new ChromeOptions(), TimeSpan.FromMinutes(3));
			}
			Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10.0);
			ActionsInstance = new Actions(Instance);
			JSInstance = (IJavaScriptExecutor)Instance;
		}

		public static void GoToUrl(this string url)
		{
			Instance.Navigate().GoToUrl(url);
		}

		public static void Refresh()
		{
			Instance.Navigate().Refresh();
		}

		public static void Close()
		{
			Instance.Close();
		}

		public static void Quit()
		{
			IWebDriver instance = Instance;
			if (instance != null)
			{
				instance.Quit();
			}
		}

		public static void Wait(int sec)
        {
			Thread.Sleep(sec*1000);
        }

		public static Size GetWindowSize()
		{
			return Instance.Manage().Window.Size;
		}

		public static DriverInitializeOptions getChromeOptions()
		{
			ChromeOptions browserOptions = new ChromeOptions();
			return new DriverInitializeOptions
			{
				WindowSize = new Size(1920, 1080),
				BrowserType = Browser.Chrome,
				BrowserOptions = browserOptions
			};
		}

		public static IWebElement FindElement(By by, int seconds)
		{
			Exception exception = null;
			if (Driver.CheckElementExist(by, seconds))
			{
				var results = FindElements(by, seconds, ref exception);

				if (results.Count > 0)
				{
					return results[0];
				}
			}
			throw new NoSuchElementException($"Element was not found by:\n{by}", exception);
		}

		public static bool CheckElementExist(this By by, int seconds)
		{
			bool flag = false;
			try
			{
				Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
				Instance.FindElement(by);
				return flag = true;
			}
			catch (Exception ex)
			{
				return flag;
			}
		}

		private static ReadOnlyCollection<IWebElement> FindElements(By by, int seconds, ref Exception exception)
		{
			seconds = ((seconds == 0) ? seconds : 10);
			Exception ex = exception;
			ReadOnlyCollection<IWebElement> elements = null;
			try
			{
				WebDriverWait val = new WebDriverWait(Instance, TimeSpan.FromSeconds(seconds));
				((DefaultWait<IWebDriver>)(object)val).Until<bool>((Func<IWebDriver, bool>)delegate (IWebDriver driver)
				{
					ex = RetryAction(delegate
					{
						elements = by.FindElements((ISearchContext)(object)driver);
					}, "FindElements");
					return elements.Count > 0;
				});
				exception = ex;
			}
			catch (WebDriverTimeoutException val2)
			{
				WebDriverTimeoutException val3 = val2;
				exception = (Exception)new WebDriverTimeoutException(((Exception)(object)val3).Message, ex);
			}
			return elements;
		}

		internal static Exception RetryAction(Action action, [CallerMemberName] string methodName = "")
		{
			Exception result = null;
			int num = 0;
			while (num < 2)
			{
				num++;
				try
				{
					action();
					return null;
				}
				catch (Exception ex)
				{
					result = ex;
					Thread.Sleep(200);
				}
			}
			return result;
		}
	}
}
