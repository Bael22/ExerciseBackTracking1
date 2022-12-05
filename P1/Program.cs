//En caso se haga en la parte positiva del plano carteseano
/*
(C,A): y=2x/7+6
(B,C): y=-3x+6
(A,B): y=(8x-16)/5
 */
using P1;

Console.Write("Escriba el numero de puntos aletorios que quiere generar: ");
int puntos=int.Parse(Console.ReadLine());
Console.WriteLine("\n");

int puntInt = AreasporPts.PtsIntersectados((7 / 2), 4, puntos);
double Area = puntInt * (7 * 8) / puntos;
Console.WriteLine("La area aproximada del triangulo con "+puntos+" puntos es: "+Area);