using ProjectBlazor.Data;

namespace ProjectBlazor.Services
{
    public partial class VehiculoService 
	{
		public readonly IApplicationDbContext dbContext;
		public VehiculoService(IApplicationDbContext dbContext) 
		{ 
			this.dbContext = dbContext;
		}

		public async Task<Result> Create(VehiculoRequest producto)
		{
			try
			{
				var entity = Producto.Create(producto.Nombre, producto.Descripcion, producto.CategoriaId, producto.Precio);
				dbContext.Productos.Add(entity);
				await dbContext.SaveChangesAsync();
				return Result.Success("✅Producto registrado con exito!");
			}
			catch (Exception Ex)
			{
				return Result.Failure($"☠️ Error: {Ex.Message}");
			}
		}
	}
}
