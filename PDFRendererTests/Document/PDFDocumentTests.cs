using PDFRenderer.Document;

namespace PDFRendererTests.Document;

public class PDFDocumentTests
{
    [Fact]
    public void InvalidDocumentTest()
    {
        Assert.Throws<FileNotFoundException>(() => PDFDocument.Load(Path.Combine(Resources.ResourcesFolder, "missing.pdf")));
    }
    
    [Fact]
    public void InvalidDocumentLoadTest()
    {
        Assert.Throws<InvalidDocumentException>(() => PDFDocument.Load(Resources.TextFile));
    }
    
    [Fact]
    public void ValidDocumentWithoutPasswordLoadTest()
    {
        using PDFDocument document = PDFDocument.Load(Resources.ValidDocument);
        
        Assert.NotNull(document);
    }
    
    [Fact]
    public void CorrectDocumentPageCountTest()
    {
        using PDFDocument document = PDFDocument.Load(Resources.ValidDocument);
        
        Assert.Equal(4, document.PageCount);
    }
}