using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_P2
{
    internal class BackTracking
    {
       public static void imprimir(int[,]a)
        {
            Console.WriteLine();
            for(int i=0; i<a.GetLength(0); i++)
            {
                Console.Write("|");
                for (int f=0; f<a.GetLength(1); f++)
                {
                    if (a[i, f] == 10) Console.Write("X|");
                    else Console.Write(a[i, f] + "|");
                }
                Console.Write("\n-");
                for (int f = 0; f < a.GetLength(1); f++)
                { Console.Write("--"); }
                Console.WriteLine();
            }
        }
        public static int termino(int[,]res)
        { int cont = 0;
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int l = 0; l < res.GetLength(1); l++)
                {
                    if (res[i, l] != 10) cont++;
                }
                
            }
            return cont;
        }
        public static bool Validar(int[] numero,int i,int[,] lab, int[,] res, int fil, int col)
        {
            if (fil >= lab.GetLength(0) || fil < 0)
            {
                return false;
            }
            if (col >= lab.GetLength(1) || col < 0)
            {
                return false;
            }
            if (res[fil, col] != 10)
            {
                return false;
            }
            if (lab[fil,col]== numero[i])
            {
                res[fil, col] = numero[i];
                return true;
            }
            
            return false;
        }
        public static bool EncontrarNumero(int[] numero,int i, int[,] matriz, int[,]res,int fil,int col)
        {
            if (termino(res)==numero.Length)
            {
                return true;
            }
            else
            {//der=0,izq=1,arr=2,abajo=3

              // imprimir(res);
               
                if (Validar(numero,i,matriz, res, fil, col + 1) 
                    && EncontrarNumero(numero, i+1, matriz, res, fil, col+1))//derecha
                {
                    return true;
                }
                else if (Validar(numero, i, matriz, res, fil-1, col )
                    && EncontrarNumero(numero, i + 1, matriz, res, fil-1, col))//Arriba
                {
                    return true;
                }
                else if (Validar(numero, i, matriz, res, fil, col - 1)
                    && EncontrarNumero(numero, i + 1, matriz, res, fil, col - 1))//izquierda
                {
                    return true;
                }
                else if (Validar(numero, i, matriz, res, fil + 1, col)
                    && EncontrarNumero(numero, i + 1, matriz, res, fil + 1, col))//abajo
                {
                    return true;
                }

                else
                {
                    if(i!=0)
                    {
                        res[fil, col] = 10;
                    }
                    if(i==0&&(fil!=matriz.GetLength(0)-1||col!= matriz.GetLength(1)-1))
                    {
                        if (col == matriz.GetLength(1) - 1) { fil++; col = -1; }
                        else col++;
                        if(EncontrarNumero(numero,i, matriz, res, fil, col)) return true;
                    }
                    
                    return false;
                }
            }
        }
    }
}

