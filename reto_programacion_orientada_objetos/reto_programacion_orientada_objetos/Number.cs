using System;
using System.Collections.Generic;
using System.Text;

namespace reto_programacion_orientada_objetos
{
    public class Number
    {
        private int width;
        private int height;
        private int nChar;
        private string[,] numbers;
        private string verLine= "|";
        private string horLine = "_";
        private string space = " ";
       public Number(string n)
        {
            this.width = 3;
            this.height = 3;
            this.nChar = n.Length;
            numbers = new string[height, nChar];
        }
       public Number(int w, int h, string n)
        {
            this.width = w;
            this.height = h;
            this.nChar = n.Length;
            numbers = new string[height, nChar];
        }

        public void SetNumber(string n)
        {
            this.nChar = n.Length;
            for (int i = 0; i < n.Length; i++)
            {
                switch (n[i])
                {
                    case '0': Zero(i);break;
                    case '1': One(i);break;
                    case '2': Two(i);break;
                    case '3': Three(i);break;
                    case '4': Four(i);break;
                    case '5': Five(i);break;
                    case '6': Six(i);break;
                    case '7': Seven(i);break;
                    case '8': Eight(i);break;
                    case '9': Nine(i); break;
                    default: Console.Write("Opcion Invalida");break;
                }
               
            }
        }

        public void Imprimir()
        {
            Console.WriteLine($"\nDimensiones: Altura[{height}], Ancho[{width}]\nCaracteres [{nChar}]");
            string[] a = new string[height];
           for (int i = 0; i < height; i++)//n lines
           {
                for (int j = 0; j < nChar; j++) //col 
                {
                        a[i] += numbers[i, j];     //building a single line
                }
                a[i] += "\n";
            }

            for (int i = 0; i < a.Length; i++) Console.Write(a[i]);
        }
        private void Zero(int position)
        {
            string r1 = ""; 
            string r2 = ""; 
            string r3 = ""; 
            for (int i = 0; i< width; i++) //building horizontal lines
            {
                r1 += (i == 0 || i == width - 1) ? space : horLine;//   _    
                r2+= (i == 0 || i == width - 1) ? verLine : space; //  | |  
                r3 += (i == 0 || i == width - 1) ? verLine : horLine;//|_| 
            }
            for (int i = 0; i< height; i++)//building number with lines
            {
                if (i == 0) numbers[i,position] = r1;
                else if (i == height - 1) numbers[i, position] = r3;
                else numbers[i, position] = r2;
            }
        }
        private void One(int position)
        {
            string r1 = "";
            string r2 = ""; 
            for (int i = 0; i < width; i++) //building horizontal lines
            {
                r1 += space;
                r2+= (i == width-1)?verLine: space;// |
            }

            for (int i = 0; i < height; i++)
            {
                if (i == 0) numbers[i,position] = r1;
                else numbers[i,position] = r2;
            }
        }
        private void Two(int position)
        {
            string r1 = "";
            string r2 = "";
            string r3 = "";
            string r4 = "";
            string r5 = "";
            for(int i = 0; i < width; i++)
            {
                r1 += (i == 0 || i == width - 1) ? space : horLine;        //  _
                r2 += (i == width - 1) ? verLine :(i!=0)? horLine:space ;  //  _|
                r4 += (i == 0) ? verLine : space;                          // |
                r3 += (i == 0) ? verLine : (i != width-1) ? horLine : space;//|_ 
                r5 += (i == width - 1) ? verLine : space;                   //  |

            }
            for(int i = 0; i < height; i++)
            {
                int half = height/2;
                if (i == 0) numbers[i, position] = r1;
                else if (i == height - 1) numbers[i, position] = r3;

                if (height == 3 && i == 1) numbers[i, position] = r2;
                else if (height > 3)
                {
                    if (i == half) numbers[i, position] = r2;
                    else if (i < half && i > 0) numbers[i, position] = r5;
                    else if (i > half && i < height - 1) numbers[i, position] = r4;
                }
            }
        }
        private void Three(int position)
        {
            string r1 = "";
            string r2 = "";
            string r3 = "";
            for (int i = 0; i < width; i++) 
            {
                r1 += (i == 0 || i == width - 1) ? space : horLine;           // _ 
                r2 += (i == width - 1) ? verLine : (i != 0) ? horLine : space;// _|
                r3 += (i == width - 1) ? verLine : space;                     //  |

            }
            for (int i = 0; i < height; i++)
            {
                int half = height / 2;
                if (i == 0) numbers[i, position] = r1;
                else if(i == height-1) numbers[i, position] = r2;
               
                if (height == 3 && i == half) numbers[i, position] = r2;
                else if (height > 3)
                {
                    if (i == half) numbers[i, position] = r2;
                    else if (i < half && i > 0) numbers[i, position] = r3;
                    else if (i > half && i < height-1) numbers[i, position] = r3;
                }
            }
        }
        private void Four(int position)
        {
            string r1 = "";
            string r2 = "";
            string r3 = "";
            string r4 = "";
            for (int i = 0; i < width; i++)
            {
                r1 += space;
                r2 += (i == 0 || i == width - 1) ? verLine : space;//  | |
                r3 += (i == 0 || i == width - 1) ? verLine : horLine;//|_|
                r4 += (i == width - 1) ? verLine : space;            //  |
            }
            for (int i = 0; i < height; i++)
            {
                int half = height / 2;
                if (i == 0) numbers[i, position] = r1;
                else if (i == height - 1) numbers[i, position] = r4;

                if (height == 3 && i == half) numbers[i, position] = r3;
                else if(height > 3)
                {
                    if (i == half) numbers[i, position] = r3;
                    else if (i > 0 && i < half) numbers[i, position] = r2;
                    else if (i > half) numbers[i, position] = r4;
                }
            }
        }
        private void Five(int position)
        {
            string r1 = "";
            string r2 = "";
            string r3 = "";
            string r4 = "";
            string r5 = "";
            for (int i = 0; i < width; i++) 
            {
                r1 += (i == 0 || i == width - 1) ? space : horLine;        //    _
                r2 += (i == 0) ? verLine : (i==width-1)?space:horLine;     //   |_ 
                r3 += (i == 0) ? space : (i == width - 1) ? verLine : horLine;// _|
                r4 += (i == 0) ? verLine : space;                            // |
                r5 += (i == width - 1) ? verLine : space;                    //   |
            }
            for (int i = 0; i < height; i++) 
            {
                int half = height / 2;
                if (i == 0) numbers[i, position] = r1;
                else if (i == height - 1) numbers[i, position] = r3;

                if (height == 3 && i == half) numbers[i, position] = r2;
                else if (height > 3)
                {
                    if (i == half) numbers[i, position] = r2;
                    else if (i < half && i > 0) numbers[i, position] = r4;
                    else if (i > half && i < height - 1) numbers[i, position] = r5;
                }
            }

        }
        private void Six(int position)
        {
            string r1 = "";
            string r2 = "";
            string r3 = "";
            string r4 = "";
            string r5 = "";
            for (int i = 0; i < width; i++)
            {
                r1 += (i == 0 || i == width - 1) ? space : horLine;            // _
                r2 += (i == 0) ? verLine : (i < width - 1) ? horLine : space; // |_
                r3 += (i == 0 || i == width - 1) ? verLine : horLine;         // |_|
                r4 += (i == 0) ? verLine : space; // |  
                r5 += (i == 0 || i == width - 1) ? verLine : space;//| |
            }
            
            for (int i = 0; i < height; i++)
            {
                int half = height / 2;
                if (i == 0) numbers[i, position] = r1;
                else if (i == height - 1) numbers[i, position] = r3;

                if (height == 3 && i == half) numbers[i, position] = r2;
                else if (height > 3)
                {
                    if (i == half) numbers[i, position] = r2;
                    else if (i < half && i > 0) numbers[i, position] = r4;
                    else if (i > half && i < height - 1) numbers[i, position] = r5;
                }
            }
        }
        private void Seven(int position)
        {
            string r1 = "";
            string r2 = "";
            for (int i = 0; i < width; i++)
            {
               r1 += (i == 0 || i == width - 1) ? space : horLine; //_
               r2 += (i == width - 1) ? verLine : space;           // |
            }
            for (int i = 0; i < height; i++)
            {
                if (i == 0) numbers[i, position] = r1;
                else numbers[i, position] = r2;
            }
        }
        private void Eight(int position)
        {
            string r1 = "";
            string r2 = "";
            string r3 = "";
            for (int i = 0; i < width; i++)
            {
                r1 += (i == 0 || i == width - 1) ? space : horLine; //  _
                r2 += (i == 0 || i == width - 1) ? verLine : space;//  | |
                r3 += (i == 0 || i == width - 1) ? verLine : horLine;//|_|
            }
            for (int i = 0; i < height; i++)
            {
                int half = height / 2;
                if (i == 0) numbers[i, position] = r1;
                else if (i == height - 1) numbers[i, position] = r3;

                if (height == 3 && i == half) numbers[i, position] = r3;
                else if(height > 3)
                {
                    if (i == half) numbers[i, position] = r3;
                    else if (i != half && i > 0 && i < height - 1) numbers[i, position] = r2;
                }
                
            }
        }
        private void Nine(int position)
        {
            string r1 = "";
            string r2 = "";
            string r3 = "";
            string r4 = "";
            string r5 = "";
            for (int i = 0; i < width; i++)
            {
                r1 += (i == 0 || i == width - 1) ? space : horLine;           // _
                r2 += (i == 0 || i == width - 1) ? verLine : horLine;        // |_|
                r3 += (i == width - 1) ? verLine : space;                     //  |
                r4 += (i == 0) ? space : (i == width - 1) ? verLine : horLine;// _|
                r5 += (i == 0 || i == width - 1) ? verLine : space;//  | |
            }
            for (int i = 0; i < height; i++)
            {
                int half = height / 2;
                if (i == 0) numbers[i, position] =r1;
                else if(i == height-1) numbers[i, position] =r4;

                if(height == 3 && i == half) numbers[i, position] = r2;
                else if (height > 3)
                {
                    if (i == half) numbers[i, position] = r2;
                    else if (i > 0 && i < half) numbers[i, position] = r5;
                    else if (i > half && i < height - 1) numbers[i, position] = r3;
                }
            }
        }
    }
}
