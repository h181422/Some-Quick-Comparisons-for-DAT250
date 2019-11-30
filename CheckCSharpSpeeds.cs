using System;
using System.Collections.Generic;
using System.Diagnostics;

//This code is used for both console and blazor
//Swith between doMath and BubbleSort to evaluate math operations and memory operations respectively.

namespace ClassLibrary1
{
    public class CheckSomeSpeeds
    {
     static void Main(string[] args)
            {
                try
                {
                    while (true)
                        SortALot();
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            }
    
            public static string Result;
            public static int numElements = 10;
            public static int numtests = 20;
            public static void SortALot()
            {
                Result = "";
                var sw = Stopwatch.StartNew();
                for (int k = 0; k < 13; k++)
                {
                    var k10 = Math.Pow(10, k);
                    string prt = (k+1).ToString();
                    for (int i = 0; i < numtests; i++)
                    {
                        var arr = new List<int>();// int[(int)(numElements * k10)];
                        Random r = new Random();
                        for (int j = 0; j < numElements*k10; j++)
                        {
                            arr[j] = (r.Next(100000));
                        }
                    
                        sw.Reset();
                        sw.Start();
                        doMath((int)k10);//BubbleSort(arr,(int)(numElements * k10));
                        prt += ";" + sw.ElapsedMilliseconds;
                    }
                    Result += prt + "<br>";
                    Console.WriteLine(Result);
                }
            }
    
            public static void doMath(int len)
            {
                var v = 0.0;
                for (int i = 0; i < len; i++)
                {
                    v += 3.1415;
                }
            }
            
            public static void BubbleSort(List<int> tabell, int size)
            {
                bool bytter;
                int temp;
                size--;
                do
                {
                    bytter = false;
                    for (int i = 0; i < size; i++)
                    {
                        if (tabell[i] > tabell[i + 1])
                        {
                            temp = tabell[i];
                            tabell[i] = tabell[i + 1];
                            tabell[i + 1] = temp;
                            bytter = true;
                        }
                    }
                } while (bytter);
            }
    }
}