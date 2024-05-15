﻿using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo.Utils
{
    public static class PersonHelper
    {
        public static string GenerateIdNumber(string prefix)
        {
            var randomNumber = RandomNumberGenerator
                .GetInt32(100000, 9999999)
                .ToString();
            return $"{prefix}-{randomNumber}";
        }
    }
}
