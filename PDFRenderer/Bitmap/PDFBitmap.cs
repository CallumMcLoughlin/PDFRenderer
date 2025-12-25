using Native;
using PDFRenderer.Page;

namespace PDFRenderer.Bitmap;

public unsafe class PDFBitmap : IDisposable
{
    private readonly fpdf_bitmap_t__* _bitmapPtr;
    
    public PDFBitmapFormat Format { get; private set; }
    public int Width { get; private set; }
    public int Height { get; private set; }
    public int Stride { get; private set; }
    
    internal PDFBitmap(fpdf_bitmap_t__* bitmapPtr, int width, int height, PDFBitmapFormat format)
    {
        _bitmapPtr = bitmapPtr;
        Width = width;
        Height = height;
        Stride = NativeMethods.FPDFBitmap_GetStride(bitmapPtr);
        Format = format;
    }

    public static PDFBitmap Create(int width, int height, PDFBitmapFormat format)
    {
        fpdf_bitmap_t__* bitmapPtr = NativeMethods.FPDFBitmap_CreateEx(width, height, (int)format, null, 0);
        if (bitmapPtr == null)
        {
            throw new InvalidBitmapException($"Bitmap of size {width}, {height}, with format {format}");
        }
        
        PDFBitmap bitmap = new PDFBitmap(bitmapPtr, width, height, format);
        ThrowIfInvalid(bitmap);
        return bitmap;
    }
    
    private static void ThrowIfInvalid(PDFBitmap? bitmap)
    {
        ArgumentNullException.ThrowIfNull(bitmap);
        if (bitmap._bitmapPtr == null)
        {
            throw new InvalidBitmapException(nameof(bitmap));
        }
    }

    public void Render(PDFPage page)
    {
        NativeMethods.FPDF_RenderPageBitmap(_bitmapPtr, page._pagePtr, 0, 0, (int)page.Width, (int)page.Height, 0, 0);
    }
    
    public Span<byte> GetBitmapData()
    {
        return new Span<byte>(NativeMethods.FPDFBitmap_GetBuffer(_bitmapPtr), Stride * Height);
    }

    private void ReleaseUnmanagedResources()
    {
        if (_bitmapPtr != null)
        {
            NativeMethods.FPDFBitmap_Destroy(_bitmapPtr);
        }
    }

    public void Dispose()
    {
        ReleaseUnmanagedResources();
        GC.SuppressFinalize(this);
    }

    ~PDFBitmap()
    {
        ReleaseUnmanagedResources();
    }
}