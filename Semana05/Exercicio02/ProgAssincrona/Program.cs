using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProgAssincrona
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            ExectuarComTasks();
            sw.Stop();
            Console.WriteLine($"Operação gastou {sw.ElapsedMilliseconds} milisegundos.");
        }


        static void RealizarOperacao (int op, string nome, string sobrenome)
        {
            Console.WriteLine($"Iniciando operação {op}...");
            for (int i = 0; i < 1000000000; i++)
            {
                var p = new Pessoa(nome, sobrenome, 23);
            }
            Console.WriteLine($"Finalizando operação {op}...");
        }

        static void ExecutarSequencial()
        {
            RealizarOperacao(1, "Paula", "Tejano");
            RealizarOperacao(2, "Cuca", "Beludo");
            RealizarOperacao(3, "Tomas", "Turbando");
        }

        static void ExectuarComThreads()
        {
            var t1 = new Thread(() => 
            {
                RealizarOperacao(1, "Paula", "Tejano");
            });
            var t2 = new Thread(() =>
            {
                RealizarOperacao(2, "Cuca", "Beludo");
            });
            var t3 = new Thread(() =>
            {   
                RealizarOperacao(3, "Tomas", "Turbando");
            });

            t1.Start();
            t2.Start();
            t3.Start();

            t1.Join();
            t2.Join();
            t3.Join();
        }

        static void ExectuarComTasks()
        {
            var t1 = Task<int>.Run(() => 
            {
                RealizarOperacao(1, "Paula", "Tejano");
                return 1;
            });
            var t2 = Task<int>.Run(() =>
            {
                RealizarOperacao(2, "Cuca", "Beludo");
                return 2;
            });
            var t3 = Task<int>.Run(() =>
            {   
                RealizarOperacao(3, "Tomas", "Turbando");
                return 3;            
            });
            Console.WriteLine($"Tarefa {t1.Result} finalizou.");
            Console.WriteLine($"Tarefa {t2.Result} finalizou.");
            Console.WriteLine($"Tarefa {t3.Result} finalizou.");
        }

    }
    
}