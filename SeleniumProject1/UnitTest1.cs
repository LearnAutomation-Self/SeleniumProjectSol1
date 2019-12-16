using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using excel = Microsoft.Office.Interop.Excel;





namespace SeleniumProject1
{
	public class Tests
	{


		[SetUp]
		public void Setup()
		{


		}

		[Test]
		public void Test1()
		{
		
			//Assert.Pass();

			//IWebDriver driver = new ChromeDriver();
			
			// Test1.Testmethod("", "");
			IWebDriver driver = new ChromeDriver();

			driver.Navigate().GoToUrl("https://www.lux.com/in/home.html");
			driver.FindElement(By.XPath("/html//section[@id='contentWrapperSection']/footer/div[@class='footerpar iparsys parsys']/div[@class='component-wrapper section']/div/div//ul[@class='c-global-footer-v2-list']/li[@class='c-global-footer-v2-list__item col-sm-6']/ul[1]//a[@title='Contact Us']")).Click();


			//string s1;
			//string s2 = "If you are reporting a problem with one of our products, please be sure to include your address and a telephone number where you can be reached during the day so we can contact you for further information.";
			//string s3 = "Type of Inquiry *";
			//string s4;
			//s1 = driver.FindElement(By.XPath("/html//section[@id='contentWrapperSection']/div[@class='flexi_hero_par parsys']/div[2]/div/div/div/div[@class='column-container row']/div[@class='col-md-8']/div[@class='container_par_1 parsys']/div[3]/div/div//div[@class='c-rich-text-v2__description js-ct-linkclick']/p[1]")).Text;
			//s4 = driver.FindElement(By.XPath("/html//section[@id='contentWrapperSection']/div[@class='flexi_hero_par parsys']/div[2]/div/div/div/div[@class='column-container row']/div[@class='col-md-8']/div[@class='container_par_1 parsys']/div[5]/div/form[@role='form']/div[1]/div//label[@class='c-control-label']")).Text;
			//ContactUs _contactUs = new ContactUs(driver);
			//if (s2.Equals(s1))
			//	if (s3.Equals(s4))

			//		_contactUs.FillFormTypeofInq();

			////_contactUs.FillFormEmail();


			ContactUs _contactUs = new ContactUs(driver);

			_contactUs.LableTest();

		}


	}
}