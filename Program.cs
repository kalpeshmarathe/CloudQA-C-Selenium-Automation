using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



class cloudQAFormAutomationTest
{

    public static void Main()
    {
      
        IWebDriver driver = new ChromeDriver();

        try
        {
            // Navigate to the CloudQA Automation Practice Form URL
            driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

            // Wait for the page to load 
            Thread.Sleep(2000);

            // Fill in the First Name field
            var firstName = driver.FindElement(By.Name("First Name")); // Entering my first name
            firstName.SendKeys("Kalpesh");

            // Fill in the Last Name field
            var lastNameInput = driver.FindElement(By.Name("Last Name")); ;
            lastNameInput.SendKeys("Marathe"); // Entering my last name


            // Enter Date of Birth
            var DOBInput = driver.FindElement(By.Id("dob")); ;
            DOBInput.SendKeys("2003-08-12"); // Format should be yyyy-mm-dd

            // Fill in Email address
            var emailInput = driver.FindElement(By.Name("Email")); ;
            emailInput.SendKeys("KalpeshMarathe@gmail.com"); // Typing email

            // Click the Submit button
            var submit = driver.FindElement(By.XPath("/html/body/div[1]/form/div[4]/button[1]")); ;
            submit.Click(); // Submitting the form

        }
        catch (Exception ex)
        {
            // Catch any errors that occur and print them
            Console.WriteLine("Test failed: " + ex.Message);
        }
        finally
        {
            // Wait for 3 seconds before closing the browser
            Thread.Sleep(3000);

            // Close the browser
            driver.Quit();
        }
    }
}
