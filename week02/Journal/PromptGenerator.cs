public class PromptGenerator
{
    public List<string> _Prompts;

    public string GetRandomPrompt()
    {
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
        };
        
         // Generate a random prompt
        string randomPrompt = GetRandomPrompt(prompts);

        // Display the random prompt
        Console.WriteLine(randomPrompt);

        // Capture user input
        string response = Console.ReadLine();

        // Output the user's response
        Console.WriteLine($"You answered: {response}");
        
        return GetRandomPrompt();
    }

    static string GetRandomPrompt(string[] prompts)
    {
        // Create a random number generator
        Random random = new Random();

        // Generate a random index within the bounds of the array
        int index = random.Next(prompts.Length);

        // Return the random prompt
        return prompts[index];
    }

}