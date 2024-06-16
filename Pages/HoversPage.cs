using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_17.Factory;
using OpenQA.Selenium.Interactions;

namespace Homework_17.Pages
{
    internal class HoversPage
    {
        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/hovers");
        }
    }
}


//*[@class ='example']//div[1]//img
//*[@class ='example']//div[2]//img
//*[@class ='example']//div[3]//img