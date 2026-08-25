using Seido.Utilities.SeedGenerator;
namespace Models;

public class CreditCard : ICreditCard
{
    public Guid CreditCardId { get; set; }
    public string CreditCardNumber { get; set; }
    public string ExpiryMonth { get; set; }
    public string ExpiryYear { get; set; }

    public bool Seeded { get; set; } = false;
    public CreditCard Seed(SeedGenerator seeder)
    {
        Seeded = true;
        CreditCardId = Guid.NewGuid();
        CreditCardNumber = $"{seeder.Next(1000, 9999)}-{seeder.Next(1000, 9999)}-{seeder.Next(1000, 9999)}-{seeder.Next(1000, 9999)}";
        ExpiryYear = $"{seeder.Next(2026, 2033)}";
        ExpiryMonth = $"{seeder.Next(1, 12):D2}";

        return this;
    }

}