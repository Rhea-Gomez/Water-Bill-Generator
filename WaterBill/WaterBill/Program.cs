class WaterBill
{
    static int TotalWaterBill(int units)
    {
        int meter_charge = 75;
        int charge;
        if(units <= 100)
        {
            charge = units * 5;
        }
        else if(units > 100 && units <= 250)
        {
            charge = units * 10;
        } 
        else
        {
            charge = units * 20;
        }
        int total_water_bill = charge + meter_charge;
        return total_water_bill;

        
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter the no. of units consumed: ");
        int no_of_units = int.Parse(Console.ReadLine());
        int bill = TotalWaterBill(no_of_units);
        Console.Write("Total Water Bill: " +bill);
        
    }
}
