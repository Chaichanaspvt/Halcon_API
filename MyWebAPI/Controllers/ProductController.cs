using Microsoft.AspNetCore.Mvc;
using HalconDotNet;
namespace MyWebAPI.Controllers
{
    // * dont fix path for controller
    [Route("api/private/[controller]")]
    [ApiController]
    public class ProductController  : ControllerBase
    {
    // hostlocal:5000/api/private/Products
      [HttpGet]
      public string GetProductAll()
      {
        return "SP Visoin ";
      }
    
  // ! Cannot use same HttpGet name
    //   [HttpGet]
    //   public string test()
    //   {
    //     return "SP Visoin ";
    //   }


    // hostlocal:5000/api/private/Products/value ?
      [HttpGet("{pathImg}")]
      public string GetProductby(string pathImg)
      {
        HObject RawImage;
        HTuple Width ,Height;
        HOperatorSet.ReadImage(out RawImage,@"C:\Users\Public\Documents\MVTec\HALCON-20.11-Steady\examples\images\bicycle\bicycle_01.png");
        HOperatorSet.GetImageSize(RawImage,out Width,out Height);
        return  pathImg+ "\n"+"Width : " + Width.ToString() + "\n" + "Height : " + Height.ToString() ;
      }
    }
}