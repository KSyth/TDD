using System.Runtime.CompilerServices;
using ClassLibrary;

namespace TestTDD;

[TestClass]
public class SearchCitytest
{
    private SearchCity _searchCity;

    [TestMethod]
    public void When_searc_is_less_than_2()
    {
        _searchCity = new SearchCity();

        Assert.ThrowsException<NotFoundException>(() => _searchCity.FindCity("B"));

    }

    [TestMethod]
    public void When_search_is_more_than_2()
    {
        _searchCity = new SearchCity();

        var result = _searchCity.FindCity("Va");
        var excpected = new List<string>() { "Valence", "Vancouver" };
        
        CollectionAssert.AreEquivalent(excpected, result);
    }
}