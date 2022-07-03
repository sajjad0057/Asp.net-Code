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
        public async Task CopyAsync(string path1, string path2)
        {
            ////File.ReadAllText() return only string , but File.ReadALlTextAsync() return a Task object .
            
            using Task<string> text1 = File.ReadAllTextAsync(path1); 
            using Task<string> text2 = File.ReadAllTextAsync(path2);
            Task.WaitAll(text1, text2); //  here waited for next line code execution untill finished all task .
            Console.WriteLine(text1+"\n"+text2);

        }


        public async Task PrintAsync()  //// here make a synchronous function to asynchronous signature                                       
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i);
                }
            });
        }


    }
}
