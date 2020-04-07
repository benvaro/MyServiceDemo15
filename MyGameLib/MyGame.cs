using System;

namespace MyGameLib
{
    public class MyGame : IMyGame
    {
        //public MyGame()
        //{
        //    Console.WriteLine("Hello from game.");
        //}
        public string GetAnswer(string question)
        {
            string[] answer = { "Yes", "No", "Mayby yes,maybe no", "Definitely", "I'm busy.Try again later" };
            Random rand = new Random();
            return answer[rand.Next(answer.Length)];
        }

        public void Show(string question)
        {
            Console.WriteLine(question);
        }
    }
}
