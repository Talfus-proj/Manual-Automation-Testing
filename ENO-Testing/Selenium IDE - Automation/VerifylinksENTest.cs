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
public class VerifylinksENTest {
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
  public void eNOHomeEN() {
    driver.Navigate().GoToUrl("https://entrepreneursnightout.org/en");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.Id("default-btn-36e2f1ffe57de7385eb4732c55a4b4db")).Click();
    driver.FindElement(By.CssSelector("#primary-menu > .menu-item-home .menu-text")).Click();
    driver.FindElement(By.Id("default-btn-179d07576bdd5642896f264df3328a85")).Click();
    driver.FindElement(By.CssSelector("#primary-menu > .menu-item-home .menu-text")).Click();
    driver.FindElement(By.Id("default-btn-ba67d49997e2cfe09ff4d719043231e4")).Click();
    driver.FindElement(By.CssSelector("#primary-menu > .menu-item-home .menu-text")).Click();
    driver.FindElement(By.Id("default-btn-9e913a2195a9bc82ac977efc0d27ed8f")).Click();
    driver.FindElement(By.CssSelector(".branding .preload-me:nth-child(1)")).Click();
    driver.Close();
  }
  [Test]
  public void eNOAboutEN() {
    driver.Navigate().GoToUrl("https://entrepreneursnightout.org/en");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.LinkText("English")).Click();
    driver.FindElement(By.CssSelector("#primary-menu > .menu-item-16014 .menu-text")).Click();
    driver.FindElement(By.Id("default-btn-09c259ff52de21f5d89493229a3c00d0")).Click();
    driver.FindElement(By.CssSelector("#primary-menu > .menu-item-16014 .menu-text")).Click();
    vars["WindowHandles"] = driver.WindowHandles;
    driver.FindElement(By.Id("default-btn-9a121a2587422680d4a6da77cbcc3f5a")).Click();
    vars["win6772"] = waitForWindow(2000);
    vars["root"] = driver.CurrentWindowHandle;
    driver.SwitchTo().Window(vars["win6772"].ToString());
    driver.Close();
    driver.SwitchTo().Window(vars["root"].ToString());
    vars["WindowHandles"] = driver.WindowHandles;
    driver.FindElement(By.Id("default-btn-eba7bd9540cfb1faf6293e7fea0b99e5")).Click();
    vars["win3124"] = waitForWindow(2000);
    driver.SwitchTo().Window(vars["win3124"].ToString());
    driver.Close();
    driver.SwitchTo().Window(vars["root"].ToString());
    driver.FindElement(By.CssSelector(".branding .preload-me:nth-child(1)")).Click();
    driver.Close();
  }
  [Test]
  public void eNOEventsEN() {
    driver.Navigate().GoToUrl("https://entrepreneursnightout.org/en");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.CssSelector("#primary-menu > .menu-item-16015 .menu-text")).Click();
    driver.FindElement(By.CssSelector(".ult-item-wrap:nth-child(1) .vc_icon_element-link")).Click();
    driver.FindElement(By.CssSelector("#primary-menu > .menu-item-16015 .menu-text")).Click();
    driver.FindElement(By.Id("default-btn-1e3fa1832a413ba01cafe4151fcf23f6")).Click();
    driver.FindElement(By.CssSelector("#primary-menu > .menu-item-16015 .menu-text")).Click();
    vars["WindowHandles"] = driver.WindowHandles;
    driver.FindElement(By.Id("default-btn-83b52c950bf3fec3cff174016982fd95")).Click();
    vars["win8323"] = waitForWindow(2000);
    vars["root"] = driver.CurrentWindowHandle;
    driver.SwitchTo().Window(vars["win8323"].ToString());
    driver.Close();
    driver.SwitchTo().Window(vars["root"].ToString());
    driver.FindElement(By.CssSelector("#ultimate-heading-12996135b27dbcd40 p:nth-child(2)")).Click();
    vars["WindowHandles"] = driver.WindowHandles;
    driver.FindElement(By.Id("default-btn-062c114f408e31d5b76600b51a44ccc4")).Click();
    vars["win6334"] = waitForWindow(2000);
    driver.SwitchTo().Window(vars["win6334"].ToString());
    driver.Close();
    driver.SwitchTo().Window(vars["root"].ToString());
    driver.FindElement(By.CssSelector(".branding .preload-me:nth-child(1)")).Click();
    driver.Close();
  }
}