using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace loginswitcher
{
    
    public partial class loginswitcher : ServiceBase
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool Wow64DisableWow64FsRedirection(ref IntPtr ptr);
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool Wow64RevertWow64FsRedirection(IntPtr ptr);
        

        public loginswitcher()
        {
            InitializeComponent();
           

            DirectoryInfo inputDir = new DirectoryInfo(@"C:\Users\Dave\Pictures\Logins");

            FileInfo[] files;
            inputDir.GetFiles();
            files = inputDir.GetFiles("*.jpg");

            int count = files.Count();
            while (true)
            {
                bool redirectionDisabled = false;
                var ptr = new IntPtr();
                redirectionDisabled = Wow64DisableWow64FsRedirection(ref ptr);

                Random random = new Random();
                int index = random.Next(count - 1);

                File.Copy(files[index].FullName, @"c:\windows\system32\oobe\info\backgrounds\backgroundDefault.jpg", true);

                System.Threading.Thread.Sleep(5000);

                Wow64RevertWow64FsRedirection(ptr);
            }

        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }
    }
}
