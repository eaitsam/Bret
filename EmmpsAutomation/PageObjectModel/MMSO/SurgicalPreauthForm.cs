using EmmpsAutomation.PageObjectModel.LOD;
using EmmpsAutomation.PageObjectModel.MMSO;
using FluentAssertions;
using MedchartSeleniumAutomationCore.Core_Framework;
using MedchartSeleniumAutomationCore.Core_PageObjects;
using MedchartSeleniumAutomationCore.Core_Settings;
using MedchartSeleniumAutomationCore.Core_Shared_Methods;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmpsAutomation.PageObjectModel.MMSO
{
   public class SurgicalPreauthForm
    {
        BaseDriverInit _driverInit;

        DocumentUpload _DocumentUploaduhh;
        Login _login;
        MasterMenuNavigation _masterMenuNavigation;
        SearchandFilterCases _searchandFilterCases;

        DocumentUploadObjects _documentUpload;
        MiscPageObjects _miscPage;
        NavMenuObjects _navMenu;
        SearchFilterObjects _searchFilter;
     
        ExcelDataCollection _excelDataCollection;
        ExcelUtil _excelUtil;

        MMSOAuthorizations _Authorization;


        public SurgicalPreauthForm()
        {
          // _driverInit = new BaseDriverInit();
           _DocumentUploaduhh = new DocumentUpload();
           _login = new Login();
           _masterMenuNavigation = new MasterMenuNavigation();
           _searchandFilterCases = new SearchandFilterCases();

           _documentUpload = new DocumentUploadObjects();
           _miscPage = new MiscPageObjects();
           _navMenu = new NavMenuObjects();
           _searchFilter = new SearchFilterObjects();

           _excelDataCollection = new ExcelDataCollection();
           _excelUtil = new ExcelUtil();

           _Authorization = new MMSOAuthorizations();


        }

    }

}
