namespace WebAPI.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }

    public class TodoItemDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public string Secret { get; set; }
    }

    public static class TodoItemExtensions
    {
        public static TodoItemDTO ToDto(this TodoItem item)
        {
            return new TodoItemDTO
            {
                Id = item.Id,
                Name = item.Name,
                IsComplete = item.IsComplete
            };
        }
    }
}
