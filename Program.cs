using System;
using System.Collections.Generic;

namespace H5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IDeveloper> workers = new List<IDeveloper>();

            IDeveloper programmer1 = new Programmer(" C#");
            workers.Add(programmer1);

            IDeveloper programmer2 = new Programmer(" C++");
            workers.Add(programmer2);

            IDeveloper builder1 = new Builder(" Tool1");
            workers.Add(builder1);

            IDeveloper builder2 = new Builder(" Tool2");
            workers.Add(builder2);


            foreach (IDeveloper worker in workers)
            {
                worker.Create();
                worker.Destroy();
            }


            workers.Sort();
            foreach (IDeveloper worker in workers)
            {
                Console.WriteLine(worker.Tool);
            }
        }
    }
}
