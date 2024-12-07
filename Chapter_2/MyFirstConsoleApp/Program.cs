
//OperatorExamples();

//void OperatorExamples()
//{


//    int width = 3; 
//    width++; 
//    int height = 2 + 4; 
//    int area = width * height; 
//   // Console.Write(area); 


//    string result = "The area";
//    result = result + " is " + area;
//    Console.WriteLine(result);

//    bool truthValue = true;
//    Console.WriteLine(truthValue);

//    while (area < 50)
//    {

//        height++;
//        area = width * height;
//    }

//    do
//    {

//        width--;
//        area = width * height;

//    } while (area > 25);

//    int someValue = 10;
//    string message = "";

//    if (someValue == 24 )
//    {
//        message = "Yes, it is 24";
//    }
//    else
//    {
//        message = "No";
//    }




//    /* 
//     * 
//     for (initializer; condition; iterator)
//        {
//        body
//        } 
//     */


//    int count = 5;
//    while (count > 0)
//    {
//        count = count * 3;
//        count = count * -1;
//    }

//}

using System;

//class Program
//{
//    static void Main()
//    {
//        int p = 2;

//        for (int q = 2; q < 32; q = q * 2)
//        {
//            while (p < q)
//            {
//                p = p * q; // Ensure this is really your intended logic
//            }
//            q = p - q;
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {

//        int i = 0;
//        int count = 2;
//        while(i ==0)
//        {
//            count = count * 3;
//            count = count * 2;
//        }
//    }
//}



using System;

class Program
{
    static void Main()
    {
        TrySomeLoops(); // Call the TrySomeLoops method
    }

    // Move TrySomeLoops outside of Main
    static void TrySomeLoops()
    {
        int count = 0;

        while (count < 10)
        {
            count = count + 1; // Increment count
        }

        for (int i = 0; i < 5; i++)
        {
            count = count - 1; // Decrement count
        }

        Console.WriteLine("The answer is " + count);
    }
}
