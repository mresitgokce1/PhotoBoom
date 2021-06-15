using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhotoBoom.Business.Abstract;
using PhotoBoom.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using PhotoBoom.Business.Concrete;

namespace PhotoBoom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotosController : ControllerBase
    {
        private IPhotoService _photoService;
        private readonly IWebHostEnvironment _env;

        public PhotosController(IPhotoService photoService,IWebHostEnvironment env)
        {
            _photoService = photoService;
            _env = env;
        }

        [HttpGet]
        public List<Photo> Get()
        {
            return _photoService.GetAllPhotos();
        }

        [HttpGet("{id}")]
        public Photo Get(int id)
        {
            return _photoService.GetHotelById(id);
        }

        [HttpPost]
        public Photo Post([FromForm]string Title, [FromForm]string Tags, [FromForm]IFormFile Photos)
        {
            string imageName = Convert.ToString(Guid.NewGuid()) +"."+ Photos.FileName.Split(".").Last();

            var path = Path.Combine(_env.WebRootPath, "Images", imageName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                Photos.CopyTo(stream);

                Photo pht = new Photo
                {
                    Title = Title,
                    Tags = Tags,
                    Photos = imageName
                };
                return _photoService.CreatePhoto(pht);
            }
           

        }

        [HttpPut]
        public Photo Put([FromBody]Photo photo)
        {
            return _photoService.UpdatePhoto(photo);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _photoService.DeletePhoto(id);
        }
    }
}
