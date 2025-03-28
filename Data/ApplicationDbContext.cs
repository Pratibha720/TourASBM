using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TourASBM.Models;

namespace TourASBM.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Differentiator> Differentiators { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<FacultyMember> FacultyMembers { get; set; }
        public DbSet<AcademicProgram> AcademicPrograms { get; set; }
        public DbSet<Organogram> Organograms { get; set; }
        public DbSet<MediaSpeak> MediaSpeaks { get; set; }
        public DbSet<TourASBM.Models.ApplicationForm> ApplicationForm { get; set; }


        // Add the missing models
        public DbSet<AdmissionProcess> AdmissionProcesses { get; set; }
        public DbSet<Fee> Fees { get; set; }
        public DbSet<ApplicationForm> ApplicationForms { get; set; }
        public DbSet<OnlineFeePayment> OnlineFeePayments { get; set; }
        public DbSet<EducationLoan> EducationLoans { get; set; }
    }
}

