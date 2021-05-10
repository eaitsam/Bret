using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkAutomation.PageObjectModel
{
    public class UserBandwidthReport
    {
        public int year { get; set; }
        public int month { get; set; }
        public int day { get; set; }
        public By Datetimepicker => By.XPath("/html/body/div[4]/div[1]/div[1]");
        public By LastnameTextbox => By.XPath("//*[@id='MEDCHARTContent_MedchartPagesContent_LastNameTextBox']");
        public By EdipinTextbox => By.XPath("//*[@id='MEDCHARTContent_MedchartPagesContent_UserEdiPnTextBox']");
        public By RunButton => By.XPath("//a[contains(text(), 'Run')]");
        public By Paging => By.XPath("/html/body/form/div[5]/div/div[2]/div[1]/div[4]/div/div/div/div/div[3]/table/tbody/tr[13]/td/table/tbody/tr/td[2]/a");
        public By FromTextbox => By.Id("MEDCHARTContent_MedchartPagesContent_StartDateTextBox");
        public By ToTextbox => By.Id("MEDCHARTContent_MedchartPagesContent_EndDateTextBox");
        public By FromDatePicker => By.XPath("/html/body/div[4]/div[1]/div[1]");
        public By ToDatePicker => By.CssSelector("div.xdsoft_datetimepicker:nth-child(6) > div:nth-child(1) > div:nth-child(2)");
        public By dateSelected => By.XPath("//*[@data-date='15']");
        public By PrevButton => By.ClassName("xdsoft_prev");
        public By MonthDropdown => By.XPath("/html/body/div[4]/div[1]/div[1]/div[1]/div");
        public By SelectLink => By.XPath("/html/body/form/div[5]/div/div[2]/div[1]/div[4]/div/div/div/div/div[3]/table/tbody/tr[9]/td[5]/a");
        public By NoRecord => By.XPath("/html/body/form/div[5]/div/div[2]/div[1]/div[4]/div/div/div/div/div[3]/table/tbody/tr/td");
        public By Select1 => By.CssSelector("#ulg-row-0-select > a:nth-child(1)");
        public By Select2 => By.XPath("/html/body/form/div[5]/div/div[2]/div[1]/div[4]/div/div/div/div/div[3]/table/tbody/tr[2]/td[5]/a");
        public By LogoutLink => By.Id("FixedLogout");
        public By Rows => By.XPath("/html/body/div[4]/div[1]/div[2]/table/tbody/tr");
        public By CurrentYear => By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div/div[1]/div[8]");
        public By NewYear => By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div/div[1]/div[7]");
        public By Scrollbar => By.XPath("/html/body/div[4]/div[1]/div[1]/div[2]/div/div[2]/div");
        public By Calendar =>By.XPath("/html/body/div[4]/div[1]/div[2]/table/tbody/tr");
        public By Edipi =>By.Id("MEDCHARTContent_MedchartPagesContent_UserEdiPnTextBox");
        public By UserListTable => By.Id("MEDCHARTContent_MedchartPagesContent_UserListGridView");
    }
}

