using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using PriceChecker.Common;
using Application = Microsoft.Office.Interop.Excel.Application;
using Excel = Microsoft.Office.Interop.Excel; 

namespace PriceChecker.search
{
    public class Search
    {
        public List<ResultRowCell> SearchByFile(string[] listOfWords, SupplierType supplierType, string priceFileName)
        {
            Application xlApp = new Excel.ApplicationClass();
            xlApp.ReferenceStyle = XlReferenceStyle.xlA1;
            Workbook xlWorkBook = xlApp.Workbooks.Open(priceFileName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

            var xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(supplierType.SheetNumber);
            int lastUsedRow = xlWorkSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing).Row;

            //начало поиска
            var searchResult = new List<ResultRowCell>();

            for (int currentRow = supplierType.ListCell[0].Row; currentRow <= lastUsedRow; currentRow++)
            {

                var resultRowCell = new ResultRowCell();
                resultRowCell.Clear();
                for (int iCell = 0; iCell < supplierType.ListCell.Count; iCell++)
                {
                    //для всех ячеек получаем их значения
                    int currentColumn = supplierType.ListCell[iCell].Col;

                    //проверка ячейки на существование.
                    var value = ((Range) xlWorkSheet.Cells[currentRow, currentColumn]).Value;
                    string result = "";
                    if (value != null)
                        result = value.ToString();
                    else
                        result = "";

                    resultRowCell.VSupplierName = supplierType.Name;
                    resultRowCell.Add(new ResultCell(currentRow, currentColumn, result,
                                                     supplierType.ListCell[iCell].Name));
                }

                //ищем по всем словам, по всем ячейкам
                int qty = 0;
                if ((qty = ParseRow(resultRowCell, listOfWords)) > 0)
                {
                    //MessageBox.Show(@"Current row: " + currentRow.ToString());
                    resultRowCell.qty = qty;
                    searchResult.Add(resultRowCell);
                }

            }

            //конец поиска
            xlWorkBook.Close(false, null, null);
            xlApp.Quit();

            ReleaseObject(xlWorkSheet);
            ReleaseObject(xlWorkBook);
            ReleaseObject(xlApp);


            return searchResult;
        }

        private static int ParseRow(ResultRowCell resultRowCell, string[] listOfWords)
        {
            int value = 0;
            for (int i = 0; i < listOfWords.Length; i++)
            {
                value += resultRowCell.ParseListByString(listOfWords[i]);
            }
            if (value != listOfWords.Length)
                value = 0;

            return value;
        }

        private static void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(@"Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}
