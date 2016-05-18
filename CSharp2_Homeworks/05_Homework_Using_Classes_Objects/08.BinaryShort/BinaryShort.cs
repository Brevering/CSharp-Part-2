using System;

namespace _08.BinaryShort
{
    class BinaryShort
    {
        static void Main()
        {
            short inputVal = short.Parse(Console.ReadLine());
            byte[] bytesInput = BitConverter.GetBytes(inputVal);

            string inputToBinary = "";
            for (int i = 0; i < bytesInput.Length; i++) //convert each byte to its binary representation and pad
            {                                           //with zeroes to get 8 bits for each byte
                inputToBinary = Convert.ToString(bytesInput[i], 2).PadLeft(8, '0') + inputToBinary;
            }

            Console.WriteLine(inputToBinary);
        }
    }
}
