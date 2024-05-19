namespace worker.API.Models
{
    public class RolePostModel
    {
        public string Name { get; set; }
        public bool IsAdministrative { get; set; }
        public DateTime StartDate { get; set; }
    }
}
