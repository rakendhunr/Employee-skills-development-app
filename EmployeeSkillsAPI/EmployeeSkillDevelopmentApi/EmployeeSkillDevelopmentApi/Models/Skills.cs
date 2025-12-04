namespace EmployeeSkillDevelopmentApi.Models
{
    public class Skills
    {
        public int SkillId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
