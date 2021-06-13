using System;

namespace NullableTypesExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<DateTime> data = null;
            //Console.WriteLine($"Data1: {data.Value}");
            Console.WriteLine($"Data2: {data.GetValueOrDefault()}");
            if (data.HasValue)
            {
                Console.WriteLine($"Data3: {data.Value}");
            }
            else
            {
                Console.WriteLine($"Data3: null");
            }
            //data = data == null ? DateTime.Now : data;
            data = data ?? DateTime.Now;
            Console.WriteLine($"Data4: {data}");
        }
    }
}
