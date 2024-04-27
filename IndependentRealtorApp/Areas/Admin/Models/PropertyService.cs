using IndependentRealtorApp.Models.DataLayer;
using IndependentRealtorApp.Models.DomainModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace IndependentRealtorApp.Area.Admin.Models
{
    public class PropertyService
    {
        private readonly RealtorContext _context;

        public PropertyService(RealtorContext context)
        {
            _context = context;
        }

        public Property? GetPropertyById(int id)
        {
            return _context.Properties.Find(id);
        }

        public List<Property> GetProperties()
        {
            return _context.Properties.ToList();
        }

        public void AddProperty(Property property)
        {
            if (property.Id == 0)
            {
                _context.Add(property);
            }
            else
            {
                _context.Update(property);
            }
        }

        public void UpdateProperty(Property property)
        {
            try
            {
                _context.Update(property);
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException is SqlException sqlEx && sqlEx.Number == 547)
                {
                    // Handle foreign key violation exception here
                    Console.WriteLine("Cannot update property. The RealtorId does not exist.");
                }
                else
                {
                    throw;
                }
            }
        }

        public void Delete(Property property)
        {
            _context.Properties.Remove(property);
            _context.SaveChanges();
        }

        public void DeleteProperty(int id)
        {
            var property = _context.Properties.Find(id);
            if (property != null)
            {
                _context.Properties.Remove(property);
                _context.SaveChanges();
            }
        }
    }
}