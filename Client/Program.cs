using Core;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
          
            KeyVault.GetSecret(Core.EnvironmentEnum.Development,"");



            KeyVault.GetSecret(Core.EnvironmentEnum.Development, "");

            Console.WriteLine("Hello World!");
        }
    }
}
