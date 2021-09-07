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
public class VerifylinksBGTest {
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
  public void eNOHome() {
    driver.Navigate().GoToUrl("https://entrepreneursnightout.org/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.Id("default-btn-7e855bcd41393a898fa938294f4e9cd3")).Click();
    driver.FindElement(By.CssSelector("#primary-menu > .menu-item-home .menu-text")).Click();
    driver.FindElement(By.Id("default-btn-eb01668d047f65716cb63961966430c7")).Click();
    driver.FindElement(By.CssSelector("#primary-menu > .menu-item-home .menu-text")).Click();
    driver.FindElement(By.Id("default-btn-931daf93814eb8fdc52da4ba40c94f52")).Click();
    driver.FindElement(By.CssSelector("#primary-menu > .menu-item-home .menu-text")).Click();
    driver.FindElement(By.Id("default-btn-fe06c86a499f5fb5ee18360c42d1ac98")).Click();
    driver.FindElement(By.CssSelector(".branding .preload-me:nth-child(1)")).Click();
    driver.Close();
  }
  [Test]
  public void eNOAbout() {
    driver.Navigate().GoToUrl("https://entrepreneursnightout.org/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.CssSelector("#primary-menu > .menu-item-15135 .menu-text")).Click();
    driver.FindElement(By.Id("default-btn-4826a041ea988986a17602417fe3ee63")).Click();
    driver.FindElement(By.CssSelector("#primary-menu > .menu-item-15135 .menu-text")).Click();
    vars["WindowHandles"] = driver.WindowHandles;
    driver.FindElement(By.Id("default-btn-9ef0547e3f9d6d39165e00522a2a4ef9")).Click();
    vars["win1328"] = waitForWindow(2000);
    vars["root"] = driver.CurrentWindowHandle;
    driver.SwitchTo().Window(vars["win1328"].ToString());
    driver.Close();
    driver.SwitchTo().Window(vars["root"].ToString());
    vars["WindowHandles"] = driver.WindowHandles;
    driver.FindElement(By.Id("default-btn-44c8ea0252f45e12196ab77954aeb6a0")).Click();
    vars["win2529"] = waitForWindow(2000);
    driver.SwitchTo().Window(vars["win2529"].ToString());
    driver.Close();
    driver.SwitchTo().Window(vars["root"].ToString());
    driver.FindElement(By.CssSelector(".branding .preload-me:nth-child(1)")).Click();
    driver.Close();
  }
  [Test]
  public void eNOEvents() {
    driver.Navigate().GoToUrl("https://entrepreneursnightout.org/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.CssSelector("#primary-menu > .menu-item-15249 .menu-text")).Click();
    driver.FindElement(By.CssSelector(".ult-item-wrap:nth-child(1) .vc_icon_element-link")).Click();
    driver.FindElement(By.CssSelector("#primary-menu > .menu-item-15249 .menu-text")).Click();
    driver.FindElement(By.Id("default-btn-84b96bc88cd105e9fbd1ca23a5a1d3d0")).Click();
    driver.FindElement(By.CssSelector("#primary-menu > .menu-item-15249 .menu-text")).Click();
    vars["WindowHandles"] = driver.WindowHandles;
    driver.FindElement(By.Id("default-btn-8b8d003413e3f28048ed990706c26011")).Click();
    vars["win2886"] = waitForWindow(2000);
    vars["root"] = driver.CurrentWindowHandle;
    driver.SwitchTo().Window(vars["win2886"].ToString());
    driver.Close();
    driver.SwitchTo().Window(vars["root"].ToString());
    vars["WindowHandles"] = driver.WindowHandles;
    driver.FindElement(By.Id("default-btn-2a25df5ca740cf83cf10aeb7ae30502b")).Click();
    vars["win4750"] = waitForWindow(2000);
    driver.SwitchTo().Window(vars["win4750"].ToString());
    driver.Close();
    driver.SwitchTo().Window(vars["root"].ToString());
    driver.FindElement(By.CssSelector(".branding .preload-me:nth-child(1)")).Click();
    driver.Close();
  }
  [Test]
  public void eNOPictures() {
    driver.Navigate().GoToUrl("https://entrepreneursnightout.org/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.CssSelector("#primary-menu > .menu-item-15248 .menu-text")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[1]/div[4]/div/div/div/div/div/div/div/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[1]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[2]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[2]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[3]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[4]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[5]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[6]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[7]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[8]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[9]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[10]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[11]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[12]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[13]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[14]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[15]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[16]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[17]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[18]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[19]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[20]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[21]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[22]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[23]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[24]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[25]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[26]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[27]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[28]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[29]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[30]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[31]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[32]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[33]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[34]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[35]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[36]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[37]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[38]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[39]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[40]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"primary-menu\"]/li[4]/a/span/span")).Click();
    driver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div/div/div/div/div/div[1]/div[41]/div[1]/div/div[2]/a")).Click();
    driver.FindElement(By.XPath("//*[@id=\"page\"]/div[2]/header/div/a/img[1]")).Click();
    driver.Close();
  }
}
