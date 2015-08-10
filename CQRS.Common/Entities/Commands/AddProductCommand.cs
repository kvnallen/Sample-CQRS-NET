using System;

namespace CQRS.Common.Entities.Commands
{
    public class AddProductCommand
    {
        public AddProductCommand(string description, decimal price)
        {
            Description = description;
            Price = price;
        }

        public string Description { get; private set; }
        public decimal Price { get; private set; }
    }
}