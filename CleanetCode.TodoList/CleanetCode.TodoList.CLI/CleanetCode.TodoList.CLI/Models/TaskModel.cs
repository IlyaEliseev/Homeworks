namespace CleanetCode.TodoList.CLI.Models
{
    public class TaskModel
    {
		public Guid Id { get; set; }
		public  int InStorrageId = 0;
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsCompleted { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
		public DateTime? DeletedDate { get; set; }
		public Guid UserId { get; set; }
	}
}
