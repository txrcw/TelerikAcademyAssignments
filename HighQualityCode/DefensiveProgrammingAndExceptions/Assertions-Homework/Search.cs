﻿namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;
    using System.Linq;

    public class Search
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(arr.Length > 0, "Array cannot be empty");
            Debug.Assert(arr != null, "Array is null");
            Debug.Assert(value != null, "Cannot search for null value");

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    startIndex = midIndex + 1;
                }
                else
                {
                    endIndex = midIndex - 1;
                }
            }

            return -1;
        }
    }
}