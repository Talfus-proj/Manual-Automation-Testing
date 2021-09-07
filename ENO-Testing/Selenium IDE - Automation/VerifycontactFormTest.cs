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
public class VerifycontactFormTest {
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
  [Test]
  public void eNOContactFormEN() {
    driver.Navigate().GoToUrl("https://entrepreneursnightout.org/en");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.CssSelector("#primary-menu > .menu-item-16017 .menu-text")).Click();
    driver.FindElement(By.Name("your-name")).SendKeys("testenglish");
    driver.FindElement(By.Name("your-email")).SendKeys("testen@gmail.com");
    driver.FindElement(By.Name("tel-707")).SendKeys("161670197");
    driver.FindElement(By.Name("your-subject")).SendKeys("testenglish");
    driver.FindElement(By.Name("your-message")).SendKeys("english test send");
    driver.FindElement(By.CssSelector(".wpcf7-submit")).Click();
    driver.Close();
  }
  [Test]
  public void eNOContactFormBG() {
    driver.Navigate().GoToUrl("https://entrepreneursnightout.org/");
    driver.Manage().Window.Size = new System.Drawing.Size(1936, 1056);
    driver.FindElement(By.CssSelector("#primary-menu > .menu-item-15178 .menu-text")).Click();
    driver.FindElement(By.Name("your-name")).SendKeys("testbgtest");
    driver.FindElement(By.Name("your-email")).SendKeys("testbgtest@gmail.com");
    driver.FindElement(By.Name("tel-707")).SendKeys("31154367");
    driver.FindElement(By.Name("your-subject")).SendKeys("TestBG");
    driver.FindElement(By.Name("your-message")).SendKeys("TestBGTesttest");
    driver.FindElement(By.CssSelector(".wpcf7-submit")).Click();
    driver.Close();
  }
}
