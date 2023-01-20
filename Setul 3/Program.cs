using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Collections.Concurrent;

namespace Setul_3
{
    internal class Program
    {
        static void p1()
        {
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            for (int i = 0; i < n; i++)
            {
                suma += v[i];
            }
            Console.WriteLine(suma);
            Console.ReadKey();
        }

        static void p2()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int poz = -1;
            bool ok = false;
            for (int i = 0; i < n; i++)
            {
                if (v[i] == k && poz == -1)
                {
                    poz = i;
                    ok = true;
                }

            }
            if (ok == true)
                Console.WriteLine("Prima pozitie din vector pe care apare k=" + k + " este: " + poz + " .");
            else
                Console.WriteLine("-1");

        }

        static void p3()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int minim = v[0];
            int maxim = v[0];
            int[] pozminim = new int[n];
            int[] pozmaxim = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (v[i] >= maxim)
                    maxim = v[i];

                if (v[i] <= minim)
                    minim = v[i];
            }
            for (int i = 0; i < n; i++)
            {
                if (v[i] == maxim)
                    pozmaxim[i]++;
                if (v[i] == minim)
                    pozminim[i]++;
            }
            Console.Write("Cel mai mic element al vectorului se afla pe poz: ");
            for (int a = 0; a < n; a++)
            {
                if (pozminim[a] != 0)
                    Console.Write(a + " ");
            }
            Console.WriteLine();

            Console.Write("Cel mai mare element al vectorului se afla pe poz: ");
            for (int b = 0; b < n; b++)
            {
                if (pozmaxim[b] != 0)
                    Console.Write(b + " ");
            }

        }

        static void p4()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int minim = v[0];
            int nrmin = 0;
            int maxim = v[0];
            int nrmax = 0;
            for (int i = 0; i < n; i++)
            {
                if (minim >= v[i])
                {
                    if (minim == v[i])
                        nrmin++;
                    if (minim > v[i])
                    {
                        minim = v[i];
                        nrmin = 1;
                    }
                }
                if (maxim <= v[i])
                {
                    if (maxim == v[i])
                        nrmax++;
                    if (maxim < v[i])
                    {
                        maxim = v[i];
                        nrmax = 1;
                    }
                }
            }
            Console.WriteLine("Cea mai mica valoare a vectorului este: " + minim + " si apare de " + nrmin + " ori.");
            Console.WriteLine("Cea mai mare valoare a vectorului este: " + maxim + " si apare de " + nrmax + " ori.");
        }

        static void p5()
        {
            int n = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int aux = 0;
            int aux2 = 0;
            int[] v = new int[n + 1];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);

            }
            for (int i = 0; i <= n; i++)
            {
                if (i == k)
                {
                    aux = v[i];
                    v[i] = e;
                }
                if (i > k)
                {
                    aux2 = v[i];
                    v[i] = aux;
                    aux = aux2;
                }
            }
            for (int i = 0; i <= n; i++)
            {

                Console.Write(v[i] + " ");
            }

        }

        static void p6()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);

            }
            for (int i = k; i < n; i++)
            {
                if (i == n - 1)
                {
                    v[i] = '\0';
                    break;
                }
                v[i] = v[i + 1];

            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }

        static void p7()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int aux = 0;
            int a = 1;
            for (int i = 0; i < n / 2; i++)
            {

                aux = v[i];
                v[i] = v[n - a];
                v[n - a] = aux;
                a++;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }

        static void p8()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int aux = v[0];
            for (int i = 0; i < n - 1; i++)
                v[i] = v[i + 1];
            v[n - 1] = aux;
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }

; }

        static void p9()
        {

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            for (int j = 1; j <= k; j++)
            {
                int aux = v[0];
                for (int i = 0; i < n - 1; i++)
                    v[i] = v[i + 1];
                v[n - 1] = aux;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }

        }

        static void p10()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int left = 0;
            int right = n - 1;
            int sol = -1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (v[mid] == k)
                {
                    sol = mid;
                    break;
                }
                if (v[mid] > k)
                { right = mid - 1; }
                if (v[mid] < k)
                { left = mid + 1; }

            }
            Console.WriteLine(sol);
            Console.ReadKey();

        }
        static void p11()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] v = new bool[n];
            int idx = 2;
            Console.Write(idx + " ");
            do
            {
                int k = 1;


                while (idx * k < n)
                {
                    v[idx * k] = true;
                    k++;
                }

                while (v[idx])
                    idx++;
                Console.Write(idx + " ");
            } while (idx < n - 1);
            Console.WriteLine(idx);

        }

        static void p12()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int aux;
            for (int step = 0; step < n - 1; step++)
            {
                int minim = step;
                for (int i = step + 1; i < n; i++)
                {
                    if (v[i] < v[minim])
                        minim = i;
                }
                aux = v[minim];
                v[minim] = v[step];
                v[step] = aux;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }

        static void p13()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int j, key;
            for (int i = 1; i < n; i++)
            {
                key = v[i];
                j = i - 1;
                while (j >= 0 && v[j] > key)
                {
                    v[j + 1] = v[j];
                    j--;
                }
                v[j + 1] = key;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }

        static void p14()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int left = 0;
            int right = n - 1;
            while (left <= right)
            {
                if (v[left] == 0)
                {
                    int aux = v[right];
                    v[right] = v[left];
                    v[left] = aux;
                    right--;
                }
                else
                    left++;
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }
        static void p15()
        {
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int k = n - 1;
            for (int i = 1; i < k; i++)
            { bool ok = false;
                for (int j = 0; j < i; j++)
                    if (v[i] == v[j])
                    { ok = true;
                        break;
                    }
                if (ok)
                {
                    int aux = v[i];
                    v[i] = v[k];
                    v[k] = aux;
                    k--;
                    i--;
                }
            }
            for (int i = 0; i < k; i++)
                Console.Write(v[i] + " ");

        }

        static void p16()
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            string[] t = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            int d = v[0];
            int r;
            for (int i = 1; i < n; i++)
            {
                r = d % v[i];
                while (r > 0)
                {
                    d = v[i];
                    v[i] = r;
                    r = d % v[i];
                }
                d = v[i];
            }
            Console.WriteLine(d);
        }

        /*static void p17()
        {
            double n=double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            ulong pi = (ulong)n;
            double pf=n-(double)pi;
            double[] vi = new double[100];
            double[] vf=new double[100];
            int lungime = 0;
            int i = 0;
            ulong c, r;
        }*/
        static void p17()
        {
            int n = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int i = 0;
            int lungime = 0;
            int c, r;
            c = n / b;
            int[] v = new int[n];
            while (c > 0)
            {
                r = n % b;
                v[i++] = r;
                lungime++;
                n = c;
                c = n / b;
                if (c == 0)
                {
                    r = n % b;
                    v[i++] = r;
                    lungime++;
                }
            }
            for (i = lungime; i >= 0; i--)
                Console.Write(v[i] + " ");

        }


        static double val(double[] P, double x)
        {
            double suma = 0;
            for (int i = 0; i < P.Length; i++)
                suma += P[i] * Math.Pow(x, i);
            return suma;
        }
        static void p18()
        {
            TextReader load = new StreamReader(@"..\..\polinom.txt");

            int n = int.Parse(load.ReadLine());
            double[] P = new double[n];
            string[] t = load.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                P[i] = double.Parse(t[i]);
            }
            double x = double.Parse(load.ReadLine());
            Console.Write(val(P, x).ToString());
            Console.ReadKey();

        }

        static void p19()
        {
            TextReader load = new StreamReader(@"..\..\vectori.txt");

            string[] t1 = load.ReadLine().Split(' ');
            int[] s = new int[t1.Length];
            for (int i = 0; i < t1.Length; i++)
                s[i] = int.Parse(t1[i]);

            string[] t2 = load.ReadLine().Split(' ');
            int[] p = new int[t2.Length];
            for (int i = 0; i < t2.Length; i++)
                p[i] = int.Parse(t2[i]);
            int nr = 0;
            for (int i = 0; i < s.Length - p.Length + 1; i++)
            {
                if (s[i] == p[0])
                {
                    bool ok = true;
                    for (int j = 1; j < p.Length; j++)
                        if (p[j] != s[i + j])
                            ok = false;
                    if (ok) nr++;
                }
            }
            Console.Write(nr);
        }

        static void p20()
        {
            TextReader load = new StreamReader(@"..\..\margele.txt");

            string[] t1 = load.ReadLine().Split(' ');
            int[] s1 = new int[t1.Length];
            for (int i = 0; i < t1.Length; i++)
                s1[i] = int.Parse(t1[i]);

            string[] t2 = load.ReadLine().Split(' ');
            int[] s2 = new int[t2.Length];
            for (int i = 0; i < t2.Length; i++)
                s2[i] = int.Parse(t2[i]);
            int max = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                int s = 0;
                for (int j = 0; j < s2.Length; j++)
                    if (s1[(i + j) % s1.Length] == s2[j])
                        s++;
                if (s > max) max = s;
            }
            Console.Write(max);
            Console.ReadKey();
        }

        static int check(int[] s1, int[] s2)
        {
            int min = s1.Length;
            if (s2.Length < min) min = s2.Length;
            for (int i = 0; i < min; i++)
                if (s1[i] != s2[i])
                {
                    if (s1[i] > s2[i])
                        return 1;
                    else
                        return -1;
                }
            if (s1.Length == min && s2.Length == min)
                return 0;
            if (s1.Length == min)
                return -1;
            else
            if (s2.Length == min)
                return 1;
            else
                return 0;

        }
        static void p21()
        {
            string[] t1 = Console.ReadLine().Split(' ');
            int[] s1 = new int[t1.Length];
            for (int i = 0; i < t1.Length; i++)
                s1[i] = int.Parse(t1[i]);
            string[] t2 = Console.ReadLine().Split(' ');
            int[] s2 = new int[t1.Length];
            for (int i = 0; i < t2.Length; i++)
                s2[i] = int.Parse(t2[i]);
            Console.Write(check(s1, s2));
        }

        static void p22()
        {
            string[] t1 = Console.ReadLine().Split(' ');
            int[] v1 = new int[t1.Length];
            for (int i = 0; i < t1.Length; i++)
                v1[i] = int.Parse(t1[i]);
            string[] t2 = Console.ReadLine().Split(' ');
            int[] v2 = new int[t2.Length];
            for (int i = 0; i < t2.Length; i++)
                v2[i] = int.Parse(t2[i]);
            int lungime = t1.Length + t2.Length;
            int[] N = new int[lungime];
            int[] U = new int[lungime];
            int[] D1 = new int[lungime];
            int[] D2 = new int[lungime];
            int a = 0, nl = 0;
            for (int i = 0; i < t1.Length; i++)
            {
                for (int j = 0; j < t2.Length; j++)
                    if (v1[i] == v2[j])
                    {
                        N[a++] = v1[i];
                        nl++;
                    }
            }
            for (a = 0; a < nl; a++)
                Console.Write(N[a] + " ");
            Console.WriteLine();

            int b = 0;
            for (int i = 0; i < t1.Length; i++)
            {
                U[b++] = v1[i];
            }
            for (int i = 0; i < t2.Length; i++)
            {
                U[b++] = v2[i];
            }
            for (b = 0; b < lungime; b++)
                Console.Write(U[b] + " ");
            Console.WriteLine();

            int c = 0;
            for (int i = 0; i < t1.Length; i++)
            {
                bool d1 = true;
                for (int j = 0; j < t2.Length; j++)
                {

                    if (v1[i] == v2[j])
                    {
                        d1 = false;
                    }

                }
                if (d1)
                {
                    D1[c] = v1[i];
                    c++;
                }
            }
            for (int i = 0; i < c; i++)
                Console.Write(D1[i] + " ");
            Console.WriteLine();

            int d = 0;
            for (int i = 0; i < t2.Length; i++)
            {
                bool d2 = true;
                for (int j = 0; j < t1.Length; j++)
                {

                    if (v2[i] == v1[j])
                    {
                        d2 = false;
                    }
                }
                if (d2)

                    D2[d++] = v2[i];
            }
            for (int i = 0; i < d; i++)
                Console.Write(D2[i] + " ");

        }

        static void p23()
        {
            string[] t1 = Console.ReadLine().Split(' ');
            int[] v1 = new int[t1.Length];
            for (int i = 0; i < t1.Length; i++)
                v1[i] = int.Parse(t1[i]);
            string[] t2 = Console.ReadLine().Split(' ');
            int[] v2 = new int[t2.Length];
            for (int i = 0; i < t2.Length; i++)
                v2[i] = int.Parse(t2[i]);
            int lungime = t1.Length + t2.Length;
            int[] N = new int[lungime];
            int[] U = new int[lungime];
            int[] D1 = new int[lungime];
            int[] D2 = new int[lungime];
            int a = 0, nl = 0;
            for (int i = 0; i < t1.Length; i++)
            {
                for (int j = 0; j < t2.Length; j++)
                    if (v1[i] == v2[j])
                    {
                        N[a++] = v1[i];
                        nl++;
                    }
            }
            for (a = 0; a < nl; a++)
                Console.Write(N[a] + " ");
            Console.WriteLine();

            int b = 0;
            for (int i = 0; i < t1.Length; i++)
            {
                U[b++] = v1[i];
            }
            for (int i = 0; i < t2.Length; i++)
            {
                U[b++] = v2[i];
            }
            for (b = 0; b < lungime; b++)
                Console.Write(U[b] + " ");
            Console.WriteLine();

            int c = 0;
            for (int i = 0; i < t1.Length; i++)
            {
                bool d1 = true;
                for (int j = 0; j < t2.Length; j++)
                {

                    if (v1[i] == v2[j])
                    {
                        d1 = false;
                    }

                }
                if (d1)
                {
                    D1[c] = v1[i];
                    c++;
                }
            }
            for (int i = 0; i < c; i++)
                Console.Write(D1[i] + " ");
            Console.WriteLine();

            int d = 0;
            for (int i = 0; i < t2.Length; i++)
            {
                bool d2 = true;
                for (int j = 0; j < t1.Length; j++)
                {

                    if (v2[i] == v1[j])
                    {
                        d2 = false;
                    }
                }
                if (d2)

                    D2[d++] = v2[i];
            }
            for (int i = 0; i < d; i++)
                Console.Write(D2[i] + " ");

        }

        static void p25()
        {
            string[] t1 = Console.ReadLine().Split(' ');
            int[] v1 = new int[t1.Length];
            for (int i = 0; i < t1.Length; i++)
                v1[i] = int.Parse(t1[i]);
            string[] t2 = Console.ReadLine().Split(' ');
            int[] v2 = new int[t2.Length];
            for (int i = 0; i < t2.Length; i++)
                v2[i] = int.Parse(t2[i]);
            int[] F = new int[t1.Length + t2.Length];
            int f = 0;
           
            for (int i = 0; i < t1.Length; i++)
            {
                F[f++] = v1[i];
            }
            for (int i = 0; i < t2.Length; i++)
            {
                F[f++] = v2[i];
            }
            int key,j;
            for (int i = 1; i < t1.Length+t2.Length; i++)
            {
                key = F[i];
                j = i - 1;
                while(j>= 0 && F[j]>key)
                {
                    F[j + 1] = F[j];
                    j--;
                }
                F[j+1] = key;
            }
            for(int i=0;i<t1.Length+t2.Length;i++)
                Console.Write(F[i]+" ");
        }

       static  int[] QuickSort(int[] v, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = v[left];
            while (i <= j)
            {
                while (v[i] < pivot)
                {
                    i++;
                }

                while (v[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = v[i];
                    v[i] = v[j];
                    v[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuickSort(v, left, j);
            if (i < right)
                QuickSort(v, i, right);
            return v;
        }
       
        static void p28()
        {
            int n = int.Parse(Console.ReadLine());
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            QuickSort(v, 0, n - 1);
            for (int i=0;i<n;i++)
            {
                Console.Write(v[i] +" ");
            }
        }



        static void Merge(int[] v, int left, int m, int right)
        {
            int n1 = m - left + 1;
            int n2 = right - m;
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;
            for(i=0;i<n1;i++)
            {
                L[i] = v[left +i];
            }
            for(j=0;j<n2;j++)
            {
                R[j] = v[m +j+ 1];
            }
            i = 0;
            j = 0;
            int k = left;
            while(i<n1 && j<n2)
            {
                if (L[i] <= R[j])
                {
                    v[k] = L[i];
                    i++;
                }
                else
                {
                    v[k] = R[j];
                    j++;
                }
                k++;
            }
            while(i<n1)
            {
                v[k] = L[i];
                i++; k++;
            }
            while(j<n2)
            {
                v[k] = R[j];
                j++; k++;
            }
        }
       static void Sort(int[] v, int left, int right)
        {
            if(left<right)
            {
                int m = left + (right - left) / 2;
                Sort(v, left, m);
                Sort(v, m+1, right);
                Merge(v, left, m, right);
            }
            
        }
        static void p29()
        {
            int n = int.Parse(Console.ReadLine());
            string[] t = Console.ReadLine().Split(' ');
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(t[i]);
            }
            Sort(v, 0, n-1);
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul problemei:");
            int nrp = int.Parse(Console.ReadLine());
            if (nrp == 1)
            {
                Console.WriteLine("Problema " + nrp);
                p1();
            }
            if (nrp == 2)
            {
                Console.WriteLine("Problema " + nrp);
                p2();
            }
            if (nrp == 3)
            {
                Console.WriteLine("Problema " + nrp);
                p3();
            }
            if (nrp == 4)
            {
                Console.WriteLine("Problema " + nrp);
                p4();
            }
            if (nrp == 5)
            {
                Console.WriteLine("Problema " + nrp);
                p5();
            }
            if (nrp == 6)
            {
                Console.WriteLine("Problema " + nrp);
                p6();
            }
            if (nrp == 7)
            {
                Console.WriteLine("Problema " + nrp);
                p7();
            }
            if (nrp == 8)
            {
                Console.WriteLine("Problema " + nrp);
                p8();
            }
            if (nrp == 9)
            {
                Console.WriteLine("Problema " + nrp);
                p9();
            }
            if (nrp == 10)
            {
                Console.WriteLine("Problema " + nrp);
                p10();
            }
            if (nrp == 11)
            {
                Console.WriteLine("Problema " + nrp);
                p11();
            }
            if (nrp == 12)
            {
                Console.WriteLine("Problema " + nrp);
                p12();
            }
            if (nrp == 13)
            {
                Console.WriteLine("Problema " + nrp);
                p13();
            }
            if (nrp == 14)
            {
                Console.WriteLine("Problema " + nrp);
                p14();
            }
            if (nrp == 15)
            {
                Console.WriteLine("Problema " + nrp);
                p15();
            }
            if (nrp == 16)
            {
                Console.WriteLine("Problema " + nrp);
                p16();
            }
            if (nrp == 17)
            {
                Console.WriteLine("Problema " + nrp);
                p17();
            }
            if (nrp == 18)
            {
                Console.WriteLine("Problema " + nrp);
                p18();
            }
            if (nrp == 19)
            {
                Console.WriteLine("Problema " + nrp);
                p19();
            }
            if (nrp == 20)
            {
                Console.WriteLine("Problema " + nrp);
                p20();
            }
            if (nrp == 21)
            {
                Console.WriteLine("Problema " + nrp);
                p21();
            }
            if (nrp == 22)
            {
                Console.WriteLine("Problema " + nrp);
                p22();
            }
            if (nrp == 23)
            {
                Console.WriteLine("Problema " + nrp);
                p23();
            }
            if (nrp == 24)
            {
                Console.WriteLine("Problema " + nrp);
                //p24();
            }
            if (nrp == 25)
            {
                Console.WriteLine("Problema " + nrp);
                p25();
            }
            if (nrp == 26)
            {
                Console.WriteLine("Problema " + nrp);
                //p26();
            }
            if (nrp == 27)
            {
                Console.WriteLine("Problema " + nrp);
                //p27();
            }
            if (nrp == 28)
            {
                Console.WriteLine("Problema " + nrp);
                p28();
            }
            if (nrp == 29)
            {
                Console.WriteLine("Problema " + nrp);
                p29();
            }
            Console.ReadKey();
        }
    }
}
