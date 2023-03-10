// Программа формирования из имеющегося массива строк, массив из строк, длина которых меньше либо равно 3 символам
string[] FormArray(string[]inArray)
{
    string[]newArray=new string[inArray.Length];
    int index =0;
    foreach(string str in inArray)
    {
        if(str.Length<=3)
        {
            newArray[index]=str;
            index++;
        }
    }
Array.Resize (ref inArray, index);
return newArray;
}


void Print(string[] col)
{
    int count=col.Length;
    int pos=0;
    while(pos<count)
    {
        Console.WriteLine(col[pos]);
        pos++;
    }
    Console.WriteLine();
}

string[]Ar={"apll","sd","dot"};

string[] nArr= FormArray(Ar);
Print(nArr);

