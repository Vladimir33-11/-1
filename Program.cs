 string[]massiv;
 int count;
 string m;
 string[]massiv2;
 Console.WriteLine("Введите слова из группы");
 count = 0;
 massiv = new string[count];
 do
 {
    m = Console.ReadLine();
    if (m!="")
    {
        count++;
        massiv2=new string[count];
        for (int i=0; i<massiv2.Length-1; i++)
        massiv2[i]=massiv[i];
        massiv2[count-1]=m;
        massiv=massiv2;
    }
 } while (m!="");
 
