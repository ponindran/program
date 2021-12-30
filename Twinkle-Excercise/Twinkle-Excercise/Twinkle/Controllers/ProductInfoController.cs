using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Store.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Twinkle.Models;
using Twinkle.Models.ViewModels;
using Twinkle.Mvc.BusinessService.Contract;

namespace Twinkle.Controllers
{

    public class ProductInfoController : Controller
    {
        private readonly IProductService _product;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private IMapper _mapper;
        private ILogwrapper<ProductInfoController> _logger;

        public ProductInfoController(IProductService product, IMapper mapper, ILogwrapper<ProductInfoController> logger, IWebHostEnvironment webHostEnvironment)
        {
            _product = product;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
            _logger = logger;
        }


        public async Task<IActionResult> Index()
        {
            var name = await _product.SearchAsync();

            var user = _mapper.Map<List<ProductInfo>, List<ProductInfoVM>>(name);

            return View(user);
        }


        //GET - UPSERT
        public async Task<IActionResult> Upsert(int? productId)
        {

            var productInfoVM = new ProductInfoVM();

            if (productId == null)
            {
                //this is for create
                return View(productInfoVM);
            }
            else
            {
                var name = await _product.SearchAsync();

                var prodtEntity = name.FirstOrDefault(x=> x.ProductId == productId);

                if (prodtEntity == null)
                {
                    return NotFound();
                }
                productInfoVM = _mapper.Map<ProductInfo, ProductInfoVM>(prodtEntity);
                return View(productInfoVM);
            }
        }


        //POST - UPSERT
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Upsert(ProductInfoVM productVM)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                string webRootPath = _webHostEnvironment.WebRootPath;

                if (productVM.ProductId == 0)
                {
                    //Creating
                    string upload = webRootPath + WC.ImagePath;
                    string fileName = Guid.NewGuid().ToString();
                    string extension = Path.GetExtension(files[0].FileName);

                    using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }

                    productVM.Image = fileName + extension;
                    productVM.CreatedOn = DateTime.UtcNow.ToString();

                    var productInfo = _mapper.Map<ProductInfoVM,ProductInfo>(productVM);
                    productInfo.PriceInfo = _mapper.Map<ProductInfoVM, PriceInfo>(productVM);

                    await _product.CreateAsync(productInfo);
                }
                else
                {
                    //updating
                    var productInfoLst = await  _product.SearchAsync();
                    var productInfo = productInfoLst.FirstOrDefault(x => x.ProductId == productVM.ProductId);

                    if (files.Count > 0)
                    {
                        string upload = webRootPath + WC.ImagePath;
                        string fileName = Guid.NewGuid().ToString();
                        string extension = Path.GetExtension(files[0].FileName);

                        var oldFile = Path.Combine(upload, productInfo.Image);

                        if (System.IO.File.Exists(oldFile))
                        {
                            System.IO.File.Delete(oldFile);
                        }

                        using (var fileStream = new FileStream(Path.Combine(upload, fileName + extension), FileMode.Create))
                        {
                            files[0].CopyTo(fileStream);
                        }

                        productInfo.Image = fileName + extension;
                        productInfo.Name = productVM.Name;
                        productInfo.Description = productVM.Description;
                        productInfo.ShortDesc = productVM.ShortDesc;
                        productInfo.PriceInfo.Price = productVM.Price;

                        
                    }
                    else
                    {
                        productInfo.Name = productVM.Name;
                        productInfo.Description = productVM.Description;
                        productInfo.ShortDesc = productVM.ShortDesc;
                        productInfo.PriceInfo.Price = productVM.Price;
                    }

                    await _product.UpdateAsync(productInfo);
                }

                return RedirectToAction("Index");
            }
            
            return View(productVM);
        }

   
        //GET - DELETE
        public async Task<IActionResult> Delete(int? productId)
        {
            if (productId == null || productId == 0)
            {
                return NotFound();
            }
            var productInfoLst = await _product.SearchAsync();
            var productInfo = productInfoLst.FirstOrDefault(x => x.ProductId == productId);
            if (productInfo == null)
            {
                return NotFound();
            }

            var productInfoVM = _mapper.Map<ProductInfo, ProductInfoVM>(productInfo);

            return View(productInfoVM);
        }

        //POST - DELETE
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? productId)
        {
            //var obj = _db.Product.Find(id);
            //if (obj == null)
            //{
            //    return NotFound();
            //}

            //string upload = _webHostEnvironment.WebRootPath + WC.ImagePath;
            //var oldFile = Path.Combine(upload, obj.Image);

            //if (System.IO.File.Exists(oldFile))
            //{
            //    System.IO.File.Delete(oldFile);
            //}


            //_db.Product.Remove(obj);
            //    _db.SaveChanges();
                return RedirectToAction("Index");
            

        }

    }
}
