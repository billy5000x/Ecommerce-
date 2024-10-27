﻿using E_Commerce.Context;
using E_Commerce.Models;
using E_Commerce.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Repositories
{
    public class DetallesPedidosRepository : IDetallesPedidos
    {
        public readonly E_commerceContext context;

        public DetallesPedidosRepository(E_commerceContext context)
        {
            this.context = context;
        }

        public async Task<List<DetallesPedidos>> GetDetallesPedidos()
        {
            var data = await context.DetallesPedidos.ToListAsync();
            return data;
        }

        public async Task<bool> PostDetallesPedidos(DetallesPedidos detallesPedidos)
        {
            await context.DetallesPedidos.AddAsync(detallesPedidos);
            await context.SaveAsync();
            return true;
        }
    }
}