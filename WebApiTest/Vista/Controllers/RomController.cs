using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Web.Http.Description;
using Vista.Models;
using System.Net;
using System.Net.Http;

namespace Vista.Controllers
{
    [System.Web.Http.RoutePrefix("api/ROM")]
    public class RomController : ApiController
    {
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("leer/{cara}")]
        [ResponseType(typeof(ESuic))]
        public IHttpActionResult LeerRom(int cara)
        {
            ESuic suic = new ESuic();
            suic.rom = LogicaTest.MasterLogica.LeerRom(cara);
            return Ok(suic);
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("escribir")]
        public IHttpActionResult EscribirRom(RSuic rsuic)
        {
            RSuic suic = rsuic;
            LogicaTest.MasterLogica.EscribirRom(suic.rom, 1);
            return Ok("ok");
        }
    }
}