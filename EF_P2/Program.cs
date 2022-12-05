using EF_P2;

Console.WriteLine("------------------Buen dia------------------\nIngrese los parametros de su matriz mxn:");
Console.Write("m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("\n\n---------------Matriz mxn--------------\n");
int[,] mtrz = new int[m, n];
Random r = new Random();
for (int i = 0; i < m; i++)
{
    for (int l = 0; l < n; l++)
    {
        mtrz[i, l] = r.Next(0, 10);
    }
}
BackTracking.imprimir(mtrz);

Console.Write("\nIngrese los numeros que quiere encontrar: "); 
int num = int.Parse(Console.ReadLine());
int cont=num.ToString().Count();int potencia = cont-1;
int[] arraysecuencia=new int[cont];
Console.WriteLine("\n------------------Numero que se quiere encontrar------------------");
for(int i=0;i<cont;i++)
{
    arraysecuencia[i] = (int)((num / (Math.Pow(10, potencia)))%10);
    Console.Write(" "+ arraysecuencia[i]);potencia--;
}
Console.WriteLine("\n");
//Matriz de respuesta
int[,]res= new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int l = 0; l < n; l++)
    {
        res[i, l] = 10;
    }
}
if(BackTracking.EncontrarNumero(arraysecuencia, 0, mtrz, res, 0, -1))    
{
    Console.WriteLine("Se encontro la sucesion de numeros!!!");
    BackTracking.imprimir(res);
}
else
    Console.WriteLine("No se encontro, tenga suerte la proxima");


