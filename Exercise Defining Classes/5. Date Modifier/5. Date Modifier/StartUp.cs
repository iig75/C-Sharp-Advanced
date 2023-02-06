namespace DateAndTime
{

    public class StartUp
    {

        static void Main()
        {
            DateTime input1 = Convert.ToDateTime(Console.ReadLine());

            DateTime input2 = Convert.ToDateTime(Console.ReadLine());

            DateModifier calc1 = new DateModifier(input1, input2);

            Console.WriteLine(calc1.CalculateDays());
        }
    }
}