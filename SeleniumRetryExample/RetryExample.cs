using System;
using OpenQA.Selenium;

namespace SeleniumRetryExample
{
  public static class RetryExample
  {
    public static void AttemptToPerformAction(this IWebElement element, Action action, int numberOfTimesToRetry = 3, int secondsBetweenRetries = 5)
    {
      for (var attempt = 0; attempt <= numberOfTimesToRetry ; attempt++)
      {
        try
        {
          action();
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