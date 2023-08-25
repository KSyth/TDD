namespace ClassLibrary;

public class SearchCity
{
    private List<string> _cities = new ()
    {
        "Paris",
        "Budapest", "Skopje", "Rotterdam", "Valence", "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York", "Londres", "Bangkok", "Hong Kong", "Dubaï", "Rome", "Istanbul"
    };
    

    public List<string> FindCity(string search)
    {
        var cityFind = new List<string>();
        
        if (search.Length < 2)
        {
            throw new NotFoundException();
        }
        // else if (search.Length >= 2)
        // {
        //     foreach (var city in _cities)
        //     {
        //         if (city.Contains(search))
        //             Console.WriteLine(city);
        //             // cityFind.Add(city);
        //     }
        // }
        // else if (search == "*")
        // {
        //     cityFind = new List<string>(_cities);
        // }
        //
        // // Console.WriteLine("[{0}]", string.Join(", ", cityFind));
        return cityFind;
    }
    
}

public class NotFoundException : Exception
{
    public NotFoundException() : base("La recherche doit être supérieur à 2 lettre")
    {
    }
}