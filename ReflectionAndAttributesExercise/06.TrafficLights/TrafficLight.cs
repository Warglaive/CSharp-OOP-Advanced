using System;

public class TrafficLight
{
    public Signal CurrentSignal;
    public TrafficLight(string signal)
    {
        this.CurrentSignal = (Signal)Enum.Parse(typeof(Signal), signal);
    }

    public void Update()
    {
        int previous = (int)this.CurrentSignal;
        var nameLength = Enum.GetNames(typeof(Signal)).Length;
        this.CurrentSignal = (Signal)(++previous % nameLength);
    }
}