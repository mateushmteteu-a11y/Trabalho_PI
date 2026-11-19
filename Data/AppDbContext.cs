using CrudEF.Models;
using Microsoft.EntityFrameworkCore;

optionsBuilder.UseSqlServer(
    @"Server=localhost;
    Database=;
    User = root;
    Password=Senac2026;"
)