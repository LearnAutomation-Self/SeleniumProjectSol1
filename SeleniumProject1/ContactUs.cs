using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
using System.IO;



using System.Data;

namespace SeleniumProject1
{


    public class ContactUs
    {


        


        IWebDriver driver;
        By TypeOfInq = By.XPath("/html//select[@id='contactUs-inquiryType']");
        By Email = By.XPath("/html//input[@id='contact-email']");
        By FirstName = By.XPath("html//input[@id='contact-givenName']");
        By LastName = By.XPath("/html//input[@id='contact-familyName']");


        public ContactUs(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void FillFormTypeofInq()
        {
            var option = driver.FindElement(TypeOfInq);
            var selectElement = new SelectElement(option);
            System.Threading.Thread.Sleep(5000);
            selectElement.SelectByText("Product Concern");
            //driver.FindElement(TypeOfInq).SendKeys("");
        }

        public void FillFormEmail() 
        {

            driver.FindElement(Email).SendKeys("abcd@1234");
        }

        public void FillFormFirstNameq()
        {
            driver.FindElement(FirstName);

        }

        public void FillFormLast()
        {

            driver.FindElement(LastName);
        }

        public void LableTest() 

        {
            string Lable1 = "Type of Inquiry *";
            string Lable2 = "Email Address *";

            By lable1xpath = By.XPath("/html//section[@id='contentWrapperSection']/div[@class='flexi_hero_par parsys']/div[2]/div/div/div/div[@class='column-container row']/div[@class='col-md-8']/div[@class='container_par_1 parsys']/div[5]/div/form[@role='form']/div[1]/div//label[@class='c-control-label']");
            By lablexpath2 = By.XPath("/html//section[@id='contentWrapperSection']/div[@class='flexi_hero_par parsys']/div[2]/div/div/div/div[@class='column-container row']/div[@class='col-md-8']/div[@class='container_par_1 parsys']/div[5]/div/form[@role='form']/div[3]/div//label[@class='c-control-label']");

            string t = driver.FindElement(lable1xpath).Text; 

            if (t.Equals(Lable1))
            { 
                //System.Diagnostics.Debug.WriteLine("Find Lable1");


                Debug.WriteLine("Find Lable1");
                //log4net.Config.BasicConfigurator.Configure();


                ////excel.Application xapp = new excel.Application();
                ////excel.Workbook x1workbook = xapp.Workbooks.Open(@"C:\VisualStudioSelProj\FirsrProject\DataReader\SelLableReader");
                //////x1workbook.Sheets[1];
                ////excel._Worksheet x1worksheet = (excel.Worksheet)x1workbook.Worksheets.get_Item(1);
                ////excel.Range range = x1worksheet.UsedRange;

                //////  loginrange.Cells[1].

                //////    var cellValue = (string)(x1worksheet.Cells[1,1] as excel.Range).Value;


                ////string value = Convert.ToString((range.Cells[1, 1] as excel.Range).Value2);
                ///

                
                

                
             
              




                string path = @"C:\VisualStudioSelProj\Logs" + DateTime.Now.ToString("MMDDYYYY");
                StreamWriter sm = File.AppendText(path);
                sm.WriteLine("Find Lable1");
               
                sm.Close();




            }

            else
            {
                Console.WriteLine("Not Find LAble1");
            }


        }
    }
}
