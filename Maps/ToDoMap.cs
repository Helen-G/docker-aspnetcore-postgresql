using dockerapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace dockerapi.Maps{
    #pragma warning disable CS1591
       public class ToDoMap
    {
        public ToDoMap(EntityTypeBuilder<ToDo> entityBuilder)
        {
            entityBuilder.HasKey(x => x.Id);
            entityBuilder.ToTable("toDo");

            entityBuilder.Property(x => x.Id).HasColumnName("id");
            entityBuilder.Property(x => x.Title).HasColumnName("title");
            entityBuilder.Property(x => x.StartDate).HasColumnName("startDate");
            entityBuilder.Property(x => x.EndDate).HasColumnName("endDate");
            entityBuilder.Property(x => x.Priority).HasColumnName("priority");
        }
    }
    #pragma warning restore CS1591
}