class BaseActivity
{

    private string _activityName;
    private string _activityDescription;
    private int _duration;
    private DateTime _endTime;


    public BaseActivity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;

       _duration = 10; //Replace with call to ObtainDuration();
    }

    public void StartActivity()
    {
        // Complete
    }

    public void StartTimer()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public void DisplayEnding()
    {
        // do
    }
    public bool HasTimerExpired()
    {
       return DateTime.Now > _endTime; 
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for(int i = seconds; i>0; i--)
        {
            Console.Clear();
            Console.WriteLine($"{message} - {i}");
            Thread.Sleep(1000);
        }
        Console.CursorVisible = true;
    }

    public void RunSpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        // DateTime now = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        // for(int i = 0; i < seconds; i++)
        while(DateTime.Now < endTime)
        {
            Console.Write("+");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
        }
        Console.CursorVisible = true;
    }

    public void ObtainDuration()
    {
        // do
    }

    public string GetPromptString()
    {
        
    }
}










// using System.Diagnostics.CodeAnalysis;

// class BaseActivity
// {

//     // TODO - Add attributes
//     public BaseActivity()
//     {
//         // TODO Fill in
//     }

//     public void RunCountDownMessage(string message, int seconds)
//     {
//         Console.CursorVisible = false;
//         for(int i=seconds; i>= 1; i--)
//         {
//             Console.Clear();
//             Console.Write($"{message} - {i}");
//             Thread.Sleep(1000);
//         }
//         Console.CursorVisible = true;
//     }

//     public void DisplaySpinnerMessage(string message, int seconds)
//     {
//         Console.CursorVisible = false;
//         Console.Clear();
//         Console.Write($"{message} ");
//         DateTime endTime = DateTime.Now.AddSeconds(seconds);

//         // for (int i=0; i < seconds; i++)
//         while (DateTime.Now < endTime)
//         {
//             Console.Write("+");
//             Thread.Sleep(200);
//             Console.Write("\b");
//             Console.Write("-");
//             Thread.Sleep(200);
//             Console.Write("\b");
//         }

//         Console.Clear();
       
//         Console.Write($"{message} ");
//         string spinnerAnimation = "-\\|/";
//         int index = 0;
//         for (int i=0; i<20; i++)
//         {
//             Console.Write($"{spinnerAnimation[index++ % spinnerAnimation.Length]}");
//             Console.Write("\b");
//             Thread.Sleep(300);
//         }
//         Console.Clear();

//         Console.Write($"{message} ");
//         string fishAnimation = "><))))o>";
//         for (int i=0; i<20; i++)
//         {
//             Console.Write($" {fishAnimation}");
//             Console.Write("\b\b\b\b\b\b\b\b");
//             Thread.Sleep(300);
//         }
//         Console.Clear();

//         Console.Write($"{message} ");
//         string faceAnimation = "(^_^)(-_-)";
//         for (int i=0; i<20; i++)
//         {
//             Console.Write($"{faceAnimation[0..5]}");
//             Thread.Sleep(300);
//             Console.Write("\b\b\b\b\b");
//             Console.Write($"{faceAnimation[5..]}");
//             Thread.Sleep(300);
//             Console.Write("\b\b\b\b\b");
//         }

//         Console.CursorVisible = true;
//     }
// }
// // }