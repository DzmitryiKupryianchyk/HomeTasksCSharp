using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Engine_run
{
    internal class Train : Transport
    {
        public Train(Engine engine) : base (engine) { }

        public override void Move()
        {
            engine.RunEngine();
            Thread.Sleep(500);
            Console.Beep();
            Thread.Sleep(500);
            Console.WriteLine("Асцярожна, дзьверы зачыняюцца. Наступны прыпынак - станцыя 'Мінск Пассажырскі'");
            Console.WriteLine();
        }
    }
}
