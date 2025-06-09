using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;

namespace MyRecipeBook.Application.UseCases.User.Register
{
    public class RegisterUserUseCase
    {
        public ResponseRegisteredUserJson Execute(RequestRegisterUserJson request)
        {
            // Validate request
            Validate(request);
               
            // Mapping request in an entity

            // Encription password

            // Save in the database

            return new ResponseRegisteredUserJson
            {
                Name = request.Name,
            };
        }

        private void Validate(RequestRegisterUserJson request)
        {
            var validator = new RegisterUserValidator();

            var result = validator.Validate(request);

            if ((result.IsValid == false))
            {
                var errorMessages = result.Errors.Select(e => e.ErrorMessage);
                throw new Exception();
            }
        }
    }
}
