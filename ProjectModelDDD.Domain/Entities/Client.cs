
using System;

namespace ProjectModelDDD.Domain.Entities
{
    public class Client : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public bool Active { get; set; }
        public bool SpecialClient(Client client)
        {
            return client.Active && DateTime.Now.Year - client.Created.Year >= 5;
        }
    }
}
