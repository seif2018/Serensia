using Serensia.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Serensia.Algorithms
{

    public class DifferenceCalculator : IDifferenceCalculator
    {
        public int GetDifferenceScore(ReadOnlySpan<char> left, ReadOnlySpan<char> right)
        {
            if (left.Length != right.Length)
                throw new ArgumentException("Spans must have the same length.", nameof(right));

            int differenceScore = 0;

            for (int i = 0; i < left.Length; i++)
            {
                if (left[i] != right[i])
                {
                    differenceScore++;
                }
            }

            return differenceScore;
        }
    }

}