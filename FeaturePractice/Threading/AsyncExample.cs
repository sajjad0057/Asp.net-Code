using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    public class AsyncExample
    {
        public void Copy(string path)
        {
            ////File.ReadAllText() return only string , but File.ReadALlTextAsync() return a Task object .
            
            Task<string> task = File.ReadAllTextAsync(path);

            task.Wait();     //// here wait for finishing task

            string text = task.Result;

        }

    }
}
