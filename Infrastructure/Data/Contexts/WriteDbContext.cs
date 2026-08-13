using Domain.Common.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Contexts;

public class WriteDbContext(DbContextOptions options) : DbContext(options)
{
    
}