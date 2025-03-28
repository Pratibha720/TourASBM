namespace TourASBM.Models
{
    // Model for Admission Process
    public class AdmissionProcess
    {
        public int Id { get; set; }
        public string StepTitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    // Model for Fee Details
    public class Fee
    {
        public int Id { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string PaymentSchedule { get; set; } = string.Empty;
    }

    // Model for Application Form
    public class ApplicationForm
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string CourseApplied { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
    }

    // Model for Online Fee Payment
    public class OnlineFeePayment
    {
        public int Id { get; set; }
        public int ApplicationFormId { get; set; }
        public decimal PaymentAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string TransactionId { get; set; } = string.Empty;
        public string PaymentStatus { get; set; } = string.Empty;
    }

    // Model for Education Loan Portal
    public class EducationLoan
    {
        public int Id { get; set; }
        public string BankName { get; set; } = string.Empty;
        public string LoanScheme { get; set; } = string.Empty;
        public decimal LoanAmount { get; set; }
        public string EligibilityCriteria { get; set; } = string.Empty;
        public string ContactDetails { get; set; } = string.Empty;
    }
}
