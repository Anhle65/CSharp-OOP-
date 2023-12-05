using System;
public class Stopwatch
{   
    private DateTime _start;
    private DateTime _end;
    private bool _isRunning;

    public void Start()
    {   
        if (_isRunning)
        {
            throw new InvalidOperationException("The stopwatch is still running");
        }
        _isRunning = true;
        _start = DateTime.Now;
    }
    public void Stop()
    {   
        if(!_isRunning)
        {
            throw new InvalidOperationException("The stopwatch has not started yet"); 
        }
        _isRunning = false;
        _end = DateTime.Now;
    }
    public TimeSpan Duration
    {
        get
        {
            var duration = _start - _end;
            return duration;
        }
    }
}