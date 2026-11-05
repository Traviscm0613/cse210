class BreathingActivity : BaseActivity
{

    public BreathingActivity() : base()
    {
        
    }
    public void RunActivity()
    {
        // call Start Activity() method

        RunCountDownMessage("Get Ready", 5);
        StartTimer();
        // DateTime endTime = DateTime.Now.AddSeconds(20);
        // while(DateTime.Now < endTime)
        while(! HasTimerExpired()) // Add when code is ready
        {
            RunCountDownMessage("Breath In", 4);
            RunCountDownMessage("Breath Out", 6);
        }

        // Call EndActivity()
    }
}