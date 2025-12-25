using Native;

namespace PDFRenderer.Page;

public unsafe class PDFPage : IDisposable
{
    private readonly fpdf_page_t__* _pagePtr;
    
    public int PageIndex { get; private set; }
    public double Width => NativeMethods.FPDF_GetPageWidth(_pagePtr);
    public double Height => NativeMethods.FPDF_GetPageHeight(_pagePtr);

    private PDFPage(fpdf_page_t__* pagePtr, int index)
    {
        _pagePtr = pagePtr;
        PageIndex = index;
    }
    
    internal static PDFPage Load(fpdf_document_t__* documentPtr, int index)
    {
        PDFPage page = new PDFPage(NativeMethods.FPDF_LoadPage(documentPtr, index), index);
        ThrowIfInvalid(page);
        return page;
    }

    private static void ThrowIfInvalid(PDFPage? page)
    {
        ArgumentNullException.ThrowIfNull(page);
        if (page._pagePtr == null)
        {
            throw new InvalidPageException(nameof(page));
        }
    }

    private void ReleaseUnmanagedResources()
    {
        if (_pagePtr != null)
        {
            NativeMethods.FPDF_ClosePage(_pagePtr);
        }
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }

    ~PDFPage()
    {
        ReleaseUnmanagedResources();
    }
}