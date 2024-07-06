public class BreathingActivity : Activity
{
   public BreathingActivity(string name, string description, int time) : base(name, description, time)
   {

   }

   public void Run()
   { 
      Console.Clear();
      Console.WriteLine("Get ready.....");

      ShowSpinner(4);

      int time = GetTime();
      DateTime currentTime = DateTime.Now;
      DateTime futureTime = currentTime.AddSeconds(time);
      
      do 
      {
         Console.Clear();
         Console.Write("Breath IN... ");
         Thread.Sleep(500);
         ShowCountDown(5);

         Console.WriteLine("");
         Console.Write("Breath OUT... ");
         Thread.Sleep(500);
         ShowCountDown(5);

         currentTime = DateTime.Now;

      }while (currentTime < futureTime);

      Console.WriteLine("");
      Console.WriteLine("");
      
      EndDisplay();
      ShowSpinner(4);
   }
}