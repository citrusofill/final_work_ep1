
void PrintIndexAndValues (String[] myArr)  {
        for(int i = 0; i < myArr.Length; i++)
        {
            Console.WriteLine("   [{0}] : {1}", i, myArr[i]);
        }
        Console.WriteLine();
    }

Console.WriteLine ("Введите элементы массива чере пробел");
string [] arrLetterAll = Console.ReadLine().Split (" ").ToArray();
string [] arrLetter3 = new string [arrLetterAll.GetLength(0)];
int j = 0; 
for (int i=0;i < arrLetterAll.Length;i++)
{
if (arrLetterAll[i].Length<3) 
{
arrLetter3[j] = arrLetterAll[i];
j++;
}

}
Array.Resize(ref arrLetter3,j);

 PrintIndexAndValues (arrLetter3);