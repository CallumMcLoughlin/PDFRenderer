using System.Diagnostics;
using System.Runtime.InteropServices;

// ReSharper disable All
#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value

namespace Native;

[Conditional("DEBUG")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = false, Inherited = true)]
internal sealed class NativeTypeNameAttribute(string name) : Attribute
{
    public string Name { get; } = name;
}

internal enum FPDFANNOT_COLORTYPE
{
    FPDFANNOT_COLORTYPE_Color = 0,
    FPDFANNOT_COLORTYPE_InteriorColor,
}

internal unsafe partial struct _FX_FILEAVAIL
{
    public int version;

    [NativeTypeName("FPDF_BOOL (*)(struct _FX_FILEAVAIL *, size_t, size_t)")]
    public delegate* unmanaged[Cdecl]<_FX_FILEAVAIL*, nuint, nuint, int> IsDataAvail;
}

internal unsafe partial struct _FX_DOWNLOADHINTS
{
    public int version;

    [NativeTypeName("void (*)(struct _FX_DOWNLOADHINTS *, size_t, size_t)")]
    public delegate* unmanaged[Cdecl]<_FX_DOWNLOADHINTS*, nuint, nuint, void> AddSegment;
}

internal enum FPDF_FILEIDTYPE
{
    FILEIDTYPE_PERMANENT = 0,
    FILEIDTYPE_CHANGING = 1,
}

internal partial struct FPDF_IMAGEOBJ_METADATA
{
    [NativeTypeName("unsigned int")]
    public uint width;

    [NativeTypeName("unsigned int")]
    public uint height;

    public float horizontal_dpi;

    public float vertical_dpi;

    [NativeTypeName("unsigned int")]
    public uint bits_per_pixel;

    public int colorspace;

    public int marked_content_id;
}

internal unsafe partial struct _UNSUPPORT_INFO
{
    public int version;

    [NativeTypeName("void (*)(struct _UNSUPPORT_INFO *, int)")]
    public delegate* unmanaged[Cdecl]<_UNSUPPORT_INFO*, int, void> FSDK_UnSupport_Handler;
}

internal unsafe partial struct _IPDF_JsPlatform
{
    public int version;

    [NativeTypeName("int (*)(struct _IPDF_JsPlatform *, FPDF_WIDESTRING, FPDF_WIDESTRING, int, int)")]
    public delegate* unmanaged[Cdecl]<_IPDF_JsPlatform*, ushort*, ushort*, int, int, int> app_alert;

    [NativeTypeName("void (*)(struct _IPDF_JsPlatform *, int)")]
    public delegate* unmanaged[Cdecl]<_IPDF_JsPlatform*, int, void> app_beep;

    [NativeTypeName("int (*)(struct _IPDF_JsPlatform *, FPDF_WIDESTRING, FPDF_WIDESTRING, FPDF_WIDESTRING, FPDF_WIDESTRING, FPDF_BOOL, void *, int)")]
    public delegate* unmanaged[Cdecl]<_IPDF_JsPlatform*, ushort*, ushort*, ushort*, ushort*, int, void*, int, int> app_response;

    [NativeTypeName("int (*)(struct _IPDF_JsPlatform *, void *, int)")]
    public delegate* unmanaged[Cdecl]<_IPDF_JsPlatform*, void*, int, int> Doc_getFilePath;

    [NativeTypeName("void (*)(struct _IPDF_JsPlatform *, void *, int, FPDF_BOOL, FPDF_WIDESTRING, FPDF_WIDESTRING, FPDF_WIDESTRING, FPDF_WIDESTRING, FPDF_WIDESTRING)")]
    public delegate* unmanaged[Cdecl]<_IPDF_JsPlatform*, void*, int, int, ushort*, ushort*, ushort*, ushort*, ushort*, void> Doc_mail;

    [NativeTypeName("void (*)(struct _IPDF_JsPlatform *, FPDF_BOOL, int, int, FPDF_BOOL, FPDF_BOOL, FPDF_BOOL, FPDF_BOOL, FPDF_BOOL)")]
    public delegate* unmanaged[Cdecl]<_IPDF_JsPlatform*, int, int, int, int, int, int, int, int, void> Doc_print;

    [NativeTypeName("void (*)(struct _IPDF_JsPlatform *, void *, int, FPDF_WIDESTRING)")]
    public delegate* unmanaged[Cdecl]<_IPDF_JsPlatform*, void*, int, ushort*, void> Doc_submitForm;

    [NativeTypeName("void (*)(struct _IPDF_JsPlatform *, int)")]
    public delegate* unmanaged[Cdecl]<_IPDF_JsPlatform*, int, void> Doc_gotoPage;

    [NativeTypeName("int (*)(struct _IPDF_JsPlatform *, void *, int)")]
    public delegate* unmanaged[Cdecl]<_IPDF_JsPlatform*, void*, int, int> Field_browse;

    public void* m_pFormfillinfo;

    public void* m_isolate;

    [NativeTypeName("unsigned int")]
    public uint m_v8EmbedderSlot;
}

internal partial struct _FPDF_SYSTEMTIME
{
    [NativeTypeName("unsigned short")]
    public ushort wYear;

    [NativeTypeName("unsigned short")]
    public ushort wMonth;

    [NativeTypeName("unsigned short")]
    public ushort wDayOfWeek;

    [NativeTypeName("unsigned short")]
    public ushort wDay;

    [NativeTypeName("unsigned short")]
    public ushort wHour;

    [NativeTypeName("unsigned short")]
    public ushort wMinute;

    [NativeTypeName("unsigned short")]
    public ushort wSecond;

    [NativeTypeName("unsigned short")]
    public ushort wMilliseconds;
}

internal unsafe partial struct _FPDF_FORMFILLINFO
{
    public int version;

    [NativeTypeName("void (*)(struct _FPDF_FORMFILLINFO *)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, void> Release;

    [NativeTypeName("void (*)(struct _FPDF_FORMFILLINFO *, FPDF_PAGE, double, double, double, double)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, fpdf_page_t__*, double, double, double, double, void> FFI_Invalidate;

    [NativeTypeName("void (*)(struct _FPDF_FORMFILLINFO *, FPDF_PAGE, double, double, double, double)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, fpdf_page_t__*, double, double, double, double, void> FFI_OutputSelectedRect;

    [NativeTypeName("void (*)(struct _FPDF_FORMFILLINFO *, int)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, int, void> FFI_SetCursor;

    [NativeTypeName("int (*)(struct _FPDF_FORMFILLINFO *, int, TimerCallback)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, int, delegate* unmanaged[Cdecl]<int, void>, int> FFI_SetTimer;

    [NativeTypeName("void (*)(struct _FPDF_FORMFILLINFO *, int)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, int, void> FFI_KillTimer;

    [NativeTypeName("FPDF_SYSTEMTIME (*)(struct _FPDF_FORMFILLINFO *)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, _FPDF_SYSTEMTIME> FFI_GetLocalTime;

    [NativeTypeName("void (*)(struct _FPDF_FORMFILLINFO *)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, void> FFI_OnChange;

    [NativeTypeName("FPDF_PAGE (*)(struct _FPDF_FORMFILLINFO *, FPDF_DOCUMENT, int)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, fpdf_document_t__*, int, fpdf_page_t__*> FFI_GetPage;

    [NativeTypeName("FPDF_PAGE (*)(struct _FPDF_FORMFILLINFO *, FPDF_DOCUMENT)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, fpdf_document_t__*, fpdf_page_t__*> FFI_GetCurrentPage;

    [NativeTypeName("int (*)(struct _FPDF_FORMFILLINFO *, FPDF_PAGE)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, fpdf_page_t__*, int> FFI_GetRotation;

    [NativeTypeName("void (*)(struct _FPDF_FORMFILLINFO *, FPDF_BYTESTRING)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, sbyte*, void> FFI_ExecuteNamedAction;

    [NativeTypeName("void (*)(struct _FPDF_FORMFILLINFO *, FPDF_WIDESTRING, FPDF_DWORD, FPDF_BOOL)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, ushort*, uint, int, void> FFI_SetTextFieldFocus;

    [NativeTypeName("void (*)(struct _FPDF_FORMFILLINFO *, FPDF_BYTESTRING)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, sbyte*, void> FFI_DoURIAction;

    [NativeTypeName("void (*)(struct _FPDF_FORMFILLINFO *, int, int, float *, int)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, int, int, float*, int, void> FFI_DoGoToAction;

    [NativeTypeName("IPDF_JSPLATFORM *")]
    public _IPDF_JsPlatform* m_pJsPlatform;

    [NativeTypeName("FPDF_BOOL")]
    public int xfa_disabled;

    [NativeTypeName("void (*)(struct _FPDF_FORMFILLINFO *, FPDF_PAGE, FPDF_BOOL, double, double, double, double)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, fpdf_page_t__*, int, double, double, double, double, void> FFI_DisplayCaret;

    [NativeTypeName("int (*)(struct _FPDF_FORMFILLINFO *, FPDF_DOCUMENT)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, fpdf_document_t__*, int> FFI_GetCurrentPageIndex;

    [NativeTypeName("void (*)(struct _FPDF_FORMFILLINFO *, FPDF_DOCUMENT, int)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, fpdf_document_t__*, int, void> FFI_SetCurrentPage;

    [NativeTypeName("void (*)(struct _FPDF_FORMFILLINFO *, FPDF_DOCUMENT, FPDF_WIDESTRING)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, fpdf_document_t__*, ushort*, void> FFI_GotoURL;

    [NativeTypeName("void (*)(struct _FPDF_FORMFILLINFO *, FPDF_PAGE, double *, double *, double *, double *)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, fpdf_page_t__*, double*, double*, double*, double*, void> FFI_GetPageViewRect;

    [NativeTypeName("void (*)(struct _FPDF_FORMFILLINFO *, int, FPDF_DWORD)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, int, uint, void> FFI_PageEvent;

    [NativeTypeName("FPDF_BOOL (*)(struct _FPDF_FORMFILLINFO *, FPDF_PAGE, FPDF_WIDGET, int, float, float)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, fpdf_page_t__*, fpdf_widget_t__*, int, float, float, int> FFI_PopupMenu;

    [NativeTypeName("FPDF_FILEHANDLER *(*)(struct _FPDF_FORMFILLINFO *, int, FPDF_WIDESTRING, const char *)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, int, ushort*, sbyte*, FPDF_FILEHANDLER_*> FFI_OpenFile;

    [NativeTypeName("void (*)(struct _FPDF_FORMFILLINFO *, FPDF_FILEHANDLER *, FPDF_WIDESTRING, FPDF_WIDESTRING, FPDF_WIDESTRING, FPDF_WIDESTRING, FPDF_WIDESTRING)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, FPDF_FILEHANDLER_*, ushort*, ushort*, ushort*, ushort*, ushort*, void> FFI_EmailTo;

    [NativeTypeName("void (*)(struct _FPDF_FORMFILLINFO *, FPDF_FILEHANDLER *, int, FPDF_WIDESTRING)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, FPDF_FILEHANDLER_*, int, ushort*, void> FFI_UploadTo;

    [NativeTypeName("int (*)(struct _FPDF_FORMFILLINFO *, void *, int)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, void*, int, int> FFI_GetPlatform;

    [NativeTypeName("int (*)(struct _FPDF_FORMFILLINFO *, void *, int)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, void*, int, int> FFI_GetLanguage;

    [NativeTypeName("FPDF_FILEHANDLER *(*)(struct _FPDF_FORMFILLINFO *, FPDF_WIDESTRING)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, ushort*, FPDF_FILEHANDLER_*> FFI_DownloadFromURL;

    [NativeTypeName("FPDF_BOOL (*)(struct _FPDF_FORMFILLINFO *, FPDF_WIDESTRING, FPDF_WIDESTRING, FPDF_WIDESTRING, FPDF_WIDESTRING, FPDF_WIDESTRING, FPDF_BSTR *)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, ushort*, ushort*, ushort*, ushort*, ushort*, FPDF_BSTR_*, int> FFI_PostRequestURL;

    [NativeTypeName("FPDF_BOOL (*)(struct _FPDF_FORMFILLINFO *, FPDF_WIDESTRING, FPDF_WIDESTRING, FPDF_WIDESTRING)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, ushort*, ushort*, ushort*, int> FFI_PutRequestURL;

    [NativeTypeName("void (*)(struct _FPDF_FORMFILLINFO *, FPDF_ANNOTATION, int)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, fpdf_annotation_t__*, int, void> FFI_OnFocusChange;

    [NativeTypeName("void (*)(struct _FPDF_FORMFILLINFO *, FPDF_BYTESTRING, int)")]
    public delegate* unmanaged[Cdecl]<_FPDF_FORMFILLINFO*, sbyte*, int, void> FFI_DoURIActionWithKeyboardModifier;
}

internal enum FWL_EVENTFLAG
{
    FWL_EVENTFLAG_ShiftKey = 1 << 0,
    FWL_EVENTFLAG_ControlKey = 1 << 1,
    FWL_EVENTFLAG_AltKey = 1 << 2,
    FWL_EVENTFLAG_MetaKey = 1 << 3,
    FWL_EVENTFLAG_KeyPad = 1 << 4,
    FWL_EVENTFLAG_AutoRepeat = 1 << 5,
    FWL_EVENTFLAG_LeftButtonDown = 1 << 6,
    FWL_EVENTFLAG_MiddleButtonDown = 1 << 7,
    FWL_EVENTFLAG_RightButtonDown = 1 << 8,
}

internal enum FWL_VKEYCODE
{
    FWL_VKEY_Back = 0x08,
    FWL_VKEY_Tab = 0x09,
    FWL_VKEY_NewLine = 0x0A,
    FWL_VKEY_Clear = 0x0C,
    FWL_VKEY_Return = 0x0D,
    FWL_VKEY_Shift = 0x10,
    FWL_VKEY_Control = 0x11,
    FWL_VKEY_Menu = 0x12,
    FWL_VKEY_Pause = 0x13,
    FWL_VKEY_Capital = 0x14,
    FWL_VKEY_Kana = 0x15,
    FWL_VKEY_Hangul = 0x15,
    FWL_VKEY_Junja = 0x17,
    FWL_VKEY_Final = 0x18,
    FWL_VKEY_Hanja = 0x19,
    FWL_VKEY_Kanji = 0x19,
    FWL_VKEY_Escape = 0x1B,
    FWL_VKEY_Convert = 0x1C,
    FWL_VKEY_NonConvert = 0x1D,
    FWL_VKEY_Accept = 0x1E,
    FWL_VKEY_ModeChange = 0x1F,
    FWL_VKEY_Space = 0x20,
    FWL_VKEY_Prior = 0x21,
    FWL_VKEY_Next = 0x22,
    FWL_VKEY_End = 0x23,
    FWL_VKEY_Home = 0x24,
    FWL_VKEY_Left = 0x25,
    FWL_VKEY_Up = 0x26,
    FWL_VKEY_Right = 0x27,
    FWL_VKEY_Down = 0x28,
    FWL_VKEY_Select = 0x29,
    FWL_VKEY_Print = 0x2A,
    FWL_VKEY_Execute = 0x2B,
    FWL_VKEY_Snapshot = 0x2C,
    FWL_VKEY_Insert = 0x2D,
    FWL_VKEY_Delete = 0x2E,
    FWL_VKEY_Help = 0x2F,
    FWL_VKEY_0 = 0x30,
    FWL_VKEY_1 = 0x31,
    FWL_VKEY_2 = 0x32,
    FWL_VKEY_3 = 0x33,
    FWL_VKEY_4 = 0x34,
    FWL_VKEY_5 = 0x35,
    FWL_VKEY_6 = 0x36,
    FWL_VKEY_7 = 0x37,
    FWL_VKEY_8 = 0x38,
    FWL_VKEY_9 = 0x39,
    FWL_VKEY_A = 0x41,
    FWL_VKEY_B = 0x42,
    FWL_VKEY_C = 0x43,
    FWL_VKEY_D = 0x44,
    FWL_VKEY_E = 0x45,
    FWL_VKEY_F = 0x46,
    FWL_VKEY_G = 0x47,
    FWL_VKEY_H = 0x48,
    FWL_VKEY_I = 0x49,
    FWL_VKEY_J = 0x4A,
    FWL_VKEY_K = 0x4B,
    FWL_VKEY_L = 0x4C,
    FWL_VKEY_M = 0x4D,
    FWL_VKEY_N = 0x4E,
    FWL_VKEY_O = 0x4F,
    FWL_VKEY_P = 0x50,
    FWL_VKEY_Q = 0x51,
    FWL_VKEY_R = 0x52,
    FWL_VKEY_S = 0x53,
    FWL_VKEY_T = 0x54,
    FWL_VKEY_U = 0x55,
    FWL_VKEY_V = 0x56,
    FWL_VKEY_W = 0x57,
    FWL_VKEY_X = 0x58,
    FWL_VKEY_Y = 0x59,
    FWL_VKEY_Z = 0x5A,
    FWL_VKEY_LWin = 0x5B,
    FWL_VKEY_Command = 0x5B,
    FWL_VKEY_RWin = 0x5C,
    FWL_VKEY_Apps = 0x5D,
    FWL_VKEY_Sleep = 0x5F,
    FWL_VKEY_NumPad0 = 0x60,
    FWL_VKEY_NumPad1 = 0x61,
    FWL_VKEY_NumPad2 = 0x62,
    FWL_VKEY_NumPad3 = 0x63,
    FWL_VKEY_NumPad4 = 0x64,
    FWL_VKEY_NumPad5 = 0x65,
    FWL_VKEY_NumPad6 = 0x66,
    FWL_VKEY_NumPad7 = 0x67,
    FWL_VKEY_NumPad8 = 0x68,
    FWL_VKEY_NumPad9 = 0x69,
    FWL_VKEY_Multiply = 0x6A,
    FWL_VKEY_Add = 0x6B,
    FWL_VKEY_Separator = 0x6C,
    FWL_VKEY_Subtract = 0x6D,
    FWL_VKEY_Decimal = 0x6E,
    FWL_VKEY_Divide = 0x6F,
    FWL_VKEY_F1 = 0x70,
    FWL_VKEY_F2 = 0x71,
    FWL_VKEY_F3 = 0x72,
    FWL_VKEY_F4 = 0x73,
    FWL_VKEY_F5 = 0x74,
    FWL_VKEY_F6 = 0x75,
    FWL_VKEY_F7 = 0x76,
    FWL_VKEY_F8 = 0x77,
    FWL_VKEY_F9 = 0x78,
    FWL_VKEY_F10 = 0x79,
    FWL_VKEY_F11 = 0x7A,
    FWL_VKEY_F12 = 0x7B,
    FWL_VKEY_F13 = 0x7C,
    FWL_VKEY_F14 = 0x7D,
    FWL_VKEY_F15 = 0x7E,
    FWL_VKEY_F16 = 0x7F,
    FWL_VKEY_F17 = 0x80,
    FWL_VKEY_F18 = 0x81,
    FWL_VKEY_F19 = 0x82,
    FWL_VKEY_F20 = 0x83,
    FWL_VKEY_F21 = 0x84,
    FWL_VKEY_F22 = 0x85,
    FWL_VKEY_F23 = 0x86,
    FWL_VKEY_F24 = 0x87,
    FWL_VKEY_NunLock = 0x90,
    FWL_VKEY_Scroll = 0x91,
    FWL_VKEY_LShift = 0xA0,
    FWL_VKEY_RShift = 0xA1,
    FWL_VKEY_LControl = 0xA2,
    FWL_VKEY_RControl = 0xA3,
    FWL_VKEY_LMenu = 0xA4,
    FWL_VKEY_RMenu = 0xA5,
    FWL_VKEY_BROWSER_Back = 0xA6,
    FWL_VKEY_BROWSER_Forward = 0xA7,
    FWL_VKEY_BROWSER_Refresh = 0xA8,
    FWL_VKEY_BROWSER_Stop = 0xA9,
    FWL_VKEY_BROWSER_Search = 0xAA,
    FWL_VKEY_BROWSER_Favorites = 0xAB,
    FWL_VKEY_BROWSER_Home = 0xAC,
    FWL_VKEY_VOLUME_Mute = 0xAD,
    FWL_VKEY_VOLUME_Down = 0xAE,
    FWL_VKEY_VOLUME_Up = 0xAF,
    FWL_VKEY_MEDIA_NEXT_Track = 0xB0,
    FWL_VKEY_MEDIA_PREV_Track = 0xB1,
    FWL_VKEY_MEDIA_Stop = 0xB2,
    FWL_VKEY_MEDIA_PLAY_Pause = 0xB3,
    FWL_VKEY_MEDIA_LAUNCH_Mail = 0xB4,
    FWL_VKEY_MEDIA_LAUNCH_MEDIA_Select = 0xB5,
    FWL_VKEY_MEDIA_LAUNCH_APP1 = 0xB6,
    FWL_VKEY_MEDIA_LAUNCH_APP2 = 0xB7,
    FWL_VKEY_OEM_1 = 0xBA,
    FWL_VKEY_OEM_Plus = 0xBB,
    FWL_VKEY_OEM_Comma = 0xBC,
    FWL_VKEY_OEM_Minus = 0xBD,
    FWL_VKEY_OEM_Period = 0xBE,
    FWL_VKEY_OEM_2 = 0xBF,
    FWL_VKEY_OEM_3 = 0xC0,
    FWL_VKEY_OEM_4 = 0xDB,
    FWL_VKEY_OEM_5 = 0xDC,
    FWL_VKEY_OEM_6 = 0xDD,
    FWL_VKEY_OEM_7 = 0xDE,
    FWL_VKEY_OEM_8 = 0xDF,
    FWL_VKEY_OEM_102 = 0xE2,
    FWL_VKEY_ProcessKey = 0xE5,
    FWL_VKEY_Packet = 0xE7,
    FWL_VKEY_Attn = 0xF6,
    FWL_VKEY_Crsel = 0xF7,
    FWL_VKEY_Exsel = 0xF8,
    FWL_VKEY_Ereof = 0xF9,
    FWL_VKEY_Play = 0xFA,
    FWL_VKEY_Zoom = 0xFB,
    FWL_VKEY_NoName = 0xFC,
    FWL_VKEY_PA1 = 0xFD,
    FWL_VKEY_OEM_Clear = 0xFE,
    FWL_VKEY_Unknown = 0,
}

internal unsafe partial struct _IFSDK_PAUSE
{
    public int version;

    [NativeTypeName("FPDF_BOOL (*)(struct _IFSDK_PAUSE *)")]
    public delegate* unmanaged[Cdecl]<_IFSDK_PAUSE*, int> NeedToPauseNow;

    public void* user;
}

internal unsafe partial struct FPDF_FILEWRITE_
{
    public int version;

    [NativeTypeName("int (*)(struct FPDF_FILEWRITE_ *, const void *, unsigned long)")]
    public delegate* unmanaged[Cdecl]<FPDF_FILEWRITE_*, void*, uint, int> WriteBlock;
}

internal unsafe partial struct _FPDF_SYSFONTINFO
{
    public int version;

    [NativeTypeName("void (*)(struct _FPDF_SYSFONTINFO *)")]
    public delegate* unmanaged[Cdecl]<_FPDF_SYSFONTINFO*, void> Release;

    [NativeTypeName("void (*)(struct _FPDF_SYSFONTINFO *, void *)")]
    public delegate* unmanaged[Cdecl]<_FPDF_SYSFONTINFO*, void*, void> EnumFontsA;

    [NativeTypeName("void *(*)(struct _FPDF_SYSFONTINFO *, int, FPDF_BOOL, int, int, const char *, FPDF_BOOL *)")]
    public delegate* unmanaged[Cdecl]<_FPDF_SYSFONTINFO*, int, int, int, int, sbyte*, int*, void*> MapFont;

    [NativeTypeName("void *(*)(struct _FPDF_SYSFONTINFO *, const char *)")]
    public delegate* unmanaged[Cdecl]<_FPDF_SYSFONTINFO*, sbyte*, void*> GetFont;

    [NativeTypeName("unsigned long (*)(struct _FPDF_SYSFONTINFO *, void *, unsigned int, unsigned char *, unsigned long)")]
    public delegate* unmanaged[Cdecl]<_FPDF_SYSFONTINFO*, void*, uint, byte*, uint, uint> GetFontData;

    [NativeTypeName("unsigned long (*)(struct _FPDF_SYSFONTINFO *, void *, char *, unsigned long)")]
    public delegate* unmanaged[Cdecl]<_FPDF_SYSFONTINFO*, void*, sbyte*, uint, uint> GetFaceName;

    [NativeTypeName("int (*)(struct _FPDF_SYSFONTINFO *, void *)")]
    public delegate* unmanaged[Cdecl]<_FPDF_SYSFONTINFO*, void*, int> GetFontCharset;

    [NativeTypeName("void (*)(struct _FPDF_SYSFONTINFO *, void *)")]
    public delegate* unmanaged[Cdecl]<_FPDF_SYSFONTINFO*, void*, void> DeleteFont;
}

internal unsafe partial struct FPDF_CharsetFontMap_
{
    public int charset;

    [NativeTypeName("const char *")]
    public sbyte* fontname;
}

internal enum FPDF_TEXT_RENDERMODE
{
    FPDF_TEXTRENDERMODE_UNKNOWN = -1,
    FPDF_TEXTRENDERMODE_FILL = 0,
    FPDF_TEXTRENDERMODE_STROKE = 1,
    FPDF_TEXTRENDERMODE_FILL_STROKE = 2,
    FPDF_TEXTRENDERMODE_INVISIBLE = 3,
    FPDF_TEXTRENDERMODE_FILL_CLIP = 4,
    FPDF_TEXTRENDERMODE_STROKE_CLIP = 5,
    FPDF_TEXTRENDERMODE_FILL_STROKE_CLIP = 6,
    FPDF_TEXTRENDERMODE_CLIP = 7,
    FPDF_TEXTRENDERMODE_LAST = FPDF_TEXTRENDERMODE_CLIP,
}

internal partial struct fpdf_action_t__
{
}

internal partial struct fpdf_annotation_t__
{
}

internal partial struct fpdf_attachment_t__
{
}

internal partial struct fpdf_avail_t__
{
}

internal partial struct fpdf_bitmap_t__
{
}

internal partial struct fpdf_bookmark_t__
{
}

internal partial struct fpdf_clippath_t__
{
}

internal partial struct fpdf_dest_t__
{
}

internal partial struct fpdf_document_t__
{
}

internal partial struct fpdf_font_t__
{
}

internal partial struct fpdf_form_handle_t__
{
}

internal partial struct fpdf_glyphpath_t__
{
}

internal partial struct fpdf_javascript_action_t
{
}

internal partial struct fpdf_link_t__
{
}

internal partial struct fpdf_page_t__
{
}

internal partial struct fpdf_pagelink_t__
{
}

internal partial struct fpdf_pageobject_t__
{
}

internal partial struct fpdf_pageobjectmark_t__
{
}

internal partial struct fpdf_pagerange_t__
{
}

internal partial struct fpdf_pathsegment_t
{
}

internal partial struct fpdf_schhandle_t__
{
}

internal partial struct fpdf_signature_t__
{
}

internal partial struct fpdf_structelement_t__
{
}

internal partial struct fpdf_structelement_attr_t__
{
}

internal partial struct fpdf_structelement_attr_value_t__
{
}

internal partial struct fpdf_structtree_t__
{
}

internal partial struct fpdf_textpage_t__
{
}

internal partial struct fpdf_widget_t__
{
}

internal partial struct fpdf_xobject_t__
{
}

internal enum _FPDF_DUPLEXTYPE_
{
    DuplexUndefined = 0,
    Simplex,
    DuplexFlipShortEdge,
    DuplexFlipLongEdge,
}

internal unsafe partial struct FPDF_BSTR_
{
    [NativeTypeName("char *")]
    public sbyte* str;

    public int len;
}

internal partial struct _FS_MATRIX_
{
    public float a;

    public float b;

    public float c;

    public float d;

    public float e;

    public float f;
}

internal partial struct _FS_RECTF_
{
    public float left;

    public float top;

    public float right;

    public float bottom;
}

internal partial struct FS_SIZEF_
{
    public float width;

    public float height;
}

internal partial struct FS_POINTF_
{
    public float x;

    public float y;
}

internal partial struct _FS_QUADPOINTSF
{
    [NativeTypeName("FS_FLOAT")]
    public float x1;

    [NativeTypeName("FS_FLOAT")]
    public float y1;

    [NativeTypeName("FS_FLOAT")]
    public float x2;

    [NativeTypeName("FS_FLOAT")]
    public float y2;

    [NativeTypeName("FS_FLOAT")]
    public float x3;

    [NativeTypeName("FS_FLOAT")]
    public float y3;

    [NativeTypeName("FS_FLOAT")]
    public float x4;

    [NativeTypeName("FS_FLOAT")]
    public float y4;
}

internal enum FPDF_RENDERER_TYPE
{
    FPDF_RENDERERTYPE_AGG = 0,
    FPDF_RENDERERTYPE_SKIA = 1,
}

internal unsafe partial struct FPDF_LIBRARY_CONFIG_
{
    public int version;

    [NativeTypeName("const char **")]
    public sbyte** m_pUserFontPaths;

    public void* m_pIsolate;

    [NativeTypeName("unsigned int")]
    public uint m_v8EmbedderSlot;

    public void* m_pPlatform;

    public FPDF_RENDERER_TYPE m_RendererType;
}

internal unsafe partial struct FPDF_FILEACCESS
{
    [NativeTypeName("unsigned long")]
    public uint m_FileLen;

    [NativeTypeName("int (*)(void *, unsigned long, unsigned char *, unsigned long)")]
    public delegate* unmanaged[Cdecl]<void*, uint, byte*, uint, int> m_GetBlock;

    public void* m_Param;
}

internal unsafe partial struct FPDF_FILEHANDLER_
{
    public void* clientData;

    [NativeTypeName("void (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, void> Release;

    [NativeTypeName("FPDF_DWORD (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, uint> GetSize;

    [NativeTypeName("FPDF_RESULT (*)(void *, FPDF_DWORD, void *, FPDF_DWORD)")]
    public delegate* unmanaged[Cdecl]<void*, uint, void*, uint, int> ReadBlock;

    [NativeTypeName("FPDF_RESULT (*)(void *, FPDF_DWORD, const void *, FPDF_DWORD)")]
    public delegate* unmanaged[Cdecl]<void*, uint, void*, uint, int> WriteBlock;

    [NativeTypeName("FPDF_RESULT (*)(void *)")]
    public delegate* unmanaged[Cdecl]<void*, int> Flush;

    [NativeTypeName("FPDF_RESULT (*)(void *, FPDF_DWORD)")]
    public delegate* unmanaged[Cdecl]<void*, uint, int> Truncate;
}

internal partial struct FPDF_COLORSCHEME_
{
    [NativeTypeName("FPDF_DWORD")]
    public uint path_fill_color;

    [NativeTypeName("FPDF_DWORD")]
    public uint path_stroke_color;

    [NativeTypeName("FPDF_DWORD")]
    public uint text_fill_color;

    [NativeTypeName("FPDF_DWORD")]
    public uint text_stroke_color;
}

internal static unsafe partial class NativeMethods
{
    public const string DLL_NAME = "pdfium";
    
    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_IsSupportedSubtype([NativeTypeName("FPDF_ANNOTATION_SUBTYPE")] int subtype);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_ANNOTATION")]
    internal static extern fpdf_annotation_t__* FPDFPage_CreateAnnot([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("FPDF_ANNOTATION_SUBTYPE")] int subtype);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFPage_GetAnnotCount([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_ANNOTATION")]
    internal static extern fpdf_annotation_t__* FPDFPage_GetAnnot([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFPage_GetAnnotIndex([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFPage_CloseAnnot([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPage_RemoveAnnot([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_ANNOTATION_SUBTYPE")]
    internal static extern int FPDFAnnot_GetSubtype([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_IsObjectSupportedSubtype([NativeTypeName("FPDF_ANNOTATION_SUBTYPE")] int subtype);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_UpdateObject([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* obj);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFAnnot_AddInkStroke([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("const FS_POINTF *")] FS_POINTF_* points, [NativeTypeName("size_t")] nuint point_count);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_RemoveInkList([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_AppendObject([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* obj);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFAnnot_GetObjectCount([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_PAGEOBJECT")]
    internal static extern fpdf_pageobject_t__* FPDFAnnot_GetObject([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_RemoveObject([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_SetColor([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, FPDFANNOT_COLORTYPE type, [NativeTypeName("unsigned int")] uint R, [NativeTypeName("unsigned int")] uint G, [NativeTypeName("unsigned int")] uint B, [NativeTypeName("unsigned int")] uint A);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_GetColor([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, FPDFANNOT_COLORTYPE type, [NativeTypeName("unsigned int *")] uint* R, [NativeTypeName("unsigned int *")] uint* G, [NativeTypeName("unsigned int *")] uint* B, [NativeTypeName("unsigned int *")] uint* A);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_HasAttachmentPoints([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_SetAttachmentPoints([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("size_t")] nuint quad_index, [NativeTypeName("const FS_QUADPOINTSF *")] _FS_QUADPOINTSF* quad_points);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_AppendAttachmentPoints([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("const FS_QUADPOINTSF *")] _FS_QUADPOINTSF* quad_points);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    internal static extern nuint FPDFAnnot_CountAttachmentPoints([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_GetAttachmentPoints([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("size_t")] nuint quad_index, [NativeTypeName("FS_QUADPOINTSF *")] _FS_QUADPOINTSF* quad_points);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_SetRect([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("const FS_RECTF *")] _FS_RECTF_* rect);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_GetRect([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("FS_RECTF *")] _FS_RECTF_* rect);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFAnnot_GetVertices([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("FS_POINTF *")] FS_POINTF_* buffer, [NativeTypeName("unsigned long")] uint length);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFAnnot_GetInkListCount([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFAnnot_GetInkListPath([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("unsigned long")] uint path_index, [NativeTypeName("FS_POINTF *")] FS_POINTF_* buffer, [NativeTypeName("unsigned long")] uint length);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_GetLine([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("FS_POINTF *")] FS_POINTF_* start, [NativeTypeName("FS_POINTF *")] FS_POINTF_* end);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_SetBorder([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, float horizontal_radius, float vertical_radius, float border_width);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_GetBorder([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, float* horizontal_radius, float* vertical_radius, float* border_width);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFAnnot_GetFormAdditionalActionJavaScript([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, int @event, [NativeTypeName("FPDF_WCHAR *")] ushort* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_HasKey([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_OBJECT_TYPE")]
    internal static extern int FPDFAnnot_GetValueType([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_SetStringValue([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key, [NativeTypeName("FPDF_WIDESTRING")] ushort* value);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFAnnot_GetStringValue([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key, [NativeTypeName("FPDF_WCHAR *")] ushort* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_GetNumberValue([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key, float* value);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_SetAP([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("FPDF_ANNOT_APPEARANCEMODE")] int appearanceMode, [NativeTypeName("FPDF_WIDESTRING")] ushort* value);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFAnnot_GetAP([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("FPDF_ANNOT_APPEARANCEMODE")] int appearanceMode, [NativeTypeName("FPDF_WCHAR *")] ushort* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_ANNOTATION")]
    internal static extern fpdf_annotation_t__* FPDFAnnot_GetLinkedAnnot([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFAnnot_GetFlags([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_SetFlags([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, int flags);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFAnnot_GetFormFieldFlags([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* handle, [NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_SetFormFieldFlags([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* handle, [NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, int flags);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_ANNOTATION")]
    internal static extern fpdf_annotation_t__* FPDFAnnot_GetFormFieldAtPoint([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("const FS_POINTF *")] FS_POINTF_* point);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFAnnot_GetFormFieldName([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("FPDF_WCHAR *")] ushort* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFAnnot_GetFormFieldAlternateName([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("FPDF_WCHAR *")] ushort* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFAnnot_GetFormFieldType([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFAnnot_GetFormFieldValue([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("FPDF_WCHAR *")] ushort* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFAnnot_GetOptionCount([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFAnnot_GetOptionLabel([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, int index, [NativeTypeName("FPDF_WCHAR *")] ushort* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_IsOptionSelected([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* handle, [NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_GetFontSize([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, float* value);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_SetFontColor([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* handle, [NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("unsigned int")] uint R, [NativeTypeName("unsigned int")] uint G, [NativeTypeName("unsigned int")] uint B);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_GetFontColor([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("unsigned int *")] uint* R, [NativeTypeName("unsigned int *")] uint* G, [NativeTypeName("unsigned int *")] uint* B);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_IsChecked([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_SetFocusableSubtypes([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("const FPDF_ANNOTATION_SUBTYPE *")] int* subtypes, [NativeTypeName("size_t")] nuint count);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFAnnot_GetFocusableSubtypesCount([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_GetFocusableSubtypes([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_ANNOTATION_SUBTYPE *")] int* subtypes, [NativeTypeName("size_t")] nuint count);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_LINK")]
    internal static extern fpdf_link_t__* FPDFAnnot_GetLink([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFAnnot_GetFormControlCount([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFAnnot_GetFormControlIndex([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFAnnot_GetFormFieldExportValue([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("FPDF_WCHAR *")] ushort* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAnnot_SetURI([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("const char *")] sbyte* uri);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_ATTACHMENT")]
    internal static extern fpdf_attachment_t__* FPDFAnnot_GetFileAttachment([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_ATTACHMENT")]
    internal static extern fpdf_attachment_t__* FPDFAnnot_AddFileAttachment([NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot, [NativeTypeName("FPDF_WIDESTRING")] ushort* name);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFDoc_GetAttachmentCount([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_ATTACHMENT")]
    internal static extern fpdf_attachment_t__* FPDFDoc_AddAttachment([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_WIDESTRING")] ushort* name);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_ATTACHMENT")]
    internal static extern fpdf_attachment_t__* FPDFDoc_GetAttachment([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFDoc_DeleteAttachment([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFAttachment_GetName([NativeTypeName("FPDF_ATTACHMENT")] fpdf_attachment_t__* attachment, [NativeTypeName("FPDF_WCHAR *")] ushort* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAttachment_HasKey([NativeTypeName("FPDF_ATTACHMENT")] fpdf_attachment_t__* attachment, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_OBJECT_TYPE")]
    internal static extern int FPDFAttachment_GetValueType([NativeTypeName("FPDF_ATTACHMENT")] fpdf_attachment_t__* attachment, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAttachment_SetStringValue([NativeTypeName("FPDF_ATTACHMENT")] fpdf_attachment_t__* attachment, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key, [NativeTypeName("FPDF_WIDESTRING")] ushort* value);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFAttachment_GetStringValue([NativeTypeName("FPDF_ATTACHMENT")] fpdf_attachment_t__* attachment, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key, [NativeTypeName("FPDF_WCHAR *")] ushort* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAttachment_SetFile([NativeTypeName("FPDF_ATTACHMENT")] fpdf_attachment_t__* attachment, [NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("const void *")] void* contents, [NativeTypeName("unsigned long")] uint len);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFAttachment_GetFile([NativeTypeName("FPDF_ATTACHMENT")] fpdf_attachment_t__* attachment, void* buffer, [NativeTypeName("unsigned long")] uint buflen, [NativeTypeName("unsigned long *")] uint* out_buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFAttachment_GetSubtype([NativeTypeName("FPDF_ATTACHMENT")] fpdf_attachment_t__* attachment, [NativeTypeName("FPDF_WCHAR *")] ushort* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFCatalog_IsTagged([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFCatalog_SetLanguage([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_BYTESTRING")] sbyte* language);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_AVAIL")]
    internal static extern fpdf_avail_t__* FPDFAvail_Create([NativeTypeName("FX_FILEAVAIL *")] _FX_FILEAVAIL* file_avail, FPDF_FILEACCESS* file);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFAvail_Destroy([NativeTypeName("FPDF_AVAIL")] fpdf_avail_t__* avail);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFAvail_IsDocAvail([NativeTypeName("FPDF_AVAIL")] fpdf_avail_t__* avail, [NativeTypeName("FX_DOWNLOADHINTS *")] _FX_DOWNLOADHINTS* hints);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_DOCUMENT")]
    internal static extern fpdf_document_t__* FPDFAvail_GetDocument([NativeTypeName("FPDF_AVAIL")] fpdf_avail_t__* avail, [NativeTypeName("FPDF_BYTESTRING")] sbyte* password);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFAvail_GetFirstPageNum([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* doc);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFAvail_IsPageAvail([NativeTypeName("FPDF_AVAIL")] fpdf_avail_t__* avail, int page_index, [NativeTypeName("FX_DOWNLOADHINTS *")] _FX_DOWNLOADHINTS* hints);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFAvail_IsFormAvail([NativeTypeName("FPDF_AVAIL")] fpdf_avail_t__* avail, [NativeTypeName("FX_DOWNLOADHINTS *")] _FX_DOWNLOADHINTS* hints);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFAvail_IsLinearized([NativeTypeName("FPDF_AVAIL")] fpdf_avail_t__* avail);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOKMARK")]
    internal static extern fpdf_bookmark_t__* FPDFBookmark_GetFirstChild([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_BOOKMARK")] fpdf_bookmark_t__* bookmark);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOKMARK")]
    internal static extern fpdf_bookmark_t__* FPDFBookmark_GetNextSibling([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_BOOKMARK")] fpdf_bookmark_t__* bookmark);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFBookmark_GetTitle([NativeTypeName("FPDF_BOOKMARK")] fpdf_bookmark_t__* bookmark, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFBookmark_GetCount([NativeTypeName("FPDF_BOOKMARK")] fpdf_bookmark_t__* bookmark);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOKMARK")]
    internal static extern fpdf_bookmark_t__* FPDFBookmark_Find([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_WIDESTRING")] ushort* title);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_DEST")]
    internal static extern fpdf_dest_t__* FPDFBookmark_GetDest([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_BOOKMARK")] fpdf_bookmark_t__* bookmark);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_ACTION")]
    internal static extern fpdf_action_t__* FPDFBookmark_GetAction([NativeTypeName("FPDF_BOOKMARK")] fpdf_bookmark_t__* bookmark);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFAction_GetType([NativeTypeName("FPDF_ACTION")] fpdf_action_t__* action);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_DEST")]
    internal static extern fpdf_dest_t__* FPDFAction_GetDest([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_ACTION")] fpdf_action_t__* action);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFAction_GetFilePath([NativeTypeName("FPDF_ACTION")] fpdf_action_t__* action, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFAction_GetURIPath([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_ACTION")] fpdf_action_t__* action, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFDest_GetDestPageIndex([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_DEST")] fpdf_dest_t__* dest);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFDest_GetView([NativeTypeName("FPDF_DEST")] fpdf_dest_t__* dest, [NativeTypeName("unsigned long *")] uint* pNumParams, [NativeTypeName("FS_FLOAT *")] float* pParams);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFDest_GetLocationInPage([NativeTypeName("FPDF_DEST")] fpdf_dest_t__* dest, [NativeTypeName("FPDF_BOOL *")] int* hasXVal, [NativeTypeName("FPDF_BOOL *")] int* hasYVal, [NativeTypeName("FPDF_BOOL *")] int* hasZoomVal, [NativeTypeName("FS_FLOAT *")] float* x, [NativeTypeName("FS_FLOAT *")] float* y, [NativeTypeName("FS_FLOAT *")] float* zoom);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_LINK")]
    internal static extern fpdf_link_t__* FPDFLink_GetLinkAtPoint([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, double x, double y);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFLink_GetLinkZOrderAtPoint([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, double x, double y);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_DEST")]
    internal static extern fpdf_dest_t__* FPDFLink_GetDest([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_LINK")] fpdf_link_t__* link);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_ACTION")]
    internal static extern fpdf_action_t__* FPDFLink_GetAction([NativeTypeName("FPDF_LINK")] fpdf_link_t__* link);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFLink_Enumerate([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int* start_pos, [NativeTypeName("FPDF_LINK *")] fpdf_link_t__** link_annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_ANNOTATION")]
    internal static extern fpdf_annotation_t__* FPDFLink_GetAnnot([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("FPDF_LINK")] fpdf_link_t__* link_annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFLink_GetAnnotRect([NativeTypeName("FPDF_LINK")] fpdf_link_t__* link_annot, [NativeTypeName("FS_RECTF *")] _FS_RECTF_* rect);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFLink_CountQuadPoints([NativeTypeName("FPDF_LINK")] fpdf_link_t__* link_annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFLink_GetQuadPoints([NativeTypeName("FPDF_LINK")] fpdf_link_t__* link_annot, int quad_index, [NativeTypeName("FS_QUADPOINTSF *")] _FS_QUADPOINTSF* quad_points);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_ACTION")]
    internal static extern fpdf_action_t__* FPDF_GetPageAAction([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int aa_type);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDF_GetFileIdentifier([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, FPDF_FILEIDTYPE id_type, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDF_GetMetaText([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_BYTESTRING")] sbyte* tag, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDF_GetPageLabel([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, int page_index, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_DOCUMENT")]
    internal static extern fpdf_document_t__* FPDF_CreateNewDocument();

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_PAGE")]
    internal static extern fpdf_page_t__* FPDFPage_New([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, int page_index, double width, double height);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFPage_Delete([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, int page_index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_MovePages([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("const int *")] int* page_indices, [NativeTypeName("unsigned long")] uint page_indices_len, int dest_page_index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFPage_GetRotation([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFPage_SetRotation([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int rotate);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFPage_InsertObject([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPage_InsertObjectAtIndex([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("size_t")] nuint index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPage_RemoveObject([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFPage_CountObjects([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_PAGEOBJECT")]
    internal static extern fpdf_pageobject_t__* FPDFPage_GetObject([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPage_HasTransparency([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPage_GenerateContent([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFPageObj_Destroy([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_HasTransparency([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFPageObj_GetType([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_GetIsActive([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("FPDF_BOOL *")] int* active);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_SetIsActive([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("FPDF_BOOL")] int active);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFPageObj_Transform([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, double a, double b, double c, double d, double e, double f);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_TransformF([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("const FS_MATRIX *")] _FS_MATRIX_* matrix);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_GetMatrix([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("FS_MATRIX *")] _FS_MATRIX_* matrix);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_SetMatrix([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("const FS_MATRIX *")] _FS_MATRIX_* matrix);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFPage_TransformAnnots([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, double a, double b, double c, double d, double e, double f);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_PAGEOBJECT")]
    internal static extern fpdf_pageobject_t__* FPDFPageObj_NewImageObj([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFPageObj_GetMarkedContentID([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFPageObj_CountMarks([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_PAGEOBJECTMARK")]
    internal static extern fpdf_pageobjectmark_t__* FPDFPageObj_GetMark([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("unsigned long")] uint index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_PAGEOBJECTMARK")]
    internal static extern fpdf_pageobjectmark_t__* FPDFPageObj_AddMark([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("FPDF_BYTESTRING")] sbyte* name);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_RemoveMark([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("FPDF_PAGEOBJECTMARK")] fpdf_pageobjectmark_t__* mark);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObjMark_GetName([NativeTypeName("FPDF_PAGEOBJECTMARK")] fpdf_pageobjectmark_t__* mark, [NativeTypeName("FPDF_WCHAR *")] ushort* buffer, [NativeTypeName("unsigned long")] uint buflen, [NativeTypeName("unsigned long *")] uint* out_buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFPageObjMark_CountParams([NativeTypeName("FPDF_PAGEOBJECTMARK")] fpdf_pageobjectmark_t__* mark);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObjMark_GetParamKey([NativeTypeName("FPDF_PAGEOBJECTMARK")] fpdf_pageobjectmark_t__* mark, [NativeTypeName("unsigned long")] uint index, [NativeTypeName("FPDF_WCHAR *")] ushort* buffer, [NativeTypeName("unsigned long")] uint buflen, [NativeTypeName("unsigned long *")] uint* out_buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_OBJECT_TYPE")]
    internal static extern int FPDFPageObjMark_GetParamValueType([NativeTypeName("FPDF_PAGEOBJECTMARK")] fpdf_pageobjectmark_t__* mark, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObjMark_GetParamIntValue([NativeTypeName("FPDF_PAGEOBJECTMARK")] fpdf_pageobjectmark_t__* mark, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key, int* out_value);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObjMark_GetParamFloatValue([NativeTypeName("FPDF_PAGEOBJECTMARK")] fpdf_pageobjectmark_t__* mark, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key, float* out_value);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObjMark_GetParamStringValue([NativeTypeName("FPDF_PAGEOBJECTMARK")] fpdf_pageobjectmark_t__* mark, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key, [NativeTypeName("FPDF_WCHAR *")] ushort* buffer, [NativeTypeName("unsigned long")] uint buflen, [NativeTypeName("unsigned long *")] uint* out_buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObjMark_GetParamBlobValue([NativeTypeName("FPDF_PAGEOBJECTMARK")] fpdf_pageobjectmark_t__* mark, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key, [NativeTypeName("unsigned char *")] byte* buffer, [NativeTypeName("unsigned long")] uint buflen, [NativeTypeName("unsigned long *")] uint* out_buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObjMark_SetIntParam([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("FPDF_PAGEOBJECTMARK")] fpdf_pageobjectmark_t__* mark, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key, int value);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObjMark_SetFloatParam([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("FPDF_PAGEOBJECTMARK")] fpdf_pageobjectmark_t__* mark, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key, float value);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObjMark_SetStringParam([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("FPDF_PAGEOBJECTMARK")] fpdf_pageobjectmark_t__* mark, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key, [NativeTypeName("FPDF_BYTESTRING")] sbyte* value);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObjMark_SetBlobParam([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("FPDF_PAGEOBJECTMARK")] fpdf_pageobjectmark_t__* mark, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key, [NativeTypeName("const unsigned char *")] byte* value, [NativeTypeName("unsigned long")] uint value_len);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObjMark_RemoveParam([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("FPDF_PAGEOBJECTMARK")] fpdf_pageobjectmark_t__* mark, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFImageObj_LoadJpegFile([NativeTypeName("FPDF_PAGE *")] fpdf_page_t__** pages, int count, [NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* image_object, FPDF_FILEACCESS* file_access);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFImageObj_LoadJpegFileInline([NativeTypeName("FPDF_PAGE *")] fpdf_page_t__** pages, int count, [NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* image_object, FPDF_FILEACCESS* file_access);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFImageObj_SetMatrix([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* image_object, double a, double b, double c, double d, double e, double f);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFImageObj_SetBitmap([NativeTypeName("FPDF_PAGE *")] fpdf_page_t__** pages, int count, [NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* image_object, [NativeTypeName("FPDF_BITMAP")] fpdf_bitmap_t__* bitmap);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BITMAP")]
    internal static extern fpdf_bitmap_t__* FPDFImageObj_GetBitmap([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* image_object);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BITMAP")]
    internal static extern fpdf_bitmap_t__* FPDFImageObj_GetRenderedBitmap([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* image_object);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFImageObj_GetImageDataDecoded([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* image_object, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFImageObj_GetImageDataRaw([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* image_object, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFImageObj_GetImageFilterCount([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* image_object);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFImageObj_GetImageFilter([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* image_object, int index, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFImageObj_GetImageMetadata([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* image_object, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, FPDF_IMAGEOBJ_METADATA* metadata);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFImageObj_GetImagePixelSize([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* image_object, [NativeTypeName("unsigned int *")] uint* width, [NativeTypeName("unsigned int *")] uint* height);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFImageObj_GetIccProfileDataDecoded([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* image_object, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("uint8_t *")] byte* buffer, [NativeTypeName("size_t")] nuint buflen, [NativeTypeName("size_t *")] nuint* out_buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_PAGEOBJECT")]
    internal static extern fpdf_pageobject_t__* FPDFPageObj_CreateNewPath(float x, float y);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_PAGEOBJECT")]
    internal static extern fpdf_pageobject_t__* FPDFPageObj_CreateNewRect(float x, float y, float w, float h);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_GetBounds([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, float* left, float* bottom, float* right, float* top);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_GetRotatedBounds([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("FS_QUADPOINTSF *")] _FS_QUADPOINTSF* quad_points);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFPageObj_SetBlendMode([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("FPDF_BYTESTRING")] sbyte* blend_mode);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_SetStrokeColor([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("unsigned int")] uint R, [NativeTypeName("unsigned int")] uint G, [NativeTypeName("unsigned int")] uint B, [NativeTypeName("unsigned int")] uint A);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_GetStrokeColor([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("unsigned int *")] uint* R, [NativeTypeName("unsigned int *")] uint* G, [NativeTypeName("unsigned int *")] uint* B, [NativeTypeName("unsigned int *")] uint* A);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_SetStrokeWidth([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, float width);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_GetStrokeWidth([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, float* width);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFPageObj_GetLineJoin([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_SetLineJoin([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, int line_join);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFPageObj_GetLineCap([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_SetLineCap([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, int line_cap);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_SetFillColor([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("unsigned int")] uint R, [NativeTypeName("unsigned int")] uint G, [NativeTypeName("unsigned int")] uint B, [NativeTypeName("unsigned int")] uint A);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_GetFillColor([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("unsigned int *")] uint* R, [NativeTypeName("unsigned int *")] uint* G, [NativeTypeName("unsigned int *")] uint* B, [NativeTypeName("unsigned int *")] uint* A);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_GetDashPhase([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, float* phase);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_SetDashPhase([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, float phase);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFPageObj_GetDashCount([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_GetDashArray([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, float* dash_array, [NativeTypeName("size_t")] nuint dash_count);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPageObj_SetDashArray([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, [NativeTypeName("const float *")] float* dash_array, [NativeTypeName("size_t")] nuint dash_count, float phase);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFPath_CountSegments([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* path);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_PATHSEGMENT")]
    internal static extern fpdf_pathsegment_t* FPDFPath_GetPathSegment([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* path, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPathSegment_GetPoint([NativeTypeName("FPDF_PATHSEGMENT")] fpdf_pathsegment_t* segment, float* x, float* y);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFPathSegment_GetType([NativeTypeName("FPDF_PATHSEGMENT")] fpdf_pathsegment_t* segment);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPathSegment_GetClose([NativeTypeName("FPDF_PATHSEGMENT")] fpdf_pathsegment_t* segment);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPath_MoveTo([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* path, float x, float y);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPath_LineTo([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* path, float x, float y);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPath_BezierTo([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* path, float x1, float y1, float x2, float y2, float x3, float y3);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPath_Close([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* path);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPath_SetDrawMode([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* path, int fillmode, [NativeTypeName("FPDF_BOOL")] int stroke);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPath_GetDrawMode([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* path, int* fillmode, [NativeTypeName("FPDF_BOOL *")] int* stroke);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_PAGEOBJECT")]
    internal static extern fpdf_pageobject_t__* FPDFPageObj_NewTextObj([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_BYTESTRING")] sbyte* font, float font_size);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFText_SetText([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* text_object, [NativeTypeName("FPDF_WIDESTRING")] ushort* text);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFText_SetCharcodes([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* text_object, [NativeTypeName("const uint32_t *")] uint* charcodes, [NativeTypeName("size_t")] nuint count);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_FONT")]
    internal static extern fpdf_font_t__* FPDFText_LoadFont([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("const uint8_t *")] byte* data, [NativeTypeName("uint32_t")] uint size, int font_type, [NativeTypeName("FPDF_BOOL")] int cid);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_FONT")]
    internal static extern fpdf_font_t__* FPDFText_LoadStandardFont([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_BYTESTRING")] sbyte* font);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_FONT")]
    internal static extern fpdf_font_t__* FPDFText_LoadCidType2Font([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("const uint8_t *")] byte* font_data, [NativeTypeName("uint32_t")] uint font_data_size, [NativeTypeName("FPDF_BYTESTRING")] sbyte* to_unicode_cmap, [NativeTypeName("const uint8_t *")] byte* cid_to_gid_map_data, [NativeTypeName("uint32_t")] uint cid_to_gid_map_data_size);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFTextObj_GetFontSize([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* text, float* size);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFFont_Close([NativeTypeName("FPDF_FONT")] fpdf_font_t__* font);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_PAGEOBJECT")]
    internal static extern fpdf_pageobject_t__* FPDFPageObj_CreateTextObj([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_FONT")] fpdf_font_t__* font, float font_size);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern FPDF_TEXT_RENDERMODE FPDFTextObj_GetTextRenderMode([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* text);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFTextObj_SetTextRenderMode([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* text, FPDF_TEXT_RENDERMODE render_mode);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFTextObj_GetText([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* text_object, [NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, [NativeTypeName("FPDF_WCHAR *")] ushort* buffer, [NativeTypeName("unsigned long")] uint length);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BITMAP")]
    internal static extern fpdf_bitmap_t__* FPDFTextObj_GetRenderedBitmap([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* text_object, float scale);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_FONT")]
    internal static extern fpdf_font_t__* FPDFTextObj_GetFont([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* text);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    internal static extern nuint FPDFFont_GetBaseFontName([NativeTypeName("FPDF_FONT")] fpdf_font_t__* font, [NativeTypeName("char *")] sbyte* buffer, [NativeTypeName("size_t")] nuint length);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    internal static extern nuint FPDFFont_GetFamilyName([NativeTypeName("FPDF_FONT")] fpdf_font_t__* font, [NativeTypeName("char *")] sbyte* buffer, [NativeTypeName("size_t")] nuint length);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFFont_GetFontData([NativeTypeName("FPDF_FONT")] fpdf_font_t__* font, [NativeTypeName("uint8_t *")] byte* buffer, [NativeTypeName("size_t")] nuint buflen, [NativeTypeName("size_t *")] nuint* out_buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFFont_GetIsEmbedded([NativeTypeName("FPDF_FONT")] fpdf_font_t__* font);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFFont_GetFlags([NativeTypeName("FPDF_FONT")] fpdf_font_t__* font);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFFont_GetWeight([NativeTypeName("FPDF_FONT")] fpdf_font_t__* font);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFFont_GetItalicAngle([NativeTypeName("FPDF_FONT")] fpdf_font_t__* font, int* angle);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFFont_GetAscent([NativeTypeName("FPDF_FONT")] fpdf_font_t__* font, float font_size, float* ascent);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFFont_GetDescent([NativeTypeName("FPDF_FONT")] fpdf_font_t__* font, float font_size, float* descent);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFFont_GetGlyphWidth([NativeTypeName("FPDF_FONT")] fpdf_font_t__* font, [NativeTypeName("uint32_t")] uint glyph, float font_size, float* width);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_GLYPHPATH")]
    internal static extern fpdf_glyphpath_t__* FPDFFont_GetGlyphPath([NativeTypeName("FPDF_FONT")] fpdf_font_t__* font, [NativeTypeName("uint32_t")] uint glyph, float font_size);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFGlyphPath_CountGlyphSegments([NativeTypeName("FPDF_GLYPHPATH")] fpdf_glyphpath_t__* glyphpath);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_PATHSEGMENT")]
    internal static extern fpdf_pathsegment_t* FPDFGlyphPath_GetGlyphPathSegment([NativeTypeName("FPDF_GLYPHPATH")] fpdf_glyphpath_t__* glyphpath, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFFormObj_CountObjects([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* form_object);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_PAGEOBJECT")]
    internal static extern fpdf_pageobject_t__* FPDFFormObj_GetObject([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* form_object, [NativeTypeName("unsigned long")] uint index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFFormObj_RemoveObject([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* form_object, [NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FSDK_SetUnSpObjProcessHandler([NativeTypeName("UNSUPPORT_INFO *")] _UNSUPPORT_INFO* unsp_info);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FSDK_SetTimeFunction([NativeTypeName("time_t (*)()")] delegate* unmanaged[Cdecl]<long> func);

    //[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    //internal static extern void FSDK_SetLocaltimeFunction([NativeTypeName("struct tm *(*)(const time_t *)")] delegate* unmanaged[Cdecl]<long*, tm*> func);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFDoc_GetPageMode([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFPage_Flatten([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int nFlag);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_FORMHANDLE")]
    internal static extern fpdf_form_handle_t__* FPDFDOC_InitFormFillEnvironment([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_FORMFILLINFO *")] _FPDF_FORMFILLINFO* formInfo);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFDOC_ExitFormFillEnvironment([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FORM_OnAfterLoadPage([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FORM_OnBeforeClosePage([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FORM_DoDocumentJSAction([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FORM_DoDocumentOpenAction([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FORM_DoDocumentAAction([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, int aaType);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FORM_DoPageAAction([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, int aaType);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_OnMouseMove([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int modifier, double page_x, double page_y);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_OnMouseWheel([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int modifier, [NativeTypeName("const FS_POINTF *")] FS_POINTF_* page_coord, int delta_x, int delta_y);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_OnFocus([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int modifier, double page_x, double page_y);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_OnLButtonDown([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int modifier, double page_x, double page_y);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_OnRButtonDown([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int modifier, double page_x, double page_y);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_OnLButtonUp([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int modifier, double page_x, double page_y);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_OnRButtonUp([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int modifier, double page_x, double page_y);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_OnLButtonDoubleClick([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int modifier, double page_x, double page_y);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_OnKeyDown([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int nKeyCode, int modifier);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_OnKeyUp([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int nKeyCode, int modifier);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_OnChar([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int nChar, int modifier);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FORM_GetFocusedText([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FORM_GetSelectedText([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FORM_ReplaceAndKeepSelection([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("FPDF_WIDESTRING")] ushort* wsText);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FORM_ReplaceSelection([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("FPDF_WIDESTRING")] ushort* wsText);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_SelectAllText([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_CanUndo([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_CanRedo([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_Undo([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_Redo([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_ForceToKillFocus([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_GetFocusedAnnot([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* handle, int* page_index, [NativeTypeName("FPDF_ANNOTATION *")] fpdf_annotation_t__** annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_SetFocusedAnnot([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* handle, [NativeTypeName("FPDF_ANNOTATION")] fpdf_annotation_t__* annot);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFPage_HasFormFieldAtPoint([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, double page_x, double page_y);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFPage_FormFieldZOrderAtPoint([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, double page_x, double page_y);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDF_SetFormFieldHighlightColor([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, int fieldType, [NativeTypeName("unsigned long")] uint color);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDF_SetFormFieldHighlightAlpha([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("unsigned char")] byte alpha);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDF_RemoveFormFieldHighlight([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDF_FFLDraw([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_BITMAP")] fpdf_bitmap_t__* bitmap, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int start_x, int start_y, int size_x, int size_y, int rotate, int flags);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_GetFormType([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_SetIndexSelected([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int index, [NativeTypeName("FPDF_BOOL")] int selected);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FORM_IsIndexSelected([NativeTypeName("FPDF_FORMHANDLE")] fpdf_form_handle_t__* hHandle, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_LoadXFA([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFDoc_GetJavaScriptActionCount([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_JAVASCRIPT_ACTION")]
    internal static extern fpdf_javascript_action_t* FPDFDoc_GetJavaScriptAction([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFDoc_CloseJavaScriptAction([NativeTypeName("FPDF_JAVASCRIPT_ACTION")] fpdf_javascript_action_t* javascript);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFJavaScriptAction_GetName([NativeTypeName("FPDF_JAVASCRIPT_ACTION")] fpdf_javascript_action_t* javascript, [NativeTypeName("FPDF_WCHAR *")] ushort* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFJavaScriptAction_GetScript([NativeTypeName("FPDF_JAVASCRIPT_ACTION")] fpdf_javascript_action_t* javascript, [NativeTypeName("FPDF_WCHAR *")] ushort* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_ImportPagesByIndex([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* dest_doc, [NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* src_doc, [NativeTypeName("const int *")] int* page_indices, [NativeTypeName("unsigned long")] uint length, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_ImportPages([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* dest_doc, [NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* src_doc, [NativeTypeName("FPDF_BYTESTRING")] sbyte* pagerange, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_DOCUMENT")]
    internal static extern fpdf_document_t__* FPDF_ImportNPagesToOne([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* src_doc, float output_width, float output_height, [NativeTypeName("size_t")] nuint num_pages_on_x_axis, [NativeTypeName("size_t")] nuint num_pages_on_y_axis);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_XOBJECT")]
    internal static extern fpdf_xobject_t__* FPDF_NewXObjectFromPage([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* dest_doc, [NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* src_doc, int src_page_index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDF_CloseXObject([NativeTypeName("FPDF_XOBJECT")] fpdf_xobject_t__* xobject);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_PAGEOBJECT")]
    internal static extern fpdf_pageobject_t__* FPDF_NewFormObjectFromXObject([NativeTypeName("FPDF_XOBJECT")] fpdf_xobject_t__* xobject);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_CopyViewerPreferences([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* dest_doc, [NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* src_doc);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_RenderPageBitmapWithColorScheme_Start([NativeTypeName("FPDF_BITMAP")] fpdf_bitmap_t__* bitmap, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int start_x, int start_y, int size_x, int size_y, int rotate, int flags, [NativeTypeName("const FPDF_COLORSCHEME *")] FPDF_COLORSCHEME_* color_scheme, [NativeTypeName("IFSDK_PAUSE *")] _IFSDK_PAUSE* pause);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_RenderPageBitmap_Start([NativeTypeName("FPDF_BITMAP")] fpdf_bitmap_t__* bitmap, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int start_x, int start_y, int size_x, int size_y, int rotate, int flags, [NativeTypeName("IFSDK_PAUSE *")] _IFSDK_PAUSE* pause);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_RenderPage_Continue([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("IFSDK_PAUSE *")] _IFSDK_PAUSE* pause);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDF_RenderPage_Close([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_SaveAsCopy([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_FILEWRITE *")] FPDF_FILEWRITE_* pFileWrite, [NativeTypeName("FPDF_DWORD")] uint flags);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_SaveWithVersion([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_FILEWRITE *")] FPDF_FILEWRITE_* pFileWrite, [NativeTypeName("FPDF_DWORD")] uint flags, int fileVersion);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFText_GetCharIndexFromTextIndex([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int nTextIndex);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFText_GetTextIndexFromCharIndex([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int nCharIndex);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_GetSignatureCount([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_SIGNATURE")]
    internal static extern fpdf_signature_t__* FPDF_GetSignatureObject([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFSignatureObj_GetContents([NativeTypeName("FPDF_SIGNATURE")] fpdf_signature_t__* signature, void* buffer, [NativeTypeName("unsigned long")] uint length);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFSignatureObj_GetByteRange([NativeTypeName("FPDF_SIGNATURE")] fpdf_signature_t__* signature, int* buffer, [NativeTypeName("unsigned long")] uint length);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFSignatureObj_GetSubFilter([NativeTypeName("FPDF_SIGNATURE")] fpdf_signature_t__* signature, [NativeTypeName("char *")] sbyte* buffer, [NativeTypeName("unsigned long")] uint length);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFSignatureObj_GetReason([NativeTypeName("FPDF_SIGNATURE")] fpdf_signature_t__* signature, void* buffer, [NativeTypeName("unsigned long")] uint length);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFSignatureObj_GetTime([NativeTypeName("FPDF_SIGNATURE")] fpdf_signature_t__* signature, [NativeTypeName("char *")] sbyte* buffer, [NativeTypeName("unsigned long")] uint length);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    internal static extern uint FPDFSignatureObj_GetDocMDPPermission([NativeTypeName("FPDF_SIGNATURE")] fpdf_signature_t__* signature);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_STRUCTTREE")]
    internal static extern fpdf_structtree_t__* FPDF_StructTree_GetForPage([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDF_StructTree_Close([NativeTypeName("FPDF_STRUCTTREE")] fpdf_structtree_t__* struct_tree);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_StructTree_CountChildren([NativeTypeName("FPDF_STRUCTTREE")] fpdf_structtree_t__* struct_tree);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_STRUCTELEMENT")]
    internal static extern fpdf_structelement_t__* FPDF_StructTree_GetChildAtIndex([NativeTypeName("FPDF_STRUCTTREE")] fpdf_structtree_t__* struct_tree, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDF_StructElement_GetAltText([NativeTypeName("FPDF_STRUCTELEMENT")] fpdf_structelement_t__* struct_element, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDF_StructElement_GetActualText([NativeTypeName("FPDF_STRUCTELEMENT")] fpdf_structelement_t__* struct_element, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDF_StructElement_GetID([NativeTypeName("FPDF_STRUCTELEMENT")] fpdf_structelement_t__* struct_element, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDF_StructElement_GetLang([NativeTypeName("FPDF_STRUCTELEMENT")] fpdf_structelement_t__* struct_element, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDF_StructElement_GetStringAttribute([NativeTypeName("FPDF_STRUCTELEMENT")] fpdf_structelement_t__* struct_element, [NativeTypeName("FPDF_BYTESTRING")] sbyte* attr_name, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_StructElement_GetMarkedContentID([NativeTypeName("FPDF_STRUCTELEMENT")] fpdf_structelement_t__* struct_element);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDF_StructElement_GetType([NativeTypeName("FPDF_STRUCTELEMENT")] fpdf_structelement_t__* struct_element, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDF_StructElement_GetObjType([NativeTypeName("FPDF_STRUCTELEMENT")] fpdf_structelement_t__* struct_element, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDF_StructElement_GetTitle([NativeTypeName("FPDF_STRUCTELEMENT")] fpdf_structelement_t__* struct_element, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_StructElement_CountChildren([NativeTypeName("FPDF_STRUCTELEMENT")] fpdf_structelement_t__* struct_element);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_STRUCTELEMENT")]
    internal static extern fpdf_structelement_t__* FPDF_StructElement_GetChildAtIndex([NativeTypeName("FPDF_STRUCTELEMENT")] fpdf_structelement_t__* struct_element, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_StructElement_GetChildMarkedContentID([NativeTypeName("FPDF_STRUCTELEMENT")] fpdf_structelement_t__* struct_element, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_STRUCTELEMENT")]
    internal static extern fpdf_structelement_t__* FPDF_StructElement_GetParent([NativeTypeName("FPDF_STRUCTELEMENT")] fpdf_structelement_t__* struct_element);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_StructElement_GetAttributeCount([NativeTypeName("FPDF_STRUCTELEMENT")] fpdf_structelement_t__* struct_element);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_STRUCTELEMENT_ATTR")]
    internal static extern fpdf_structelement_attr_t__* FPDF_StructElement_GetAttributeAtIndex([NativeTypeName("FPDF_STRUCTELEMENT")] fpdf_structelement_t__* struct_element, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_StructElement_Attr_GetCount([NativeTypeName("FPDF_STRUCTELEMENT_ATTR")] fpdf_structelement_attr_t__* struct_attribute);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_StructElement_Attr_GetName([NativeTypeName("FPDF_STRUCTELEMENT_ATTR")] fpdf_structelement_attr_t__* struct_attribute, int index, void* buffer, [NativeTypeName("unsigned long")] uint buflen, [NativeTypeName("unsigned long *")] uint* out_buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_STRUCTELEMENT_ATTR_VALUE")]
    internal static extern fpdf_structelement_attr_value_t__* FPDF_StructElement_Attr_GetValue([NativeTypeName("FPDF_STRUCTELEMENT_ATTR")] fpdf_structelement_attr_t__* struct_attribute, [NativeTypeName("FPDF_BYTESTRING")] sbyte* name);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_OBJECT_TYPE")]
    internal static extern int FPDF_StructElement_Attr_GetType([NativeTypeName("FPDF_STRUCTELEMENT_ATTR_VALUE")] fpdf_structelement_attr_value_t__* value);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_StructElement_Attr_GetBooleanValue([NativeTypeName("FPDF_STRUCTELEMENT_ATTR_VALUE")] fpdf_structelement_attr_value_t__* value, [NativeTypeName("FPDF_BOOL *")] int* out_value);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_StructElement_Attr_GetNumberValue([NativeTypeName("FPDF_STRUCTELEMENT_ATTR_VALUE")] fpdf_structelement_attr_value_t__* value, float* out_value);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_StructElement_Attr_GetStringValue([NativeTypeName("FPDF_STRUCTELEMENT_ATTR_VALUE")] fpdf_structelement_attr_value_t__* value, void* buffer, [NativeTypeName("unsigned long")] uint buflen, [NativeTypeName("unsigned long *")] uint* out_buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_StructElement_Attr_GetBlobValue([NativeTypeName("FPDF_STRUCTELEMENT_ATTR_VALUE")] fpdf_structelement_attr_value_t__* value, void* buffer, [NativeTypeName("unsigned long")] uint buflen, [NativeTypeName("unsigned long *")] uint* out_buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_StructElement_Attr_CountChildren([NativeTypeName("FPDF_STRUCTELEMENT_ATTR_VALUE")] fpdf_structelement_attr_value_t__* value);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_STRUCTELEMENT_ATTR_VALUE")]
    internal static extern fpdf_structelement_attr_value_t__* FPDF_StructElement_Attr_GetChildAtIndex([NativeTypeName("FPDF_STRUCTELEMENT_ATTR_VALUE")] fpdf_structelement_attr_value_t__* value, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_StructElement_GetMarkedContentIdCount([NativeTypeName("FPDF_STRUCTELEMENT")] fpdf_structelement_t__* struct_element);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_StructElement_GetMarkedContentIdAtIndex([NativeTypeName("FPDF_STRUCTELEMENT")] fpdf_structelement_t__* struct_element, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const FPDF_CharsetFontMap *")]
    internal static extern FPDF_CharsetFontMap_* FPDF_GetDefaultTTFMap();

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    internal static extern nuint FPDF_GetDefaultTTFMapCount();

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const FPDF_CharsetFontMap *")]
    internal static extern FPDF_CharsetFontMap_* FPDF_GetDefaultTTFMapEntry([NativeTypeName("size_t")] nuint index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDF_AddInstalledFont(void* mapper, [NativeTypeName("const char *")] sbyte* face, int charset);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDF_SetSystemFontInfo([NativeTypeName("FPDF_SYSFONTINFO *")] _FPDF_SYSFONTINFO* font_info);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_SYSFONTINFO *")]
    internal static extern _FPDF_SYSFONTINFO* FPDF_GetDefaultSystemFontInfo();

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDF_FreeDefaultSystemFontInfo([NativeTypeName("FPDF_SYSFONTINFO *")] _FPDF_SYSFONTINFO* font_info);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_TEXTPAGE")]
    internal static extern fpdf_textpage_t__* FPDFText_LoadPage([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFText_ClosePage([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFText_CountChars([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    internal static extern uint FPDFText_GetUnicode([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_PAGEOBJECT")]
    internal static extern fpdf_pageobject_t__* FPDFText_GetTextObject([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFText_IsGenerated([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFText_IsHyphen([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFText_HasUnicodeMapError([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern double FPDFText_GetFontSize([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFText_GetFontInfo([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int index, void* buffer, [NativeTypeName("unsigned long")] uint buflen, int* flags);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFText_GetFontWeight([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFText_GetFillColor([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int index, [NativeTypeName("unsigned int *")] uint* R, [NativeTypeName("unsigned int *")] uint* G, [NativeTypeName("unsigned int *")] uint* B, [NativeTypeName("unsigned int *")] uint* A);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFText_GetStrokeColor([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int index, [NativeTypeName("unsigned int *")] uint* R, [NativeTypeName("unsigned int *")] uint* G, [NativeTypeName("unsigned int *")] uint* B, [NativeTypeName("unsigned int *")] uint* A);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern float FPDFText_GetCharAngle([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFText_GetCharBox([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int index, double* left, double* right, double* bottom, double* top);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFText_GetLooseCharBox([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int index, [NativeTypeName("FS_RECTF *")] _FS_RECTF_* rect);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFText_GetMatrix([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int index, [NativeTypeName("FS_MATRIX *")] _FS_MATRIX_* matrix);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFText_GetCharOrigin([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int index, double* x, double* y);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFText_GetCharIndexAtPos([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, double x, double y, double xTolerance, double yTolerance);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFText_GetText([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int start_index, int count, [NativeTypeName("unsigned short *")] ushort* result);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFText_CountRects([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int start_index, int count);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFText_GetRect([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, int rect_index, double* left, double* top, double* right, double* bottom);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFText_GetBoundedText([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, double left, double top, double right, double bottom, [NativeTypeName("unsigned short *")] ushort* buffer, int buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_SCHHANDLE")]
    internal static extern fpdf_schhandle_t__* FPDFText_FindStart([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page, [NativeTypeName("FPDF_WIDESTRING")] ushort* findwhat, [NativeTypeName("unsigned long")] uint flags, int start_index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFText_FindNext([NativeTypeName("FPDF_SCHHANDLE")] fpdf_schhandle_t__* handle);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFText_FindPrev([NativeTypeName("FPDF_SCHHANDLE")] fpdf_schhandle_t__* handle);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFText_GetSchResultIndex([NativeTypeName("FPDF_SCHHANDLE")] fpdf_schhandle_t__* handle);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFText_GetSchCount([NativeTypeName("FPDF_SCHHANDLE")] fpdf_schhandle_t__* handle);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFText_FindClose([NativeTypeName("FPDF_SCHHANDLE")] fpdf_schhandle_t__* handle);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_PAGELINK")]
    internal static extern fpdf_pagelink_t__* FPDFLink_LoadWebLinks([NativeTypeName("FPDF_TEXTPAGE")] fpdf_textpage_t__* text_page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFLink_CountWebLinks([NativeTypeName("FPDF_PAGELINK")] fpdf_pagelink_t__* link_page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFLink_GetURL([NativeTypeName("FPDF_PAGELINK")] fpdf_pagelink_t__* link_page, int link_index, [NativeTypeName("unsigned short *")] ushort* buffer, int buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFLink_CountRects([NativeTypeName("FPDF_PAGELINK")] fpdf_pagelink_t__* link_page, int link_index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFLink_GetRect([NativeTypeName("FPDF_PAGELINK")] fpdf_pagelink_t__* link_page, int link_index, int rect_index, double* left, double* top, double* right, double* bottom);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFLink_GetTextRange([NativeTypeName("FPDF_PAGELINK")] fpdf_pagelink_t__* link_page, int link_index, int* start_char_index, int* char_count);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFLink_CloseWebLinks([NativeTypeName("FPDF_PAGELINK")] fpdf_pagelink_t__* link_page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFPage_GetDecodedThumbnailData([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDFPage_GetRawThumbnailData([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BITMAP")]
    internal static extern fpdf_bitmap_t__* FPDFPage_GetThumbnailAsBitmap([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFPage_SetMediaBox([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, float left, float bottom, float right, float top);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFPage_SetCropBox([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, float left, float bottom, float right, float top);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFPage_SetBleedBox([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, float left, float bottom, float right, float top);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFPage_SetTrimBox([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, float left, float bottom, float right, float top);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFPage_SetArtBox([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, float left, float bottom, float right, float top);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPage_GetMediaBox([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, float* left, float* bottom, float* right, float* top);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPage_GetCropBox([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, float* left, float* bottom, float* right, float* top);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPage_GetBleedBox([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, float* left, float* bottom, float* right, float* top);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPage_GetTrimBox([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, float* left, float* bottom, float* right, float* top);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPage_GetArtBox([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, float* left, float* bottom, float* right, float* top);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFPage_TransFormWithClip([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("const FS_MATRIX *")] _FS_MATRIX_* matrix, [NativeTypeName("const FS_RECTF *")] _FS_RECTF_* clipRect);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFPageObj_TransformClipPath([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object, double a, double b, double c, double d, double e, double f);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_CLIPPATH")]
    internal static extern fpdf_clippath_t__* FPDFPageObj_GetClipPath([NativeTypeName("FPDF_PAGEOBJECT")] fpdf_pageobject_t__* page_object);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFClipPath_CountPaths([NativeTypeName("FPDF_CLIPPATH")] fpdf_clippath_t__* clip_path);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFClipPath_CountPathSegments([NativeTypeName("FPDF_CLIPPATH")] fpdf_clippath_t__* clip_path, int path_index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_PATHSEGMENT")]
    internal static extern fpdf_pathsegment_t* FPDFClipPath_GetPathSegment([NativeTypeName("FPDF_CLIPPATH")] fpdf_clippath_t__* clip_path, int path_index, int segment_index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_CLIPPATH")]
    internal static extern fpdf_clippath_t__* FPDF_CreateClipPath(float left, float bottom, float right, float top);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDF_DestroyClipPath([NativeTypeName("FPDF_CLIPPATH")] fpdf_clippath_t__* clipPath);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFPage_InsertClipPath([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("FPDF_CLIPPATH")] fpdf_clippath_t__* clipPath);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDF_InitLibraryWithConfig([NativeTypeName("const FPDF_LIBRARY_CONFIG *")] FPDF_LIBRARY_CONFIG_* config);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDF_InitLibrary();

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDF_DestroyLibrary();

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDF_SetSandBoxPolicy([NativeTypeName("FPDF_DWORD")] uint policy, [NativeTypeName("FPDF_BOOL")] int enable);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_SetPrintMode(int mode);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_DOCUMENT")]
    internal static extern fpdf_document_t__* FPDF_LoadDocument([NativeTypeName("FPDF_STRING")] sbyte* file_path, [NativeTypeName("FPDF_BYTESTRING")] sbyte* password);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_DOCUMENT")]
    internal static extern fpdf_document_t__* FPDF_LoadMemDocument([NativeTypeName("const void *")] void* data_buf, int size, [NativeTypeName("FPDF_BYTESTRING")] sbyte* password);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_DOCUMENT")]
    internal static extern fpdf_document_t__* FPDF_LoadMemDocument64([NativeTypeName("const void *")] void* data_buf, [NativeTypeName("size_t")] nuint size, [NativeTypeName("FPDF_BYTESTRING")] sbyte* password);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_DOCUMENT")]
    internal static extern fpdf_document_t__* FPDF_LoadCustomDocument(FPDF_FILEACCESS* pFileAccess, [NativeTypeName("FPDF_BYTESTRING")] sbyte* password);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_GetFileVersion([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* doc, int* fileVersion);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDF_GetLastError();

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_DocumentHasValidCrossReferenceTable([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDF_GetTrailerEnds([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("unsigned int *")] uint* buffer, [NativeTypeName("unsigned long")] uint length);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDF_GetDocPermissions([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDF_GetDocUserPermissions([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_GetSecurityHandlerRevision([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_GetPageCount([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_PAGE")]
    internal static extern fpdf_page_t__* FPDF_LoadPage([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, int page_index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern float FPDF_GetPageWidthF([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern double FPDF_GetPageWidth([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern float FPDF_GetPageHeightF([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern double FPDF_GetPageHeight([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_GetPageBoundingBox([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("FS_RECTF *")] _FS_RECTF_* rect);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_GetPageSizeByIndexF([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, int page_index, [NativeTypeName("FS_SIZEF *")] FS_SIZEF_* size);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_GetPageSizeByIndex([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, int page_index, double* width, double* height);

    //[DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    //[return: NativeTypeName("FPDF_BOOL")]
    //internal static extern int FPDF_RenderPage([NativeTypeName("HDC")] HDC__* dc, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int start_x, int start_y, int size_x, int size_y, int rotate, int flags);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDF_RenderPageBitmap([NativeTypeName("FPDF_BITMAP")] fpdf_bitmap_t__* bitmap, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int start_x, int start_y, int size_x, int size_y, int rotate, int flags);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDF_RenderPageBitmapWithMatrix([NativeTypeName("FPDF_BITMAP")] fpdf_bitmap_t__* bitmap, [NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, [NativeTypeName("const FS_MATRIX *")] _FS_MATRIX_* matrix, [NativeTypeName("const FS_RECTF *")] _FS_RECTF_* clipping, int flags);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDF_ClosePage([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDF_CloseDocument([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_DeviceToPage([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int start_x, int start_y, int size_x, int size_y, int rotate, int device_x, int device_y, double* page_x, double* page_y);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_PageToDevice([NativeTypeName("FPDF_PAGE")] fpdf_page_t__* page, int start_x, int start_y, int size_x, int size_y, int rotate, double page_x, double page_y, int* device_x, int* device_y);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BITMAP")]
    internal static extern fpdf_bitmap_t__* FPDFBitmap_Create(int width, int height, int alpha);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BITMAP")]
    internal static extern fpdf_bitmap_t__* FPDFBitmap_CreateEx(int width, int height, int format, void* first_scan, int stride);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFBitmap_GetFormat([NativeTypeName("FPDF_BITMAP")] fpdf_bitmap_t__* bitmap);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDFBitmap_FillRect([NativeTypeName("FPDF_BITMAP")] fpdf_bitmap_t__* bitmap, int left, int top, int width, int height, [NativeTypeName("FPDF_DWORD")] uint color);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void* FPDFBitmap_GetBuffer([NativeTypeName("FPDF_BITMAP")] fpdf_bitmap_t__* bitmap);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFBitmap_GetWidth([NativeTypeName("FPDF_BITMAP")] fpdf_bitmap_t__* bitmap);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFBitmap_GetHeight([NativeTypeName("FPDF_BITMAP")] fpdf_bitmap_t__* bitmap);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDFBitmap_GetStride([NativeTypeName("FPDF_BITMAP")] fpdf_bitmap_t__* bitmap);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern void FPDFBitmap_Destroy([NativeTypeName("FPDF_BITMAP")] fpdf_bitmap_t__* bitmap);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_VIEWERREF_GetPrintScaling([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_VIEWERREF_GetNumCopies([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_PAGERANGE")]
    internal static extern fpdf_pagerange_t__* FPDF_VIEWERREF_GetPrintPageRange([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("size_t")]
    internal static extern nuint FPDF_VIEWERREF_GetPrintPageRangeCount([NativeTypeName("FPDF_PAGERANGE")] fpdf_pagerange_t__* pagerange);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_VIEWERREF_GetPrintPageRangeElement([NativeTypeName("FPDF_PAGERANGE")] fpdf_pagerange_t__* pagerange, [NativeTypeName("size_t")] nuint index);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_DUPLEXTYPE")]
    internal static extern _FPDF_DUPLEXTYPE_ FPDF_VIEWERREF_GetDuplex([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDF_VIEWERREF_GetName([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_BYTESTRING")] sbyte* key, [NativeTypeName("char *")] sbyte* buffer, [NativeTypeName("unsigned long")] uint length);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_DWORD")]
    internal static extern uint FPDF_CountNamedDests([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_DEST")]
    internal static extern fpdf_dest_t__* FPDF_GetNamedDestByName([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, [NativeTypeName("FPDF_BYTESTRING")] sbyte* name);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_DEST")]
    internal static extern fpdf_dest_t__* FPDF_GetNamedDest([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, int index, void* buffer, [NativeTypeName("long *")] int* buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    internal static extern int FPDF_GetXFAPacketCount([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned long")]
    internal static extern uint FPDF_GetXFAPacketName([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, int index, void* buffer, [NativeTypeName("unsigned long")] uint buflen);

    [DllImport(DLL_NAME, CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("FPDF_BOOL")]
    internal static extern int FPDF_GetXFAPacketContent([NativeTypeName("FPDF_DOCUMENT")] fpdf_document_t__* document, int index, void* buffer, [NativeTypeName("unsigned long")] uint buflen, [NativeTypeName("unsigned long *")] uint* out_buflen);
}