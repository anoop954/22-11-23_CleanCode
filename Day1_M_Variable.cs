  Review1.cs
public bool IsShopOpen(string day)
{
    if (!string.IsNullOrEmpty(day))
    {
        day = day.ToLower();
        if (day == "friday")
        {
            return true;
        }
        else if (day == "saturday")
        {
            return true;
        }
        else if (day == "sunday")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }

}


var openDays = new HashSet<string>()
{
    "friday",
    "saturday",
    "sunday"
};

public bool IsShopOpen(string day)
{
    day = day.ToLower();
    if (openDays.Contains(day))
    {
        return true;
    }
    else
    {
        return false;
    }
}


  Review3.cs
public long Fibonacci(int n)
{
    if (n < 50)
    {
        if (n != 0)
        {
            if (n != 1)
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            else
            {
                return 1;
            }
        }
        else
        {
            return 0;
        }
    }
    else
    {
        throw new System.Exception("Not supported");
    }
}


public long Fibonacci(int n)
{
    if (n == 0 || n == 1)
    {
        return n;
    }

    if (n < 50)
    {
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
    else
    {
        throw new System.Exception("Not supported");
    }
}


  Review4.cs
var l = new[] { "Austin", "New York", "San Francisco" };

for (var i = 0; i < l.Count(); i++)
{
    var li = l[i];
    DoStuff();
    DoSomeOtherStuff();

    // ...
    // ...
    // ...
    // Wait, what is `li` for again?
    Dispatch(li);
}


var listOfCities = new[] { "Austin", "New York", "San Francisco" };

for (var i = 0; i < listOfCities.Count(); i++)
{
    var city = listOfCities[i];
    DoStuff();
    DoSomeOtherStuff();

    // ...
    // ...
    // ...
    // Wait, what is `li` for again?
    Dispatch(city);
}


  Review5.cs
if (userRole == 8) // Check if Admin 
{
    
}

const int ADMIN=8;
if (userRole == ADMIN) // Check if Admin 
{
    
}


  Review6.cs
public class Car
{
    public string CarMake { get; set; }
    public string CarModel { get; set; }
    public string CarColor { get; set; }

    //...
}

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    //...
}


  Review7.cs
var ymdstr = DateTime.UtcNow.ToString("MMMM dd, yyyy");

var dateInMonthDayYear = DateTime.UtcNow.ToString("MMMM, dd, yyyy");


  Review9.cs
public void CreateMicrobrewery(string name = null)
{
    var breweryName = !string.IsNullOrEmpty(name) ? name : "Hipster Brew Co.";
    // ...
}

public void CreateMicrobrewery(string name)
{
    var breweryName = name ?? "Hipster Brew Co.";
    // ...
}
