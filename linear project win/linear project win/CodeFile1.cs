using System;
using System.Threading;

namespace upgrade_project
{
    internal class Program
    {
        public static void Print(double[,] data, string str)
        {
            Console.WriteLine("============================\n\n" + str);
            for (int i = 0; i < data.GetLength(0); i++)
            {
                Console.Write("|  ");
                for (int j = 0; j < data.GetLength(1); j++)
                    Console.Write(data[i, j] + "  ");
                Console.Write("|\n");
            }
        }
        public static void Swap(ref double[,] data, int row)
        {
            double[] ch = new double[data.GetLength(1)];

            for (int i = 0; i < data.GetLength(1); i++)
            {
                ch[i] = data[0, i];
            }
            for (int i = 0; i < data.GetLength(1); i++)
            {
                data[0, i] = data[row, i];
            }
            for (int i = 0; i < data.GetLength(1); i++)
            {
                data[row, i] = ch[i];
            }

        }
        public static void Go_Down(ref double[,] data, int row)
        {

            double[] ch = new double[data.GetLength(1)];

            for (int i = 0; i < data.GetLength(1); i++)
            {
                ch[i] = data[data.GetLength(0) - 1, i];
            }
            for (int i = 0; i < data.GetLength(1); i++)
            {
                data[data.GetLength(0) - 1, i] = data[row, i];
            }
            for (int i = 0; i < data.GetLength(1); i++)
            {
                data[row, i] = ch[i];
            }

        }
        public static void ToLeading(ref double[,] data)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                if (data[0, j] == 1) goto End;
                if (data[0, j] != 0 && data[0, j] != 1)
                {
                    double dev = data[0, j];
                    for (int i = 0; i < data.GetLength(1); ++i)
                    {
                        data[0, i] /= dev;
                    }
                    Print(data, "to leading");
                    goto End;
                }
            }
        End:;
        }
        public static void To_Row_Echlon(ref double[,] data, int col)
        {
            double num = 0;
            double[] arr = new double[data.GetLength(1)];
            for (int i = 1; i < data.GetLength(0); i++)
            {
                for (int j = col; j < data.GetLength(1); j++)
                {
                    if (j == col && data[i, j] != 0)
                    {
                        num = -data[i, j];
                        for (int k = 0; k < data.GetLength(1); k++)
                            arr[k] = data[0, k] * num;

                        for (int l = 0; l < data.GetLength(1); l++)
                            data[i, l] += arr[l];
                    }
                }
            }
            Print(data, "to zero");
        }
        public static void Last(ref double[,] data, int leadi, int leadj, int chi)
        {
            double[] change = new double[data.GetLength(1)];
            for (int i = 0; i < data.GetLength(1); i++)
            {
                change[i] = data[leadi, i];
            }
            for (int i = 0; i < data.GetLength(1); i++)
            {
                change[i] = change[i] * -1 * data[chi, leadj];
            }
            for (int i = 0; i < data.GetLength(1); i++)
            {
                data[chi, i] += change[i];
            }
            Print(data, "Reduced row_echlon form");
        }
        static void Main1(string[] args)
        {
        start:
            Console.WriteLine("enter the size");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("enter m");
            int num_of_r = int.Parse(Console.ReadLine());

            Console.WriteLine("enter n");
            int num_of_c = int.Parse(Console.ReadLine());

            if (num_of_r * num_of_c != size)
            {
                Console.WriteLine("you enterd a wrong num\n\n======================");

                goto start;
            }
            //اسقبال العناصر في الصفوف
            double[,] arr = new double[num_of_r, num_of_c];
            double[,] fArr = new double[num_of_r, num_of_c];
            for (int j = 0; j < num_of_r; j++)
            {
                for (int i = 0; i < num_of_c; i++)
                {
                    Console.WriteLine($"enter a{j + 1}{i + 1}");
                    arr[j, i] = double.Parse(Console.ReadLine());
                }
            }
            int flag = 0;
            //السيستم ليه اكتر من حل
            for (int i = 0; i < num_of_r; i++)
            {
                if (arr[i, arr.GetLength(0) - 1] == 0) flag++;
                if (flag == arr.GetLength(0)) { Console.WriteLine("the linear system have infinitely many solutions"); }
            }
            //السيستم الله الوكيل مش إله حل
            int flag2 = 0;
            for (int i = 0; i < num_of_r; i++)
            {
                for (int j = 0; j < num_of_c - 1; j++)
                {
                    if (arr[i, j] == 0) flag2++;
                }
                if (flag2 == num_of_c - 1 && arr[i, num_of_c - 1] != 0) { Console.WriteLine("the linear system have no solutions"); goto end; }
            }
            //  طباعة المصفوفه  
            Print(arr, "the augmented matrix");
            //  تحديد اول عامود غير صفري وتبديل الصف الاول
            //  تبديل الصف الصفري
            for (int start = 0; start < num_of_r; start++)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    int x = 0;
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] != 0)
                        {
                            x = 1;
                        }
                    }
                    if (x == 0) Go_Down(ref arr, i);
                }

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[0, j] == 0 && arr[i, j] != 0)
                        {
                            Swap(ref arr, i);
                            goto end_of_the_loop;
                        }

                    }

                }
            end_of_the_loop:
                Print(arr, "after swapping");


                ToLeading(ref arr);
                // جعل باقي عناصر العامود =0

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] == 1)
                        {
                            To_Row_Echlon(ref arr, j);
                            goto end_of_the_loop2;
                        }
                    }
                }
            end_of_the_loop2:
                //تخزين الصف الاول في مصفوفه جديده وحذفه
                for (int j = 0; j < num_of_c; j++)
                {
                    fArr[start, j] = arr[0, j];
                    arr[0, j] = 0;
                }
            }
            Print(fArr, "the row-echlon form");
            //تحويل المصفوفه الى ريديوسد رو ايشلون فورم 
            for (int i = 0; i < num_of_r; i++)
            {
                for (int j = 0; j < num_of_c - 1; j++)
                {
                    int X;
                    if (fArr[i, j] == 1)
                    {
                        X = i;
                        for (int k = 0; k < num_of_r; k++)
                        {
                            if (fArr[k, j] != 0 && k != X) Last(ref fArr, i, j, k);
                        }
                        break;
                    }
                }
            }
            //الناتج النهائي للمتغيرات كلها
            for (int i = 0; i < num_of_r; i++)
            {
                for (int j = 0; j < num_of_c; j++)
                {
                    if (fArr[i, j] == 1)
                    {
                        Console.WriteLine($"x{j + 1} = {fArr[i, num_of_c - 1]}"); break;
                    }
                }
            }
        end:;
        }
    }
}
