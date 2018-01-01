﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;

namespace EndToEndCourse._05
{
    [TestFixture]
    public class Workshop05Tests
    {
        private string testUrl = "https://suvroc.github.io/selenium-course/05/workshop.html";

        [Test]
        public void ShouldSelectAnswers()
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl(testUrl);

            var qualityElement = driver.FindElement(By.Id("procuctQualityElement"));
            var supportElement = driver.FindElement(By.Id("supportQualityElement"));

            #region TEST

            #endregion

            Assert.AreEqual(qualityElement.GetAttribute("value"), "good");
            Assert.AreEqual(supportElement.GetAttribute("value"), "poor");

            driver.Quit();
        }
    }
}
