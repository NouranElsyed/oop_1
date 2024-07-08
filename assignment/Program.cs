using System.Text;
using System.Xml.Linq;

namespace assignment
{
    public enum WeekDays
    {

        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    public enum session
    {
        Spring, Summer, Autumn, Winter
    }
    [Flags]
    public enum permissions { 
    Delete =1 , Excute = 2 , Read =4 , Write = 8
    }

    public enum Colors 
    {
    Red, Green, Blue    
    }
    internal class Program
    {
         static double distance (int x1 , int y1 , int x2 , int y2) {
          double result =  Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return result;
        }

        static void Main(string[] args)
        {
            #region Q1
            //foreach (int i in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine((WeekDays)i);
            //}

            #endregion

            #region Q2
            //string? name;
            //do {name = Console.ReadLine(); } while (name == null);

            //switch (name.ToLower())
            //{
            //    case "march":
            //    case "april":
            //    case "may":
            //        Console.WriteLine(session.Spring);
            //        break;
            //    case "june":
            //    case "july":
            //    case "august ":

            //        Console.WriteLine(session.Summer);
            //        break;
            //    case "september":
            //    case "october":
            //    case "november ":
            //        Console.WriteLine(session.Autumn);
            //        break;
            //    case "december ":
            //    case "january":
            //    case "february ":
            //        Console.WriteLine(session.Winter);
            //        break;
            //    default :
            //        Console.WriteLine("that is not a month name.");
            //        break;
            //}

            #endregion

            #region Q3
            //permissions YourPermission = (permissions)7;
            //Console.WriteLine("the permissions you have:");
            //Console.WriteLine(YourPermission);
            //Console.WriteLine("change if you have permission to delete romve it or add the delete permission if it is not existd."); 
            //YourPermission = YourPermission ^ permissions.Delete;
            //Console.WriteLine(YourPermission);

            //Console.WriteLine("to check if you have permission to Delete or not and add if not.");
            //if ((YourPermission & permissions.Delete) == permissions.Delete)
            //{
            //    Console.WriteLine("permission Delete is already existed");
            //    Console.WriteLine(YourPermission);
            //}
            //else
            //{
            //    Console.WriteLine("permission Delete is not existed, I'll added");
            //    YourPermission = YourPermission ^ permissions.Delete;
            //    Console.WriteLine(YourPermission);


            //}

            //Console.WriteLine("if write is existed no nothing if not add it");

            //YourPermission = YourPermission ^ permissions.Write;
            //Console.WriteLine(YourPermission);


            #endregion

            #region Q4
            //bool Result = Enum.TryParse<Colors>(Console.ReadLine(),true,out Colors x);
            //if (Result)
            //{ Console.WriteLine("color is a primary color"); }
            //else { Console.WriteLine("color is not a primary color"); }

            #endregion
            #region Q5
          //  Point p1, p2;
          //  Console.WriteLine("Enter x of point 1:");
          //  int.TryParse(Console.ReadLine(),out int x1);
          //  Console.WriteLine("Enter y of point 1:");
          //  int.TryParse(Console.ReadLine(), out int y1);
          //  Console.WriteLine("Enter x of point 2:");
          //  int.TryParse(Console.ReadLine(), out int x2);
          //  Console.WriteLine("Enter y of point 2:");
          //  int.TryParse(Console.ReadLine(), out int y2);

          //  p1 = new Point(x1, y1);
          //  p2 = new Point(x2,y2);


          //double res =  distance(p1.x, p1.y, p2.x, p2.y);
          //  Console.WriteLine("Distance between them: ");

          //  Console.WriteLine(res);

            #endregion
        }
    }
}
