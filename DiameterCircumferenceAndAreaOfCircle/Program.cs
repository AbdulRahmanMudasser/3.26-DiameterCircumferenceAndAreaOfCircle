class Circle
{
    static void Main(string[] args)
    {
        // declaring variable
        int radius;

        // prompting user to get input for radius
        Console.Write("Enter Radius Of Circle:  ");
        radius = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();    // just for spacing purpose

        // calculating and displaying diameter of the circle
        Console.WriteLine("Diameter Of The Circle:  " + (2 * radius));

        // calculating and displaying circumference of the circle
        Console.WriteLine("Circumference Of The Circle:  " + (2 * Math.PI * radius));

        // calculating and displaying circumference of the circle
        Console.WriteLine("Area Of The Circle:  " + (Math.PI * radius * radius));
    }
    // end of Main method
}
// end of Circle class
