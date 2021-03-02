using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAlfanumerico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teclado AlfaNumérico");
            string Mensagem = string.Empty;
            string MensagemSwitchCase = string.Empty;


            int[] array = new int[] { 33, 8, 88, 777, 66, 0, 345, 9, 33, 22, 0, 33, 0, 7777, 666, 333, 8, 9, 2, 777, 33, 0, 7777, 666, 555, 88, 8, 444, 666, 66 };

            for (int i = 0; i < array.Length; i++)
            {
                switch (array[i])
                {
                    case 33:
                        MensagemSwitchCase += "E";
                        break;
                    case 8:
                        MensagemSwitchCase += "T";
                        break;
                    case 88:
                        MensagemSwitchCase += "U";
                        break;
                    case 777:
                        MensagemSwitchCase += "R";
                        break;
                    case 66:
                        MensagemSwitchCase += "N";
                        break;
                    case 0:
                        MensagemSwitchCase += " ";
                        break;
                    case 9:
                        MensagemSwitchCase += "W";
                        break;
                    case 666:
                        MensagemSwitchCase += "O";
                        break;
                    case 22:
                        MensagemSwitchCase += "B";
                        break;
                    case 333:
                        MensagemSwitchCase += "F";
                        break;
                    case 7777:
                        MensagemSwitchCase += "S";
                        break;
                    case 2:
                        MensagemSwitchCase += "A";
                        break;
                    case 555:
                        MensagemSwitchCase += "L";
                        break;
                    case 444:
                        MensagemSwitchCase += "I";
                        break;



                }

            }
            Console.WriteLine(Mensagem);
            Console.WriteLine(MensagemSwitchCase);

            Console.ReadKey();
        }
    }
}
