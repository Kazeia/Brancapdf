using IronPdf;
using System.IO;
using System.Linq;
using System;

namespace BrancaBRRRRRRR_LOSILUMINATI_BRRRRR
{
    class Program
    {
        static void Main(string[] args)
        {
            // Select one or more images.  This example selects all JPEG images in a specific folder.
            var ImageFiles = Directory.EnumerateFiles(@"C:\Users\kaz\source\repos\Branca\BrancaBRRRRRRR_LOSILUMINATI_BRRRRR").Where(f => f.EndsWith(".jpg") || f.EndsWith(".jpeg"));
            // Convert the images to a PDF and save it.
            ImageToPdfConverter.ImageToPdf(ImageFiles).SaveAs(@"C:\Users\kaz\source\repos\Branca\BrancaBRRRRRRR_LOSILUMINATI_BRRRRR\composite.pdf");

            //Also see PdfDocument.RasterizeToImageFiles() method to flatten a PDF to images or thumbnails

            Console.ReadLine();
        }
    }
}
