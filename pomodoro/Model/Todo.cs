namespace pomodoro.Model
{
    public class Todo
    {
        public int Id { get; set; }
        public string TaskTitle { get; set; }
        public DateTime TaskCreated { get; set; }   
        public bool SetReminder { get; set; } = false;
        public Status Status { get; set; }
        public ICollection<Reminder> Reminders { get; set; }    
    }

    public enum Status
    {
        Open,
        InProgress,
        Completed,
        Cancelled
    }

}
