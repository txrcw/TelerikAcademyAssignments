﻿namespace CohesionAndCoupling
{
    using System;

    internal class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(FileNameUtilities.GetFileExtension("example"));
            Console.WriteLine(FileNameUtilities.GetFileExtension("example.pdf"));
            Console.WriteLine(FileNameUtilities.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileNameUtilities.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileNameUtilities.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileNameUtilities.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", Two_DimCalculation.CalcDistance(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", Three_DimCalculation.CalcDistance(5, 2, -1, 3, -6, 4));

            var someShape = new Shape();
            someShape.Width = 3;
            someShape.Height = 4;
            someShape.Depth = 5;

            Console.WriteLine("Volume = {0:f2}", Three_DimCalculation.CalcVolume(someShape));
            Console.WriteLine("Diagonal XYZ = {0:f2}", Three_DimCalculation.CalcDiagonalXYZ(someShape));
            Console.WriteLine("Diagonal XY = {0:f2}", Two_DimCalculation.CalcDiagonalXY(someShape));
            Console.WriteLine("Diagonal XZ = {0:f2}", Two_DimCalculation.CalcDiagonalXZ(someShape));
            Console.WriteLine("Diagonal YZ = {0:f2}", Two_DimCalculation.CalcDiagonalYZ(someShape));
        }
    }
}