using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using nuCypherUI.Utils;

namespace nuCypherUI.Controllers
{
    public class CustomController : Controller
    {
        private Cerberus _cerberus;

        public Cerberus Cerberus
        {
            get { return _cerberus = _cerberus ?? new Cerberus(); }
        }


        private ApiDataAdapter _apiDataAdapter;

        public ApiDataAdapter ApiDataAdapter
        {
            get { return _apiDataAdapter = _apiDataAdapter ?? new ApiDataAdapter(); }
        }
    }
}