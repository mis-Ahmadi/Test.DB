using Microsoft.EntityFrameworkCore;
using test.db.DB;
using test.db.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TestDB>(options =>
{
    options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=StudentsDB;Trusted_Connection=True");
});

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//app.UseHttpsRedirection();
app.MapPost("/Student/add", (TestDB db, Student student) =>
{
    db.Students.Add(student);
    db.SaveChanges();
});
app.MapPost("/Student/list", (TestDB db) =>
{
    return db.Students.ToList();
});
app.MapPost("/Student/update", (TestDB db, Student student) =>
{
    db.Students.Update(student);
    db.SaveChanges();
});
app.MapPost("/Student/remove{id}", (TestDB db, int id) =>
{
    var student = db.Students.Find(id);
    if (student != null)
    {
        db.Students.Remove(student);
        db.SaveChanges();
    }
});
app.Run();
