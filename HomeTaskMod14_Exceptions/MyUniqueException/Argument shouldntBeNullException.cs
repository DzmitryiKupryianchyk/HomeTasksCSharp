using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUniqueException
{
    internal class Argument_shouldntBeNullException : Exception
    {
        private readonly string message;
        public Argument_shouldntBeNullException(string message) : base("Ошибка. Пустая строка." + message) 
        { 
            this.message = message;
        } 
    }
}
