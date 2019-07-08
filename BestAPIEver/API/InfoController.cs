using BestAPIEver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace BestAPIEver.API {

	[RoutePrefix("api/info")]
	public class InfoController : ApiController {
		[HttpGet]
		[Route("GetUserInfo")]
		public IHttpActionResult GetUserInfo() {
			UserInfo userInfo = new UserInfo() {
				Age = 20,
				FullName = "Aleksander Marinov"
			};

			return Ok(userInfo);
		}

		[HttpPost]
		[Route("SetUserInfo")]
		public IHttpActionResult SetUserInfo([FromBody]UserInfo userInfo) {
			return Ok("Wohoooooo!");
		}
    }
}