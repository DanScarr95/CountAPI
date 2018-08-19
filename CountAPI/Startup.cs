﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CountAPI
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			
			services.AddMvc()
					.SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
		}

		public void Configure(IApplicationBuilder app)
		{
			app.UseMvc();
		}
	}
}