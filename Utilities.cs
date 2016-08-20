using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace BuildAndShootLauncher2
{

    class Utilities
    {
        public string game_path;
        public bool usingBnS;
        public void runSpades(string server, bool injectPubovl=false, string[] otherInjects=null)
        {
            var user_json = System.IO.File.ReadAllText("user.json");
            JObject user_info = JObject.Parse(user_json);

            game_path = getPath((bool)user_info["use_bns"], true, true);
            usingBnS = (bool)user_info["use_bns"];

            if (usingBnS == true)
            {
                Process.Start(game_path, server);
            }
            else
            {
                Process.Start(game_path, "-" + server);
            }
            

            //if (injectPubovl || otherInjects != null)
            //{
            //    var t = Task.Delay((int)user_info["inject_timer"]);
            //    t.Wait();
            //    Injector injector = new Injector();
            //
            //    String pubovlDLL = getPath(usingBnS) + @"\dll\pubovl.dll";
            //    String strProcessName = "client";
            //
            //    Int32 ProcID = injector.GetProcessId(strProcessName);
            //    if (ProcID >= 0)
            //    {
            //        IntPtr hProcess = (IntPtr)Injector.OpenProcess(0x1F0FFF, 1, ProcID);
            //        if (hProcess == null)
            //        {
            //            MessageBox.Show("OpenProcess() Failed!");
            //            return;
            //        }
            //        else
            //            injector.InjectDLL(hProcess, pubovlDLL);
            //    }
            //}
            

        }

        public bool ItemExists(dynamic[] list, dynamic toSearchFor) {
            //.Contains doesn't fucking work, and i dont know why the fuck it doesnt so heres a thing that pretty much does the same thing as .Contains
            foreach(var i in list)
            {
                if (i == toSearchFor)
                    return true;
            }
            return false;
        }

        public string getPath(bool useBNS, bool returnClientExe=false, bool returnLauncherIf=false)
        {
            string path;
            if (!useBNS)
            {
                if (returnClientExe)
                    path = Directory.GetCurrentDirectory() + @"\versions\0.75\client.exe";
                else
                    path = Directory.GetCurrentDirectory() + @"\versions\0.75";
            }
            else
            {
                if (returnLauncherIf)
                    path = @"C:\Program Files (x86)\Build and Shoot\Launcher.exe";
                else
                    path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Build and Shoot\Game Installations\0.75";
            }
            return path;
        }

        public void RemoveItem(object[] list, dynamic item)
        {
        }
    }
}
