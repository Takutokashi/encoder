using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shifr
{
    class Program
    {
        class Shifred
        {
            public string RR(string slovo)
            {
                return slovo;
            }
            public string Reader_Writer(string slovo)
            {
                string lastt = string.Empty;
                for (int i = 0; i < slovo.Length; i++)
                {
                    if (slovo[i].ToString() != " ".ToString())
                    {
                        lastt += slovo[i];
                    }
                }
                return lastt;
            }
            public string Shifrotor(string jj)
            {
                string resultS = string.Empty;
                int stolb = 4;
                double rows = jj.Length / 4.0;
                rows = Math.Ceiling(rows);
                char[,] result = new char[(int)rows, stolb];
                int si = 0;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < stolb; j++)
                    {
                        result[i, j] = jj[si];
                        si += 1;
                        if (si >= jj.Length)
                        {
                            break;
                        }
                    }
                }
                for (int a = 0; a < stolb; a++)               
                {
                    for (int b = 0; b < rows; b++)
                    {
                        resultS += result[b , a];
                      
                    }
                }
                return resultS;
            }
            public string deshifr(string jj)
            {
                string resultS = string.Empty;
                int stolb = 4;
                double rows = jj.Length / 4.0;
                rows = Math.Ceiling(rows);
                char[,] result = new char[(int)rows, stolb];
                int si = 0;
                for (int i = 0; i < stolb; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        result[j, i] = jj[si];
                        si += 1;
                        if (si >= jj.Length)
                        {
                            break;
                        }
                    }
                }
                for (int a = 0; a < rows; a++)
                {
                    for (int b = 0; b < stolb; b++)
                    {
                        resultS += result[a, b];
                    }
                }
                //if (slovo[i].ToString() != " ".ToString())
                //{
                //    lastt += slovo[i];
                //}
                return resultS;
            }
        }
        static void Main(string[] args)
        {
            Shifred Sh = new Shifred();
            string jj = Sh.RR(Console.ReadLine());
            Sh.Reader_Writer(jj);
            string res = Sh.Shifrotor(jj);
            Console.WriteLine(res);
          
            Console.WriteLine(Sh.deshifr(res));
            
            Console.ReadKey();

        }
    }
}
