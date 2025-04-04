using System;

namespace lesson
{
    public class Program
    {
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            //LessonInformation();

            Console.WriteLine("Ora gli esercizi");
            //esercizio1();
            Console.WriteLine();
            //esercizio2();
            Console.WriteLine();
            //esercizio3();
            Console.WriteLine();
            //esercizio4();
            Console.WriteLine();
            //esercizio5();
            Console.WriteLine();
            esercizio6();
        }

        /// <summary>
        /// carica un arrauy d n celle, chiedendo in input tutti i valori
        /// </summary>
        /// <param name="n">Il numero di celle da creare nell'array</param>
        /// <returns>L'array risultato</returns>
        private static int[] loadArray(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Il numero deve essere maggiore di 0");
                return new int[] {};
            }else
            {
                int[] result = new int[n];
                for (int i = 0; i < result.Length; i++)
                {
                    Console.Write($"inserire numero array {i}: ");
                    result[i] = Convert.ToInt32(Console.ReadLine());
                }
                return result;
            }
           
        }

        /// <summary>
        /// creo una matrice
        /// </summary>
        /// <param name="row">righe della matrice</param>
        /// <param name="col">colonne della matrice</param>
        /// <returns></returns>
        private static int[,] loadMatrix(int row,int  col)
        {
            if (row < 0 || col<0)
            {
                Console.WriteLine("Il numero deve essere maggiore di 0");
                return new int[,] { };
            }
            else
            {
                int[,] result = new int[row, col];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j<col; j++)
                    {
                        Console.Write($"inserire numero Matrix[{i},{j}]: ");
                        result[i,j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                return result;
            }
        }


        /// <summary>
        /// stampa l'array creato in precedenza
        /// </summary>
        /// <param name="array">array da stampare</param>
        private static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"array{i} -> {array[i]}\n");
            }
        }

        private static void printMatrix(int[,] matrix)
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j< col; j++)
                {
                    Console.Write($"Matrix[{i},{j}] -> {matrix[i,j]}");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// copiare l'array in un secondo
        /// </summary>
        private static void esercizio1()
        {
            Console.WriteLine("Digitare N: ");
            int n=Convert.ToInt32(Console.ReadLine());

            int[] arrayA = loadArray(n);
            int[] arrayB = new int[n];

            //copiamo
            for(int i = 0;i < arrayA.Length;i++)
            {
                arrayB[i]=arrayA[i];
            }

            //stampiamo
            Console.WriteLine("ArrayA:");
            printArray(arrayA);

            Console.WriteLine();
            //stampiamo copiato
            Console.WriteLine("ArrayB:");
            printArray(arrayB);
        }

        /// <summary>
        /// copia gli elementi in un secondo array invertendoli 
        /// </summary>
        private static void esercizio2()
        {
            Console.WriteLine("Digitare N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arrayA = loadArray(n);
            int[] arrayB = new int[n];

            for (int i = 0; i<arrayA.Length; i++)
            {
                arrayB[i] = arrayA[arrayA.Length-i-1];
            }

            //stampiamo
            Console.WriteLine("ArrayA:");
            printArray(arrayA);

            Console.WriteLine();
            //stampiamo copiato
            Console.WriteLine("ArrayB:");
            printArray(arrayB);
        }


        /// <summary>
        /// copiare gli elemti invertiti senza usare un secondo array
        /// </summary>
        private static void esercizio3()
        {
            Console.WriteLine("Digitare N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arrayA = loadArray(n);

            //stampiamo
            Console.WriteLine("ArrayA:");
            printArray(arrayA);

            int temp;
            for (int i = 0; i<arrayA.Length/2; i++)
            {
                temp = arrayA[i];
                arrayA[i] = arrayA[arrayA.Length - i - 1];
                arrayA[arrayA.Length - i - 1] = temp;
            }

            Console.WriteLine("ArrayA Invertito:");
            printArray(arrayA);
        }

        /// <summary>
        /// valore maggiore e minore
        /// </summary>
        private static void esercizio4()
        {
            Console.WriteLine("Digitare N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arrayA = loadArray(n);
            int massimoInt = int.MinValue;
            int minimoInt = int.MaxValue;

            for (int i = 0;i<arrayA.Length;i++)
            {
                if (massimoInt < arrayA[i])
                {
                    massimoInt = arrayA[i];
                }
                else if (minimoInt > arrayA[i])
                {
                    minimoInt = arrayA[i];
                }
            }
            Console.WriteLine("Il valore maggiore è: " + massimoInt);
            Console.WriteLine("Il valore minore è: " + minimoInt);
        }

        /// <summary>
        /// calcolare la somma di due matrici richieste in input nella stessa posizione
        /// </summary>
        private static void esercizio5()
        {
            Console.WriteLine("Digitare le righe: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digitare le colonne: ");
            int col = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = loadMatrix (row, col);
            int[,] matrix2 = loadMatrix (row, col);

            int[,] matrixResult = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrixResult[i,j] = matrix1[i, j]+matrix2[i,j];
                }
            }

            printMatrix(matrixResult);
        }

        /// <summary>
        /// conta il numero di occorrenze di un valore preso in input all'interno della matrice 
        /// </summary>
        private static void esercizio6()
        {
            Console.WriteLine("Digitare le righe: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digitare le colonne: ");
            int col = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digitare il numero da cercare ");
            int num = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = loadMatrix(row, col);

            int cont = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix[i,j] == num)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine($"Il numero da cercare {num} compare: " + cont);
        }

        /// <summary>
        /// Informazioni relative alla lezione
        /// </summary>
        private static void LessonInformation()
        {
            Console.WriteLine("Esercitazione 3 - .NET Console");

            Console.WriteLine();
            Console.WriteLine("I tipo primitivi");
            Console.WriteLine(@"Sono i tipi di dato elementare che non possono essere scomposti 
            in pù tipi semplici. 
            Esempio:
            - bool
            -char 
            string
            -int 
            (sono indicati tutti dal colore blu scuro)");

            Console.WriteLine();
            Console.WriteLine("I tipo derivato");
            Console.WriteLine(@"Composti dall'unione di tipi primitivi in diverse maniere:
            esempio:
            -array (di qualsiasi dimensione)
            -struct -> tipi prim. allocati in maniera non omogenea
            -classi -> allocati in maniera omogenea, seguono regole programmazione ad oggetti");

            Console.WriteLine();
            Console.WriteLine("Gli array");
            Console.WriteLine(@"Variabile che consiste nell'allocazione contigua di celle (una attaccata all'altra) di memoria
            che contengono valori appartenenti allo stesso tipo primitivo
            array monodimensionale oppure quelli multi come le matrici");
            int[] array = { 1, 2, 3 }; //inizializzazione diretta dell'array
            //int[] array = {}; inizializzare un vettore vuoto

            int[] array2 = new int[10]; //inizializzazione array vuoto di lunghezza 10. Tutte le celle sono a 0

            //le dimensioni non devono essere per forza delle costanti
            // vanno anche bene delle variabili
            int n = 10;
            int[] array3 = new int[n];
            //metodo per allungare array senza perdere i valori già inseriti
            Array.Resize(ref array3, n*2);//ref -> indica la "referenza" indirizzo la variabile 

            Console.WriteLine(@"Per accedere ad una cella dell'array usiamo la notazione
            array[indice]");
            array[0] = 1;//imposto 
            Console.WriteLine(array[0]);//leggo 
            int i = 1;
            Console.WriteLine($"array[{i}] -> {array[i]}"); // posso passare anche variabile per l'indice

            Console.WriteLine();
            Console.WriteLine("Matrici");
            Console.WriteLine(@"Array multi-dimensionale avente N dimensioni");
            //inizializzazione diretta
            int[,] matrix2D =
            {
                { 1, 2 },
                { 3, 4 },
            };
            //inizializzazione con zero-values
            int[,] matrix2DZero = new int[10,10];

            //assegnamento
            matrix2D[0, 1] = 1;


        }
    }
}
