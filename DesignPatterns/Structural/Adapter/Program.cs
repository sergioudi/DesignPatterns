
Console.Title = "Adapter";
{
    Console.WriteLine("Using Adapter.ClassAdapter");

    // adapter example (same code for object & class adapter)
    Adapter.ClassAdapter.ICityAdapter adapter = new Adapter.ClassAdapter.CityAdapter();
    var city = adapter.GetCity();

    Console.WriteLine($"{city.FullName}, {city.Inhabitants}");
}

{
    Console.WriteLine("\nUsing Adapter.ObjectAdapter");

    // adapter example (same code for object & class adapter)
    Adapter.ObjectAdapter.ICityAdapter adapter = new Adapter.ObjectAdapter.CityAdapter();
    var city = adapter.GetCity();

    Console.WriteLine($"{city.FullName}, {city.Inhabitants}");
}

Console.ReadKey(); 