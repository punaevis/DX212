using System;

namespace MauiAppCSharpBasic.Classes;

public class Car
{
    public string Model ; 
    public string Color ;
    public double Speed ; 
    public double Fuel ;
    public double TotalMile ;
    public double UsedFuelRate ; // xxx miles per liter


    public Car(string model, double speed, double fuel)
    {
        this.Model = model;
        this.Speed = speed;
        this.Fuel = fuel;
       
    }
    public void Run(double mile)
    {
        this.TotalMile += mile;
        var used_fuel = mile * this.UsedFuelRate;
        this.Fuel = this.Fuel - used_fuel;
    }

    public uint RaceTimeUsed(double mile)
    {
        var timeused = mile / Speed;
        this.Run(mile);
        return Convert.ToUInt16(timeused);
    }

    public string ShowInfo()
    {
        var info = $"Model: { this.Model } \nTotal Mile: { this.TotalMile} \nFuel: { this.Fuel }";
        return info;
    }

}
