using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;
        private Random _random;

        public Scripture(Reference reference, string fullText)
        {
            _reference = reference;
            _random = new Random();

            string[] splitWords = fullText.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            _words = new List<Word>();
            foreach (string w in splitWords)
            {
                _words.Add(new Word(w));
            }
        }

        public void Display()
        {
            Console.WriteLine(_reference.ToString());
            Console.WriteLine();

            for (int i = 0; i < _words.Count; i++)
            {
                Console.Write(_words[i].Display());
                if (i < _words.Count - 1)
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
        }

        public void HideRandomWords(int count)
        {
            List<int> visibleIndices = new List<int>();
            for (int i = 0; i < _words.Count; i++)
            {
                if (!_words[i].IsHidden)
                {
                    visibleIndices.Add(i);
                }
            }

            if (visibleIndices.Count == 0)
            {
                return;
            }

            int hideCount = Math.Min(count, visibleIndices.Count);

            for (int i = visibleIndices.Count - 1; i > 0; i--)
            {
                int swapIndex = _random.Next(i + 1);
                int temp = visibleIndices[i];
                visibleIndices[i] = visibleIndices[swapIndex];
                visibleIndices[swapIndex] = temp;
            }

            for (int i = 0; i < hideCount; i++)
            {
                int wordIndex = visibleIndices[i];
                _words[wordIndex].Hide();
            }
        }

        public bool AllWordsHidden()
        {
            for (int i = 0; i < _words.Count; i++)
            {
                if (!_words[i].IsHidden)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
