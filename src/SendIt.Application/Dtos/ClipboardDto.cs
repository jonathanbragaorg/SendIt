namespace SendIt.Application.Dtos
{
    public class ClipboardDto
    {
        public int ClipboardId { get; set; }
        public int UserId { get; set; }
        public string ClipboardName { get; set; }
        public DateTimeOffset CreateAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
    }
}
