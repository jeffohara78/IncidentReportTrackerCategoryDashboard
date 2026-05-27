using System;

namespace IncidentReportTracker
{
    // This class represents ONE incident report.
    public class IncidentReport
    {
        public int IncidentId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Severity { get; set; }

        public bool IsResolved { get; set; }

        public DateTime DateCreated { get; set; }

        // UPDATE ADDED 05/27/2026:
        // Stores the type/category of incident.
        // Examples: Phishing, Malware, Unauthorized Access, Data Leak
        public string Category { get; set; }

        // NEW FOR JSON:
        // System.Text.Json needs a parameterless constructor
        // so it can rebuild objects when loading from the JSON file.
        public IncidentReport()
        {
        }

        // Constructor used when creating a new incident normally.
        // UPDATE MODIFIED 05/27/2026:
        // Added category so every new incident has both a severity and an incident type.
        public IncidentReport(int incidentId, string title, string description, string severity, string category)
        {
            IncidentId = incidentId;
            Title = title;
            Description = description;
            Severity = severity;
            Category = category;
            IsResolved = false;
            DateCreated = DateTime.Now;
        }
    }
}