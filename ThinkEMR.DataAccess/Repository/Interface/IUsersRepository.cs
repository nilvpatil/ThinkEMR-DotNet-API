﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThinkEMR_Care.DataAccess.Models;

namespace ThinkEMR_Care.DataAccess.Repository.Interface
{
    public interface IUsersRepository
    {
        Task<List<StaffUser>> GetStaffUsers();
        Task<StaffUser> AddStaffUsers(StaffUser staffUser);
        Task<StaffUser> GetStaffUsersById(int id);
        Task<StaffUser> EditStaffUsers(int id, StaffUser staffUser);
        Task<StaffUser> DeleteStaffUsers(int id);
    }
}
