using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_New_Feature
{
    public record Person1(string FirstName, string LastName);

    public class Class1
    {
        public string Name { get; init; }



    }


    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Distance => Math.Sqrt(X * X + Y * Y);

        public override string ToString() =>
            $"({X}, {Y}) is {Distance} from the origin";
    }



    public class Class2
    {
        public enum Rainbow
        {
            Red,
            Orange,
            Yellow,
            Green,
            Blue,
            Indigo,
            Violet
        }

        public static string FromRainbow(Rainbow colorBand) =>
             colorBand switch
             {
                 Rainbow.Red => "Color is red",
                 Rainbow.Orange => "Color is Orange",
                 Rainbow.Yellow => "Color is Yellow",
                 Rainbow.Green => "Color is Green",
                 Rainbow.Blue => "Color is Blue",
                 Rainbow.Indigo => "Color is Indigo",
                 Rainbow.Violet => "Color is Violet",
                 _ => throw new ArgumentException(message: "invalid enum value", paramName: nameof(colorBand)),

             };


        public static async IAsyncEnumerable<int> GenerateSequence()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }



    }
   
}
