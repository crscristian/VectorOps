using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace VectorOps
//{
//    internal static class Program
//    {
//        /// <summary>
//        /// The main entry point for the application.
//        /// </summary>
//        [STAThread]
//        static void Main()
//        {
//            Application.EnableVisualStyles();
//            Application.SetCompatibleTextRenderingDefault(false);
//            Application.Run(new VectorOps());
//        }
//    }
//}

namespace VectorOps
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Inițializăm și rulăm fereastra OpenGL
            using (var window = new OpenGL3DWindow())
            {
                window.Run(60.0); // Rulează cu 60 FPS
            }
        }
    }
}
