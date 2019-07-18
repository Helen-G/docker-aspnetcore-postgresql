
using dockerapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace dockerapi.Maps{
    #pragma warning disable CS1591
    public class TodoMap
    {
        public TodoMap(EntityTypeBuilder<Todo> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.ToTable("todo");

            entityBuilder.Property(x => x.Id).HasColumnName("id");
            entityBuilder.Property(x => x.Title).HasColumnName("title");
            
            entityBuilder.Property(x => x.StartDate).HasColumnName("start_date");
            entityBuilder.Property(x => x.EndDate).HasColumnName("end_date");

            entityBuilder.Property(x => x.Priority).HasColumnName("priority");
        }
    }
    #pragma warning restore CS1591
}