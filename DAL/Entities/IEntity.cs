using System;

namespace DAL.Entities
{
    public interface IEntity
    {
        DateTime PurchaseDate { get; set; }

        DateTime? ModifiedDate { get; set; }
    }
}