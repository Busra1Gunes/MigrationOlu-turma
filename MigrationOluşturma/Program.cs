// See https://aka.ms/new-console-template for more information
using MigrationOluşturma.Model.Context;
using MigrationOluşturma.Model.Entity;

Console.WriteLine("Hello, World!");

//bu şekilde veri tabanı ve tablo oluşturulur
VerilerDbContext Veri = new VerilerDbContext();
Veri.Database.Create();



//bu şekilde eklenen tabloya veri kaydı yapılır 
//VerilerDbContext a = new VerilerDbContext();
//a.Users.Add(new User
//{
//    Name = "Büşra",
//    Surname = "Güneş"
//});
//a.SaveChanges();


//bu şekilde veri güncellenmekte
//VerilerDbContext Veri = new VerilerDbContext();
//User ornek = Veri.Users.FirstOrDefault(o => o.id == 1);
//ornek.Name = "Büşra";
//ornek.Surname = "Güneş Güneş";
//Veri.SaveChanges();


//bu şekildede verilen id deki veriyi silme işlemi yapılır 
//VerilerDbContext Veri = new VerilerDbContext();
//User ornek = Veri.Users.FirstOrDefault(o => o.id == 1);
//Veri.Users.Remove(ornek);
//Veri.SaveChanges();