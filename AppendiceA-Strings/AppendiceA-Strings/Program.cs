using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppendiceA_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello world";
            Console.WriteLine(str);

            str = new string('a', 10);
            Console.WriteLine(str);

            char[] arr={'a','b','c','d','e'};
            str = new string(arr, 1, 3);
            Console.WriteLine(str);

            str = "\\\u0045";
            Console.WriteLine(str);

            str = @"c:\temp\file\a.txt"; //non è necessario raddoppiare i \
            Console.WriteLine(str);

            str=@"""Questa stringa è fra doppi apici""";
            Console.WriteLine(str);

            str = "hello";
            char ch = str[0];

            int len = str.Length;

            for(int i=0;i<str.Length;i++)
            {
                Console.WriteLine(str[i]);
            }

            foreach (char c in str)
            {
                Console.WriteLine(c);
            }

            char[] chars = str.ToCharArray();
            chars = str.ToCharArray(3, 2);

            

            string empty = String.Empty;
            len = empty.Length;

            string snull=null;
            str = snull + "abc";
            Console.WriteLine(str);

            bool isNullOrEmpty = string.IsNullOrEmpty(str);

            string space = "   ";
            bool isNullOrEmptyOrSpace = string.IsNullOrWhiteSpace(space);

            str = "hello world";
            int index = str.IndexOf('h');

            index= str.IndexOfAny( new char[]{'l', 'w'}); //2

            bool sb = str.StartsWith("hel"); //true
            bool eb = str.EndsWith("abc"); //false

            bool cb=str.Contains("wo");
            //compare
            string str1 = "hel"+"lo";
            string str2 = "hello";
            bool eq = str1 == "hello";

            eq = string.ReferenceEquals(str1,"hello"); //false

            str1="hello";
            str2="HELLO";
            eq = str1.Equals(str2); //false
            eq = str1.Equals(str2, StringComparison.OrdinalIgnoreCase); //true

            Console.WriteLine(String.Compare("A", "B"));// -1, A è minore di B
            Console.WriteLine(String.Compare("A", "A")); // 0, A è uguale ad A
            Console.WriteLine(String.Compare("B", "A")); // 1, B è maggiore di A
            Console.WriteLine(String.Compare("A", null)); // 1, A è maggiore di null

            str1="Hello";
            str2="World";
            string str3 = string.Concat(str1, str2);

            chars=new char[3];
            str3.CopyTo(0, chars, 0, chars.Length); //H,e,l

            str3 = str1.Insert(0, "World");//WorldHello

         
            str3 = String.Join("-", str1, str2); //Hello-World

            str3 = str1.PadLeft(10);
            str3 = str2.PadRight(10, '.');

            str3 = str1.Remove(2);
            str3 = str1.Remove(0, 2);

            str3 = str1.Replace('e', '3'); //h3llo
            str3 = str1.Replace("ll", String.Empty); //heo

            string longString="Ecco una stringa lunga";
            string[] splitted = longString.Split(' ');

            str3 = "helloworld".Substring(3, 4);

            string titolo="IT";
            string autore="Stephen King";
            int pagine=1317;
            string formatted = String.Format("Titolo del libro {0}, Autore {1}, pagine {2}", titolo, autore, pagine);

            formatted = String.Format("Titolo: {0, -20} prezzo: {1,10:c}", titolo, 10);
            Console.WriteLine(formatted);

            StringBuilder builder = new StringBuilder("Hello");
            Console.WriteLine(builder.Length);
            Console.WriteLine(builder.Capacity);
            Console.WriteLine(builder.MaxCapacity);
            Console.WriteLine("primo carattere: {0}",builder[0]);
            builder.Append("world");
           
            builder.AppendLine();
            builder.AppendFormat("{0}: {1}", "prova", 123);

            //Regex
            string frase = "abc def ghi";


            string pattern=@"\d{2}";
            string input="oggi ci sono 25 gradi";
            Regex rex=new Regex(pattern);
            Match match=rex.Match(input);
            if(match.Success)
            {
                Console.WriteLine(match.Value);
                Console.WriteLine(match.Index);
                Console.WriteLine(match.Length);
            }

            MatchCollection matches = Regex.Matches(input, "i");
            Console.WriteLine("trovate {0} corrispondenze di 'i' in {1}", matches.Count, input);
            foreach(Match m in matches)
            {
                Console.WriteLine("indice {0}", m.Index);
            }

            
            match= Regex.Match(input, pattern, RegexOptions.Multiline| RegexOptions.IgnoreCase);
            

            input = "La stringa attuale contiene più parole di lunghezza due";
            pattern= @"\b\w{2}\b";
            var risultati= Regex.Matches(input, pattern, RegexOptions.IgnoreCase);
            foreach(Match m in risultati)
            {
                Console.WriteLine(m.Value);
            }

            //escape
            input = "Come ti chiami?";
            pattern = @"chiami?";
            pattern = Regex.Escape(pattern);
            match = Regex.Match(input, pattern);
            if(match.Success)
            {
                Console.WriteLine(match.Value);
            }

            input = "hello antonio";
            pattern = "[abcde]";
            matches  = Regex.Matches(input, pattern);
            foreach(Match m in matches)
                Console.WriteLine("at {0}: {1}",m.Index, m.Value);

            input = "a1 h1 b2 h2";
            pattern = @"[a-f]\d";
            matches = Regex.Matches(input, pattern);
            foreach (Match m in matches)
                Console.WriteLine("at {0}: {1}", m.Index, m.Value);//a1 b2

            input = "98065 123 abc 9210";
            pattern = @"\d{5}";
            matches = Regex.Matches(input, pattern);
            foreach (Match m in matches)
                Console.WriteLine("at {0}: {1}", m.Index, m.Value);//98065


            pattern = @"(\+\d{2})-(\d{3}-\d{4})";
            input = "In questa stringa ci sono dei numeri 212-555-6666 +39-932-1111 +415-222-3333 +01-888-9999 alcuni dei quali sono telefoni con prefisso";
            matches = Regex.Matches(input, pattern);

            foreach (Match mn in matches)
            {
                Console.WriteLine("Prefisso nazione:        {0}", mn.Groups[1].Value);
                Console.WriteLine("numero tel.: {0}", mn.Groups[2].Value);
                Console.WriteLine();
            }
            Console.WriteLine();

            pattern = @"(\w+)\s(\1)";
            input = "In questa frase frase ci sono sono delle parole ripetute";
            foreach (Match mr in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
                Console.WriteLine("Duplicato '{0}'", mr.Groups[1].Value);

            pattern = @"(?<dup>\w+)\s(\k<dup>)";
            input = "In questa frase frase ci sono sono delle parole ripetute";
            foreach (Match mr in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
                Console.WriteLine("Duplicato '{0}'", mr.Groups["dup"].Value);

            input = "Questa stringa  ha   troppi spazi    bianchi   ";
            pattern = "\\s+";
            string replacement = " ";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);

            Console.WriteLine("Originale: {0}", input);
            Console.WriteLine("Dopo sostituzione: {0}", result);

            input = "una frase tutta in minuscolo";
            result= Regex.Replace(input, @"\b[a-z]\w+", delegate(Match matchToEval)
                {
                    string v = matchToEval.ToString();
                    return char.ToUpper(v[0]) + v.Substring(1);
                });
            Console.WriteLine("Originale: {0}", input);
            Console.WriteLine("Dopo sostituzione: {0}", result);

            input = "12/31/2014";
            pattern = @"\b(\d{1,2})\/(\d{1,2})\/(\d{2,4})";
            replacement="$2-$1-$3";
            result = Regex.Replace(input, pattern, replacement);
            Console.WriteLine("{0} convertita in {1}", input, result);

            pattern = @"\b(?<mese>\d{1,2})\/(?<giorno>\d{1,2})\/(?<anno>\d{2,4})";
            replacement = "${giorno}-${mese}-${anno}";
            result = Regex.Replace(input, pattern, replacement);
            Console.WriteLine("{0} convertita in {1}", input, result);
        }
    }
}
