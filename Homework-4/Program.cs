Console.WriteLine("LÜTFEN... Yazılı notlarını 1-100 arasında giriniz...:\n");

dön1:

Console.Write("1. yazılı notunu giriniz...:");
int n1 = int.Parse(Console.ReadLine());

if (n1 < 0 || n1 > 100) goto dön1; 


dön2:
Console.Write("2. yazılı notunu giriniz...:");
int n2 = int.Parse(Console.ReadLine());

if (n2 < 0 || n2 > 100) goto dön2;


dön3:
Console.Write("3. yazılı notunu giriniz...:");
int n3 = int.Parse(Console.ReadLine());

if (n3 < 0 || n3 > 100) goto dön3;


int ort = (n1 + n2 + n3) / 3;

Console.WriteLine("Ortalama notunuz: " + ort);

Console.ReadKey();