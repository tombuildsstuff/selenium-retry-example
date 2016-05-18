using OpenQA.Selenium;

namespace SeleniumRetryExample
{
  class Program
  {
    public static void Main(string[] args)
    {
      Foo();
    }

    public static void Foo()
    {
      IWebElement element = null; // TODO: found through some other means

      element.AttemptToPerformAction(() =>
      {
        element.Click();
      }, 3, 5);
    }
  }
}


