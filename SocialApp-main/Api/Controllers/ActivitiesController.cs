using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Persistance;

namespace Api.Controllers;

    [Route("[controller]")]
    public class ActivitiesController : Controller
    {
        private readonly DataContext _dataContext;
        public ActivitiesController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

         [HttpGet]
        public ActionResult <IList<Activity>> GetAll ()
        {
           var result = _dataContext.Activities.ToList();
           return Ok(result);
        }
        [HttpGet]
        [Route("GetById")]
        public ActionResult GetById(Guid Id)
        {
            var result = _dataContext.Activities.Find(Id);
            return Ok(result);
        }
}