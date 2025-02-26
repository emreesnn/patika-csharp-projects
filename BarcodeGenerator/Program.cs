using System;
using System.Drawing;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;
using System.Drawing.Imaging;
using ZXing.QrCode;
using IronBarCode;

/*
 * var myBarcode = BarcodeWriter.CreateBarcode("12345", BarcodeWriterEncoding.EAN8);

// Reading a barcode is easy with IronBarcode:
var resultFromFile = BarcodeReader.Read(@"file/barcode.png"); // From a file
var resultFromPdf = BarcodeReader.ReadPdf(@"file/mydocument.pdf"); // From PDF use ReadPdf

// After creating a barcode, we may choose to resize and save which is easily done with:
myBarcode.ResizeTo(400, 100);
myBarcode.SaveAsImage("myBarcodeResized.jpeg");
*/
class Program
{
    static void Main()
    {
        Console.Write("Lütfen barkod için bir metin girin: ");
        string inputText = Console.ReadLine();

        var myBarcode = BarcodeWriter.CreateBarcode(inputText, BarcodeEncoding.EAN8);
        myBarcode.ResizeTo(400, 100);
        string filePath = "myBarcode.png"; 
        myBarcode.SaveAsPng(filePath);

        Console.WriteLine($"Barkod oluşturuldu ve {filePath} olarak kaydedildi.");

        try
        {
            var resultFromFile = BarcodeReader.Read(filePath); 

            if (resultFromFile != null && resultFromFile.Values != null)
            {
                foreach(string str in resultFromFile.Values())
                {
                    Console.WriteLine(str);
                }
            }
            else
            {
                Console.WriteLine("Barkod okunamadı!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Barkod okuma hatası: {ex.Message}");
        }
    }
}
