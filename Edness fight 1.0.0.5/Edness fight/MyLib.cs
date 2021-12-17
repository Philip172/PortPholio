using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Numerics;

namespace MyLib
{
    #region Функции, в основном для консольных приложений || Functions mainly for console applications
    //Quick("fast") pasting
    public static class f
    {
        //print & nrint
        #region functions "print" and "nrint", they print some text || функции "print" и "nrint", они печатают какой-либо текст

        //prints like WriteLine
        public static void nrint(bool str)
        {
            Console.WriteLine(str);
        }

        public static void nrint(byte str)
        {
            Console.WriteLine(str);
        }

        public static void nrint(sbyte str)
        {
            Console.WriteLine(str);
        }

        public static void nrint(short str)
        {
            Console.WriteLine(str);
        }

        public static void nrint(ushort str)
        {
            Console.WriteLine(str);
        }

        public static void nrint(int str)
        {
            Console.WriteLine(str);
        }

        public static void nrint(uint str)
        {
            Console.WriteLine(str);
        }

        public static void nrint(long str)
        {
            Console.WriteLine(str);
        }

        public static void nrint(ulong str)
        {
            Console.WriteLine(str);
        }

        public static void nrint(float str)
        {
            Console.WriteLine(str);
        }

        public static void nrint(double str)
        {
            Console.WriteLine(str);
        }

        public static void nrint(decimal str)
        {
            Console.WriteLine(str);
        }

        public static void nrint(char str)
        {
            Console.WriteLine(str);
        }

        public static void nrint(string str)
        {
            Console.WriteLine(str);
        }

        public static void nrint(object str)
        {
            Console.WriteLine(str);
        }



        //prints like Write
        public static void print(bool str)
        {
            Console.Write(str);
        }

        public static void print(byte str)
        {
            Console.Write(str);
        }

        public static void print(sbyte str)
        {
            Console.Write(str);
        }

        public static void print(short str)
        {
            Console.Write(str);
        }

        public static void print(ushort str)
        {
            Console.Write(str);
        }

        public static void print(int str)
        {
            Console.Write(str);
        }

        public static void print(uint str)
        {
            Console.Write(str);
        }

        public static void print(long str)
        {
            Console.Write(str);
        }

        public static void print(ulong str)
        {
            Console.Write(str);
        }

        public static void print(float str)
        {
            Console.Write(str);
        }

        public static void print(double str)
        {
            Console.Write(str);
        }

        public static void print(decimal str)
        {
            Console.Write(str);
        }

        public static void print(char str)
        {
            Console.Write(str);
        }

        public static void print(string str)
        {
            Console.Write(str);
        }

        public static void print(object str)
        {
            Console.Write(str);
        }
        #endregion


        //end
        #region void "end", it Imitates "Console.ReadKey()"
        public static void end()
        {
            Console.ReadKey();
        }
        #endregion


        //Hello World
        #region this function writes "Hello World!" at the Console
        public static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        #endregion
    }
    #endregion



    #region Универсальные функции || Universal functions
    //Safe convertation
    //Безопасная конвертация
    public static class MyConvert
    {
        //toBool
        //Converting to type Bool || Конвертирование в тип Bool
        #region "toBool", it safety converts any type to bool
        public static bool toBool(bool pre_str)
        {
            return pre_str;
        }

        public static bool toBool(byte pre_str)
        {
            if (pre_str > 0)
                return true;
            else
                return false;
        }

        public static bool toBool(sbyte pre_str)
        {
            if (pre_str > 0)
                return true;
            else
                return false;
        }

        public static bool toBool(short pre_str)
        {
            if (pre_str > 0)
                return true;
            else
                return false;
        }

        public static bool toBool(ushort pre_str)
        {
            if (pre_str > 0)
                return true;
            else
                return false;
        }

        public static bool toBool(int pre_str)
        {
            if (pre_str > 0)
                return true;
            else
                return false;
        }

        public static bool toBool(uint pre_str)
        {
            if (pre_str > 0)
                return true;
            else
                return false;
        }

        public static bool toBool(long pre_str)
        {
            if (pre_str > 0)
                return true;
            else
                return false;
        }

        public static bool toBool(ulong pre_str)
        {
            if (pre_str > 0)
                return true;
            else
                return false;
        }

        public static bool toBool(float pre_str)
        {
            if (pre_str > 0)
                return true;
            else
                return false;
        }

        public static bool toBool(double pre_str)
        {
            if (pre_str > 0)
                return true;
            else
                return false;
        }

        public static bool toBool(decimal pre_str)
        {
            if (pre_str > 0)
                return true;
            else
                return false;
        }

        public static bool toBool(char pre_str)
        {
            if (pre_str > 0)
                return true;
            else
                return false;
        }

        public static bool toBool(string pre_str)
        {
            if (pre_str.Replace(" ", "") != "")
                return true;
            else
                return false;
        }

        public static bool toBool(BigInteger pre_str)
        {
            if (pre_str > 0)
                return true;
            else
                return false;
        }
        #endregion


        //toDouble
        //Converting to type Double || Конвертирование в тип Double
        #region "toDouble", it safety converts any type to double
        public static double toDouble(bool pre_str)
        {
            if (pre_str == true)
                return 1;

            return 0;
        }

        public static double toDouble(byte pre_str)
        {
            double.TryParse(pre_str.ToString().Replace(".", ",").Replace(" ", ""), out double str);
            return str;
        }

        public static double toDouble(sbyte pre_str)
        {
            double.TryParse(pre_str.ToString().Replace(".", ",").Replace(" ", ""), out double str);
            return str;
        }

        public static double toDouble(short pre_str)
        {
            double.TryParse(pre_str.ToString().Replace(".", ",").Replace(" ", ""), out double str);
            return str;
        }

        public static double toDouble(ushort pre_str)
        {
            double.TryParse(pre_str.ToString().Replace(".", ",").Replace(" ", ""), out double str);
            return str;
        }

        public static double toDouble(int pre_str)
        {
            double.TryParse(pre_str.ToString().Replace(".", ",").Replace(" ", ""), out double str);
            return str;
        }

        public static double toDouble(uint pre_str)
        {
            double.TryParse(pre_str.ToString().Replace(".", ",").Replace(" ", ""), out double str);
            return str;
        }

        public static double toDouble(long pre_str)
        {
            double.TryParse(pre_str.ToString().Replace(".", ",").Replace(" ", ""), out double str);
            return str;
        }

        public static double toDouble(ulong pre_str)
        {
            double.TryParse(pre_str.ToString().Replace(".", ",").Replace(" ", ""), out double str);
            return str;
        }

        public static double toDouble(float pre_str)
        {
            double.TryParse(pre_str.ToString().Replace(".", ",").Replace(" ", ""), out double str);
            return str;
        }

        public static double toDouble(double pre_str)
        {
            double.TryParse(pre_str.ToString().Replace(".", ",").Replace(" ", ""), out double str);
            return str;
        }

        public static double toDouble(decimal pre_str)
        {
            double.TryParse(pre_str.ToString().Replace(".", ",").Replace(" ", ""), out double str);
            return str;
        }

        public static double toDouble(char pre_str)
        {
            double.TryParse(pre_str.ToString().Replace(".", ",").Replace(" ", ""), out double str);
            return str;
        }

        public static double toDouble(string pre_str)
        {
            double.TryParse(pre_str.ToString().Replace(".", ",").Replace(" ", ""), out double str);
            return str;
        }

        public static double toDouble(object pre_str)
        {
            double.TryParse(pre_str.ToString().Replace(".", ",").Replace(" ", ""), out double str);
            return str;
        }
        #endregion


        //toInt
        //Converting to type Int || Конвертирование в тип Int
        #region "toInt", it safety converts any type to int
        public static int toInt(bool pre_str)
        {
            if (pre_str == true)
                return 1;

            return 0;
        }

        public static int toInt(byte pre_str)
        {
            double.TryParse((pre_str.ToString().Replace(".", "").Replace(" ", "")), out double str);
            int.TryParse(Math.Floor(str).ToString(), out int resultInt);

            return resultInt;
        }

        public static int toInt(sbyte pre_str)
        {
            double.TryParse((pre_str.ToString().Replace(".", "").Replace(" ", "")), out double str);
            int.TryParse(Math.Floor(str).ToString(), out int resultInt);

            return resultInt;
        }

        public static int toInt(short pre_str)
        {
            double.TryParse((pre_str.ToString().Replace(".", "").Replace(" ", "")), out double str);
            int.TryParse(Math.Floor(str).ToString(), out int resultInt);

            return resultInt;
        }

        public static int toInt(ushort pre_str)
        {
            double.TryParse((pre_str.ToString().Replace(".", "").Replace(" ", "")), out double str);
            int.TryParse(Math.Floor(str).ToString(), out int resultInt);

            return resultInt;
        }

        public static int toInt(int pre_str)
        {
            double.TryParse((pre_str.ToString().Replace(".", "").Replace(" ", "")), out double str);
            int.TryParse(Math.Floor(str).ToString(), out int resultInt);

            return resultInt;
        }

        public static int toInt(uint pre_str)
        {
            double.TryParse((pre_str.ToString().Replace(".", "").Replace(" ", "")), out double str);
            int.TryParse(Math.Floor(str).ToString(), out int resultInt);

            return resultInt;
        }

        public static int toInt(long pre_str)
        {
            double.TryParse((pre_str.ToString().Replace(".", "").Replace(" ", "")), out double str);
            int.TryParse(Math.Floor(str).ToString(), out int resultInt);

            return resultInt;
        }

        public static int toInt(ulong pre_str)
        {
            double.TryParse((pre_str.ToString().Replace(".", "").Replace(" ", "")), out double str);
            int.TryParse(Math.Floor(str).ToString(), out int resultInt);

            return resultInt;
        }

        public static int toInt(float pre_str)
        {
            double.TryParse((pre_str.ToString().Replace(".", "").Replace(" ", "")), out double str);
            int.TryParse(Math.Floor(str).ToString(), out int resultInt);

            return resultInt;
        }

        public static int toInt(double pre_str)
        {
            double.TryParse((pre_str.ToString().Replace(".", "").Replace(" ", "")), out double str);
            int.TryParse(Math.Floor(str).ToString(), out int resultInt);

            return resultInt;
        }

        public static int toInt(decimal pre_str)
        {
            double.TryParse((pre_str.ToString().Replace(".", "").Replace(" ", "")), out double str);
            int.TryParse(Math.Floor(str).ToString(), out int resultInt);

            return resultInt;
        }

        public static int toInt(char pre_str)
        {
            double.TryParse((pre_str.ToString().Replace(".", "").Replace(" ", "")), out double str);
            int.TryParse(Math.Floor(str).ToString(), out int resultInt);

            return resultInt;
        }

        public static int toInt(string pre_str)
        {
            double.TryParse((pre_str.ToString().Replace(".", "").Replace(" ", "")), out double str);
            int.TryParse(Math.Floor(str).ToString(), out int resultInt);

            return resultInt;
        }

        public static int toInt(object pre_str)
        {
            double.TryParse((pre_str.ToString().Replace(".", "").Replace(" ", "")), out double str);
            int.TryParse(Math.Floor(str).ToString(), out int resultInt);

            return resultInt;
        }
        #endregion
    }

    //Reverse
    //Переворот
    public static class Reverse
    {
        //Переворот массива
        public static bool[] ReverseAnArray(bool[] array)
        {
            bool[] catchArray = new bool[] { false };
            if (array.Length > 0)
            {
                bool[] newArray = new bool[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[array.Length - i];
                }
                return newArray;
            }
            return catchArray;
        }
    }

    //Проверки
    //Testings
    public static class Testings
    {
        //Проверка, стартовал ли процесс
        public static bool IfProcessStarted(string process)
        {
            var runningProcs = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
            if (runningProcs.Count(p => p.ProcessName.Contains(process)) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    #endregion



    #region Функции для работы с типом string (строками) и походими типами || Fuctions for working with strings and similar types
    public static class MyStrings
    {
        //Delete_unnecessary_spaces
        //Removing extra whitespace from string
        //Удаление лишних пробелом из string
        #region void "Delete_unnecessary_spaces"
        public static string Delete_unnecessary_spaces(string pre_str)
        {
            //Подготовка
            string str = "";
            bool space = true;
            int lastchar = 0;

            //Удаление лишних пробелов
            foreach (char s in pre_str)
            {
                if (s == ' ' && !space)
                {
                    space = true;
                    str += ' ';
                    lastchar++;
                }
                else if (s != ' ')
                {
                    space = false;
                    str += s.ToString();
                    lastchar = 0;
                }
            }

            str = str.Remove(str.Length - lastchar, lastchar);

            return str;
        }
        #endregion


        //AddSomeZeroes
        //Adding the desired zeros
        //Добавление нужных нолей
        #region void "AddSomeZeroes"
        public static string AddSomeZeroes(int number)
        {
            if (number / 10 == 0)
            {
                return "00" + number;
            }
            else if (number / 100 == 0)
            {
                return "0" + number;
            }

            return number.ToString();
        }

        public static string AddSomeZeroes(string pre_number)
        {
            int number = int.Parse(pre_number);
            if (number / 10 == 0)
            {
                return "00" + number;
            }
            else if (number / 100 == 0)
            {
                return "0" + number;
            }

            return number.ToString();
        }
        #endregion


        //GetPowOf10
        //Getting 10 to the right power
        //Получение 10 в нужной степени
        #region void "GetPowOf10"
        public static long GetPowOf10(long power)
        {
            return long.Parse(Math.Pow(10, power).ToString());
        }
        #endregion


        //DivideToGrades
        //Dividing a number into grades
        //Разбиение числа по разрядам
        #region voids "DivideToGrades"
        //Новая версия
        public static string DivideToGrades(long number)
        {
            int powerCount;
            List<string> Grades = new List<string> { };

            #region Выделение разрядов
            //Выделение едениц
            powerCount = 0;
            if (number >= powerCount)
            {
                Grades.Add((number % GetPowOf10(powerCount + 3)).ToString());
            }
            else
                goto linkEnd;

            //Выделение тысяч
            powerCount = 3;
            if (number >= GetPowOf10(powerCount))
            {
                Grades.Add((number % GetPowOf10(powerCount + 3) / GetPowOf10(powerCount)).ToString() + " ");
                Grades[powerCount / 3 - 1] = AddSomeZeroes(Grades[powerCount / 3 - 1]) + " ";
            }
            else
                goto linkEnd;

            //Выделение миллионов
            powerCount = 6;
            if (number >= GetPowOf10(powerCount))
            {
                Grades.Add((number % GetPowOf10(powerCount + 3) / GetPowOf10(powerCount)).ToString() + " ");
                Grades[powerCount / 3 - 1] = AddSomeZeroes(Grades[powerCount / 3 - 1]) + " ";
            }
            else
                goto linkEnd;

            //Выделение миллиардов
            powerCount = 9;
            if (number >= GetPowOf10(powerCount))
            {
                Grades.Add((number % GetPowOf10(powerCount + 3) / GetPowOf10(powerCount)).ToString() + " ");
                Grades[powerCount / 3 - 1] = AddSomeZeroes(Grades[powerCount / 3 - 1]) + " ";
            }
            else
                goto linkEnd;
            #endregion



            //Обзединение разрядов в число
            linkEnd:
            string result = "";
            Grades.Reverse();
            foreach (string grade in Grades)
                result += grade;
            return result;

        }

        //Старая версия
        public static string DivideToGrades_old(int number)
        {
            //99999
            //99 999

            string quadrillions = "", thrillions = "", billions = "", thousands = "", units = "";

            if (number >= Math.Pow(10, 12))
            {
                //123
                quadrillions = (MyConvert.toInt(number % Math.Pow(10, 15) / Math.Pow(10, 12))).ToString();

                //456
                thrillions = AddSomeZeroes(MyConvert.toInt((number % Math.Pow(10, 12) / Math.Pow(10, 9))));

                //789
                billions = AddSomeZeroes(MyConvert.toInt((number % Math.Pow(10, 9) / Math.Pow(10, 6))));

                //12
                thousands = AddSomeZeroes(MyConvert.toInt((number % Math.Pow(10, 6) / Math.Pow(10, 3))));

                //345
                units = AddSomeZeroes(MyConvert.toInt((number % Math.Pow(10, 3) / Math.Pow(10, 0))));

                //Возвращаем разделённое число
                return $"{quadrillions} {thrillions} {billions} {thousands} {units}";
            }

            //456789012345
            //456 789 012 345

            else if (number >= Math.Pow(10, 9))
            {
                //456
                thrillions = (MyConvert.toInt(number % Math.Pow(10, 12) / Math.Pow(10, 9))).ToString();

                //789
                billions = AddSomeZeroes(MyConvert.toInt((number % Math.Pow(10, 9) / Math.Pow(10, 6))));

                //12
                thousands = AddSomeZeroes(MyConvert.toInt((number % Math.Pow(10, 6) / Math.Pow(10, 3))));

                //345
                units = AddSomeZeroes(MyConvert.toInt((number % Math.Pow(10, 3) / Math.Pow(10, 0))));

                //Возвращаем разделённое число
                return $"{thrillions} {billions} {thousands} {units}";
            }

            //789012345
            //789 012 345

            else if (number >= Math.Pow(10, 6))
            {
                //789
                billions = (MyConvert.toInt(number % Math.Pow(10, 9) / Math.Pow(10, 6))).ToString();

                //12
                thousands = AddSomeZeroes(MyConvert.toInt((number % Math.Pow(10, 6) / Math.Pow(10, 3))));

                //345
                units = AddSomeZeroes(MyConvert.toInt((number % Math.Pow(10, 3) / Math.Pow(10, 0))));

                //Возвращаем разделённое число
                return $"{billions} {thousands} {units}";
            }

            //012345
            //12 345

            else if (number >= Math.Pow(10, 3))
            {
                //1
                //99
                //12
                thousands = (MyConvert.toInt(number % Math.Pow(10, 6) / Math.Pow(10, 3))).ToString();

                //345
                units = AddSomeZeroes(MyConvert.toInt((number % Math.Pow(10, 3) / Math.Pow(10, 0))));

                //Возвращаем разделённое число
                return $"{thousands} {units}";
            }
            else
            {
                units = number.ToString();
            }

            //Возвращаем разделённое число
            return units;
        }
        #endregion


        //RewriteFirstLetterUp
        //Rewrite the first letter of words into a capital
        //Переписывание первой буквы слов в большую
        #region void "RewriteFirstLetterUp"
        public static string RewriteFirstLetterUp(char pre_pre_str)
        {
            string pre_str = pre_pre_str.ToString();
            string str = "";
            bool locked = false;
            bool unlocked = true;

            foreach (char s in pre_str)
            {
                if (s != ' ')
                {
                    unlocked = false;
                }
                if (locked)
                {
                    str += s.ToString().ToLower();
                }
                else
                {
                    locked = true;
                    str += s.ToString().ToUpper();
                }
                if (s == ' ' && unlocked)
                {
                    locked = false;
                }

            }
            return str;
        }

        public static string RewriteFirstLetterUp(string pre_pre_str)
        {
            string pre_str = pre_pre_str.ToString();
            string str = "";
            bool locked = false;
            bool unlocked = true;

            foreach (char s in pre_str)
            {
                if (s != ' ')
                {
                    unlocked = false;
                }
                if (locked)
                {
                    str += s.ToString().ToLower();
                }
                else
                {
                    locked = true;
                    str += s.ToString().ToUpper();
                }
                if (s == ' ' && unlocked)
                {
                    locked = false;
                }

            }
            return str;
        }
        #endregion


        //RewriteFirstLetterUpInAllWords
        //Rewrite the first letter of words into a capital in each word
        //Переписывание первой буквы слов в большую в каждом слове
        #region void "RewriteFirstLetterUpInAllWords"
        public static string RewriteFirstLetterUpInAllWords(char pre_pre_str)
        {
            string pre_str = pre_pre_str.ToString();
            string str = "";
            bool locked = false;

            foreach (char s in pre_str)
            {
                if (locked)
                {
                    str += s.ToString().ToLower();
                }
                else
                {
                    locked = true;
                    str += s.ToString().ToUpper();
                }
                if (s == ' ')
                {
                    locked = false;
                }
            }
            return str;
        }

        public static string RewriteFirstLetterUpInAllWords(string pre_pre_str)
        {
            string pre_str = pre_pre_str.ToString();
            string str = "";
            bool locked = false;

            foreach (char s in pre_str)
            {
                if (locked)
                {
                    str += s.ToString().ToLower();
                }
                else
                {
                    locked = true;
                    str += s.ToString().ToUpper();
                }
                if (s == ' ')
                {
                    locked = false;
                }
            }
            return str;
        }
        #endregion


        //Rewrite_to_common_format
        //Remaking string to common format (without unnecessary spaces, all words with a small register)
        //Преобразование string в общий формат (без лишних пробелов, все слова с маленьким регистром)
        #region void "Rewrite_to_common_format"
        public static string Rewrite_to_common_format(char pre_pre_str)
        {
            string pre_str = pre_pre_str.ToString();

            //Подготовка
            string str = "";
            bool space = true;
            int lastchar = 0;

            //Удаление лишних пробелов
            foreach (char s in pre_str)
            {
                if (s == ' ' && !space)
                {
                    space = true;
                    str += ' ';
                    lastchar++;
                }
                else if (s != ' ')
                {
                    space = false;
                    str += s.ToString().ToLower();
                    lastchar = 0;
                }
            }

            str = str.Remove(str.Length - lastchar, lastchar);

            return str;
        }

        public static string Rewrite_to_common_format(string pre_pre_str)
        {
            string pre_str = pre_pre_str.ToString();

            //Подготовка
            string str = "";
            bool space = true;
            int lastchar = 0;

            //Удаление лишних пробелов
            foreach (char s in pre_str)
            {
                if (s == ' ' && !space)
                {
                    space = true;
                    str += ' ';
                    lastchar++;
                }
                else if (s != ' ')
                {
                    space = false;
                    str += s.ToString().ToLower();
                    lastchar = 0;
                }
            }

            str = str.Remove(str.Length - lastchar, lastchar);

            return str;
        }
        #endregion


        //ReverseString
        //Reversing string
        //Переворачивание string
        #region void "ReverseString"
        public static string ReverseString(string pre_str)
        {
            string str = "";

            for (int i = pre_str.Length - 1; i >= 0; i--)
            {
                str += pre_str[i];
            }

            return str;
        }
        #endregion


        //SeverWordsToList; SeverWordsToString
        //Splitting a string by words
        //Разделение строки по словам
        #region voids "SeverWordsTo..."

        #region Метод возвращает лист с разъеденёнными словами, с которым можно работать, подходит также и для вычленения отдельного слова
        public static List<string> SeverWordsToList(string str)
        {
            //Источник строки в аргументах метода

            #region Главный код

            string EndedString = "";


            List<string> strList = new List<string>();


            string strEnd = "";

            #region Удаление лишних пробелов
            //Подготовка
            string RT = "";
            bool space = true;
            int lastchar = 0;

            //Удаление лишних пробелов
            foreach (char ch in str)
            {
                if (ch == ' ' && !space)
                {
                    space = true;
                    RT += ' ';
                    lastchar++;
                }
                else if (ch != ' ')
                {
                    space = false;
                    RT += ch.ToString();
                    lastchar = 0;
                }
            }

            RT = RT.Remove(RT.Length - lastchar, lastchar);

            str = RT;
            #endregion


            #region Анализ
            for (int g = 0; g < str.Length; g++)
            {
                for (; ; g++)
                {
                    if (g != str.Length && str[g] != ' ')
                    {
                        strEnd += str[g];
                    }
                    else
                    {
                        strList.Add(strEnd);
                        strEnd = "";
                        break;
                    }

                }
            }

            for (int i = 0; i < strList.Count; i++)
            {
                EndedString += strList[i] + @"
";
            }
            #endregion


            return strList;//вывод итоговых строк
            #endregion
        }
        #endregion

        #region метод возвращает строку типа string с разъеденёнными словами, с которой можно работать
        public static string SeverWordsToString(string str)
        {
            //Источник строки в аргументах метода

            #region Главный код

            string EndedString = "";


            List<string> strList = new List<string>();


            string strEnd = "";

            #region Удаление лишних пробелов
            //Подготовка
            string RT = "";
            bool space = true;
            int lastchar = 0;

            //Удаление лишних пробелов
            foreach (char ch in str)
            {
                if (ch == ' ' && !space)
                {
                    space = true;
                    RT += ' ';
                    lastchar++;
                }
                else if (ch != ' ')
                {
                    space = false;
                    RT += ch.ToString();
                    lastchar = 0;
                }
            }

            RT = RT.Remove(RT.Length - lastchar, lastchar);

            str = RT;
            #endregion


            #region Анализ
            for (int g = 0; g < str.Length; g++)
            {
                for (; ; g++)
                {
                    if (g != str.Length && str[g] != ' ')
                    {
                        strEnd += str[g];
                    }
                    else
                    {
                        strList.Add(strEnd);
                        strEnd = "";
                        break;
                    }

                }
            }

            for (int i = 0; i < strList.Count; i++)
            {
                EndedString += strList[i] + @"
";
            }
            #endregion


            return EndedString;//вывод итоговых строк
            #endregion
        }
        #endregion

        #endregion


        //SeverWithEnterToListRight
        //Getting a list with Enter
        //Получение листа с учётом Enter
        #region void "SeverWithEnterToListRight"
        public static List<string> SeverWithEnterToListRight(string pre_result)
        {
            List<string> list = new List<string>();
            string resultAtLine = "";


            foreach (char str in pre_result)
            {
                if (str == '\n')
                {
                    list.Add(resultAtLine);
                    resultAtLine = "";
                }
                else
                {
                    resultAtLine += str;
                }
            }

            if (resultAtLine != "")
            {
                list.Add(resultAtLine);
            }

            return list;
        }
        #endregion


        //GetRightList
        //Getting a list with "*/", "/*", "//" and Enter
        //Получение листа с учётом "*/", "/*", "//" и Enter
        #region void "GetRightList"
        public static List<string> GetRightList(string str)
        {
            List<string> list = new List<string> { };
            List<string> Links = new List<string> { };

            list = SeverWithEnterToListRight(str);

            int can_readAtAll = 1;
            bool can_read = true;
            bool ready = false;
            string final_string = "";

            foreach (string pre_item in list)
            {
                string item = pre_item.Replace("\r", "");

                if (item.Contains("/*"))
                {
                    can_read = false;
                    can_readAtAll -= 1;
                }
                else if (can_readAtAll > 0 && item.Contains("//"))
                {
                    foreach (char ch in item)
                    {
                        if (ch == '/' && !ready)
                        {
                            ready = true;
                        }
                        else if (ch == '/' && ready)
                        {
                            ready = false;
                            can_read = false;
                        }

                        if (ch != '/')
                        {
                            if (can_read)
                            {
                                if (ready)
                                {
                                    final_string += '/';
                                    ready = false;
                                }

                                final_string += ch;
                            }
                        }
                    }
                }
                else if (can_readAtAll > 0)
                {
                    final_string = item;
                }


                if (item.Contains("*/"))
                    can_readAtAll += 1;
                can_read = true;

                if (final_string != "" && final_string != "\n" && final_string != "\r")
                {
                    Links.Add(final_string.Replace("\r", ""));
                }

                final_string = "";
            }



            return Links;
        }
        #endregion


        //GetRightListForHttps
        //Getting a list with "*/", "/*", "//", Enter and https://
        //Получение листа с учётом "*/", "/*", "//", Enter и https://
        #region void "GetRightListForHttps"
        public static List<string> GetRightListForHttps(string str)
        {
            List<string> list = new List<string> { };
            List<string> Links = new List<string> { };

            list = SeverWithEnterToListRight(str);

            int can_readAtAll = 1;
            bool can_read = true;
            bool ready = false;
            string final_string = "";

            foreach (string pre_item in list)
            {
                string item = pre_item.Replace("\r", "");

                if (item.Contains("/*"))
                {
                    can_read = false;
                    can_readAtAll -= 1;
                }
                else if (can_readAtAll > 0 && item.Contains("##"))
                {
                    foreach (char ch in item)
                    {
                        if (ch == '#' && ready == false)
                        {
                            ready = true;
                        }
                        else if (ch == '#' && ready == true)
                        {
                            ready = false;
                            can_read = false;
                        }

                        if (ch != '#')
                        {
                            if (can_read)
                            {
                                if (ready == true)
                                {
                                    final_string += '#';
                                    ready = false;
                                }

                                final_string += ch;
                            }
                        }
                    }
                }
                else if (can_readAtAll > 0)
                {
                    final_string = item;
                }

                can_read = true;

                if (item.Contains("*/"))
                {
                    can_read = true;
                    can_readAtAll += 1;
                }


                if (final_string != "" && final_string != "\n" && final_string != "\r")
                {
                    Links.Add(final_string.Replace("\r", ""));
                }

                final_string = "";
            }



            return Links;
        }
        #endregion

        //GetRightWord
        //Putting the word in the correct form, depending on the amount
        //Постановка слова в правильную форму, в зависимости от количества
        #region void "GetRightWord"
        public static string GetRightWord(int count, string mode1_0_объектов, string mode2_1_объект, string mode3_2_объекта)
        {
            //Объектов

            //Объектов: 0 ,5-10 ,[11-20] ,25-30 ,35-40
            //Объект: 1 ,21 ,31
            //Объекта: 2-4 ,22-24 ,32-34

            //Объектов: [11-20], last = 0, last = 5-9
            //Объект: last = 1
            //Объекта: [иначе]

            int last = count % 10;

            if ((11 <= count && count <= 20) || last == 0 || (5 <= last && last <= 9))
            {
                //Объектов
                return $"{count} {mode1_0_объектов}";
            }
            else if (last == 1)
            {
                //Объект
                return $"{count} {mode2_1_объект}";
            }
            else
            {
                //Объекта
                return $"{count} {mode3_2_объекта}";
            }
        }
        #endregion
    }
    #endregion




    #region Math fuctions || Математические функции
    public static class MyMath
    {
        //GetModul
        //Getting the modul of a number
        //Получение модуля числа
        #region void "GetModul"
        public static int GetModul(int number)
        {
            if (number < 0)
                return -number;

            return number;
        }

        public static long GetModul(long number)
        {
            if (number < 0)
                return -number;

            return number;
        }

        public static float GetModul(float a)
        {
            if (a < 0)
                return -a;

            return a;
        }

        public static double GetModul(double a)
        {
            if (a < 0)
                return -a;

            return a;
        }

        public static decimal GetModul(decimal a)
        {
            if (a < 0)
                return -a;

            return a;
        }

        public static BigInteger GetModul(BigInteger a)
        {
            if (a < 0)
                return -a;

            return a;
        }
        #endregion


        //ReverseNumber
        //Getting the opposite number
        //Получение обратного числа
        #region void "ReverseNumber"
        public static int ReverseNumber(int a)
        {
            return -a;
        }

        public static long ReverseNumber(long a)
        {
            return -a;
        }

        public static float ReverseNumber(float a)
        {
            return -a;
        }

        public static double ReverseNumber(double a)
        {
            return -a;
        }

        public static decimal ReverseNumber(decimal a)
        {
            return -a;
        }

        public static BigInteger ReverseNumber(BigInteger a)
        {
            return -a;
        }
        #endregion

        //theBiggest
        //Searching the biggest number of the array
        //Поиск наибольшего числа в массиве
        #region void "theBiggest"
        public static byte theBiggest(byte[] big)
        {
            if (big.Length > 0)
            {
                byte theBiggest = big[0];
                foreach (byte trY in big)
                {
                    if (trY > theBiggest)
                    {
                        theBiggest = trY;
                    }
                }
                return theBiggest;
            }
            else
                return 0;
        }
        public static sbyte theBiggest(sbyte[] big)
        {
            if (big.Length > 0)
            {
                sbyte theBiggest = big[0];
                foreach (sbyte trY in big)
                {
                    if (trY > theBiggest)
                    {
                        theBiggest = trY;
                    }
                }
                return theBiggest;
            }
            else
                return 0;
        }
        public static short theBiggest(short[] big)
        {
            if (big.Length > 0)
            {
                short theBiggest = big[0];
                foreach (short trY in big)
                {
                    if (trY > theBiggest)
                    {
                        theBiggest = trY;
                    }
                }
                return theBiggest;
            }
            else
                return 0;
        }
        public static ushort theBiggest(ushort[] big)
        {
            if (big.Length > 0)
            {
                ushort theBiggest = big[0];
                foreach (ushort trY in big)
                {
                    if (trY > theBiggest)
                    {
                        theBiggest = trY;
                    }
                }
                return theBiggest;
            }
            else
                return 0;
        }
        public static int theBiggest(int[] big)
        {
            if (big.Length > 0)
            {
                int theBiggest = big[0];
                foreach (int trY in big)
                {
                    if (trY > theBiggest)
                    {
                        theBiggest = trY;
                    }
                }
                return theBiggest;
            }
            else
                return 0;
        }
        public static uint theBiggest(uint[] big)
        {
            if (big.Length > 0)
            {
                uint theBiggest = big[0];
                foreach (uint trY in big)
                {
                    if (trY > theBiggest)
                    {
                        theBiggest = trY;
                    }
                }
                return theBiggest;
            }
            else
                return 0;
        }
        public static long theBiggest(long[] big)
        {
            if (big.Length > 0)
            {
                long theBiggest = big[0];
                foreach (long trY in big)
                {
                    if (trY > theBiggest)
                    {
                        theBiggest = trY;
                    }
                }
                return theBiggest;
            }
            else
                return 0;
        }
        public static ulong theBiggest(ulong[] big)
        {
            if (big.Length > 0)
            {
                ulong theBiggest = big[0];
                foreach (ulong trY in big)
                {
                    if (trY > theBiggest)
                    {
                        theBiggest = trY;
                    }
                }
                return theBiggest;
            }
            else
                return 0;
        }
        public static float theBiggest(float[] big)
        {
            if (big.Length > 0)
            {
                float theBiggest = big[0];
                foreach (float trY in big)
                {
                    if (trY > theBiggest)
                    {
                        theBiggest = trY;
                    }
                }
                return theBiggest;
            }
            else
                return 0;
        }
        public static double theBiggest(double[] big)
        {
            if (big.Length > 0)
            {
                double theBiggest = big[0];
                foreach (double trY in big)
                {
                    if (trY > theBiggest)
                    {
                        theBiggest = trY;
                    }
                }
                return theBiggest;
            }
            else
                return 0;
        }
        public static decimal theBiggest(decimal[] big)
        {
            if (big.Length > 0)
            {
                decimal theBiggest = big[0];
                foreach (decimal trY in big)
                {
                    if (trY > theBiggest)
                    {
                        theBiggest = trY;
                    }
                }
                return theBiggest;
            }
            else
                return 0;
        }
        public static char theBiggest(char[] big)
        {
            if (big.Length > 0)
            {
                char theBiggest = big[0];
                foreach (char trY in big)
                {
                    if (trY > theBiggest)
                    {
                        theBiggest = trY;
                    }
                }
                return theBiggest;
            }
            else
                return '0';
        }
        public static string theBiggest(string[] big)
        {
            if (big.Length > 0)
            {
                double.TryParse(big[0], out double theBiggest);

                foreach (string trY in big)
                {
                    double.TryParse(trY, out double trY_double);

                    if (trY_double > theBiggest)
                    {
                        theBiggest = trY_double;
                    }
                }
                return theBiggest.ToString();
            }
            else
                return "0";
        }
        public static object theBiggest(object[] big)
        {
            if (big.Length > 0)
            {
                double.TryParse(big[0].ToString(), out double theBiggest);

                foreach (string trY in big)
                {
                    double.TryParse(trY, out double trY_double);

                    if (trY_double > theBiggest)
                    {
                        theBiggest = trY_double;
                    }
                }
                return theBiggest.ToString();
            }
            else
                return 0;
        }
        public static BigInteger theBiggest(BigInteger[] big)
        {
            if (big.Length > 0)
            {
                BigInteger.TryParse(big[0].ToString(), out BigInteger theBiggest);

                foreach (BigInteger trY in big)
                {
                    if (trY > theBiggest)
                    {
                        theBiggest = trY;
                    }
                }
                return theBiggest;
            }
            else
                return 0;
        }
        #endregion

        //theSmallest
        //Searching the smallest number of the array
        //Поиск наименьшего числа в массиве
        #region void "theSmallest"
        public static byte theSmallest(byte[] big)
        {
            if (big.Length > 0)
            {
                byte theSmallest = big[0];
                foreach (byte trY in big)
                {
                    if (trY < theSmallest)
                    {
                        theSmallest = trY;
                    }
                }
                return theSmallest;
            }
            else
                return 0;
        }
        public static sbyte theSmallest(sbyte[] big)
        {
            if (big.Length > 0)
            {
                sbyte theSmallest = big[0];
                foreach (sbyte trY in big)
                {
                    if (trY < theSmallest)
                    {
                        theSmallest = trY;
                    }
                }
                return theSmallest;
            }
            else
                return 0;
        }
        public static short theSmallest(short[] big)
        {
            if (big.Length > 0)
            {
                short theSmallest = big[0];
                foreach (short trY in big)
                {
                    if (trY < theSmallest)
                    {
                        theSmallest = trY;
                    }
                }
                return theSmallest;
            }
            else
                return 0;
        }
        public static ushort theSmallest(ushort[] big)
        {
            if (big.Length > 0)
            {
                ushort theSmallest = big[0];
                foreach (ushort trY in big)
                {
                    if (trY < theSmallest)
                    {
                        theSmallest = trY;
                    }
                }
                return theSmallest;
            }
            else
                return 0;
        }
        public static int theSmallest(int[] big)
        {
            if (big.Length > 0)
            {
                int theSmallest = big[0];
                foreach (int trY in big)
                {
                    if (trY < theSmallest)
                    {
                        theSmallest = trY;
                    }
                }
                return theSmallest;
            }
            else
                return 0;
        }
        public static uint theSmallest(uint[] big)
        {
            if (big.Length > 0)
            {
                uint theSmallest = big[0];
                foreach (uint trY in big)
                {
                    if (trY < theSmallest)
                    {
                        theSmallest = trY;
                    }
                }
                return theSmallest;
            }
            else
                return 0;
        }
        public static long theSmallest(long[] big)
        {
            if (big.Length > 0)
            {
                long theSmallest = big[0];
                foreach (long trY in big)
                {
                    if (trY < theSmallest)
                    {
                        theSmallest = trY;
                    }
                }
                return theSmallest;
            }
            else
                return 0;
        }
        public static ulong theSmallest(ulong[] big)
        {
            if (big.Length > 0)
            {
                ulong theSmallest = big[0];
                foreach (ulong trY in big)
                {
                    if (trY < theSmallest)
                    {
                        theSmallest = trY;
                    }
                }
                return theSmallest;
            }
            else
                return 0;
        }
        public static float theSmallest(float[] big)
        {
            if (big.Length > 0)
            {
                float theSmallest = big[0];
                foreach (float trY in big)
                {
                    if (trY < theSmallest)
                    {
                        theSmallest = trY;
                    }
                }
                return theSmallest;
            }
            else
                return 0;
        }
        public static double theSmallest(double[] big)
        {
            if (big.Length > 0)
            {
                double theSmallest = big[0];
                foreach (double trY in big)
                {
                    if (trY < theSmallest)
                    {
                        theSmallest = trY;
                    }
                }
                return theSmallest;
            }
            else
                return 0;
        }
        public static decimal theSmallest(decimal[] big)
        {
            if (big.Length > 0)
            {
                decimal theSmallest = big[0];
                foreach (decimal trY in big)
                {
                    if (trY < theSmallest)
                    {
                        theSmallest = trY;
                    }
                }
                return theSmallest;
            }
            else
                return 0;
        }
        public static char theSmallest(char[] big)
        {
            if (big.Length > 0)
            {
                char theSmallest = big[0];
                foreach (char trY in big)
                {
                    if (trY < theSmallest)
                    {
                        theSmallest = trY;
                    }
                }
                return theSmallest;
            }
            else
                return '0';
        }
        public static string theSmallest(string[] big)
        {
            if (big.Length > 0)
            {
                BigInteger.TryParse(big[0], out BigInteger theSmallest);

                foreach (string trY in big)
                {
                    BigInteger.TryParse(trY, out BigInteger trY_double);

                    if (trY_double < theSmallest)
                    {
                        theSmallest = trY_double;
                    }
                }
                return theSmallest.ToString();
            }
            else
                return "0";
        }
        public static object theSmallest(object[] big)
        {
            if (big.Length > 0)
            {
                double.TryParse(big[0].ToString(), out double theSmallest);

                foreach (string trY in big)
                {
                    double.TryParse(trY, out double trY_double);

                    if (trY_double < theSmallest)
                    {
                        theSmallest = trY_double;
                    }
                }
                return theSmallest.ToString();
            }
            else
                return 0;
        }
        public static BigInteger theSmallest(BigInteger[] big)
        {
            if (big.Length > 0)
            {
                BigInteger.TryParse(big[0].ToString(), out BigInteger theSmallest);

                foreach (BigInteger trY in big)
                {
                    if (trY < theSmallest)
                    {
                        theSmallest = trY;
                    }
                }
                return theSmallest;
            }
            else
                return 0;
        }
        #endregion
    }
    #endregion


}
