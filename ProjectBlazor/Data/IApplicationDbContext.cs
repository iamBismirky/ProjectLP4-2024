﻿using Microsoft.EntityFrameworkCore;
using ProjectBlazor.Entities;

namespace ProjectBlazor.Data
{
    public interface IApplicationDbContext
    {
		DbSet<Vehiculo> Vehiculos { get; set; }
		Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

	}
}