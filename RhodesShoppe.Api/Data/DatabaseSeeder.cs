using RhodesShoppe.Api.Models;

public static class DatabaseSeeder
{
    public static void Seed(ShopContext context)
    {
        if (!context.Customers.Any())
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Name = "John Doe",
                    PhoneNumber = "123-456-7890",
                    Repairs = new List<GuitarRepair>
                    {
                        new GuitarRepair
                        {
                            GuitarModel = "Fender Stratocaster",
                            Issue = "Broken strings",
                            RepairStatus = "Pending",
                            CostEstimate = 50m,
                            DateReceived = DateTime.Now.AddDays(-1)
                        }
                    }
                },
                new Customer
                {
                    Name = "Jimi Hendrix",
                    PhoneNumber = "987-654-3210",
                    Repairs = new List<GuitarRepair>
                    {
                        new GuitarRepair
                        {
                            GuitarModel = "Gibson Les Paul",
                            Issue = "Pickup issue",
                            RepairStatus = "In Progress",
                            CostEstimate = 150m,
                            DateReceived = DateTime.Now.AddDays(-5)
                        }
                    }
                },
                new Customer
                {
                    Name = "Eric Clapton",
                    PhoneNumber = "456-789-1234",
                    Repairs = new List<GuitarRepair>
                    {
                        new GuitarRepair
                        {
                            GuitarModel = "Gibson SG",
                            Issue = "Fret buzzing",
                            RepairStatus = "Completed",
                            CostEstimate = 100m,
                            DateReceived = DateTime.Now.AddDays(-3)
                        }
                    }
                },
                new Customer
                {
                    Name = "Jimmy Page",
                    PhoneNumber = "321-654-9870",
                    Repairs = new List<GuitarRepair>
                    {
                        new GuitarRepair
                        {
                            GuitarModel = "Gibson EDS-1275",
                            Issue = "Neck adjustment",
                            RepairStatus = "Completed",
                            CostEstimate = 120m,
                            DateReceived = DateTime.Now.AddDays(-2)
                        }
                    }
                },
                new Customer
                {
                    Name = "B.B. King",
                    PhoneNumber = "654-321-0987",
                    Repairs = new List<GuitarRepair>
                    {
                        new GuitarRepair
                        {
                            GuitarModel = "Gibson Lucille",
                            Issue = "String change and setup",
                            RepairStatus = "Completed",
                            CostEstimate = 75m,
                            DateReceived = DateTime.Now.AddDays(-4)
                        }
                    }
                },
                new Customer
                {
                    Name = "Slash",
                    PhoneNumber = "789-012-3456",
                    Repairs = new List<GuitarRepair>
                    {
                        new GuitarRepair
                        {
                            GuitarModel = "Gibson Les Paul",
                            Issue = "Re-fretting",
                            RepairStatus = "Pending",
                            CostEstimate = 300m,
                            DateReceived = DateTime.Now
                        }
                    }
                },
                new Customer
                {
                    Name = "Chuck Berry",
                    PhoneNumber = "123-987-6543",
                    Repairs = new List<GuitarRepair>
                    {
                        new GuitarRepair
                        {
                            GuitarModel = "Gibson ES-335",
                            Issue = "Electronics repair",
                            RepairStatus = "In Progress",
                            CostEstimate = 200m,
                            DateReceived = DateTime.Now.AddDays(-1)
                        }
                    }
                },
                new Customer
                {
                    Name = "David Gilmour",
                    PhoneNumber = "456-123-7890",
                    Repairs = new List<GuitarRepair>
                    {
                        new GuitarRepair
                        {
                            GuitarModel = "Fender Stratocaster",
                            Issue = "Setup and tuning",
                            RepairStatus = "Completed",
                            CostEstimate = 80m,
                            DateReceived = DateTime.Now.AddDays(-6)
                        }
                    }
                },
                new Customer
                {
                    Name = "Keith Richards",
                    PhoneNumber = "321-456-7890",
                    Repairs = new List<GuitarRepair>
                    {
                        new GuitarRepair
                        {
                            GuitarModel = "Fender Telecaster",
                            Issue = "Bridge replacement",
                            RepairStatus = "Pending",
                            CostEstimate = 120m,
                            DateReceived = DateTime.Now
                        }
                    }
                }
            };

            context.Customers.AddRange(customers);
            context.SaveChanges();
        }
    }
}
