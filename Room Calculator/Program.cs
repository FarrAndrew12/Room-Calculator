
public class program
{
    public static void Main()
    {
        Console.WriteLine("Please input Length: ");

        string inputlength = Console.ReadLine();

        Console.WriteLine("the lenght of the rectangle is " + inputlength);


        Console.WriteLine("Please Input Width: ");

        string inputwidth = Console.ReadLine();

        Console.WriteLine("the width of the rectangle is " + inputwidth);

        Console.WriteLine("please input height: ");

        string inputheight = Console.ReadLine();

        Console.WriteLine("the height of the rectangle is " + inputheight);
        
        double length = double.Parse(inputlength); 

        double width  = double.Parse(inputwidth);

        double height = double.Parse(inputheight);

        double area = length * width;

        Console.WriteLine("The area of the room is: " + area);

        double perimeter = width + length * 2;

        Console.WriteLine("The perimeter of the room is " + perimeter);

        double volume = length * width * height;

        Console.WriteLine("The Volume of the room is " + volume);

        double surfacearea = 2 * (width * length + height * length * height * width);

        Console.WriteLine("The surface area of the Room is " + surfacearea);

        if (surfacearea <= 250)
            {
                Console.WriteLine("This is a small sized room ");
            }
             else if ( surfacearea <= 650) 
            {
                Console.WriteLine("This is a medium sized room");
            }
             else  
            {
                Console.WriteLine("This a large sized room");
            }  
       

    }
}