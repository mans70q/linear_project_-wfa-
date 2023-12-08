using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace linear_project_win
{
    public partial class Form1 : Form
    {
        static public int num_of_r = 0;
        static public int num_of_c = 0;
        static public int Msize = 0;
        public double[,] arr;
        
        public Form1()
        {
            InitializeComponent();
        }
        //   →→→ جميع العمليات اللي بتحصل على المصفوفة   
        public void Print(double[,] arr, string str)
        { 
            matrix.Clear();
            matrix.AppendText(str.ToString()+"\n");
            for (int j = 0; j < num_of_r; j++)
            {
                matrix.AppendText("| ");
                for (int i = 0; i < num_of_c; i++)
                {
                    matrix.AppendText(arr[j, i].ToString() + " ");
                }
                matrix.AppendText(" |\n");
            }
        }
        public void Go_Down(ref double[,] data, int row ,int print)
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
            }Print(arr, "");
          if(print==0 && row!=num_of_r-1)  steps.AppendText($"R{row+1}-> R{num_of_r} \n");
        }
        public void Swap(ref double[,] data, int row)
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
            steps.AppendText($"swapping R1->R{row+1}\n");
        }
        public void ToLeading(ref double[,] data)
        {
            for (int j = 0; j < data.GetLength(1); j++)
            {
                if (data[0, j] == 1) goto End;
                if (data[0, j] != 0 && data[0, j] != 1)
                {
                    double dev = data[0, j];
                    steps.AppendText($"R / {dev} -> R\n");
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
        public  void To_Row_Echlon(ref double[,] data, int col)
        {
            double num = 0;
            double[] arr = new double[data.GetLength(1)];
            for (int i = 1; i < data.GetLength(0); i++)
            {
                for (int j = col; j < data.GetLength(1); j++)
                {
                    if (j == col && data[i, j] != 0)
                    {num = -data[i, j];
                        steps.AppendText($"R{i} *({num}) +R{i + 1}->R{i+1}\n");
                        for (int k = 0; k < data.GetLength(1); k++)
                            arr[k] = data[0, k] * num;

                        for (int l = 0; l < data.GetLength(1); l++)
                            data[i, l] += arr[l];
                    }
                }
            }
            
            Print(data, "to zero");
        }
        public void To_Reduced_Row_Echlon(ref double[,] data, int leadi, int leadj, int chi)
        {
            steps.AppendText($"R{leadi + 1}*-{data[chi,leadj]} +R{chi+1} ->R{chi + 1}");
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


        // التحكم في عدد الصفوف والاعمدة
        public void m_num_p_Click(object sender, EventArgs e)
        {
            num_of_r++;
            m_num.Text = num_of_r.ToString();
            Msize = num_of_r * num_of_c;
            lbl_size.Text = Msize.ToString();
        }

        public void m_num_m_Click(object sender, EventArgs e)
        {
            num_of_r--;
            m_num.Text = num_of_r.ToString();
            Msize = num_of_r * num_of_c;
            lbl_size.Text = Msize.ToString();
        }

        public void n_num_p_Click(object sender, EventArgs e)
        {
            num_of_c++;
            n_num.Text = num_of_c.ToString();
            Msize = num_of_r * num_of_c;
            lbl_size.Text = Msize.ToString();
        }

        public void n_num_m_Click(object sender, EventArgs e)
        {
            num_of_c--;
            n_num.Text = num_of_c.ToString();
            Msize = num_of_r * num_of_c;
            lbl_size.Text = Msize.ToString();
        }

        // قراية المصفوفة من اليوزر
        public void button6_Click(object sender, EventArgs e)
        {
            string a = matrix.Text;
            steps.Clear();
            int count = 0;
            string[] y = a.Split(' ');
            arr = new double[num_of_r, num_of_c];
            for (int j = 0; j < num_of_r; j++)
            {
                for (int i = 0; i < num_of_c; i++)
                {
                    arr[j, i] = double.Parse(y[count++]);
                }
            }
            Print(arr,"your matrix is :");
        }
        
        //  ♥♥♥♥ الكود الرئيسي  
        public void button1_Click(object sender, EventArgs e)
        {
            double[,] fArr = new double[num_of_r, num_of_c];
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
                    if (x == 0) Go_Down(ref arr, i ,start);
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
                            if (fArr[k, j] != 0 && k != X) To_Reduced_Row_Echlon(ref fArr, i, j, k);
                        }
                        break;
                    }
                }
            }
            //السيستم ليه اكتر من حل
            int flag = 0;
            for (int i = 0; i < num_of_r; i++)
            {
                flag = 0;
                for (int j = 0; j < num_of_c ; j++)
                {
                    if (fArr[i, j] == 0) { flag++; }
                    if (flag == arr.GetLength(1)) { MessageBox.Show("the linear system has infinitely many solutions"); goto end; }
                }
            }
            //السيستم الله الوكيل مش إله حل
            int flag2 = 0;
            for (int i = 0; i < num_of_r; ++i)
            {flag2 = 0;
                for (int j = 0; j < num_of_c; j++)
                {
                    if (fArr[i, j] == 0) { flag2++; }
                    if (arr.GetLength(1)-1 == flag2 && fArr[i, num_of_c-1] != 0)
                    {
                        matrix.AppendText("system has no solutions"); goto end;
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
                        matrix.AppendText($"x{j + 1} = {fArr[i, num_of_c - 1]}\n"); break;
                    }
                }
            }
        end:;
        }
    }
}
