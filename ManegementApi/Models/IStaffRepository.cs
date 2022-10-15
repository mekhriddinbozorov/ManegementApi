﻿using System.Collections.Generic;

namespace ManegementApi.Models
{
    public interface IStaffRepository
    {
        Staff Get(int id);

        IEnumerable<Staff> GetAll();

        Staff Create(Staff staff);

        Staff Update(Staff staff);

        Staff Delete(int id);
    }
}
