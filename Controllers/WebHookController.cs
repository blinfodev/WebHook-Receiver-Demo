using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebHookReceiver.Models;
using Microsoft.Extensions.Primitives;
using System.IO;
using Newtonsoft.Json;

namespace WebHookReceiver.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WebHookController : ControllerBase
	{
		[HttpGet]
		public string Get() => "The WebHook application is functioning.";

		/// <summary>
		/// This value should be entered into Odyssey's system configuration.
		/// WARNING! Do not use this default value. Generate a new GUID using
		/// a tool such as https://www.guidgenerator.com/online-guid-generator.aspx
		/// </summary>
		private readonly string AccessToken = "1f133fcd-a43c-4a07-abd1-80efa742a0d7";

		[HttpPost]
		public dynamic Post(WebHookEvent webhookData)
		{
			// First, make sure that the request contains a X-Token HTTP header
			// that matches our pre-defined AccessToken. Doing this secures our
			// API to make sure that rogue requests aren't accepted.
			Request.Headers.TryGetValue("X-Token", out StringValues value);
			if (!value.Any() || value.First() != this.AccessToken) return Unauthorized();

			// Make sure a valid object was passed to the API.
			if (webhookData == null) return BadRequest();

			/*********

			YOUR CUSTOM CODE WOULD GO HERE.

			*********/
			// This example code logs whatever data we received to a .json file where this application runs.
			var guid = Guid.NewGuid();
			System.IO.File.WriteAllText($"DebugWebHook-{guid}.json", JsonConvert.SerializeObject(webhookData, Formatting.Indented));

			return webhookData;
			// This demo application returns the values that were passed to it.
			// You can also replace this line with the following:
			// return Ok();
		}
	}
}
