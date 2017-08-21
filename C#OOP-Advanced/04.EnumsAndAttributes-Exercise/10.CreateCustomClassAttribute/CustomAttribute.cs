using System;
using System.Collections.Generic;
using System.Text;

namespace _10.CreateCustomClassAttribute
{
    [AttributeUsage(AttributeTargets.Class)]
    class CustomAttribute : Attribute
    {
        public CustomAttribute(string author, int revision, string description, params string[] reviewers)
        {
            this.Author = author;
            this.Revision = revision;
            this.Description = description;
            this.Reviewers = new List<string>(reviewers);
        }

        public string Author { get; set; }
        public int Revision { get; set; }
        public string Description { get; set; }
        public List<string> Reviewers { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Author: {this.Author}");
            sb.AppendLine($"Revision: {this.Revision}");
            sb.AppendLine($"Class description: {this.Description}");
            sb.AppendLine($"Reviewers: {string.Join(", ", this.Reviewers)}");

            return sb.ToString().TrimEnd();
        }
    }
}
