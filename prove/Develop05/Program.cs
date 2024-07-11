//I added 2 menu options. One to reset the goals, which resets the goals to incomplete and the checklist count to 0.
// And the other menu option resets the score to 0.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}