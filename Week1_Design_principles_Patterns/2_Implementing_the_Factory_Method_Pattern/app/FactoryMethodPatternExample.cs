using System;

public interface IDocument
{
    void FileOpen();
    void FileSave();
    void FileClose();
}

public class WordDocument : IDocument
{
    public void FileOpen()
    {
        Console.WriteLine("Word document has been opened");
    }

    public void FileSave()
    {
        Console.WriteLine("Word document has been saved");
    }

    public void FileClose()
    {
        Console.WriteLine("Word document has been closed");
    }
}

public class PDFDocument : IDocument
{
    public void FileOpen()
    {
        Console.WriteLine("PDF document has been opened");
    }

    public void FileSave()
    {
        Console.WriteLine("PDF document has been saved");
    }

    public void FileClose()
    {
        Console.WriteLine("PDF document has been closed");
    }
}

public class ExcelDocument : IDocument
{
    public void FileOpen()
    {
        Console.WriteLine("ExcelDocument has been opened");
    }

    public void FileSave()
    {
        Console.WriteLine("ExcelDocument has been saved");
    }

    public void FileClose()
    {
        Console.WriteLine("ExcelDocument has been closed");
    }
}

public abstract class DocumentFactory
{
    public abstract IDocument CreateDocument();
}

public class WordFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new WordDocument();
    }
}

public class PDFFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new PDFDocument();
    }
}

public class ExcelFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new ExcelDocument();
    }
}

class Test
{
    static void Main()
    {
        Console.WriteLine("Document Management System");
        Console.WriteLine("---------------------------");

        DocumentFactory wordfactory = new WordFactory();
        IDocument wordDoc = wordfactory.CreateDocument();

        DocumentFactory PDFfactory = new PDFFactory();
        IDocument pdfDoc = PDFfactory.CreateDocument();

        DocumentFactory excelfactory = new ExcelFactory();
        IDocument excelDoc = excelfactory.CreateDocument();

        Console.WriteLine("\nTesting Word Document");
        wordDoc.FileOpen();
        wordDoc.FileSave();
        wordDoc.FileClose();

        Console.WriteLine("\nTesting PDF Document");
        pdfDoc.FileOpen();
        pdfDoc.FileSave();
        pdfDoc.FileClose();

        Console.WriteLine("\nTesting Excel Document");
        excelDoc.FileOpen();
        excelDoc.FileSave();
        excelDoc.FileClose();
    }
}
