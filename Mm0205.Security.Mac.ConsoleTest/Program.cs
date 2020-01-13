using System;
using Mm0205.Security.Mac.Natives;

namespace Mm0205.Security.Mac.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new GenericPasswordEditParameter
            {
                account = "test-keychain-from-c#-account",
                comment = "test-keychain-from-c#-comment",
                description = "test-keychain-from-c#-description",
                label = "test-keychain-from-c#-label",
                password = "test-keychain-from-c#-password",
                service = "test-keychain-from-c#-service",
            };

            var ret = NativeMethods.SaveGenericPassword(
                ref input,
                out var apiStatus
            );
            if (ret != 0)
            {
                Console.Error.WriteLine($"return = {ret}, apiStatus = {apiStatus}");
            }
            else
            {
                Console.WriteLine($"return = {ret}, password saved.");
            }
        }
    }
}