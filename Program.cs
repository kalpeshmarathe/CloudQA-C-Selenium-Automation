using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


class cloudQAFormAutomationTest {

    public static void Main()
    {

        IWebDriver driver = new ChromeDriver();

        try
        {
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");
            Thread.Sleep(2000);


            var firstNameInput = driver.FindElement(By.XPath("/html/body/div[1]/form/div[1]/div[2]/input"));
            firstNameInput.SendKeys("Kalpesh");

            var lastNameInput = driver.FindElement(By.XPath("/html/body/div[1]/form/div[1]/div[3]/input"));
            lastNameInput.SendKeys("Marathe");

            var genderInput = driver.FindElement(By.XPath("/html/body/div[1]/form/div[1]/div[4]/div/input[1]"));
            genderInput.Click();

            var DOBInput = driver.FindElement(By.XPath("/html/body/div[1]/form/div[1]/div[5]/input"));
            DOBInput.SendKeys("2003-08-12");

            var emailInput = driver.FindElement(By.XPath("/html/body/div[1]/form/div[1]/div[7]/input"));
            emailInput.SendKeys("KalpeshMarathe@gmail.com");

            var submit = driver.FindElement(By.XPath("/html/body/div[1]/form/div[4]/button[1]"));
            submit.Click();
            
        }
        catch (Exception ex) {

            Console.WriteLine("❌ Test failed: " + ex.Message);
        }finally
        {
            Thread.Sleep(3000);
            driver.Quit();
        }

    }


}


