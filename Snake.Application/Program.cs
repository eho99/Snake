// Project Snake: Program.cs
// Copyright (c) 2021 Project Snake Contributors,
// Ishan Pranav, Eric Ho, and Kaylee Kim. All rights reserved.

using System;

namespace Snake.Application
{
    internal static class Program
    {
        private static void Main()
        {
            Square square = new Square();

            Console.WriteLine(square);
            Console.WriteLine(square.File);
            Console.WriteLine(square.Rank);
        }
    }
}
