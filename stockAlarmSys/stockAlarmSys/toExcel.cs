using System;
using System.Collections.Generic;
using System.Linq;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using System.Data;

namespace stockAlarmSys
{
    class OpenXmlExcelOper
    {
        /// <summary>
        /// 填充指定单元格数据
        /// </summary>
        /// <param name="path">execl文件路径</param>
        /// <param name="sheetName">工作簿名称</param>
        /// <param name="location">单元格坐标（如:A1）</param>
        /// <param name="value">填充数据</param>
        public static void FillData(string path, string sheetName, string location,string value)
        {
            using (SpreadsheetDocument document = SpreadsheetDocument.Open(
               path, true))
            {
                // find sheets by sheet name
                IEnumerable<Sheet> sheets = document.WorkbookPart.Workbook.Descendants<Sheet>().Where(s => s.Name == sheetName);
                if (sheets.Count() == 0)
                {
                    // The specified worksheet does not exist.
                    return;
                }
                WorksheetPart worksheetPart = (WorksheetPart)document.WorkbookPart.GetPartById(sheets.First().Id);
                Worksheet worksheet = worksheetPart.Worksheet;
                SheetData sheetData = worksheet.GetFirstChild<SheetData>();

                // fill data to Cell 
                Row row1 = new Row() { RowIndex = (UInt32Value)4U };
                Cell cell1 = new Cell() { CellReference = location };
                CellValue cellValue1 = new CellValue();
                cellValue1.Text = value;
                cell1.Append(cellValue1);
                row1.Append(cell1);

                // append rows to SheetData elment
                
                sheetData.Append(row1);

                // save worksheet
                worksheet.Save();
            }
        }
        public static void FillAlarmData(string path, string sheetName,DataTable dt)
        {
            using (SpreadsheetDocument document = SpreadsheetDocument.Open(
               path, true))
            {
                // find sheets by sheet name
                IEnumerable<Sheet> sheets = document.WorkbookPart.Workbook.Descendants<Sheet>().Where(s => s.Name == sheetName);
                if (sheets.Count() == 0)
                {
                    // The specified worksheet does not exist.
                    return;
                }
                WorksheetPart worksheetPart = (WorksheetPart)document.WorkbookPart.GetPartById(sheets.First().Id);
                Worksheet worksheet = worksheetPart.Worksheet;
                SheetData sheetData = worksheet.GetFirstChild<SheetData>();
                Row row;
                Cell cell;
                CellValue cellValue;
                // fill data to Cell 
                #region get value types
                //CellValues [] typeArr=new CellValues[dt.Columns.Count];
                //for (int i = 0; i < dt.Columns.Count; i++) {
                //    switch (dt.Columns[i].DataType.Name)
                //    {
                //        case "String":
                //            typeArr[i] = CellValues.String;
                //            break;
                //        default: break;
                //    }
                //}
                #endregion
                row = new Row() { RowIndex = (UInt32Value)(1) };
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    cell = new Cell();
                    cellValue = new CellValue();
                    cell.DataType = CellValues.String;
                    cellValue.Text = dt.Columns[j].ColumnName.ToString().Trim();
                    cell.Append(cellValue);
                    row.Append(cell);
                }
                sheetData.Append(row);
                for (uint i=1;i<=dt.Rows.Count;i++)
                {                
                    row = new Row() { RowIndex = (UInt32Value)(i+1) };
                    for (int j=0;j<dt.Columns.Count;j++) {
                        cell = new Cell();
                        cellValue = new CellValue();
                        cell.DataType = CellValues.String;
                        cellValue.Text = dt.Rows[(int)i-1][j].ToString().Trim();
                        cell.Append(cellValue);
                        row.Append(cell);
                    }
                    sheetData.Append(row);
                }

                // save worksheet
                worksheet.Save();
            }
        }

        public static void CreateSpreadSheet(string fileName,string sheetName)
        {
            using (SpreadsheetDocument spreadSheet = SpreadsheetDocument.Create(
                    System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName),//"test.xlsx"
                    SpreadsheetDocumentType.Workbook))
            {
                // create the workbook
                spreadSheet.AddWorkbookPart();
                spreadSheet.WorkbookPart.Workbook = new Workbook();     // create the worksheet
                spreadSheet.WorkbookPart.AddNewPart<WorksheetPart>();
                spreadSheet.WorkbookPart.WorksheetParts.First().Worksheet = new Worksheet();

                //create sheet data
                spreadSheet.WorkbookPart.WorksheetParts.First().Worksheet.AppendChild(new SheetData());

                // create row
                spreadSheet.WorkbookPart.WorksheetParts.First().Worksheet.First().AppendChild(new Row());

                //// create cell with data
                //spreadSheet.WorkbookPart.WorksheetParts.First().Worksheet.First().First().AppendChild(
                //      new Cell() { CellValue = new CellValue("100") });

                // save worksheet
                spreadSheet.WorkbookPart.WorksheetParts.First().Worksheet.Save();

                // create the worksheet to workbook relation
                spreadSheet.WorkbookPart.Workbook.AppendChild(new Sheets());
                spreadSheet.WorkbookPart.Workbook.GetFirstChild<Sheets>().AppendChild(new Sheet()
                {
                    Id = spreadSheet.WorkbookPart.GetIdOfPart(spreadSheet.WorkbookPart.WorksheetParts.First()),
                    SheetId = 1,
                    Name = sheetName
                });

                spreadSheet.WorkbookPart.Workbook.Save();
            }
        }
    }
}
