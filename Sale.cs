namespace ContentGenerator;

class Sale {
  public int Id { get; set; }
  public dynamic Date { get; set; }
  public string? Product { get; set; }
  public int Quantity { get; set; }
  public decimal UnitPrice { get; set; }
}
