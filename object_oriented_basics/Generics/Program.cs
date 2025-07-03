
using Generics;

Point<int> point1 = new Point<int>() { X = 3, Y = 4 };
Point<float> point2 = new Point<float>() { X =4.5f, Y =5.7f };
Console.WriteLine(point1.PointSum());
Console.WriteLine(point2.PointSum());

BubbleSort<int> bubbleSort = new BubbleSort<int>();
int[] array = bubbleSort.Sort([1, 5, 2, 3, 7]);
foreach(var value in array)
{
    Console.Write(value);
    Console.Write(' ');
}

Vector2D<int> vector2d = new Vector2D<int>() { XcoOrdinate = 3, YcoOrdinate = 5 };

