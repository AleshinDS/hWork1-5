using System;
using System.Text;
using System.Collections.Generic;

namespace Ex5_2
{
    //Разработать статический класс Message, содержащий следующие статические методы для
    //обработки текста:
    //а) Вывести только те слова сообщения, которые содержат не более n букв.
    //б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    //в) Найти самое длинное слово сообщения.
    //г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    //д) *** Создать метод, который производит частотный анализ текста.В качестве параметра в
    //него передается массив слов и текст, в качестве результата метод возвращает сколько раз
    //каждое из слов массива входит в этот текст.Здесь требуется использовать класс Dictionary.

    class Program
    {

        static class Message
        {
            private static string[] separators = { ",", ".", " ", "!", "?", ":", ";", ")", "(", "-" };
            public static void Method_A(string message) //пусть n=5
            {
                var words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    if (word.Length <= 5)
                    {
                        Console.WriteLine(word);
                    }
                }
            }
            public static void Method_B(string message) //пусть заданный символ будет "о" (U+043E)"
            {
                var words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                char Ex = '\u043E';

                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i][words[i].Length - 1] == Ex)
                    {
                        words[i] = null;
                    }


                }
                for (int i = 0; i < words.Length; i++)
                {
                    Console.Write(words[i] + " ");
                }
                Console.WriteLine();
            }


            public static void Method_C(string message)
            {
                var words = message.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string word = words[0];
                for (int i = 0; i < words.Length - 1; i++)
                {

                    if (words[i].Length < words[i + 1].Length)
                    {
                        word = words[i + 1];
                    }
                    else
                    {
                        word = words[i];
                    }

                }
                Console.WriteLine(word);
                Console.WriteLine("..............");

                /*Г*/

                StringBuilder result = new StringBuilder();
                int max = word.Length;
                for (int i = 0; i < words.Length - 1; i++)
                {

                    if (words[i].Length == max)
                    {
                        Console.WriteLine(words[i] +" длина слова: "+ words[i].Length + " символов");
                        
                    }



                }

            }
                static void Main(string[] args)
                {

                    string message = "Определение стоимости новой запасной части, установка которой " +
                        "назначается взамен подлежащего замене комплектующего изделия (детали, узла и агрегата), осуществляется " +
                        "путем применения электронных баз данных стоимостной информации (справочников) в отношении деталей (узлов, агрегатов)." +
                        " В случае отсутствия таких баз данных, определение стоимости проводится методом статистического наблюдения среди " +
                        "хозяйствующих субъектов (продавцов), действующих в пределах границ товарного рынка, соответствующего месту " +
                        "дорожно-транспортного происшествия.";
                    Message.Method_A(message);
                    Console.WriteLine("..............");
                    Message.Method_B(message);
                    Console.WriteLine("..............");
                    Message.Method_C(message);
                    Console.WriteLine("..............");



                }


            }
        }
    }


