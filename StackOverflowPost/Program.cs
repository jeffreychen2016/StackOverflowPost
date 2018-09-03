using System;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new StackOverflowPost();

            post.Title = "Hello, this is my first post!";
            post.Description = "I am just practing C# fundemantals";
            post.DateTimeCreated = DateTime.Now;

            post.displayPost();

            var repeat = true;
            while (repeat)
            {
                Console.WriteLine($@"
Enter Y to up-vote the post
Enter N to down-vote the post
Enter View to view the post detail
Enter other keys to kill this stupid app :)
");
                var userInput = Console.ReadLine().ToUpper();
                if (userInput == "Y")
                {
                    post.UpVote();
                }
                else if (userInput == "N")
                {
                    post.DownVote();
                }
                else if (userInput == "VIEW")
                {
                    post.displayPost();

                }
                else {
                    repeat = false;
                }
            }
        }
    }
}
