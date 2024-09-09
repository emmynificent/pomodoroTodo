using Microsoft.EntityFrameworkCore;
using pomodoro.Model;
namespace pomodoro.Data
{
    public class TaskDbContext: DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options): base(options) 
        {

        }
        public DbSet<Todo> Todo { get; set; }  
        public DbSet<Reminder> Reminders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Reminder>()
                .HasOne(r => r.Todo)
                .WithMany(r => r.Reminders)
                .HasForeignKey(r => r.TodoId);
        }
    }
}
