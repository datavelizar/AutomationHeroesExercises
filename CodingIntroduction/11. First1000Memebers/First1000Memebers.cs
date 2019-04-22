//11. Write a console application that outputs the first 1000 members of the sequence 2, -3, 4, -5, 6, -7 - (HINT - you might need to learn how to use loops)

namespace _11._First1000Memebers
{
    using System;

    class First1000Memebers
    {
        static void Main(string[] args)
        {
            int currentMember = 0, sequenceNumber = 2, mask = 1, numberOfMembers = 10;

            while (currentMember != numberOfMembers - 1)
            {
                Console.Write((mask & sequenceNumber) == 0 ? sequenceNumber + ", " : -sequenceNumber + ", ");

                currentMember++;
                sequenceNumber++;
            }

            Console.Write((mask & sequenceNumber) == 0 ? sequenceNumber : -sequenceNumber); // This line is needed to not write ", " after the last member
        }
    }
}
