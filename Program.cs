//Из имеющегося массива строк сформировать массив из строк,
//длина которых меньше либо равна 3 символа.

string[] array={"Аврора","b2b","22","House","the","bolt","Geek","&","Brains","руб"};
int count=0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length<=3) count++;
}
string[] result=new string[count];
int j=0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i].Length<=3)
    {
        result[j]=array[i];
        j++;
    }
}
Console.WriteLine($"Сформированный массив result:");
for (int i = 0; i < result.Length; i++)
{
    Console.Write (result[i]+";");
}
Console.WriteLine();