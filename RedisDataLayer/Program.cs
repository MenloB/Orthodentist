using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;
using Newtonsoft.Json;
using RedisCassandraNapredneBazePodataka.Models;

namespace RedisDataLayer
{
    class Intervencija
    {
        public DateTime Datum { get; set; }
        public string Dijagnoza { get; set; }
        public string Opis { get; set; }
        public DateTime Kontrola { get; set; }
    }

    public class Program
    {
        public static ConnectionMultiplexer connectionMultiplexer = ConnectionMultiplexer.Connect("localhost");

        static void Main(string[] args)
        {
            IDatabase db = connectionMultiplexer.GetDatabase();

            var data = db.StringGet("mykey");

            Console.WriteLine(data);
        }
    }
}
