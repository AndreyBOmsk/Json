﻿using System;
using JsonParse;

namespace ConsoleTest
{
    class Program
    {
        public const string TransferNewLine = @"\n";

        static void Main(string[] args)
        {
           JsonParser jsonParser = new JsonParser();
            string inputString = "{\"UserID\":53568,\"FirstName\":\"Kat\",\"LastName\":\"Burke\",\"City\":{\"Count\":2342234,\"Name\":\"Omsk\",\"Country\":{\"Name\":\"Russia\"}}}";

            var handleString = jsonParser.HandleString(inputString);
        }
    }
}
