using Bogus;

namespace ContentGenerator;
class Program {  
  static void Main(string[] args) {
    
    var faker = new Faker<Sale>()      
      .RuleFor(s => s.Product, f => f.Commerce.Product())
      .RuleFor(s => s.Quantity, f => f.Random.Int(1, 100))
      .RuleFor(s => s.UnitPrice, f => decimal.Parse(f.Commerce.Price(100, 50000, 2)))
      .RuleFor(s => s.Date, f => f.Date.Between(new DateTime(2018, 1, 1), new DateTime(2025, 1, 1)));
    
    var fileManager = new FileManager();

    for (int i = 1; i <= (int)1e4; i++)
    { 
      var saleData = faker.Generate();
      
      fileManager.InsertDataIntoFile(saleData.Date, saleData.Product, saleData.Quantity, saleData.UnitPrice);
    }
  }  
}
