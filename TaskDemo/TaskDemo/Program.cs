﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current task Id {Task.CurrentId}");
            Action<object> paramAction = (object val) =>
            {
                int v = (int)val;
                System.Console.WriteLine($"Here the task is starting with id:" +
                $"{Task.CurrentId} of Thread"+
                $"{Thread.CurrentThread.ManagedThreadId}");
            System.Threading.Thread.Sleep(v);
                Console.WriteLine($"Task of {Task.CurrentId} is finished after the " +
                $"sleeping of {v/1000} seconds of " +
                $"thread {Thread.CurrentThread.ManagedThreadId}");


            };
            int value = 1000;
            Task t1 = new Task(
                () =>
                {
                    System.Console.WriteLine($"Here the task is starting with id:" +
                        $"{Task.CurrentId} of Thread" +
                        $"{Thread.CurrentThread.ManagedThreadId}");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine($"Task of {Task.CurrentId} is finished" +
                        $" after the sleeping of 2 seconds of thread" +
                        $"{Thread.CurrentThread.ManagedThreadId}");

                });
            t1.Start();
            t1.Wait();
            Console.WriteLine($"Current Status of t1 task {t1.Status}");
            value = 5000;
            Task t2 = new Task(paramAction, value);
            t2.Start();
            Task t3 = Task.Factory.StartNew(() => Run(2000));
            Console.WriteLine($"Current status of t1 task {t1.Status}");
            Task t4 = Task.Run(() => paramAction(5000));
            Task.WaitAll(t1, t2, t3, t4);
            Console.WriteLine("------Completed-------");
            Console.ReadKey();
        }
        public static void Run(int duration)
        {
            System.Console.WriteLine($"Here the task is start with id :{Task.CurrentId}" +
                $"of thread {Thread.CurrentThread.ManagedThreadId}");
            System.Threading.Thread.Sleep(duration);
            Console.WriteLine($"Task of {Task.CurrentId} is finished after the " +
                $"sleeping of{duration / 1000} seonds of " +
                $"thread {Thread.CurrentThread.ManagedThreadId}");
        }

    }
}
