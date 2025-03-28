namespace TourASBM.Models
{
    // Model for Differentiators Section
    public class Differentiator
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconPath { get; set; } // Optional for images/icons
    }

    // Model for Message Section
    public class Message
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; } // For Profile Picture
    }

    // Model for Faculty Section
    public class FacultyMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Qualification { get; set; }
        public string ProfilePicturePath { get; set; }
    }

    // Model for Academic Section
    public class AcademicProgram
    {
        public int Id { get; set; }
        public string ProgramName { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
    }

    // Model for Organogram Section
    public class Organogram
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string ProfilePicturePath { get; set; }
    }

    // Model for Media Speaks Section
    public class MediaSpeak
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string MediaName { get; set; }
        public string DatePublished { get; set; }
        public string ArticleLink { get; set; }
    }
}
