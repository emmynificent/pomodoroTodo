namespace pomodoro.Model
{
    public class Reminder
    {
        public int Id { get; set; }
        public int TodoId { get; set; }
        public Todo Todo { get; set; }
        public DateTime DateTimeReminder { get; set; }
    }
}
