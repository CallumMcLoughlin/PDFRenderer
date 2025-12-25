namespace PDFRenderer.Document;

public class InvalidDocumentException : Exception
{
    public InvalidDocumentException(string? message) : base(message)
    {
        
    }
}