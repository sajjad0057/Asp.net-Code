using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLib
{
    public class Accounting : IModule
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }


        public Accounting()
        {
            Id = Guid.NewGuid();
            Name = "Accounting";
            IsActive = true;

        }

        public void Start()
        {
            Console.WriteLine("Accounting started !");
        }

    }
}
