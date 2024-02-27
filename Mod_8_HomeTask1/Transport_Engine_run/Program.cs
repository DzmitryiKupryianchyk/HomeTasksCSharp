using System.Text;

namespace Transport_Engine_run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Engine hondaMotor = new Engine();
            Car honda = new Car(hondaMotor);
            honda.Move();

            Engine shipMotor = new Engine();
            Ship titanic = new Ship(shipMotor);
            titanic.Move();

            Engine planeMotor = new Engine();
            Plane plane = new Plane(planeMotor);
            plane.Move();

            Engine trainMotor = new Engine();
            Train train = new Train(trainMotor);
            train.Move();
            
            
            
        }
    }
}
