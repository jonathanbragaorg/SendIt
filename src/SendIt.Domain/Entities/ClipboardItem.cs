namespace SendIt.Domain.Entities
{
    public class ClipboardItem
    {
        public int ClipboardItemId { get; set; }
        public string Content { get; set; }
        public int Category { get; set; }
        public DateTimeOffset CreateAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }

        public int ClipboardId { get; set; }
    }
}
