using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Interop;
using System.Xml;
using System.Xml.Serialization;

namespace AW.Winforms.Helpers
{
  // RECT structure required by WINDOWPLACEMENT structure
  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
  public struct RECT
  {
    public int Left;
    public int Top;
    public int Right;
    public int Bottom;

    public RECT(int left, int top, int right, int bottom)
    {
      Left = left;
      Top = top;
      Right = right;
      Bottom = bottom;
    }
  }

  // POINT structure required by WINDOWPLACEMENT structure
  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
  public struct POINT
  {
    public int X;
    public int Y;

    public POINT(int x, int y)
    {
      X = x;
      Y = y;
    }
  }

  // WINDOWPLACEMENT stores the position, size, and state of a window
  [Serializable]
  [StructLayout(LayoutKind.Sequential)]
  public struct WINDOWPLACEMENT
  {
    public int length;
    public int flags;
    public int showCmd;
    public POINT minPosition;
    public POINT maxPosition;
    public RECT normalPosition;
  }

  /// <summary>
  ///   http://blogs.msdn.com/b/davidrickard/archive/2010/03/09/saving-window-size-and-location-in-wpf-and-winforms.aspx
  /// </summary>
  public static class WindowPlacement
  {
    private static readonly Encoding Encoding = new UTF8Encoding();
    private static readonly XmlSerializer Serializer = new XmlSerializer(typeof (WINDOWPLACEMENT));

    [DllImport("user32.dll")]
    private static extern bool SetWindowPlacement(IntPtr hWnd, [In] ref WINDOWPLACEMENT lpwndpl);

    [DllImport("user32.dll")]
    private static extern bool GetWindowPlacement(IntPtr hWnd, out WINDOWPLACEMENT lpwndpl);

    private const int SwShownormal = 1;
    private const int SwShowminimized = 2;

    public static void SetPlacement(IntPtr windowHandle, string placementXml)
    {
      if (string.IsNullOrEmpty(placementXml))
      {
        return;
      }

      WINDOWPLACEMENT placement;
      var xmlBytes = Encoding.GetBytes(placementXml);

      try
      {
        using (var memoryStream = new MemoryStream(xmlBytes))
        {
          placement = (WINDOWPLACEMENT) Serializer.Deserialize(memoryStream);
        }

        placement.length = Marshal.SizeOf(typeof (WINDOWPLACEMENT));
        placement.flags = 0;
        placement.showCmd = (placement.showCmd == SwShowminimized ? SwShownormal : placement.showCmd);
        SetWindowPlacement(windowHandle, ref placement);
      }
      catch (InvalidOperationException)
      {
        // Parsing placement XML failed. Fail silently.
      }
    }

    public static string GetPlacement(IntPtr windowHandle)
    {
      WINDOWPLACEMENT placement;
      GetWindowPlacement(windowHandle, out placement);

      using (var memoryStream = new MemoryStream())
      {
        using (var xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8))
        {
          Serializer.Serialize(xmlTextWriter, placement);
          var xmlBytes = memoryStream.ToArray();
          return Encoding.GetString(xmlBytes);
        }
      }
    }

    public static void SetPlacement(this Window window, string placementXml)
    {
      SetPlacement(new WindowInteropHelper(window).Handle, placementXml);
    }

    public static string GetPlacement(this Window window)
    {
      return GetPlacement(new WindowInteropHelper(window).Handle);
    }
  }
}