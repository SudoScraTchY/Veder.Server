using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Contexts;

public class ReadDbContext(DbContextOptions options) : DbContext(options)
{
    
}