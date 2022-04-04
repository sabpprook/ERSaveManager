using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ERSaveManager
{
    public class Utils
    {
        private static readonly string defaultJpeg = "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";

        [DllImport("USER32.DLL")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        [DllImport("USER32.DLL")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("USER32.DLL")]
        private static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);

        [StructLayout(LayoutKind.Sequential)]
        private struct Rect
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        public static readonly string data_ersm = "data.ersm";
        public static readonly string source_ersm = "source.ersm";
        public static readonly string delta_ersm = "delta.ersm";
        public static readonly string new_ersm = "new.ersm";
        public static readonly string snapshot_jpg = "snapshot.jpg";

        public static string Sha1Sum(string fileName)
        {
            var sha1 = SHA1.Create();
            var hash = sha1.ComputeHash(File.ReadAllBytes(fileName));
            return BitConverter.ToString(hash).Replace("-", "").ToLower();
        }

        public static string CreateSnapshot(SaveItem save)
        {
            if (!File.Exists(source_ersm))
            {
                var src = Convert.FromBase64String(save.InitData);
                File.WriteAllBytes(source_ersm, GZip.decompress(src));
            }

            var fi = new FileInfo(source_ersm);

            var oldFile = fi.FullName;
            var newFile = save.FileName;

            Process.Start(new ProcessStartInfo
            {
                FileName = "xdelta3.exe",
                Arguments = $"-A -f -e -s \"{oldFile}\" \"{newFile}\" {delta_ersm}",
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = Environment.CurrentDirectory
            }).WaitForExit();

            if (File.Exists(delta_ersm))
            {
                var data = File.ReadAllBytes(delta_ersm);
                File.Delete(delta_ersm);
                return Convert.ToBase64String(data);
            }
            else
            {
                return String.Empty;
            }
        }

        public static bool RestoreSnapshot(SaveItem save, int index)
        {
            if (!File.Exists(source_ersm))
            {
                var src = Convert.FromBase64String(save.InitData);
                File.WriteAllBytes(source_ersm, GZip.decompress(src));
            }

            var fi = new FileInfo(source_ersm);

            var oldFile = fi.FullName;

            var record = save.Slots[index];
            File.WriteAllBytes(delta_ersm, Convert.FromBase64String(record.Data));

            Process.Start(new ProcessStartInfo
            {
                FileName = "xdelta3.exe",
                Arguments = $"-f -d -s \"{oldFile}\" {delta_ersm} {new_ersm}",
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = Environment.CurrentDirectory
            }).WaitForExit();

            File.Delete(delta_ersm);

            if (Sha1Sum(new_ersm) == record.Hash)
            {
                var bakFile = Environment.CurrentDirectory + "\\" + Path.GetFileName(save.FileName) + ".bak";

                var path = Path.GetDirectoryName(save.FileName);
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                if (File.Exists(save.FileName))
                    File.Replace(new_ersm, save.FileName, bakFile);
                else
                    File.Move(new_ersm, save.FileName);

                return true;
            }

            return false;
        }

        public static string ScreenShot()
        {
            var procList = Process.GetProcessesByName("eldenring");
            if (procList.Length != 1)
            {
                return defaultJpeg;
            }

            var proc = procList[0];

            ShowWindowAsync(proc.MainWindowHandle, 1);
            SetForegroundWindow(proc.MainWindowHandle);

            Thread.Sleep(1000);

            var rect = new Rect();
            GetWindowRect(proc.MainWindowHandle, ref rect);

            var width = rect.right - rect.left;
            var height = rect.bottom - rect.top;

            using (var source = new Bitmap(width, height, PixelFormat.Format32bppArgb))
            {
                using (var g1 = Graphics.FromImage(source))
                {
                    g1.CopyFromScreen(rect.left, rect.top, 0, 0, new Size(width, height), CopyPixelOperation.SourceCopy);
                    using (var convert = new Bitmap(160, 90))
                    {
                        using (var g2 = Graphics.FromImage(convert))
                        {
                            g2.DrawImage(source, 0, 0, convert.Width, convert.Height);
                        }
                        convert.Save(snapshot_jpg, ImageFormat.Jpeg);
                    }
                }
            }

            if (File.Exists(snapshot_jpg))
            {
                var data = File.ReadAllBytes(snapshot_jpg);
                File.Delete(snapshot_jpg);
                return Convert.ToBase64String(data);
            }
            else
            {
                return defaultJpeg;
            }
        }
    }
}
