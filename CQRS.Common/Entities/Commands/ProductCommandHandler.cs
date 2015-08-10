namespace CQRS.Common.Entities.Commands
{
    public class ProductCommandHandler
        : 
        ICommandHandler<AddProductCommand>,
        ICommandHandler<RemoveProductCommand>
    {
        public void Handle(AddProductCommand command)
        {
            var product = new Product
            {
                Description = command.Description,
                Price = command.Price
            };

            //save into repository...
        }

        public void Handle(RemoveProductCommand command)
        {
            //var product = _repository.get(command.Id);
            //_repository.update(product);
        }
    }
}