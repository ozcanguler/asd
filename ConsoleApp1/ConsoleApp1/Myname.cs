using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Myname
    {
        public static void o()
        {
            
            Console.SetCursorPosition(2,0);
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    
                    if ((i == 0 && j == 0)||(i == 0 && j == 3)){
                        
                        Console.Write(" ");
                    }
                    if ((i == 3 && j == 0) || (i == 3 && j == 3))
                    {
                        
                        Console.Write(" ");
                    }
                    if (((i == 1 || i == 2) && j == 1) || ((i == 1 || i == 2) && j == 2))
                    {
                        
                        Console.Write(" "); 
                    }
                    if (((i == 1||i==2) && j == 0) || ((i == 1||i==2) && j == 3))
                    {
                        
                        Console.Write("*");
                    }
                    if ((i == 0||i==3) && j == 1)
                    {
                        
                        Console.Write("*"); 
                    }
                    if ((i == 0 || i == 3) && j == 2)
                    {
                        
                        Console.Write("*"); 
                    }

                }
               
                Console.WriteLine();
            }
            
        }
        public static void z()
        {           
            for (int i = 0; i <= 3; i++)
                {
                
                for (int j = 0; j <= 3; j++)
        {
                    
                    if (i == 0 || i == 3 )
            {
                Console.Write("*");
            }
                    if ((i == 1 && j == 2)|| (i == 2 && j == 1))
                    {
                        Console.Write("*");
                    }
                    if ((i == 1 && j != 2) || (i == 2 && j != 1))
                    {
                        Console.Write(" ");
                    }

                }
        Console.WriteLine();
                }
        }

        public static void c()
        {
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    if ((i == 0 || i == 3)&&(j!=0))
                    {
                        Console.Write("*");
                    }
                    if ((i == 0 || i == 3) && (j == 0))
                    {
                        Console.Write(" ");
                    }
                    if ((i == 1 || i == 2) && (j == 0))
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }

        }
        public static void a()
        {
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 7; j++)
                {
                    if (i == 0  && (j == 3|| j == 4))
                    {
                        Console.Write("*");
                    }
                    if (i == 0 && j != 4)
                    {
                        Console.Write(" ");
                    }
                    if (i == 1 && (j == 2||j==5))
                    {
                        Console.Write("*");
                    }
                    if (i == 1 && (j != 2 || j != 5))
                    {
                        Console.Write(" ");
                    }
                    if (i == 2 && (j == 1  || j == 4 || j == 3 || j == 2))
                    {
                        Console.Write("*");
                    }
                    if (i == 2 && (j != 1  || j != 5 || j != 3 || j != 2))
                    {
                        Console.Write(" ");
                    }
                    if (i == 3 && (j == 0 || j == 7 ))
                    {
                        Console.Write("*");
                    }
                    if (i == 3 && (j != 0 || j != 7))
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }

        }
        public static void n()
        {
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 8; j++)
                {
                    if (i == 0 && ((j == 3) || (j == 8)))
                    {
                        Console.Write("*");
                    }
                    if (i == 0 && ((j != 3) || (j != 8)))
                    {
                        Console.Write(" ");
                    }
                    if (i == 1 && ((j == 2) || (j == 3) || (j == 6)))
                    {
                        Console.Write("*");
                    }
                    if (i == 1 && ((j != 2) || (j != 3) || (j != 6)))
                    {
                        Console.Write(" ");
                    }
                    if (i == 2 && (j == 1 || j == 4 || j == 5))
                    {
                        Console.Write("*");
                    }
                    if (i == 2 && (j != 1 || j != 4 || j != 5))
            {
                        Console.Write(" ");
                    }
                    if (i == 3 && (j == 0 || j == 5 ))
                    {
                        Console.Write("*");
                    }
                    if (i == 3 && (j != 0 || j != 5 ))
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
            
        }  
        public static void o_z_c_a_n()
        {
            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {

                    if ((i == 0 && j == 0) || (i == 0 && j == 3))
                    {

                        Console.Write(" ");
                    }
                    if ((i == 3 && j == 0) || (i == 3 && j == 3))
                    {

                        Console.Write(" ");
                    }
                    if (((i == 1 || i == 2) && j == 1) || ((i == 1 || i == 2) && j == 2))
                    {

                        Console.Write(" ");
                    }
                    if (((i == 1 || i == 2) && j == 0) || ((i == 1 || i == 2) && j == 3))
                    {

                        Console.Write("*");
                    }
                    if ((i == 0 || i == 3) && j == 1)
                    {

                        Console.Write("*");
                    }
                    if ((i == 0 || i == 3) && j == 2)
                    {

                        Console.Write("*");
                    }

                }

                for (int j = 0; j <= 3; j++)
                {

                    if (i == 0 || i == 3)
                    {
                        Console.Write("*");
                    }
                    if ((i == 1 && j == 2) || (i == 2 && j == 1))
                    {
                        Console.Write("*");
                    }
                    if ((i == 1 && j != 2) || (i == 2 && j != 1))
                    {
                        Console.Write(" ");
                    }

                }
                for (int j = 0; j <= 3; j++)
                {
                    if ((i == 0 || i == 3) && (j != 0))
                    {
                        Console.Write("*");
                    }
                    if ((i == 0 || i == 3) && (j == 0))
                    {
                        Console.Write(" ");
                    }
                    if ((i == 1 || i == 2) && (j == 0))
                    {
                        Console.Write("*");
                    }
                }
                for (int j = 0; j <= 7; j++)
                {
                    if (i == 0 && (j == 4))
                    {
                        Console.Write("*");
                    }
                    if (i == 0 && j != 4)
                    {
                        Console.Write(" ");
                    }
                    if (i == 1 && (j == 6 || j == 7))
                    {
                        Console.Write("*");
                    }
                    if (i == 1 && (j != 6 || j != 7))
                    {
                        Console.Write(" ");
                    }
                    if (i == 2 && (j == 5 || j == 6 || j == 7))
                    {
                        Console.Write("*");
                    }
                    if (i == 2 && (j != 5 || j != 6 || j != 7))
                    {
                        Console.Write(" ");
                    }
                    if (i == 3 && (j == 1 || j == 6))
                    {
                        Console.Write("*");
                    }
                    if (i == 3 && (j != 1 || j != 6))
                    {
                        Console.Write(" ");
                    }
                }

                for (int j = 0; j <= 10; j++)
                {
                    if (i == 0 && ((j == 2) || (j == 7)))
                    {
                        Console.Write("*");
                    }
                    if (i == 0 && ((j != 2) || (j != 7)))
                    {
                        Console.Write(" ");
                    }
                    if (i == 1 && ((j == 2) || (j == 3) || (j == 6)))
                    {
                        Console.Write("*");
                    }
                    if (i == 1 && ((j != 2) || (j != 3) || (j != 6)))
                    {
                        Console.Write(" ");
                    }
                    if (i == 2 && (j == 0 || j == 3 || j == 4))
                    {
                        Console.Write("*");
                    }
                    if (i == 2 && (j != 0 || j != 3 || j != 4))
                    {
                        Console.Write(" ");
                    }
                    if (i == 3 && (j == 3))
                    {
                        Console.Write("*");
                    }
                    if (i == 3 && (j != 3))
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
        public static void bosluk()
        {
            Console.SetCursorPosition(4, 0);
            
        }
    }
}
