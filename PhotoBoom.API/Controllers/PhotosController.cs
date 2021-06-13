using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhotoBoom.Business.Abstract;
using PhotoBoom.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PhotoBoom.Business.Concrete;

namespace PhotoBoom.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotosController : ControllerBase
    {
        private IPhotoService _photoService;

        public PhotosController(IPhotoService photoService)
        {
            _photoService = photoService;
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
        public Photo Post([FromBody]Photo photo)
        {
            return _photoService.CreatePhoto(photo);
        }

        [HttpPut]
        public Photo Put([FromBody] Photo photo)
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
