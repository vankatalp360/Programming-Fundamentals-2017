using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Note_Statistics
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var notes = new List<string>();
            var naturals = new List<string>();
            var sharps = new List<string>();
            var naturalSum = 0.0;
            var sharpsSum = 0.0;
            var beepFreq = new List<double>();

            for (int i = 0; i < numbers.Count; i++)
            {
                switch (numbers[i].ToString())
                {
                    case "261.63": notes.Add("C"); break;
                    case "277.18": notes.Add("C#"); break;
                    case "293.66": notes.Add("D"); break;
                    case "311.13": notes.Add("D#"); break;
                    case "329.63": notes.Add("E"); break;
                    case "349.23": notes.Add("F"); break;
                    case "369.99": notes.Add("F#"); break;
                    case "392": notes.Add("G"); break;
                    case "415.3": notes.Add("G#"); break;
                    case "440": notes.Add("A"); break;
                    case "466.16": notes.Add("A#"); break;
                    case "493.88": notes.Add("B"); break;
                }
                if (numbers[i] == 277.18 || numbers[i] == 311.13 ||
                    numbers[i] == 369.99 || numbers[i] == 415.3 || numbers[i] == 466.16)
                {
                    sharpsSum += numbers[i];
                    beepFreq.Add(numbers[i]);
                }
                else
                {
                    naturalSum += numbers[i];
                    beepFreq.Add(numbers[i]);
                }
            }

            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i] == "C#" || notes[i] == "D#" || 
                    notes[i] == "F#" || notes[i] == "G#" || notes[i] == "A#")
                {
                    sharps.Add(notes[i]);
                }
                else
                {
                    naturals.Add(notes[i]);
                }
            }

            Console.WriteLine($"Notes: {string.Join(" ", notes)}");
            Console.WriteLine($"Naturals: {string.Join(", ", naturals)}");
            Console.WriteLine($"Sharps: {string.Join(", ", sharps)}");
            Console.WriteLine($"Naturals sum: {naturalSum}");
            Console.WriteLine($"Sharps sum: {sharpsSum}");

            for (int i = 0; i < beepFreq.Count; i++)
            {
                Console.Beep((int)beepFreq[i], 500);
            }
        }
    }
}
