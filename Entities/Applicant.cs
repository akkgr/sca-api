namespace Sca.Api.Entities
{
    public class Applicant : Person
    {
        public string ApplicationNumber { get; set; }

        public string ApplicationCode { get; set; }

        public string Publication { get; set; }

        public int? Points { get; set; }

        public string Remarks { get; set; }

        public string RemarksPublic { get; set; }

        public string Result { get; set; }

        public string Degree { get; set; }

        public string OrgTreeNode { get; set; }

        public string Specialty { get; set; }
    }
}