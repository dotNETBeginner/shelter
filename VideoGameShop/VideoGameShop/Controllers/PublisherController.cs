using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoGameShop.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideoGameShop.Controllers
{
    public class PublisherController : Controller
    {
        private readonly IPublishers publisherobj;
        
        public PublisherController(IPublishers _publisherobj)
        { publisherobj = _publisherobj; }

        [HttpPost]
        [Route("Create")]
        public int Create([FromBody] Publishers publisher)
        { return publisherobj.AddPublisher(publisher); }

        [HttpGet]
        [Route("Index")]
        public IEnumerable<Publishers> Index()
        { return publisherobj.GetAllPublishers(); }

        [HttpGet]
        [Route("Details/{Id_Publisher}")]
        public Publishers Details(int Id_Publisher)
        { return publisherobj.GetPublisherById(Id_Publisher); }

        [HttpPut]
        [Route("Edit")]
        public int Edit([FromBody]Publishers publisher)
        { return publisherobj.UpdatePublishers(publisher); }

        [HttpDelete]
        [Route("Delete/{Id_Publisher}")]
        public int Delete(int Id_Publisher)
        { return publisherobj.DeletePublishers(Id_Publisher); }

    }
}
