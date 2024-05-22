using System;
using System.ComponentModel;
using FiorelloFront.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace FiorelloFront.ViewComponents
{
	public class HeaderViewComponent : ViewComponent
	{
		private readonly ISettingService _settingService;
		public HeaderViewComponent(ISettingService settingService)
		{
			_settingService = settingService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			return await Task.FromResult(View(await _settingService.GetAllAsync()));
		}
	}
}

