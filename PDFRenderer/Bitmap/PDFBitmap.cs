using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Native;
using PDFRenderer.Page;

namespace PDFRenderer.Bitmap;

public unsafe class PDFBitmap : IDisposable
{
    private readonly fpdf_bitmap_t__* _bitmapPtr;
    
    public int Width { get; private set; }
    public int Height { get; private set; }
    public int Stride { get; private set; }
    
    internal PDFBitmap(fpdf_bitmap_t__* bitmapPtr, int width, int height)
    {
        _bitmapPtr = bitmapPtr;
        Width = width;
        Height = height;
        Stride = NativeMethods.FPDFBitmap_GetStride(bitmapPtr);
    }

    public static PDFBitmap Create(PDFPage page, float scaleFactor = 1f)
    {
        int widthCeil = (int)Math.Ceiling(page.Width * scaleFactor);
        int heightCeil = (int)Math.Ceiling(page.Height * scaleFactor);
        
        return Create(widthCeil, heightCeil);
    }
    
    public static PDFBitmap Create(int width, int height)
    {
        fpdf_bitmap_t__* bitmapPtr = NativeMethods.FPDFBitmap_CreateEx(width, height, 4, null, 0);
        if (bitmapPtr == null)
        {
            throw new InvalidBitmapException($"Bitmap of size {width}, {height}");
        }
        
        PDFBitmap bitmap = new PDFBitmap(bitmapPtr, width, height);
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
        // FPDF_ANNOT 0x01
        // FPDF_REVERSE_BYTE_ORDER 0x10
        NativeMethods.FPDF_RenderPageBitmap(_bitmapPtr, page._pagePtr, 0, 0, Width, Height, 0, 0x01 | 0x10);
    }
    
    public Task<bool> RenderAsync(PDFPage page, CancellationToken cancellationToken = default)
    {
        // ReSharper disable once MethodSupportsCancellation
        return Task.Run(() =>
        {
            GCHandle handle = GCHandle.Alloc(cancellationToken);
            try
            {
                void* handlePtr = (void*)GCHandle.ToIntPtr(handle);
                int result = StartNativeRender(_bitmapPtr, page._pagePtr, Width, Height, handlePtr);
                NativeMethods.FPDF_RenderPage_Close(page._pagePtr);
                return result == 2;
            }
            finally
            {
                handle.Free();
            }
        });

        static int StartNativeRender(fpdf_bitmap_t__* bitmap, fpdf_page_t__* pagePtr, int width, int height, void* userPtr)
        {
            _IFSDK_PAUSE pauseFlag = new _IFSDK_PAUSE
            {
                version = 1,
                NeedToPauseNow = &ShouldPause,
                user = userPtr
            };
            
            return NativeMethods.FPDF_RenderPageBitmap_Start(bitmap, pagePtr, 0, 0, width, height, 0, 0x01 | 0x10, &pauseFlag);
        }

        [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
        static int ShouldPause(_IFSDK_PAUSE* pauseStruct)
        {
            GCHandle handle = GCHandle.FromIntPtr((IntPtr)pauseStruct->user);

            if (handle.Target is CancellationToken token)
            {
                return token.IsCancellationRequested ? 1 : 0;
            }

            return 0;
        }
    }
    
    public Span<byte> GetRGBAByteData()
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