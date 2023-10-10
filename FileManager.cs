using CsvHelper;

using System.Text;
using System.Globalization;

namespace ContentGenerator;

class FileManager {
  const string PATH = "temp/sales.csv";
  const string SEPARATOR = ",";

  public void InsertDataIntoFile(DateTime date, string productName, int quantity, decimal unitPrice) {
    StringBuilder output = new StringBuilder();

    int newId = GetSales().Count() + 1;

    String[] newLine =
    {
      newId.ToString(),
      date.ToShortDateString(),
      productName,
      quantity.ToString(),
      unitPrice.ToString()
    };

    output.AppendLine(string.Join(SEPARATOR, newLine));
    File.AppendAllText(PATH, output.ToString());    

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{newId} - {productName} inserted successfully");
  }

  public IEnumerable<Sale> GetSales() {
    var reader = new StreamReader(PATH);
    var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

    var sales = csv.GetRecords<Sale>();

    return sales;
  }  
}
