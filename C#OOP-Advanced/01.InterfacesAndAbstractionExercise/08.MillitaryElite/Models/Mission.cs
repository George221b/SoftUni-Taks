using System;

namespace _08.MillitaryElite.Models
{
    public class Mission
    {
        private string state;

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName { get; set; }
        public string State
        {
            get { return this.state; }
            set
            {
                if (value == "inProgress" || value == "Finished")
                {
                    this.state = value;
                }
                else
                {
                    throw new ArgumentException($"Invalid {nameof(this.State)}");
                }
            }
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}