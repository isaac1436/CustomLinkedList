// See https://aka.ms/new-console-template for more information


using Data_Structures;

var newList = new List<int>();

var mySecondList = new LinkedList<int>();


var myList = new CustomLinkedList<int>();

for (int i = 0; i < 20; i++)
{
    myList.AddItem(i+1);
}

Console.WriteLine($"\n\nThe sum of the first 7 items is {myList.AddFirst(7)}");

Console.WriteLine($"\n\nThe sum of the last 5 elements is {myList.AddLast(5)}");

Console.WriteLine($"\n\nThe index of 15 is {myList.find(15)}");

Console.Write($"\n\nThe list after removing 15 is: ");
myList.remove(15,20);
var temp = myList.Head;

for (int i = 0; i < 19; i++)
{
    Console.Write(myList.Head.Value+", ");
    myList.Head= myList.Head.NextNode;
}

myList.Head = temp;

Console.Write($"\n\nThe list after removing 7 is: ");
myList.remove(7, 19);
temp = myList.Head;

for (int i = 0; i < 18; i++)
{
    Console.Write(myList.Head.Value + ", ");
    myList.Head = myList.Head.NextNode;
}


myList.Head = temp;

myList.clear();

for(int i = 0; ; i++)
{
    if (myList.Head == null)
    {
        Console.WriteLine("\n\nThis List is empty ");
        break;
    }
}






