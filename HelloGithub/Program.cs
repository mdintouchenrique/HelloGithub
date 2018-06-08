using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Reflection;

namespace HelloGithub {
    class Program {
        static void Main(string[] args) {
            String fileVersion = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion; 
            Console.WriteLine("Hello Github! Version: {0}", fileVersion);
            Console.WriteLine("Press Any Key to Exit...");
            Console.ReadLine();
        }
    }
}
