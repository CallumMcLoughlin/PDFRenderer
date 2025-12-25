using PDFRenderer.Document;
using PDFRenderer.Page;

namespace PDFRendererTests.Page;

public class PDFPageTests
{
    [Fact]
    public void ValidPageLoadTest()
    {
        using PDFDocument document = PDFDocument.Load(Resources.ValidDocument);
        using PDFPage page = document.LoadPage(document.PageCount - 1);
        
        Assert.NotNull(page);
    }
    
    [Fact]
    public void InvalidPageNegativeIndexTest()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            using PDFDocument document = PDFDocument.Load(Resources.ValidDocument);
            using PDFPage page = document.LoadPage(-1);
        });
    }
    
    [Fact]
    public void InvalidPageIndexTest()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {
            using PDFDocument document = PDFDocument.Load(Resources.ValidDocument);
            using PDFPage page = document.LoadPage(document.PageCount);
        });
    }
}