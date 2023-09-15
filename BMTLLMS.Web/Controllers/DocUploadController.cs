using BMTLLMS.Domain.Models.Configuration;
using BMTLLMS.Domain.ViewModel;
using BMTLLMS.Domain.ViewModel.Request;
using BMTLLMS.Domain.ViewModel.Response;
using BMTLLMS.Service.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BMTLLMS.Web.Controllers
{
    public class DocUploadController : Controller
    {
         private readonly IDocUploadFacade _DocUploadFacade;
         public DocUploadController(IDocUploadFacade testStandardFacade)
         { 
            _DocUploadFacade = testStandardFacade;
         }
         [Authorize]
         public IActionResult Index()
         {
            return View();
         }
         [Authorize]
         public JsonResult GetDocUpload()
         {
           var response = new DocUploadResponseVM();
             try
             {
                  var result = _DocUploadFacade.GetDocUpload(0);
                  response.Data = result;
                  response.StatusCode = "200";
                  response.StatusMessage = "OK";
             }
              catch(Exception ex)
              {
                   /// Log write 
                  response.StatusCode = "500";
                  response.StatusMessage = ex.ToString();
             }
             return Json(response);
         }
         [HttpPost]
         [Authorize]
         public IActionResult DocUploadSave(DocUploadVM obj)
         {
            var user = User.Claims.ToList();
            obj.Creator = Convert.ToInt64(user[1].Value);
             if (ModelState.IsValid)
             {
               var result = _DocUploadFacade.SaveDocUpload(obj);
               return Json(result);
             };
            return Json(obj);  
         }
  
    }

}
