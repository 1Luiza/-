string[] arrayOfElementsLessThanThree (string[] incomingArray)
{
    string[] currentArray = new string [incomingArray.Length];
    int index = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if(incomingArray[i].Length <= 3)
        {
        currentArray[index] = incomingArray[i];
        index++;
        }
    }
    Array.Resize(ref currentArray, index);
    return currentArray;
}
void printArray(string[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if(i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

string[] array = new string[5] {"one", "two", "three", "four", "five"};
string[] currentArray = arrayOfElementsLessThanThree (array);
printArray(currentArray);


