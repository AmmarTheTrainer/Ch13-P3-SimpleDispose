using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13_P3_SimpleDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Dispose *****\n");
            //// Create a disposable object and call Dispose() to free any internal resources.
            //MyResourceWrapper rw = new MyResourceWrapper();

            //if (rw is IDisposable)
            //    rw.Dispose();

            #region C# using keyword

            //MyResourceWrapper rw = new MyResourceWrapper();
            //try
            //{
            //    // Use the members of rw.
            //}
            //finally
            //{
            //    // Always call Dispose(), error or not.
            //    rw.Dispose();
            //}

            //// Dispose() is called automatically when the using scope exits.
            //using (MyResourceWrapper rw = new MyResourceWrapper())
            //{
            //    // Use rw object.
            //}


            // Use a comma-delimited list to declare multiple objects to dispose.
            using (MyResourceWrapper rw = new MyResourceWrapper(), rw2 = new MyResourceWrapper())
            {
                // Use rw and rw2 objects.
            }

            #endregion

            Console.ReadLine();
        }
        // Assume you have imported
        // the System.IO namespace...
        static void DisposeFileStream()
        {
            FileStream fs = new FileStream("myFile.txt", FileMode.OpenOrCreate);
            // Confusing, to say the least!
            // These method calls do the same thing!
            fs.Close();
            fs.Dispose();
        }
    }
}
