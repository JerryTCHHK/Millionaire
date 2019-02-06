using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Millionaire.Class
{
    class PDFHandler
    {
        private string outputFileFullName;

        private Document pdfDoc; 

        //Constructor 
        public PDFHandler(string outputFileFullName)
        {
            this.outputFileFullName = outputFileFullName; 

        }

        //Create one Page PDF Document 
        public void createPDF(List<string> result1 , List<string> result2, List<string> result3, List<string> result4)
        {
            try
            {
                //Initialize the document 
                pdfDoc = new Document(PageSize.A4, 7f, 5f, 5f, 0f);

                FileStream outputStream = new FileStream(outputFileFullName, FileMode.Create);

                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, outputStream);

                pdfDoc.Open();

                //Add Title 
                Paragraph title = new Paragraph("Who wants to become a Millionaire Result");

                title.Font.SetStyle("bold,underline");
                title.Font.SetFamily("Times New Roman");
                title.Font.Size = 25;
                title.SpacingBefore = 3;
                pdfDoc.Add(title);

                //Add Generation Time 
                Paragraph time = new Paragraph(String.Format("Generation Time :{0}", DateTime.Now.ToString("ddd, dd MMM yyy HH':'mm':'ss")));
                time.Font.SetStyle("normal");
                time.Font.SetFamily("Times New Roman");
                time.Font.Size = 9;
                time.SpacingBefore = 10;
                pdfDoc.Add(time);

                //Add Table 
                int numberOfColumn = 5; 
                PdfPTable resultTable = new PdfPTable(numberOfColumn);

                resultTable.TotalWidth = 5f;
                resultTable.HorizontalAlignment = -10; 
                resultTable.SpacingBefore = 5; 

                resultTable.AddCell("");
                resultTable.AddCell("Player 1");
                resultTable.AddCell("Player 2");
                resultTable.AddCell("Player 3");
                resultTable.AddCell("Player 4");

                resultTable.AddCell("Status");
                resultTable.AddCell(result1[0]);
                resultTable.AddCell(result2[0]);
                resultTable.AddCell(result3[0]);
                resultTable.AddCell(result4[0]);

                resultTable.AddCell("Level");
                resultTable.AddCell(result1[1]);
                resultTable.AddCell(result2[1]);
                resultTable.AddCell(result3[1]);
                resultTable.AddCell(result4[1]);

                resultTable.AddCell("Price");
                resultTable.AddCell(result1[2]);
                resultTable.AddCell(result2[2]);
                resultTable.AddCell(result3[2]);
                resultTable.AddCell(result4[2]);

                resultTable.AddCell("50/50?");
                resultTable.AddCell(result1[3]);
                resultTable.AddCell(result2[3]);
                resultTable.AddCell(result3[3]);
                resultTable.AddCell(result4[3]);

                resultTable.AddCell("Phone Call?");
                resultTable.AddCell(result1[4]);
                resultTable.AddCell(result2[4]);
                resultTable.AddCell(result3[4]);
                resultTable.AddCell(result4[4]);

                resultTable.AddCell("Ask Audience?");
                resultTable.AddCell(result1[5]);
                resultTable.AddCell(result2[5]);
                resultTable.AddCell(result3[5]);
                resultTable.AddCell(result4[5]);

                pdfDoc.Add(resultTable);


                pdfDoc.Close();

            } catch ( Exception e)
            {

                throw new Exception(e.Message);

            }

        }
        

    }
}
