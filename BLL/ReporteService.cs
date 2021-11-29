using iText.IO.Source;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ReporteService
    {
        public ReporteService()
        {
                
        }

        public void CrearPDF<T>(string path, string nombre, IList<T> rows)
        {
            // Se crea el documento
            PdfWriter wr = new PdfWriter(path);
            PdfDocument pdfDoc = new PdfDocument(wr);
            Document documento = new Document(pdfDoc);

            // Se abre el documento.
            documento.SetBold();
            documento.SetFontSize(16f);
            documento.Add(new Paragraph("Software v1.0"));
            documento.Add(new Paragraph(""));
            documento.Add(new Paragraph(""));
            documento.Add(new Paragraph(""));
            documento.SetBold();
            documento.SetFontSize(10f);
            documento.Add(new Paragraph("Reporte de "+nombre+$" {DateTime.Now.ToString("d")}"));
            documento.Add(new Paragraph(""));
            documento.Add(new Paragraph(""));
            documento.Add(new Paragraph(""));

            //Encabezados
            var props = typeof(T).GetProperties();

            //Se crea la tabla
            Table tabla = new Table(props.Length);
            tabla.UseAllAvailableWidth();

            //props[0].
            documento.SetBold();
            for (int i = 0; i < props.Length; i++)
            {
                tabla.AddHeaderCell(props[i].Name.ToUpper());
            }

            documento.SetBold();
            for (int i = 0; i < rows.Count; i++)
            {
                for (int j = 0; j < props.Length; j++)
                {
                    var value = props[j].GetValue(rows[i]) ?? "";
                    tabla.AddCell(value.ToString());
                }
            }
            documento.Add(tabla);
            documento.Close();
        }
    }
}
