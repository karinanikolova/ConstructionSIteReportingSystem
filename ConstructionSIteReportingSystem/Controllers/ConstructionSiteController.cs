﻿using ConstructionSiteReportingSystem.Core.Contracts;
using ConstructionSiteReportingSystem.Core.Models.Site;
using Microsoft.AspNetCore.Mvc;

namespace ConstructionSiteReportingSystem.Controllers
{
	public class ConstructionSiteController : BaseController
	{
		private readonly ILogger<ConstructionSiteController> _logger;
		private readonly IConstructionSiteService _constructionSiteService;

		public ConstructionSiteController(ILogger<ConstructionSiteController> logger, IConstructionSiteService constructionSiteService)
		{
			_logger = logger;
			_constructionSiteService = constructionSiteService;
		}

		[HttpGet]
		public async Task<IActionResult> Site(int id, [FromQuery]SiteQueryModel model)
		{
			var site = await _constructionSiteService.GetSiteAsync(
				id,
				model.Stage,
				model.SearchDate,
				model.Sorting,
				model.CurrentPage,
				SiteQueryModel.WorksPerPage);

			if (site == null)
			{
				return BadRequest();
			}

			model.StagesWithWorks = site.StagesWithWorks;
			model.TotalWorksCount = site.TotalWorksCount;
			model.SiteName = site.SiteName;
			model.ConstructionFinishDate = site.ConstructionFinishDate;
			model.Stages = await _constructionSiteService.GetAllStagesNamesAsync();

			return View(model);
		}
	}
}
