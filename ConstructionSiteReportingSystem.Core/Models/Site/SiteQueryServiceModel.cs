﻿namespace ConstructionSiteReportingSystem.Core.Models.Site
{
    public class SiteQueryServiceModel
    {
        public string SiteName { get; set; } = string.Empty;

        public DateTime ConstructionFinishDate { get; set; }

        public int TotalWorksCount { get; set; }

        public ICollection<StageViewModel> StagesWithWorks { get; set; } = new List<StageViewModel>();

		public IEnumerable<WorkViewModel> AllWorksWithoutStages { get; set; } = new List<WorkViewModel>();
	}
}