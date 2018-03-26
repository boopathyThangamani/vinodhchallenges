using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoOfClassedNeeded
{
    /*Let X = total no of students
     T = Seating capacity of a class room.
     Can u write a function in c# to find out no fo class room required it should handle all scenarios
         */
    public class Program
    {
        static void Main(string[] args)
        {
            ClassRoomRequired classRoomRequired = new ClassRoomRequired();
            Console.Write(classRoomRequired.GetClassRoomsRequired(1, 50));
            Console.ReadLine();
        }

        
    }

    public class ClassRoomRequired
    {
        public double GetClassRoomsRequired(double x, double t)
        {
            return Math.Ceiling(x / t);
        }
    }
}
