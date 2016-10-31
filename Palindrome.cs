using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Palindrome {

        //checa se é palindromo recursivamente
        static bool palindrome(String s) {
            if (s.Length == 0 || s.Length == 1) {     //caso base: palava possui tamanho 0 ou 1
                return true;
            }
            else if (s.First().Equals(s.Last())){     //verifica se o primeiro e o ultimo caractere são iguais
                s = s.Substring(1, s.Length - 2);     //retira o primeiro e o ultimo caractere da string
                //Console.WriteLine(s);                 //debug

                return palindrome(s);                //chamada recursiva
            }         
                                    
            return false;                        
                                      
        }

        static void Main(string[] args){
            String s;

            s = Console.ReadLine();

            if (palindrome(s)) {
                Console.WriteLine("é palindromo");
            }
            else {
                Console.WriteLine("não é palindromo");
            }
                      
        }

    }
    
}
