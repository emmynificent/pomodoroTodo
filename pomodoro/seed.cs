using pomodoro.Data;
using pomodoro.Model;

namespace pomodoro
{
    public class seed
    {
        private readonly TaskDbContext taskdbContext;

        public seed(TaskDbContext context)
        {
            this.taskdbContext = context;
        }
        public void SeedDbContext()
        {
            if (!taskdbContext.Todo.Any())
            {
                var todo = new List<Todo>()
                {
                    new Todo()
                    {
                        Id = 1,
                        TaskTitle = "Buy Groceries",
                        TaskCreated = DateTime.Parse("2022-01-01T12:00:00"),
                        SetReminder = true,
                        Status = Status.Open,
                    },
                    new Todo()
                    {
                         Id = 2,
                        TaskTitle = "Finish project report",
                        TaskCreated = DateTime.Parse("2022-01-05T10:00:00"),
                        SetReminder = true,
                        Status = Status.InProgress,
                    },
                    new Todo()
                    {
                         Id = 3,
                        TaskTitle = "Meet with the team",
                        TaskCreated = DateTime.Parse("2022-01-03T14:00:00"),
                        SetReminder = true,
                        Status = Status.Open,
                    },
                    new Todo()
                    {
                         Id = 4,
                        TaskTitle = "Submit proposal",
                        TaskCreated = DateTime.Parse("2022-01-08T16:00:00"),
                        SetReminder = true,
                        Status = Status.Completed,
                    },
                    new Todo()
                    {
                         Id = 5,
                        TaskTitle = "Call client",
                        TaskCreated = DateTime.Parse("2022-01-02T11:00:00"),
                        SetReminder = true,
                        Status = Status.Open,
                    },
                    new Todo()
                    {
                         Id = 6,
                        TaskTitle = "Standup meeting",
                        TaskCreated = DateTime.Parse("2022-01-06T07:00:00"),
                        SetReminder = true,
                        Status = Status.Completed,
                    },
                };

                var reminders = new List<Reminder>()
                {
                    new Reminder()
                    {
                        Id = 1,
                        TodoId = 1,
                        DateTimeReminder = DateTime.Parse("2022-01-01T18:00:00")
                    },
                    new Reminder()
                    {
                        Id = 2,
                        TodoId = 3,
                        DateTimeReminder = DateTime.Parse("2022-01-03T13:00:00")
                    },
                    new Reminder()
                    {
                        Id = 3,
                        TodoId = 5,
                        DateTimeReminder = DateTime.Parse("2022-01-02T10:00:00")
                    }

                };
                taskdbContext.Todo.AddRange(todo);
                taskdbContext.SaveChanges();
            }
        }
    }
}
