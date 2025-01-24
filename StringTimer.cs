public class StringTimer
{
    public static string StringTimerFormat(int time)
    {
        string displayedTime = "";

        if (time < 60)
        {
            displayedTime = (time < 10) ? $"00:0{time}" : $"00:{time}";
        }
        else if ((time >= 60) && (time < 3600))
        {
            displayedTime =
                ((time / 60) < 10)
                ? ((time % 60 < 10)
                    ? $"0{time / 60}:0{time % 60}" : $"0{time / 60}:{time % 60}")
                : ((time % 60 < 10)
                    ? $"{time / 60}:0{time % 60}" : $"{time / 60}:{time % 60}");
        }
        else if (time >= 3600)
        {
            int hour = 0;

            if (time / 3600 > 1)
            {
                hour = (time / 3600) - 1;
                time -= 3600 * hour;
            }

            displayedTime =
                (hour + 1 < 10)
                ? (((time - 3600) / 60 < 10)
                    ? ((time % 60 < 10)
                        ? $"0{hour + 1}:0{(time - 3600) / 60}:0{time % 60}" : $"0{hour + 1}:0{(time - 3600) / 60}:{time % 60}")
                    : ((time % 60 < 10)
                        ? $"0{hour + 1}:{(time - 3600) / 60}:0{time % 60}" : $"0{hour + 1}:{(time - 3600) / 60}:{time % 60}"))
                : (((time - 3600) / 60 < 10)
                    ? ((time % 60 < 10)
                        ? $"{hour + 1}:0{(time - 3600) / 60}:0{time % 60}" : $"{hour + 1}:0{(time - 3600) / 60}:{time % 60}")
                    : ((time % 60 < 10)
                        ? $"{hour + 1}:{(time - 3600) / 60}:0{time % 60}" : $"{hour + 1}:{(time - 3600) / 60}:{time % 60}"));
        }

        return displayedTime;
    }

    // the same code but in if/else format
    /*
    public static string StringTimerFormat(int time)
    {
        string displayedTime = "";

        if (time < 60)
        {
            if (time < 10) { displayedTime = $"00:0{time}"; }
            else { displayedTime = $"00:{time}"; }
        }
        else if ((time >= 60) && (time < 3600))
        {
            if ((int)(time / 60.0) < 10)
            {
                if (time % 60 < 10) { displayedTime = $"0{(int)(time / 60)}:0{time % 60}"; }
                else { displayedTime = $"0{(int)(time / 60)}:{time % 60}"; }
            }
            else
            {
                if (time % 60 < 10) { displayedTime = $"{(int)(time / 60)}:0{time % 60}"; }
                else { displayedTime = $"{(int)(time / 60)}:{time % 60}"; }
            }
        }
        else if (time >= 3600)
        {
            int hour = 0;

            if (time / 3600 > 1)
            {
                hour = ((int)time / 3600) - 1;
                time -= (3600 * hour);
            }

            if (hour + 1 < 10)
            {
                if ((int)((time - 3600) / 60) < 10)
                {
                    if (time % 60 < 10) { displayedTime = $"0{hour + 1}:0{(int)((time - 3600) / 60)}:0{time % 60}"; }
                    else { displayedTime = $"0{hour + 1}:0{(int)((time - 3600) / 60)}:{time % 60}"; }
                }
                else
                {
                    if (time % 60 < 10) { displayedTime = $"0{hour + 1}:{(int)((time - 3600) / 60)}:0{time % 60}"; }
                    else { displayedTime = $"0{hour + 1}:{(int)((time - 3600) / 60)}:{time % 60}"; }
                }
            }
            else
            {
                if ((int)((time - 3600) / 60) < 10)
                {
                    if (time % 60 < 10) { displayedTime = $"{hour + 1}:0{(int)((time - 3600) / 60)}:0{time % 60}"; }
                    else { displayedTime = $"{hour + 1}:0{(int)((time - 3600) / 60)}:{time % 60}"; }
                }
                else
                {
                    if (time % 60 < 10) { displayedTime = $"{hour + 1}:{(int)((time - 3600) / 60)}:0{time % 60}"; }
                    else { displayedTime = $"{hour + 1}:{(int)((time - 3600) / 60)}:{time % 60}"; }
                }
            }
        }

        return displayedTime;
    }
    */
}



/*

How to use:
1. Just call the public static method "StringTimerFormat" from your script.


Documentation:
- The integer parameter "time" is the displayed time, which will be converted to the "string time" format.
  You can also pass the float parameter just by using: (int)someFloatValue.


Comment:
- You can use this method for timers or clocks in your game.

*/