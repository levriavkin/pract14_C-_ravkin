using System;
using System.Collections.Generic;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        int Capasity = 0;

        static void Main(string[] args)
        {
            
            for(int k=0;k<3;k++)
            {
                Console.WriteLine("Выберите задание: \nПервое - 1\n Второе а- 2\n Второе б - 3");
                int zad = int.Parse(Console.ReadLine());
                switch (zad)
                {
                    case 1:
                        {
                            try
                            {
                                Console.WriteLine("Введите количество Элементов");
                                int n = int.Parse(Console.ReadLine());


                                Stack<int> stack = new Stack<int>();
                                for (int i = 1; i <= n; i++)
                                {
                                    stack.Push(i);
                                }


                                Console.WriteLine($"Верхний эелемент стека = {n}");
                                Console.WriteLine($"Размерность стека = {n}");
                                Console.Write("Содержимое стека = ");
                                while (stack.Count > 0)
                                {
                                    int element = stack.Pop();
                                    Console.Write(element + "\t");
                                }
                                stack.Clear();
                                Console.WriteLine();
                                Console.WriteLine($"Новая размерность стека = {stack.Count}");
                            }
                            catch { Console.WriteLine("Ошибка"); }
                        }
                        break;
                    case 2:
                        {
                            try
                            {
                                Console.WriteLine("Введите выражение");
                                string expression = Console.ReadLine();
                                StreamWriter s = File.CreateText("t.txt");
                                s.WriteLine(expression);
                                s.Close();
                                 expression = File.ReadAllText("t.txt");
                                Stack<char> stack = new Stack<char>();
                                bool balanced = true;
                                int index = 1;

                                for (int i = 0; i < expression.Length; i++)
                                {
                                    char c = expression[i];

                                    if (c == '(')
                                    {
                                        stack.Push(c);
                                    }
                                    else if (c == ')')
                                    {
                                        if (stack.Count == 0)
                                        {
                                            balanced = false;
                                            index = i;
                                            break;
                                        }
                                        else
                                        {
                                            stack.Pop();
                                        }
                                    }
                                }

                                if (stack.Count == 0 && balanced)
                                {
                                    Console.WriteLine("Скобки сбалансированы");
                                }
                                else if (stack.Count > 0)
                                {
                                    Console.WriteLine($"Возможна лишняя скобка в позиции: {index} ");

                                }

                            }
                            catch { Console.WriteLine("Ошибка"); }
                            break;
                        }
                        
                    case 3:
                        try
                        {
                            


                        }
                        catch { Console.WriteLine("Ошибка"); }
                        break;
                }
            }
            
            
            

        }
        
             
    }
           
            
        
}

