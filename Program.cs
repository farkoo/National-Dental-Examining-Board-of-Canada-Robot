using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using IronXL;
using whatsapp_robot.tywebservice;

namespace whatsapp_robot
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //final fl = new final();
            //Application.Run(fl);

            ChromeDriver driver;

        ineligible0:
            try
            {
            ineligible:
                Process[] AllProcesses = Process.GetProcesses();
                foreach (var process in AllProcesses)
                {
                    if (process.MainWindowTitle != "")
                    {
                        string s = process.ProcessName.ToLower();
                        //if (s == "iexplore" || s == "iexplorer" || s == "chrome" || s == "firefox")
                        if (s == "chrome")
                        {
                            try
                            {
                                process.Kill();
                            }
                            catch { }
                        }
                        else if (s == "chromedriver")
                        {
                            try
                            {
                                process.Kill();
                            }
                            catch { }
                        }
                    }
                }
                Thread.Sleep(1000);
                System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", "C:\\chromedriver.exe");
                ChromeOptions options = new ChromeOptions();
                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                string[] substrings = userName.Split('\\');
                options.AddArgument("user-data-dir=C:/Users/" + substrings[1] + "/AppData/Local/Google/Chrome/User Data/Default");
                options.AddArgument("--start-maximized");
                options.AddArgument("--disable-application-cache");
                driver = new ChromeDriver(options);
            label1:
                try
                {

                    driver.Navigate().GoToUrl("https://ndeb-bned.my.site.com/s/login/?language=en_CA&startURL=%2Fs%2Fregistrations%3Flanguage%3Den_CA%26tabset-603fc%3D696fb%26t%3D1676199243083");
                }
                catch
                {
                    goto label1;
                }




                driver.Manage().Cookies.DeleteAllCookies(); //delete all cookies
                Thread.Sleep(4000);

                try
                {
                    ReadOnlyCollection<IWebElement> username = driver.FindElements(By.XPath("/html/body/div[3]/div[2]/div/div[2]/div/div[2]/div/div[1]/div/input")); //_13NKt
                    username[0].SendKeys("sh.tehrani333@gmail.com");
                    ReadOnlyCollection<IWebElement> password = driver.FindElements(By.XPath("/html/body/div[3]/div[2]/div/div[2]/div/div[2]/div/div[2]/div/input")); //_13NKt
                    password[0].SendKeys("az09122368982");
                    Thread.Sleep(500);
                    ReadOnlyCollection<IWebElement> login = driver.FindElements(By.XPath("/html/body/div[3]/div[2]/div/div[2]/div/div[2]/div/div[3]/button")); //_13NKt
                    login[0].SendKeys(OpenQA.Selenium.Keys.Enter);
                    Thread.Sleep(500);
                }
                catch
                {
                    try
                    {
                        ReadOnlyCollection<IWebElement> username = driver.FindElements(By.XPath("/html/body/div[3]/div[2]/div/div[2]/div/div[2]/div/div[1]/div/input"));//driver.FindElements(By.XPath("/html/body/div[3]/div[2]/div/div[2]/div/div[2]/div/div[1]/div/input")); //_13NKt
                        username[0].SendKeys("sh.tehrani333@gmail.com");
                        ReadOnlyCollection<IWebElement> password = driver.FindElements(By.XPath("/html/body/div[3]/div[2]/div/div[2]/div/div[2]/div/div[2]/div/input")); //_13NKt
                        password[0].SendKeys("az09122368982");
                        Thread.Sleep(500);
                        ReadOnlyCollection<IWebElement> login = driver.FindElements(By.XPath("/html/body/div[3]/div[2]/div/div[2]/div/div[2]/div/div[3]/button")); //_13NKt
                        login[0].SendKeys(OpenQA.Selenium.Keys.Enter);
                        Thread.Sleep(500);
                    }
                    catch
                    {
                        // goto
                        goto ineligible;
                    }
                }


                Thread.Sleep(500);
                int flag = 0;
                while (flag != 1)
                {
                    try
                    {
                        ReadOnlyCollection<IWebElement> registrations = driver.FindElements(By.XPath("/html/body/div[3]/div[2]/div/div[1]/div/div/div/section[2]/div/div/article/div/flowruntime-flow/flowruntime-navigation-bar/footer/div[2]/lightning-button/button")); //_13NKt
                        registrations[0].SendKeys(OpenQA.Selenium.Keys.Enter);
                        flag = 1;
                    }
                    catch
                    {

                    }
                }
                Thread.Sleep(500);
                flag = 0;
                while (flag != 1)
                {
                    try
                    {
                        ReadOnlyCollection<IWebElement> next2 = driver.FindElements(By.XPath("/html/body/div[3]/div[2]/div/div[1]/div/div/div/section[2]/div/div/article/div/flowruntime-flow/flowruntime-lwc-body/div/flowruntime-list-container/div/flowruntime-base-section/div/flowruntime-screen-field[2]/flowruntime-lwc-field/div/flowruntime-datatable/div/div/flowruntime-datatable-custom-types/div[2]/div/div/table/tbody/tr/td[1]/lightning-primitive-cell-checkbox/span/label/span[1]")); //_13NKt
                        next2[0].Click();
                        flag = 1;
                        ReadOnlyCollection<IWebElement> next3 = driver.FindElements(By.XPath("/html/body/div[3]/div[2]/div/div[1]/div/div/div/section[2]/div/div/article/div/flowruntime-flow/flowruntime-navigation-bar/footer/div[2]/lightning-button[2]/button")); //_13NKt
                        next3[0].Click();
                    }
                    catch
                    {

                    }
                }
                // slds-button_brand
                //ReadOnlyCollection<IWebElement> registrations2 = driver.FindElements(By.XPath("/html/body/div[3]/div[2]/div/div[1]/div/div/div/section[2]/div/div/article/div/div/div[2]/footer/div[2]/button"));
                Thread.Sleep(3000);
                ReadOnlyCollection<IWebElement> registrations2 = driver.FindElements(By.XPath("/html/body/div[3]/div[2]/div/div[1]/div/div/div/section[2]/div/div/article/div/flowruntime-flow/flowruntime-navigation-bar/footer/div[2]/lightning-button/button"));
                //while (registrations2.Count != 1)
                //{
                //    try
                //    {
                //        registrations2 = driver.FindElements(By.XPath("/html/body/div[3]/div[2]/div/div[1]/div/div/div/section[2]/div/div/article/div/div/div[2]/footer/div[2]/button"));
                //    }
                //    catch
                //    {
                //        goto ineligible; 
                //    }
                //}
                try
                {
                    if (!String.Equals(registrations2[0].Text, "Finish"))
                    {
                        Thread.Sleep(2000);
                        registrations2 = driver.FindElements(By.XPath("/html/body/div[3]/div[2]/div/div[1]/div/div/div/section[2]/div/div/article/div/flowruntime-flow/flowruntime-navigation-bar/footer/div[2]/lightning-button/button"));
                        if (!String.Equals(registrations2[0].Text, "Finish"))
                        {

                            
                            for (int i = 1; i < 100; i=i+1)
                            {
                                string pathh = "/html/body/div[3]/div[2]/div/div[1]/div/div/div/section[2]/div/div/article/div/flowruntime-flow/flowruntime-lwc-body/div/flowruntime-list-container/div/flowruntime-base-section/div/flowruntime-screen-field[2]/flowruntime-lwc-field/div/flowruntime-datatable/div/div/flowruntime-datatable-custom-types/div[2]/div/div/table/tbody/tr[" + i.ToString() + "]/th/lightning-primitive-cell-factory/div/lightning-primitive-custom-cell/lightning-formatted-rich-text";
                                ReadOnlyCollection<IWebElement> next2 = driver.FindElements(By.XPath(pathh)); //_13NKt
                                if (next2.Count == 0)
                                    break;
                                if (!next2[0].Text.Contains("New York") & !next2[0].Text.Contains("Los Angeles") & !next2[0].Text.Contains("Washington") & !next2[0].Text.Contains("Pennsylvania") & !next2[0].Text.Contains("Michigan"))
                                {
                                    string UserName = "09131045241";
                                    string Password = "150000";

                                    int messageId = 22958795;
                                    string number = "09122368982";
                                    bool vote = false;
                                    int serverid = 0;

                                    ir.avanak.portal.WebService3 client2 = new ir.avanak.portal.WebService3();
                                    var quickSendId = client2.QuickSend(UserName, Password, messageId, number, vote, serverid);

                                    //var client = new TyWebService();
                                    //client.avanak("09135547596");
                                    DateTime now = DateTime.Now;
                                    string path = @"C:\Users\Administrator\Desktop\log.txt";
                                    //string path = @"C:\Users\farzaneh\Desktop\log.txt";
                                    using (StreamWriter w = File.AppendText(path))
                                    {
                                        w.Write("Was warned");
                                    }
                                    using (StreamWriter w = File.AppendText(path))
                                    {
                                        w.Write(now);
                                    }
                                    using (StreamWriter w = File.AppendText(path))
                                    {
                                        w.Write("\n");
                                    }
                                }
                                else {
                                    //farkooooooooooooo
                                    DateTime now = DateTime.Now;
                                    string path = @"C:\Users\Administrator\Desktop\log.txt";
                                    //string path = @"C:\Users\farzaneh\Desktop\log.txt";
                                    using (StreamWriter w = File.AppendText(path))
                                    {
                                        w.Write("List      ");
                                    }
                                    using (StreamWriter w = File.AppendText(path))
                                    {
                                        w.Write(now);
                                    }
                                    using (StreamWriter w = File.AppendText(path))
                                    {
                                        w.Write("\n");
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        DateTime now = DateTime.Now;
                        string path = @"C:\Users\Administrator\Desktop\log.txt";
                        //string path = @"C:\Users\farzaneh\Desktop\log.txt";
                        using (StreamWriter w = File.AppendText(path))
                        {
                            w.Write("Unchanged ");
                        }
                        using (StreamWriter w = File.AppendText(path))
                        {
                            w.Write(now);
                        }
                        using (StreamWriter w = File.AppendText(path))
                        {
                            w.Write("\n");
                        }
                    }
                }
                catch
                {
                    DateTime now = DateTime.Now;
                    string path = @"C:\Users\Administrator\Desktop\log.txt";
                    //string path = @"C:\Users\farzaneh\Desktop\log.txt";
                    using (StreamWriter w = File.AppendText(path))
                    {
                        w.Write("Catch ");
                    }
                    using (StreamWriter w = File.AppendText(path))
                    {
                        w.Write(now);
                    }
                    using (StreamWriter w = File.AppendText(path))
                    {
                        w.Write("\n");
                    }

                    goto ineligible;
                }

                Thread.Sleep(15000);
                Main();
            }
            catch
            {
                goto ineligible0;
            }
        }
    }
}
