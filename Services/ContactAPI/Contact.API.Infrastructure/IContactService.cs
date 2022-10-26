using Contact.API.Models;

namespace Contact.API.Infrastructure
{
    public interface IContactService
    {
        ContactDTO GetContectById(int Id);
    }
}
