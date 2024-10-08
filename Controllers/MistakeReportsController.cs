﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TelemarketingControlSystem.ActionFilters;
using TelemarketingControlSystem.Services.Auth;
using TelemarketingControlSystem.Services.MistakeReportService;
using TelemarketingControlSystem.Services.ProjectEvaluationService;
using static TelemarketingControlSystem.Services.Auth.AuthModels;

namespace TelemarketingControlSystem.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MistakeReportsController : BaseController
	{
		private readonly IMistakeReportService _mistakeReportService;
		private readonly IJwtService _jwtService;
		private readonly IHttpContextAccessor _contextAccessor;

		public MistakeReportsController(IMistakeReportService mistakeReportService, IJwtService jwtService, IHttpContextAccessor contextAccessor)
		{
			_mistakeReportService = mistakeReportService;
			_jwtService = jwtService;
			_contextAccessor = contextAccessor;
		}
		private TenantDto authData()
		{
			string Header = _contextAccessor.HttpContext.Request.Headers["Authorization"];
			var token = Header.Split(' ').Last();
			TenantDto result = _jwtService.TokenConverter(token);
			if (result is null)
				return null;
			return result;
		}

		[HttpGet("projectTypeMistakeDictionary")]
		[TypeFilter(typeof(AuthTenant), Arguments = ["Admin"])]
		public IActionResult projectTypeMistakeDictionary(int projectTypeId) => _returnResultWithMessage(_mistakeReportService.projectTypeMistakeDictionary(projectTypeId));


		[HttpPut("updateProjectTypeMistakeDictionary")]
		[TypeFilter(typeof(AuthTenant), Arguments = ["Admin"])]
		public IActionResult updateProjectTypeMistakeDictionary(UpdateProjectTypeMistakeDictionaryDto dto) => _returnResultWithMessage(_mistakeReportService.updateProjectTypeMistakeDictionary(dto, authData()));


		[HttpGet("projectMistakeDictionary")]
		[TypeFilter(typeof(AuthTenant), Arguments = ["Admin"])]
		public IActionResult projectMistakeDictionary(int projectId) => _returnResultWithMessage(_mistakeReportService.projectMistakeDictionary(projectId));

		[HttpPut("updateProjectMistakeDictionary")]
		[TypeFilter(typeof(AuthTenant), Arguments = ["Admin"])]
		public IActionResult updateProjectMistakeDictionary(UpdateProjectMistakeDictionaryDto dto) => _returnResultWithMessage(_mistakeReportService.updateProjectMistakeDictionary(dto, authData()));
	}
}
