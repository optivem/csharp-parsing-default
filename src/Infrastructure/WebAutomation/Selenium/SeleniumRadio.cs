﻿using OpenQA.Selenium;
using Optivem.Common.WebAutomation;

namespace Optivem.Infrastructure.Selenium
{
    public class SeleniumRadio : BaseSeleniumElement, IRadio
    {
        public SeleniumRadio(IWebElement element) : base(element)
        {
        }

        public void Select()
        {
            Element.Click();
        }

        public bool Selected
        {
            get
            {
                return Element.Selected;
            }
        }
    }
}