using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool_IG
{
    public partial class Form1 : Form
    {

        bool run = false;
        string file_accounts_path = "accounts.txt";
        ChromeDriver driverig;
        ChromeDriver driverinss;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AllowUserToResizeColumns = false;
            if (File.Exists(file_accounts_path))
            {
                string data_acc = File.ReadAllText(file_accounts_path);
                if(!string.IsNullOrEmpty(data_acc))
                {
                    tb_User.Text = Regex.Match(data_acc, @"username_vipig=(.*?);").Groups[1].Value;
                    tb_Pass.Text = Regex.Match(data_acc, @"password_vipig=(.*?);").Groups[1].Value;
                    tb_UserIG.Text = Regex.Match(data_acc, @"username_ig_1=(.*?);").Groups[1].Value;
                    tb_PassIG.Text = Regex.Match(data_acc, @"password_ig_1=(.*?);").Groups[1].Value;

                }
            }
            else
            {
                File.Create(file_accounts_path);
            }

        }


        private void btStop_Click(object sender, EventArgs e)
        {
            run = false; 
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            run = true;
            string username_tool = tb_User.Text.Trim();
            string password_tool = tb_Pass.Text.Trim();
            string username_ig = tb_UserIG.Text.Trim();
            string password_ig = tb_PassIG.Text.Trim();
            
            if(!string.IsNullOrEmpty(username_tool) && !string.IsNullOrEmpty(password_tool) && !string.IsNullOrEmpty(username_ig) && !string.IsNullOrEmpty(password_ig))
            {
                Thread t = new Thread(() =>
                {
                    ChromeDriver driverVipig = OpenChrome("https://vipig.net/home.php");
                    if(driverVipig != null)
                    {
                        delay(2);
                        driverVipig.FindElement(By.CssSelector("button.btn.btn-primary[data-dismiss='modal']")).Click();
                        delay(1);
                        driverVipig.FindElement(By.CssSelector("input[name='username']")).Clear();
                        driverVipig.FindElement(By.CssSelector("input[name='username']")).SendKeys(username_tool);

                        driverVipig.FindElement(By.CssSelector("input[name='password']")).Clear();
                        driverVipig.FindElement(By.CssSelector("input[name='password']")).SendKeys(password_tool);

                        driverVipig.FindElement(By.CssSelector("input[name='submit']")).Click();

                        delay(2);
                        bool islogin = false;
                        try
                        {
                            var alert = driverVipig.SwitchTo().Alert();
                            string texterr = alert.Text;
                            alert.Accept();
                            driverVipig.Quit();
                            show_error(texterr);
                        }
                        catch
                        {
                             islogin = true;
                        }
                        if (islogin)
                        {
                            this.Invoke(new Action(() =>
                            {
                                //lấy thông tin username password của instagram để đăng nhập vào 
                                my_username.Text = driverVipig.FindElement(By.XPath("/html/body/div/div/div[1]/h2/i")).Text;
                                my_coins.Text = driverVipig.FindElement(By.Id("soduchinh")).Text+ "VND";
                            }));
                            ChromeDriver driverins = OpenChrome("https://www.instagram.com/");
                            delay(2);
                            driverins.FindElement(By.Name("username")).SendKeys(username_ig);
                            driverins.FindElement(By.Name("password")).SendKeys(password_ig);
                            delay(2);
                            driverins.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/section/main/article/div[2]/div[1]/div[2]/form/div/div[3]/button/div")).Click();
                            
                            Thread.Sleep(TimeSpan.FromSeconds(5));
                            if(check(driverins, By.XPath("/html/body/div[3]/div[1]/div/div[2]/div/div/div/div/div[2]/div/div/div[3]/button[2]")))
                            {
                                driverins.FindElement(By.XPath("/html/body/div[3]/div[1]/div/div[2]/div/div/div/div/div[2]/div/div/div[3]/button[2]")).Click();
                            }
                            else
                            {
                                if(check(driverins, By.Id("slfErrorAlert"))) {
                                    show_error(driverins.FindElement(By.Id("slErrorAlert")).Text);
                                    driverins.Quit();
                                    driverVipig.Quit();
                                    return;
                                }
                            }
                            if (!run)
                            {
                                driverVipig.Quit();
                                driverins.Quit();return;
                            }
                            driverinss = driverins;
                            driverig = driverVipig;
                            while (run)
                            {
                                if (!run)
                                {
                                    driverVipig.Quit();
                                    driverins.Quit(); return;
                                    //var radom = new Random();
                                    ////int rand = radom.Next(1, 3);
                                    //int rand = 1;
                                    //if(rand ==1)
                                    //{
                                    //    //like
                                    //    start_like();
                                    //}else if (rand == 2)
                                    //{
                                    //    //fl
                                    //}else if (rand == 3)
                                    //{
                                    //    //cmt
                                    //}
                                }
                                var random  = new Random();
                                //int  rand = random.Next(1, 3);
                                int rand = 1;
                                if (rand == 1)
                                {
                                    start_like();
                                    //like
                                }else if (rand == 2)
                                {
                                    //fl
                                }else if (rand == 3)
                                {
                                    //cmt
                                }
                            }
 

                        }

                    }
                    else
                    {
                        show_error("Thay đổi phiên bản chrome");
                    }
                });
                t.IsBackground = true;
                t.Start();
            }
            else
            {
                show_error("Nhập đầy đủ thông tin");
            }
        }
        void show_error(string message)
        {
            MessageBox.Show(message, "Thất Bại", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        //Open Chrome
         ChromeDriver OpenChrome(string url, bool show = true)
        {
            ChromeOptions options = new ChromeOptions();
            if (!show)
            {
                options.AddArgument("headless");
            }
            ChromeDriverService service;
            try
            {
                service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;
            }
            catch 
            {
                return null;
            }
            ChromeDriver driver = new ChromeDriver(service, options);
            try
            {
                driver.Url = url;
                driver.Navigate();
                return driver;
            }
            catch 
            {
                return null;
            }  
            

        }

        void delay(int s)
        {
            Thread.Sleep(TimeSpan.FromSeconds(s));
        }
        bool check(ChromeDriver driver, By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }catch 
            {
                return false;
            }
        }
        private void start_like()
        {
            driverig.Url = "https://vipig.net/kiemtien/";
            driverig.Navigate();
            delay(2);
            var all_jobs = driverig.FindElement(By.Id("dspost")).FindElements(By.TagName("button"));
            foreach (var button in all_jobs)
            {
                button.Click();
                string url = button.GetAttribute("title").Replace("", "");
                driverinss.Url = url;
                driverinss.Navigate();
                delay(2);
                try 
                {
                    var elements = driverinss.FindElements(By.ClassName("wp06b"));
                    if (elements.Count > 1)
                    {
                        elements[1].Click();
                    }
                    //driverinss.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div/div/div[1]/div[1]/div[2]/section/main/div[1]/div/div/div[2]/div/div[1]/div/article[1]/div/div[3]/div/div/div[1]/div[1]/span[1]/div")).Click();
                }
                catch { }
                driverig.SwitchTo().Window(driverig.WindowHandles.Last());
                driverig.Close();
                delay(2);
                string id = url.Substring(28).Trim();
                driverig.FindElement(By.Id(id)).Click();
                delay(5);
            }
        }
    }
}
