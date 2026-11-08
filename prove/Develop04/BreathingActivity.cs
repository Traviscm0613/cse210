using System;
using System.Threading;

class BreathingActivity : BaseActivity
{

    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {  
    }
        
    public void RunActivity()
    {
        // call Start Activity() method

        // RunCountDownMessage("Get Ready", 5);
        // StartTimer();
        // // DateTime endTime = DateTime.Now.AddSeconds(20);
        // // while(DateTime.Now < endTime)
        // while(! HasTimerExpired()) // Add when code is ready
        // {
        //     RunCountDownMessage("Breath In", 4);
        //     RunCountDownMessage("Breath Out", 6);
        // }

        // // Call EndActivity()


        // Pulls from base activity
        StartActivity();

        while (!HasTimerExpired())
        {
            int seconds = Math.Min(4, SecondsRemaining());
            if (seconds > 0)
            {
                RunCountDownMessage("Breathe In", seconds);
            }

            seconds = Math.Min(6, SecondsRemaining());
            if (seconds > 0)
            {
                RunCountDownMessage("Breathe Out", seconds);
            }
        }
        // Pulls from base activity
        DisplayEnding();
    }
}