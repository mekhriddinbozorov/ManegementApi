using System.Collections.Generic;
using System.Linq;

namespace ManegementApi.Models
{
    public class MockStaffRepository : IStaffRepository
    {
        private readonly List<Staff> _staff = null;
        public MockStaffRepository()
        {
            _staff = new List<Staff>()
            {
                new Staff() {Id = 1, FirstName = "Malik", LastName = "Shox", Email = "usmon@virtualdars.com", Department="Admin" },
                new Staff() {Id = 2, FirstName = "Salohiddin", LastName = "Ayyubiy", Email = "usmon@virtualdars.com", Department="Production" },
                new Staff() {Id = 3, FirstName = "Usmon", LastName = "G'oziy", Email = "usmon@virtualdars.com", Department="R&D" }
            };
        }

        public Staff Create(Staff staff)
        {
            staff.Id = _staff.Max(s=>s.Id)+1;
            _staff.Add(staff);
            return staff;
        }

        public Staff Delete(int id)
        {
            var staff = _staff.FirstOrDefault(s => s.Id == id);
            _staff.Remove(staff);
            return staff;
        }

        public Staff Get(int id)
        {
            return _staff.FirstOrDefault(x => x.Id.Equals(id));
        }

        public IEnumerable<Staff> GetAll()
        {
            return _staff;
        }

        public Staff Update(Staff staff)
        {
            var upd = _staff.FirstOrDefault(x => x.Id.Equals(staff.Id));
            upd.FirstName=staff.FirstName;
            upd.LastName=staff.LastName;
            upd.Email=staff.Email;
            upd.Department=staff.Department;
            return upd;
        }
    }
}
