using System;

namespace Euler8
{
    public class Question8
    {
        public int[] ParseNumbers(string numbers) {
            var result = new int[numbers.Length];
            var chNumbers = numbers.ToCharArray();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = int.Parse(chNumbers[i].ToString());
            }

            return result;
        }
    }
}