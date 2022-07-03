using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    public class AsyncExample
    {
        /// <summary>
        /// if return type like void use just Task , otherwise use Task<returnType> .
        /// </summary>
        public async Task Copy(string path)
        {
            ////File.ReadAllText() return only string , but File.ReadALlTextAsync() return a Task object .
            
            string text = await File.ReadAllTextAsync(path);  // for using await keywork , here waited for next line code execution untill finished this task .

            Console.WriteLine(text);

        }

    }
}
