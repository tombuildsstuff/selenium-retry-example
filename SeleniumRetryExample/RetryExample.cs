using System;
using System.Threading;
using OpenQA.Selenium;

namespace SeleniumRetryExample
{
  public static class RetryExample
  {
    public static void AttemptToPerformAction(this IWebElement element, Action action, int numberOfTimesToRetry = 3, int secondsBetweenRetries = 5)
    {
      for (var attempt = 1; attempt <= numberOfTimesToRetry ; attempt++)
      {
        try
        {
          action();
          Thread.Sleep(secondsBetweenRetries);
        }
        catch
        {
          if (attempt < numberOfTimesToRetry) {
            continue;
          }

          throw;
        }
      }
    }
  }
}