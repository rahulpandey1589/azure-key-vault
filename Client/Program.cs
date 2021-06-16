using Core;
using Core.Common;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
          
            KeyVault.GetSecret(EnvironmentEnum.Development,"");



            KeyVault.GetSecret(EnvironmentEnum.Development, "");

            Console.WriteLine("Hello World!");
        }
    }
}
