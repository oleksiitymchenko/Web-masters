using System;

namespace Common
{
    public class DescriptionDto
    {
        public Guid Id { get; set; }

        public string DescriptionTextSmall { get; set; }
        public string DescriptionTextFull { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
    }
}
