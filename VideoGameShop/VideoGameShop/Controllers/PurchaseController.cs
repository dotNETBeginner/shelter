using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VideoGameShop.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VideoGameShop.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly IUserLibraryRelativeTable purchaseobj;

        public PurchaseController(IUserLibraryRelativeTable _purchaseobj)
        { purchaseobj = _purchaseobj; }

        [HttpPost]
        [Route("Create")]
        public int Create([FromBody] UserLibraryRelativeTable purchase)
        { return purchaseobj.AddPurchase(purchase); }

        [HttpGet]
        [Route("Index")]
        public IEnumerable<UserLibraryRelativeTable> Index()
        { return purchaseobj.GetAllPurchase(); }

        [HttpGet]
        [Route("Details/{Id_Purchase}")]
        public UserLibraryRelativeTable Details(int Id_Purchase)
        { return purchaseobj.GetPurchaseById(Id_Purchase); }

        [HttpDelete]
        [Route("Delete/{Id_Purchase}")]
        public int Delete(int Id_Purchase)
        { return purchaseobj.DeletePurchase(Id_Purchase); }
    }
}
