using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Threading.Tasks;

namespace HostelManagementApp.Models
{
    public class Hostel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public HostelTaxRegisterationInfo TaxInfo { get; set; } //for 1 to 1
        public ICollection<HostelBranch> Branches { get; set; } //1 to many
    }


    //protected override void OnModelCreating(Modelbuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Company>()
    //        .HasMany(c => c.Employees)
    //        .WithOne(e => e.Company);
    //---------------------------------OR
    //modelBuilder.Entity<Employee>()
    //    .HasOne(e => e.Company)
    //    .WithMany(c => c.Employees);
    //---------------------------------OR  IsRequired
    //modelBuilder.Entity<Company>()
    //    .HasMany(c => c.Employees)
    //    .WithOne(e => e.Company).
    //    .IsRequired();
    ////--------------------------------- OR Cascading Referential Integrity Constraints l
    ///modelBuilder.Entity<Company>()
    //.HasMany(c => c.Employees)
    //.WithOne(e => e.Company).
    //.OnDelete(DeleteBehavior.SetNull); //set to NULL  //DeleteBehavior.Delete

    //Fluent API FOR 1 to 1
    //modelBuilder.Entity<Author>()
    //    .HasOne(a => a.Biography)
    //    .WithOne(b => b.Author)
    //    .HasForeignKey<AuthorBiography>(b => b.AuthorRef);
    //}

    //----------------------------------------------TABLE SPLITTING -single table to represent both entities in a one-to-one
    /*
     * public class Author
{
    public int AuthorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public AuthorBiography Biography { get; set; }
}
public class AuthorBiography
{
    public int AuthorBiographyId { get; set; }
    public string Biography { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PlaceOfBirth { get; set; }
    public string Nationality { get; set; }
    public int AuthorRef { get; set; }
    public Author Author { get; set; }
}
     modelBuilder.Entity<Author>()
		.HasOne(a => a.AuthorBiography).WithOne(b => b.Author)
		.HasForeignKey<AuthorBiography>(e => e.AuthorId);
	modelBuilder.Entity<Author>().ToTable("Authors");
	modelBuilder.Entity<AuthorBiography>().ToTable("Authors"); 
     
     
     */
    //------------------------  MANY to MANY  oin table will be named after the join entity  by connvention
    /*
     *  modelBuilder.Entity<BookCategory>()
        .HasKey(bc => new { bc.BookId, bc.CategoryId });  
    modelBuilder.Entity<BookCategory>()
        .HasOne(bc => bc.Book)
        .WithMany(b => b.BookCategories)
        .HasForeignKey(bc => bc.BookId);  
    modelBuilder.Entity<BookCategory>()
        .HasOne(bc => bc.Category)
        .WithMany(c => c.BookCategories)
        .HasForeignKey(bc => bc.CategoryId);
     */

    //------------- CONCURRENCY
    /*
     * modelBuilder.Entity<Author>().Property(a => a.LastName).IsConcurrencyToken();
     */
    //-------------------   Adding a RowVersion property -> DbUpdateException 
    /*
      [TimeStamp]
        public byte[] RowVersion { get; set; }
     OR 
        modelBuilder.Entity<Author>().Property(a => a.RowVersion).IsRowVersion();
    OR
    modelBuilder.Entity<Author>().Property(a => a.RowVersion).IsConcurrencyToken().ValueGeneratedOnAddOrUpdate();
     

    //var books = context.Books.FromSqlRaw("SELECT BookId, Title, AuthorId, Isbn FROM Books").ToList();
    
    //var p1 = new SqlParameter("@Id", id);
    //var author = db.Authors.FromSqlRaw($"SELECT * From Authors Where AuthorId = @Id", p1).FirstOrDefault();

    //SPs
    
    var authorId = new SqlParameter("@AuthorId", 1);
    var books = context.Books.FromSqlRaw("EXEC GetBooksByAuthor @AuthorId" , authorId).ToList();
    
    
    --------------Database.ExecuteSqlCommand 
    using(var context = new SampleContext())
{
    var commandText = "INSERT Categories (CategoryName) VALUES (@CategoryName)";
    var name = new SqlParameter("@CategoryName", "Test");
    context.Database.ExecuteSqlCommand(commandText, name);
}
    -----------------ADO.NET via the Context.Database
using (var context = new SampleContext())
using (var command = context.Database.GetDbConnection().CreateCommand())
{
    command.CommandText = "SELECT * From Table1";
    context.Database.OpenConnection();
    using (var result = command.ExecuteReader())
    {
        // do something with result
    }
}
    //------------------ Lazy Loading
        1. Using Proxies
        2. Using the ILazyLoader service


     */

}
