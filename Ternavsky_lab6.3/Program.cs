using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternavsky_lab6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quaternion q1 = new Quaternion(1, 2, 3, 4);
            Quaternion q2 = new Quaternion(5, 6, 7, 8);

            Console.WriteLine("Кватерніон 1: " + q1);
            Console.WriteLine("Кватерніон 2: " + q2);

            Quaternion sum = q1 + q2;
            Console.WriteLine("Cума: " + sum);

            Quaternion difference = q1 - q2;
            Console.WriteLine("Різниця: " + difference);

            Quaternion product = q1 * q2;
            Console.WriteLine("Добуток: " + product);

            Console.WriteLine("Норма  q1: " + q1.Norm());
            Console.WriteLine("Спряжений q1: " + q1.Conjugate());
            Console.WriteLine("Обернений q1: " + q1.Inverse());

            Console.WriteLine("Чи рівні q1 та q2? " + (q1 == q2));
            Console.WriteLine("Чи не рівні q1 та q2? " + (q1 != q2));

            Matrix4x4 rotationMatrix = q1;
            Console.WriteLine("Матриця обертання від q1:\n" + rotationMatrix);

            Quaternion fromMatrix = Matrix4x4.ToQuaternion(rotationMatrix);
            Console.WriteLine("Кватерніон з матриці обертання:\n" + fromMatrix);

            Console.ReadLine();
        }
    }
}
