namespace PDFRenderer.Page;

public class InvalidPageException : Exception
{
    public InvalidPageException(string? message) : base(message)
    {
        
    }
}