using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TimeTrackingServer.Models;
using Microsoft.EntityFrameworkCore;

namespace TimeTrackingServer.Controllers
{
    public class BaseController : Controller
    {
        internal TimeTrackingDBContext context;
        public BaseController(){

            // context = new TimeTrackingDBContext();
        }
        
       protected override void Dispose(bool disposing){
          
           base.Dispose(disposing);
       }
    }
}
