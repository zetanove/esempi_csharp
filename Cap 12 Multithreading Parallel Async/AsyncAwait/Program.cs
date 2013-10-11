﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("before");
            MetodoAsincrono();
            Console.WriteLine("after");
            EsecuzioneConcorrente();

            UseAwait();

            Console.ReadLine();
        }

        private async static void UseAwait()
        {
            Console.WriteLine(await GetStringAsync());

            Func<string, Task<string>> Lambda = async (file) => await GetNumbersFromStringAsync(file);
            string result=await Lambda("129mns93");



            List<string> files = new List<string>(){"file1.txt", "file2.txt", "file3.txt"};
            files.ForEach(async file => await ReadFileAsync(file));

            files.ForEach(async delegate(string file)
                        { 
                            await ReadFileAsync(file);
                        });
        }

        public static async Task ReadFileAsync(string path)
        {
            await Task.Delay(1000);
            Console.WriteLine(path);
        }

        public static async void MetodoAsincrono()
        {
            Console.WriteLine("before await");
            await Task.Run(() =>
                {
                    Console.WriteLine("start task");
                    Thread.Sleep(3000);
                    Console.WriteLine("end task");
                });
            Console.WriteLine("after await");

            Task<string> task = GetStringAsync();
            await task;
            string result= await GetStringAsync();
        }

        public static async Task<string> GetStringAsync()
        {
            await Task.Delay(1000);
            return "completed";
        }

        public static async Task<string> GetNumbersFromStringAsync(string str)
        {
            StringBuilder sb = new StringBuilder();
            await Task.Run(()=>
                {
                    
                    foreach(char ch in str)
                    {
                        if(Char.IsNumber(ch))
                            sb.Append(ch);
                    }
                    
                });
            return sb.ToString();
        }

        public async static void EsecuzioneConcorrente()
        {
            string str1 = await GetNumbersFromStringAsync("a1sd32jklfs89'03jmfws");
            Console.WriteLine(str1);
            string str2 = await GetNumbersFromStringAsync("fsdf03,v01gr52");
            Console.WriteLine(str2);

            var task1 = GetNumbersFromStringAsync("a1sd32jklfs8912gs13'03jmfws");
            var task2 = GetNumbersFromStringAsync("03,gr5lasd023las vsd 2");

            //await task1;
            //await task2;
            Task.WaitAll(task1, task2);
            Console.WriteLine(task1.Result);
            Console.WriteLine(task2.Result);

        }
    }
}
