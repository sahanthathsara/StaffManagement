namespace StaffManagement.Models
{
    public class CookTask
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public int AssignedCookId { get; set; }
        public User Cook { get; set; }
    }
}
