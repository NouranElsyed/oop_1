namespace oop_1
{
    public enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    public enum Gender { male , female}
    public enum grades { A,B,C,D,E,F}
    internal class Program
    {
        static void DoSomeProtectiveCode() {
        
        int x, y,z;
        bool flag;
            do
            {
                Console.WriteLine("Enter First Number: ");
                flag = int.TryParse(Console.ReadLine(), out x);
            } while (!flag);

            do
            {
                Console.WriteLine("Enter second Number: ");
                flag = int.TryParse(Console.ReadLine(), out y);
            } while (!flag || y==0);
            z = x / y;
            int[] Numbers = { 1, 2, 3 };
            if (Numbers?.Length > 10) { Numbers[10] = 100; }


        }
        static void Main(string[] args)
        {
            #region Exceptions handling
            try
            {
                DoSomeProtectiveCode();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); } // for any unexpected exception
            finally { Console.WriteLine("finally"); }// if the db opened or external file clr can not handle 
            #endregion
            #region enum
            #region  ex01
            ////grades x = "A" // XXXX // x its type is grades not string and A its a label in enum 
            //grades x = grades.A;
            ////grades y = 2; // XXXX // 2 is its value in db 
            //grades y = (grades)2; // explicit casting
            //grades z = (grades)10; // return 10 , can not explicit casting the label with value 10 not existed


            #endregion
            #region ex02
            //grades x = (grades)Enum.Parse(typeof(grades),Console.ReadLine()); // bad way to convert input to enum 
            //bool result = Enum.TryParse(Console.ReadLine(), out x); // with tryparse 
            //Console.WriteLine($"Result is {result}");
            //Console.WriteLine($"your grade is {x}");
            #endregion
            #region ex03
            string gender = "male";
            bool flag = Enum.TryParse<Gender>(gender, true, out Gender result);
            Console.WriteLine(result);

            Gender x = new Gender();// take defult value of enum =0
            #endregion

            #endregion
        }
    }
}
