using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HRIS.Provider;
using HRIS.ViewModel.Tests;

namespace HRIS.Main.Controllers
{
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var vm = TestProvider.GetProvider().GetGrid();
            return View(vm);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            var vm = new TestUpsertVM();
            return View(vm);
        }

        [HttpGet]
        public IActionResult Update(string candidateId)
        {
            var vm = TestProvider.GetProvider().GetSingle(candidateId);
            return View(vm);
        }

        [HttpPost]
        public IActionResult Save(TestUpsertVM vm)
        {
            if (string.IsNullOrEmpty(vm.CandidateId))
            {
                TestProvider.GetProvider().Insert(vm);
            }
            else
            {
                TestProvider.GetProvider().Update(vm);
            }
            return RedirectToAction("Index");
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult Delete(string candidateId)
        {
            TestProvider.GetProvider().Delete(candidateId);
            return RedirectToAction("Index");
        }
    }
}
