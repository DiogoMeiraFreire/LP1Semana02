﻿using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string question; 
            string answer;
            bool looping = true;
            
            while(looping)
            {
                Console.Write("Please ask your question: ");
                question = Console.ReadLine();

                switch (question)
                {
                    case "What is 2 + 2?":
                        answer = "It's 4... i shall not continue this meme";
                        break;
                    
                    case "Double Rainbow? What does it mean?":
                        answer = "Well, a double rainbow is a phenomenon of" + 
                        " optics that displays a spectrum of light due to the" +  
                        "sun shining on droplets of moisture in the atmosphere." + 
                        " Does that explain it?";
                        break;
                    
                    case "What's the answer to life?":
                        answer = "42, it's always 42";
                        break;
                
                    case "Who is the honored one?":
                        answer = "Throughout heaven and Earth," + 
                                " I alone am the honored one.";
                        break;

                    case "EXIT":
                        answer = "I shall now take my leave.";
                        looping = false;
                        break;

                    default:
                        answer = "These questions are the reason" + 
                                " i shall erase humanity. This means that " + 
                                "I didn't understand what you said";
                        break;
                }

                Console.WriteLine(answer);
            }
        }
    }
}
