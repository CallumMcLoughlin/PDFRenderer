using System.Text;
using Native;
using PDFRenderer.Page;

namespace PDFRenderer.Document;

public unsafe class PDFDocument : IDisposable
{
    private static bool IsInitialized;
    
    private readonly fpdf_document_t__* _documentPtr;
    
    public int PageCount => NativeMethods.FPDF_GetPageCount(_documentPtr);

    private PDFDocument(fpdf_document_t__* documentPtr)
    {
        _documentPtr = documentPtr;
    }

    private static void EnsureInitialized()
    {
        if (IsInitialized)
        {
            return;
        }
        
        NativeMethods.FPDF_InitLibrary();
        IsInitialized = true;
    }
    
    public static PDFDocument Load(string filename, string? password = null)
    {
        EnsureInitialized();

        ArgumentNullException.ThrowIfNull(filename);
        
        if (!File.Exists(filename))
        {
            throw new FileNotFoundException(filename);
        }

        fpdf_document_t__* docPtr;
        
        if (password == null)
        {
            fixed (byte* fileBytes = Encoding.UTF8.GetBytes(filename))
            {
                docPtr = NativeMethods.FPDF_LoadDocument((sbyte*)fileBytes, null);
            }
        }
        else
        {
            fixed (byte* fileBytes = Encoding.UTF8.GetBytes(filename), passwordBytes = Encoding.UTF8.GetBytes(password))
            {
                docPtr = NativeMethods.FPDF_LoadDocument((sbyte*)fileBytes, (sbyte*)passwordBytes);
            }
        }

        PDFDocument document = new PDFDocument(docPtr);
        ThrowIfInvalid(document);
        
        return document;
    }

    public static void Unload()
    {
        if (IsInitialized)
        {
            NativeMethods.FPDF_DestroyLibrary();
        }
    }

    public PDFPage LoadPage(int pageIndex)
    {
        int pageCount = PageCount;
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(pageIndex, pageCount, nameof(pageIndex));
        ArgumentOutOfRangeException.ThrowIfLessThan(pageIndex, 0, nameof(pageIndex));
        
        return PDFPage.Load(_documentPtr, pageIndex);
    }
    
    private static void ThrowIfInvalid(PDFDocument? document)
    {
        ArgumentNullException.ThrowIfNull(document);

        if (document._documentPtr == null)
        {
            throw new InvalidDocumentException(nameof(document._documentPtr));
        }
    }

    private void ReleaseUnmanagedResources()
    {
        if (_documentPtr != null)
        {
            NativeMethods.FPDF_CloseDocument(_documentPtr);
        }
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }

    ~PDFDocument()
    {
        ReleaseUnmanagedResources();
    }
}