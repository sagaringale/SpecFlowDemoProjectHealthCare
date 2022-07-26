﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;

namespace SpecFlowLinkGroupDemo.Utils.Selenium
{
    public static class Driver
    {
        [ThreadStatic]
        public static IWebDriver CurrentDriver;

        public static void InitChrome()
        {
            CurrentDriver = new ChromeDriver(Path.GetFullPath(@"../../../../" + "_drivers"));
        }

        public static void InitFirefox()
        {
            CurrentDriver = new FirefoxDriver(Path.GetFullPath(@"../../../../" + "_drivers"));
        }
    }
}