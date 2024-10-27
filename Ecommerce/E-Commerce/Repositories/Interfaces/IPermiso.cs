﻿using E_Commerce.Models;

namespace E_Commerce.Repositories.Interfaces
{
    public interface IPermiso
    {
        Task<List<Permiso>> GetPermiso();
        Task<bool> PostPermiso(Permiso permiso);
    }
}