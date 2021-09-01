using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Singleton
{
    public class Policy
    {
        private static readonly Policy Instance = new Policy();
        public static Policy instance{
            get{
                return Instance;
            }
        }
        public Guid Id { get; set; }

        public string Person { get; set; } = "John";
        public string Name() => Person;
    }
}
