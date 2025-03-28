namespace TourASBM.Models
{
    public class ApplicationForm
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string DocumentPath { get; set; } = string.Empty; // Add this property
    }
}
