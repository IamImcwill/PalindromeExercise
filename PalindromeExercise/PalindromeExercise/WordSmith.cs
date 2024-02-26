using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string originalWord) 
        {
            if (originalWord == null) 
            { 
                return false; 
            }
            string wordLowered =  originalWord.ToLower();
            string reversedWord = "";

             for (int i = wordLowered.Length - 1; i >= 0; i--)
                {
                reversedWord += wordLowered[i];
                }
                if (wordLowered == reversedWord) 
                { 
                    return true;
                }
                else 
                { 
                    return false;
                }
        }
    }
}
