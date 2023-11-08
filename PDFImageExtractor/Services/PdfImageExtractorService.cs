using System.Collections.Generic;
using System.Drawing;
using Spire.Pdf;


namespace PDFImageExtractor.Services
{

    public class PdfImageExtractorService
    {
        static public List<Image> ExtractImagesFromPdf(Stream pdfStream)
        {
            List<Image> images = new List<Image>();

            PdfDocument pdf = new PdfDocument();

            pdf.LoadFromStream(pdfStream);

            int i = 1;

            foreach (PdfPageBase page in pdf.Pages)
            {
                foreach (Image image in page.ExtractImages())
                {
                    images.Add(image);
                    i++;
                }
            }

            return images;
        }
    }
}

