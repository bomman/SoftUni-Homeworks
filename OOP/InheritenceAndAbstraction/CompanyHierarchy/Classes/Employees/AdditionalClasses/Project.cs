using System;
using CompanyHierarchy.Enumarator;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes.Employees.AdditionalClasses
{
    class Project : IProject
    {
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private StateOfProject state;

        public Project(string projectName, DateTime projectStartDate, string details)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            
        }

        public string ProjectName
        {
            get { return this.projectName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("ProjectName", "Product name cannot be empty or null.");
                }
                this.projectName = value;
            }
        }
        public DateTime ProjectStartDate { get; set; }

        public string Details { get; set; }

        public StateOfProject State
        {
            get
            {
                return this.state;
            }
            private set
            {
                if (ProjectStartDate > DateTime.Now)
                {
                    this.state = StateOfProject.Closed;
                }
                else
                {
                    this.state = StateOfProject.Open;
                }
            }
        }
        public void CloseProject()
        {
            state = StateOfProject.Closed;
        }

        public override string ToString()
        {
            return string.Format(
                "Project Name: {0}\nProject Start Date: {1}\nProject Details: {2}\nProject State: {3}", this.ProjectName,
                this.ProjectStartDate, this.Details, this.State);
        }
    }
}
