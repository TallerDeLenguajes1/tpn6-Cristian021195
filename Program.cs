using System;

namespace tpn5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int cond;
            string texto, texto2, texto3, suma;
            Console.WriteLine("Escriba el numero a invertir > 0");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {

                Console.WriteLine("{0}", invertir(n));
            }
            else { Console.WriteLine("Menor que cero"); }


            do {
                Console.WriteLine("1 sumar - 2 restar - 3 multiplicar - 4 dividir - 5 ABS - 6 POW - 7 SQRT - 8 SIN - 9 COS - 10 TRUNCATE - 11 MIN MAX - 0 SALIR");
                cond = Convert.ToInt32(Console.ReadLine());
                if (cond == 1) { Console.WriteLine("{0}", operar(cond)); }
                else if (cond == 2) { Console.WriteLine("{0}", operar(cond)); }
                else if (cond == 3) { Console.WriteLine("{0}", operar(cond)); }
                else if (cond == 4) { Console.WriteLine("{0}", operar(cond)); }
                else if (cond == 5) { Console.WriteLine("{0}", operar(cond)); }
                else if (cond == 6) { Console.WriteLine("{0}", operar(cond)); }
                else if (cond == 7) { Console.WriteLine("{0}", operar(cond)); }
                else if (cond == 8) { Console.WriteLine("{0}", operar(cond)); }
                else if (cond == 9) { Console.WriteLine("{0}", operar(cond)); }
                else if (cond == 10) { Console.WriteLine("{0}", operar(cond)); }
                else if (cond == 11) { Console.WriteLine("{0}", operar(cond)); }
            } while (cond != 0);

            Console.WriteLine("Ingrese el texto a analizar: ");
            texto = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo texto a analizar: ");
            texto2 = Console.ReadLine();
            char[] caracteres = texto.ToCharArray();
            foreach (char c in caracteres) {
                Console.WriteLine(c);
            }


            if (texto.Contains("a")) {
                Console.WriteLine("Si el texto 1 de {0}" + texto.Length + " caracteres si contiene la letra A: ");
                Console.WriteLine(texto + " || " + texto2);
                string resultado = "";
                resultado = texto.Substring(
                        texto.IndexOf("una") + 1,
                        texto.Length - texto.IndexOf("una") - 1);
                Console.WriteLine(resultado);
                Console.WriteLine(resultado.ToUpper());
                Console.WriteLine(resultado.ToLower());
                if (String.Compare(texto, texto2) == 1) {
                    Console.WriteLine("LAS ENTRADAS SON IGUALES!");
                }
            }
            Console.WriteLine("Ingrese el texto 3 a analizar: ");
            texto3 = Console.ReadLine();
            string[] arr = texto3.Split("/");
            foreach (string _arr in arr) { 
                Console.WriteLine(_arr);
            }

            Console.WriteLine("Ingrese la suma en texto A+B: ");
            suma = Console.ReadLine();
            int sum=0;
            int ab, bc;
            string[] arr_sum = suma.Split("+");

            ab = Convert.ToInt32(arr_sum[0]);
            bc = Convert.ToInt32(arr_sum[1]);

            sum = ab + bc;
            Console.WriteLine("A+B = "+sum);
        }
        public static string operar(int cond) {
            float a, b, x;
            string res="";
            Console.WriteLine("primer numero: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("segundo numero: ");
            b = float.Parse(Console.ReadLine());
            if (cond == 1) { x = a + b; res = "La suma de A:"+a+" + B: "+b+" Es: "+x.ToString(); }
            else if (cond == 2) { x = a - b; res = x.ToString(); }
            else if (cond == 3) { x = a * b; res = x.ToString(); }
            else if (cond == 4) { x = a / b; res = x.ToString(); }
            else if (cond == 5) { if (a < 0) { x = a * -1; } else { x = a; } res = x.ToString(); }
            else if (cond == 6) {
                double aux, aux2;
                aux = Convert.ToDouble(a);
                aux2 = Math.Pow(aux,aux); res = aux2.ToString(); 
            }
            else if (cond == 7) {
                double aux, aux2;
                aux = Convert.ToDouble(a);
                aux2 = Math.Sqrt(aux); res = aux2.ToString();
            }
            else if (cond == 8) {
                double aux = Convert.ToDouble(a);
                double aux2 = (aux * (Math.PI)) / 180;
                aux2 = Math.Sin(aux2);
                res = aux2.ToString();
            }
            else if (cond == 9) {
                double aux = Convert.ToDouble(a);
                double aux2 = (aux * (Math.PI)) / 180;
                aux2 = Math.Cos(aux2);
                res = aux2.ToString();
            }
            else if (cond == 10) {
                double aux = Convert.ToDouble(a);
                res = Math.Floor(aux).ToString();
            }
            else if (cond == 11) {
                float min, max;
                if (a < b)
                {
                    max = b;
                    min = a;
                }
                else {
                    max = a;
                    min = b;
                }
                res = "MAX: " + max + "MIN: " + min;
            }
            return res;
        }
        public static string invertir(int n) {
            int nuevo=0;
            string res = "";
            while (n != 0) {
                nuevo = n % 10;
                n /= 10;
                res += nuevo.ToString();
            }
            return res;
        }
    }
}
