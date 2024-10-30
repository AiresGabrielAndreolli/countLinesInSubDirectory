using System.IO;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{

    internal class Program
    {


        static void listaDiretorio(string diretorio)
        {


            foreach (string files in Directory.GetFiles(diretorio, "*.html"))
            {
                Console.WriteLine(files);
                Console.WriteLine(countLinha(files));

            }


            foreach (string dir in Directory.GetDirectories(diretorio))
            {
 //               Console.WriteLine(dir);
                listaDiretorio(dir);
            }

        }

        static int countLinha(string caminho)
        {
            int cont = 0;
            string line;
            StreamReader sr = new StreamReader(caminho);
            //Read the first line of text
            line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                line = sr.ReadLine();
                
                cont++;
            }
            //close the file
            sr.Close();

            return cont;
        }


        static void Main(string[] args)
        {
            string caminho = @"..\";
            listaDiretorio(caminho);
            Console.ReadLine();   
        }
    }
}