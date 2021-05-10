using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace MedchartSeleniumAutomationCore.Core_Tools
{
    public class ExcelUtil
    {
        public static List<ExcelDataCollection> _dataCollection = new List<ExcelDataCollection>();
        public static int totalRowCount = 0;

        public static DataTable ExcelToDataTable(string fileName)
        {
            //Open File and read all content of file as stream.
            FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);

            //CreateOpenXmlReader via ExcelReaderFactory
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);

            //Set the First Row as Column Name and prepare DataSet Object
            var result = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });

            //Get All The Tables
            DataTableCollection collection = result.Tables;

            //Store all collection values in DataTable
            DataTable resultTable = collection["Sheet1"];
            stream.Dispose();
            //Return Table
            return resultTable;

        }

        public static  int GetTotalRowCount()
        {
            return totalRowCount;
        }

        public static void PopulateInCollection(string fileName)
        {
            //clear _datcollection list for when multiple spreadsheets are being read
            _dataCollection.Clear();
            DataTable table = ExcelToDataTable(fileName);
            totalRowCount = table.Rows.Count;

            //Iterate through the rows and columns of the Table.
            for (int row = 1; row <= table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    ExcelDataCollection item = new ExcelDataCollection()
                    {
                        RowNumber = row,
                        ColumnName = table.Columns[col].ColumnName,
                        ColumnValue = table.Rows[row - 1][col].ToString()
                    };

                    //Add all the detail for each row
                    _dataCollection.Add(item);
                }
            }
        }

        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                //Retriving data using LINQ to reduce avoid iterations.
                string data = (from colData in _dataCollection
                               where colData.ColumnName == columnName && colData.RowNumber == rowNumber
                               select colData.ColumnValue).SingleOrDefault();

                return data;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
