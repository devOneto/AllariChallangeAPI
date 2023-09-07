using AllariChallangeAPI.Models;
using System.Text.Json;

public interface IFruitRepository
{
    public Task<IList<Fruit>> GetAll();
}

public class FruitRepository : IFruitRepository
{
    public async Task<IList<Fruit>> GetAll()
    {
        await Task.Delay(1000);
        string fruitList = @"[
            {
                ""Name"": ""Apple"",
                ""Color"": ""Red"",
                ""Flavor"": ""Sweet"",
                ""Origin"": ""Brazil"",
                ""Quantity"": 10
            },
            {
                ""Name"": ""Banana"",
                ""Color"": ""Yellow"",
                ""Flavor"": ""Sweet"",
                ""Origin"": ""Ecuador"",
                ""Quantity"": 15
            },
            {
                ""Name"": ""Orange"",
                ""Color"": ""Orange"",
                ""Flavor"": ""Tangy"",
                ""Origin"": ""Spain"",
                ""Quantity"": 20
            },
            {
                ""Name"": ""Strawberry"",
                ""Color"": ""Red"",
                ""Flavor"": ""Sweet"",
                ""Origin"": ""United States"",
                ""Quantity"": 8
            },
            {
                ""Name"": ""Grape"",
                ""Color"": ""Purple"",
                ""Flavor"": ""Sweet"",
                ""Origin"": ""Italy"",
                ""Quantity"": 12
            },
            {
                ""Name"": ""Pear"",
                ""Color"": ""Green"",
                ""Flavor"": ""Sweet"",
                ""Origin"": ""Portugal"",
                ""Quantity"": 18
            },
            {
                ""Name"": ""Pineapple"",
                ""Color"": ""Yellow"",
                ""Flavor"": ""Tangy"",
                ""Origin"": ""Costa Rica"",
                ""Quantity"": 14
            },
            {
                ""Name"": ""Kiwi"",
                ""Color"": ""Green"",
                ""Flavor"": ""Sweet"",
                ""Origin"": ""New Zealand"",
                ""Quantity"": 9
            },
            {
                ""Name"": ""Mango"",
                ""Color"": ""Yellow"",
                ""Flavor"": ""Sweet"",
                ""Origin"": ""India"",
                ""Quantity"": 7
            },
            {
                ""Name"": ""Cherry"",
                ""Color"": ""Red"",
                ""Flavor"": ""Sweet"",
                ""Origin"": ""Chile"",
                ""Quantity"": 11
            },
            {
                ""Name"": ""Watermelon"",
                ""Color"": ""Green"",
                ""Flavor"": ""Sweet"",
                ""Origin"": ""Brazil"",
                ""Quantity"": 6
            },
            {
                ""Name"": ""Lemon"",
                ""Color"": ""Green"",
                ""Flavor"": ""Tangy"",
                ""Origin"": ""Mexico"",
                ""Quantity"": 22
            },
            {
                ""Name"": ""Peach"",
                ""Color"": ""Orange"",
                ""Flavor"": ""Sweet"",
                ""Origin"": ""USA"",
                ""Quantity"": 13
            },
            {
                ""Name"": ""Coconut"",
                ""Color"": ""Brown"",
                ""Flavor"": ""Sweet"",
                ""Origin"": ""Philippines"",
                ""Quantity"": 5
            },
            {
                ""Name"": ""Plum"",
                ""Color"": ""Purple"",
                ""Flavor"": ""Sweet"",
                ""Origin"": ""Chile"",
                ""Quantity"": 8
            },
            {
                ""Name"": ""Raspberry"",
                ""Color"": ""Red"",
                ""Flavor"": ""Sweet"",
                ""Origin"": ""Canada"",
                ""Quantity"": 9
            },
            {
                ""Name"": ""Cashew"",
                ""Color"": ""Yellow"",
                ""Flavor"": ""Tangy"",
                ""Origin"": ""Brazil"",
                ""Quantity"": 17
            },
            {
                ""Name"": ""Guava"",
                ""Color"": ""Green"",
                ""Flavor"": ""Sweet"",
                ""Origin"": ""Brazil"",
                ""Quantity"": 14
            },
            {
                ""Name"": ""Papaya"",
                ""Color"": ""Orange"",
                ""Flavor"": ""Sweet"",
                ""Origin"": ""Mexico"",
                ""Quantity"": 10
            }
            ]";
        return JsonSerializer.Deserialize<IList<Fruit>>(fruitList);
    }
}