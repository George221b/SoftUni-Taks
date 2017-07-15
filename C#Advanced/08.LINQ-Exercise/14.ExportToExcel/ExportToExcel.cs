using System;
using System.IO;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace _14.ExportToExcel
{
    public class ExportToExcel
    {
        public static void Main()
        {
            var file = @"../../students.txt";

            try
            {
                using (var reader = new StreamReader(file))
                {
                    using (var excelPackage = new ExcelPackage())
                    {
                        var workSheet = excelPackage.Workbook.Worksheets.Add("Sheet");

                        workSheet.Cells[1, 1, 1, 11].Merge = true;
                        workSheet.Cells[1, 1, 1, 11].Style.Font.Size = 19;
                        workSheet.Cells[1, 1, 1, 11].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        workSheet.Cells[1, 1, 1, 11].Value = "SoftUni C# Advanced results";

                        var row = 2;
                        var line = reader.ReadLine();

                        while (line != null)
                        {
                            var cellData = line.Split('\t');

                            for (int i = 1; i <= cellData.Length; i++)
                            {
                                workSheet.Cells[row, i].Value = cellData[i - 1];
                            }

                            line = reader.ReadLine();
                            row++;
                        }

                        var outputFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "New Excel.xlsx");
                        excelPackage.SaveAs(new FileInfo(outputFile));
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                ErrorMessage(ex.Message);
            }

            SuccessMessage("Ready! Your Excel file is on your Desktop. Named - New Excel.xlsx");
        }

        private static void SuccessMessage(string message)
        {
            WriteWithDifferentColor(message, ConsoleColor.Green);
        }

        private static void ErrorMessage(string message)
        {
            WriteWithDifferentColor(message, ConsoleColor.Red);
        }

        private static void WriteWithDifferentColor(string message, ConsoleColor color)
        {
            var currentConsoleColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ForegroundColor = currentConsoleColor;
        }
    }
}