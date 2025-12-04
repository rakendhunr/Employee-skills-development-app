namespace EmployeeSkillDevelopmentApi.Models
{
    public class EmployeeSkill
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int SkillId { get; set; }
        public string Level { get; set; } // Beginner, Intermediate, Expert

        public Employee Employee { get; set; }
        public Skills Skill { get; set; }
    }
}
