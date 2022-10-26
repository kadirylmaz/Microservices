using Contact.API.Infrastructure;
using Contact.API.Models;

namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContectById(int Id)
        {
            return new ContactDTO()
            {
                Id = Id,
                FirstName = "Kadir",
                LastName = "Yılmaz"
            };
        }
    }
}
