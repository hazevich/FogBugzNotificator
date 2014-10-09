namespace FogBugzApi.Models
{
    public class FogBugzCase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Priority { get; set; }
        public string Status { get; set; }

        public override bool Equals(object obj)
        {
            FogBugzCase c = obj as FogBugzCase;

            if (this.Id == c.Id && this.Title == c.Title && this.Priority == c.Priority && this.Status == c.Status)
                return true;
            else
                return false;
        }
    }
}
