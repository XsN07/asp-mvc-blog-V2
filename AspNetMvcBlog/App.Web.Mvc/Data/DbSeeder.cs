using App.Web.Mvc.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace App.Web.Mvc.Data
{
  public class DbSeeder
  {

    public static void Seed(ModelBuilder modelBuilder)
    {
      //Category
      modelBuilder.Entity<Category>().HasData(
          new Category
          {
            Id = 1,
            CategoryName = "Technology"
          },
          new Category
          {
            Id = 2,
            CategoryName = "Nature"
          }
          );
      //User
      modelBuilder.Entity<User>().HasData(
          new User
          {
            Id = 1,
            UserName = "Hasan",
            UserSurname = "Ardanuç",
            UserNick = "XsN",
            UserEmail = "xsn07@gmail.com",
            UserPassword = "0608"
          },
          new User
          {
            Id = 2,
            UserName = "Serra",
            UserSurname = "Ardanuç",
            UserNick = "tosbik",
            UserEmail = "serra06@gmail.com",
            UserPassword = "0770"
          }
          );
      //Post
      modelBuilder.Entity<Post>().HasData(
          new Post
          {
            Id = 1,
            PostTitle = "Lorem ipsum dolor sit amet.",
            PostContext = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce elementum, enim et dapibus efficitur, augue augue blandit ex, et scelerisque orci felis ",
            UserId = 1
          },
           new Post
           {
             Id = 2,
             PostTitle = "Consectetur adipiscing.",
             PostContext = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin vulputate id nisi tristique ullamcorper. Vestibulum aliquam ipsum ac diam lacinia, vitae po",
             UserId = 2
           }
          );

    }
  }


}
