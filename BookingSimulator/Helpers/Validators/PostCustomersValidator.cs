using BookingSimulator.BusinessLayers.Models.Customers;
using FluentValidation;

namespace BookingSimulator.Helpers.Validators
{
    public class PostCustomersValidator : AbstractValidator<PostCustomerModel>
    {
        public PostCustomersValidator()
        {
            RuleFor(customer => customer.Cf).Must(BeAValidCf).WithMessage($"Codice fiscale inserito non valido");
            RuleFor(customer => customer.Name).Length(2, 20);
            RuleFor(customer => customer.Surname).Length(2, 20);

            //ALTRI ESEMPI

            //RuleFor(customer => customer.Age).InclusiveBetween(18, 100);
            //RuleFor(customer => customer.Email).EmailAddress();
            //RuleFor(customer => customer.CreditCard).CreditCard();

            
            //VALIDARE COLLECTION PROPERTIES(List<string> Contacts)

            //RuleForEach(customer => customer.Contacts).Length(9, 11);

            
            //VALIDARE PROPERTIES COMPLESSE 

            //RuleFor(customer => customer.Address).SetValidator(new AddressValidator());

            //public class AddressValidator : AbstractValidator<Address>
            //{
            //    public PostCustomersValidator()
            //    {
            //          RuleFor(address => address.Postcode).NotNull();
            //    }
            //}
        }

        private bool BeAValidCf(string cf)
        {
            if (String.IsNullOrEmpty(cf) || cf.Length < 16) 
                return false;
            
            return true;
        }
    }
}
