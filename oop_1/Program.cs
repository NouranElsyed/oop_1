namespace oop_1
{
    public enum Days { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
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
        }
    }
}
