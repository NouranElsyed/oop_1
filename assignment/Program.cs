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
    internal class Program
    {

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


            #endregion
            #region Q5


            #endregion
        }
    }
}
