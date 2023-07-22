using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = ".NET Deneme Makalesi - 1",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec faucibus elit, quis egestas massa. Ut nec viverra enim. Donec sed laoreet risus. Aenean egestas auctor turpis at laoreet. Sed tincidunt risus vitae lorem semper, et finibus neque porta. Morbi laoreet efficitur nunc, sed sagittis mi. Praesent semper posuere quam a porta. Aliquam efficitur imperdiet arcu et posuere. Quisque non ornare turpis, non ultrices massa. Donec urna tortor, interdum ultrices tincidunt et, tincidunt et ex.",
                ViewCount = 15,
                CategoryId = Guid.Parse("764F8A12-B9C3-411B-9C65-B1CF1E15D595"),               
                ImageId = Guid.Parse("AD7476C8-DAFA-4379-A3C3-376F6212ABC5"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("F34456B2-2DEF-4B91-805E-24FB21544602"),
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio Deneme Makalesi - 1",
                Content = "Visual Ut nec viverra enim. Donec sed laoreet risus. Aenean egestas auctor turpis at laoreet. Sed tincidunt risus vitae lorem semper, et finibus neque porta. Morbi laoreet efficitur nunc, sed sagittis mi. Praesent semper posuere quam a porta. Aliquam efficitur imperdiet arcu et posuere. Quisque non ornare turpis, non ultrices massa. Donec urna tortor, interdum ultrices tincidunt et, tincidunt et ex.",
                ViewCount = 25,  
                CategoryId = Guid.Parse("D913FB49-6D85-488F-9EE2-42BFDBA43B2E"),                
                ImageId = Guid.Parse("FE0D98EB-3CAD-4836-AD2A-51B9A41B1ADE"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("B1FB55DF-2930-4211-A479-DFE0D5297675"),
            }
            );
        }
    }
}
