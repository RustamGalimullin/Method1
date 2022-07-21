// See https://aka.ms/new-console-template for more information
///Console.WriteLine("Hello, World!");
void Method1()
{
    Console.WriteLine("Автор: Галимуллин Рустам Марсилович");
}
//Method1();
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
        Console.WriteLine(msg);
      i++;
    }
}
///Method21("Текст", 1000);
int Method3()
{
    return DateTime.Now.Day;
}
int day = Method3();
//Console.WriteLine(day);

string Method4(int count, string с)
{
    int i = 0;
    string result = String.Empty;
    while (i< count)
    {
        result = result + с;
        i++;
    }
    return result;



}
//string result = Method4 (10,"ебобошеньки");
//Console.WriteLine(result);


string Method41(int count, string с)
{
    
    string result = String.Empty;
    for( int i = 0; i < count; i++)
    {
        result = result + с;
    }
    return result;



}
string result = Method4 (10,"ебобошеньки");
//Console.WriteLine(result);

//for (int i = 0; i <=10; i++)
{
    //for (int j = 0; j <=10; j++)
    {
       // Console.WriteLine($"{i} x {j} = {i * j}");
    }
}



int[] arr = {1,5,6,2,4,3,7,1,1};
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i<count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        { 
            if (array[j]< array[minPosition]) minPosition = j;
    
    
        }
             int temporary = array [i];
          array [i] =  array[minPosition]; 
          array[minPosition] = temporary; 
    
    }     

}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);