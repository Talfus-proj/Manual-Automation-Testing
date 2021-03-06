// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class VerifyfooterLinksTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  public string waitForWindow(int timeout) {
    try {
      Thread.Sleep(timeout);
    } catch(Exception e) {
      Console.WriteLine("{0} Exception caught.", e);
    }
    var whNow = ((IReadOnlyCollection<object>)driver.WindowHandles).ToList();
    var whThen = ((IReadOnlyCollection<object>)vars["WindowHandles"]).ToList();
    if (whNow.Count > whThen.Count) {
      return whNow.Except(whThen).First().ToString();
    } else {
      return whNow.First().ToString();
    }
  }
  [Test]
  public void eNOFooter() {
    driver.Navigate().GoToUrl("https://entrepreneursnightout.org/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    vars["WindowHandles"] = driver.WindowHandles;
    driver.FindElement(By.CssSelector(".wp-image-15597")).Click();
    vars["win5593"] = waitForWindow(2000);
    vars["root"] = driver.CurrentWindowHandle;
    driver.SwitchTo().Window(vars["win5593"].ToString());
    driver.Close();
    driver.SwitchTo().Window(vars["root"].ToString());
    vars["WindowHandles"] = driver.WindowHandles;
    driver.FindElement(By.CssSelector(".wp-image-15598")).Click();
    vars["win1902"] = waitForWindow(2000);
    driver.SwitchTo().Window(vars["win1902"].ToString());
    driver.Close();
    driver.SwitchTo().Window(vars["root"].ToString());
    vars["WindowHandles"] = driver.WindowHandles;
    driver.FindElement(By.CssSelector(".wp-image-15599")).Click();
    vars["win1796"] = waitForWindow(2000);
    driver.SwitchTo().Window(vars["win1796"].ToString());
    driver.Close();
    driver.SwitchTo().Window(vars["root"].ToString());
    vars["WindowHandles"] = driver.WindowHandles;
    driver.FindElement(By.CssSelector("a:nth-child(4) > .alignnone")).Click();
    vars["win347"] = waitForWindow(2000);
    driver.SwitchTo().Window(vars["win347"].ToString());
    driver.Close();
    driver.SwitchTo().Window(vars["root"].ToString());
    vars["WindowHandles"] = driver.WindowHandles;
    driver.FindElement(By.CssSelector("a:nth-child(5) > .alignnone")).Click();
    vars["win6651"] = waitForWindow(2000);
    driver.SwitchTo().Window(vars["win6651"].ToString());
    driver.Close();
    driver.SwitchTo().Window(vars["root"].ToString());
    vars["WindowHandles"] = driver.WindowHandles;
    driver.FindElement(By.CssSelector(".wf-float-left font")).Click();
    vars["win5249"] = waitForWindow(2000);
    driver.SwitchTo().Window(vars["win5249"].ToString());
    driver.Close();
    driver.SwitchTo().Window(vars["root"].ToString());
    vars["WindowHandles"] = driver.WindowHandles;
    driver.FindElement(By.CssSelector("p > a:nth-child(1) > font")).Click();
    vars["win244"] = waitForWindow(2000);
    driver.SwitchTo().Window(vars["win244"].ToString());
    driver.Close();
    driver.SwitchTo().Window(vars["root"].ToString());
    vars["WindowHandles"] = driver.WindowHandles;
    driver.FindElement(By.CssSelector("a:nth-child(3) > font")).Click();
    vars["win3450"] = waitForWindow(2000);
    driver.SwitchTo().Window(vars["win3450"].ToString());
    driver.Close();
    driver.SwitchTo().Window(vars["root"].ToString());
    driver.FindElement(By.CssSelector("#branding-bottom .preload-me")).Click();
    driver.Close();
  }
}
