using System;
using System.Runtime.InteropServices;
using UnityEditor;

[InitializeOnLoad]
public class FileModDialogCloser
{

  [DllImport ("user32.dll",EntryPoint = "FindWindow",SetLastError = true)]
  static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly,string lpWindowName);

  [DllImport ("user32.dll")]
  static extern bool ShowWindow(IntPtr hWnd,int nCmdShow);

  [DllImport ("user32.dll")]
  static extern void keybd_event(byte bVk,byte bScan,uint dwFlags,int dwExtraInfo);

  const string search = "File Modification Detected";
  static IntPtr hwnd;

  static void Check()
  {
    hwnd=FindWindowByCaption (IntPtr.Zero,search);
    if ((int)hwnd!=0)
    {
      ShowWindow (hwnd,5);
      keybd_event (0x09,0,0,0);
      keybd_event (0x0D,0,0,0);
    }
  }

  static FileModDialogCloser()
  {
    EditorApplication.update+=Check;
  }
}