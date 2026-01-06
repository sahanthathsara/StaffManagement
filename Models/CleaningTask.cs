namespace StaffManagement.Models
{
    public class CleaningTask
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public int AssignedStaffId { get; set; }
        public User Staff { get; set; }
    }
}
