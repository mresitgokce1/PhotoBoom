using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoBoom.Business.Abstract;
using PhotoBoom.Entities;
using PhotoBoom.DataAccess.Abstract;
using PhotoBoom.DataAccess.Concrete;

namespace PhotoBoom.Business.Concrete
{
    public class PhotoManager : IPhotoService
    {
        private IPhotoRepository _photoRepository;

        public PhotoManager()
        {
            _photoRepository = new PhotoRepository();
        }
        public Photo CreatePhoto(Photo photo)
        {
            return _photoRepository.CreatePhoto(photo);
        }

        public void DeletePhoto(int id)
        {
            _photoRepository.DeletePhoto(id);
        }

        public List<Photo> GetAllPhotos()
        {
            return _photoRepository.GetAllPhotos();
        }

        public Photo GetHotelById(int id)
        {
            return _photoRepository.GetPhotoById(id);
        }

        public Photo UpdatePhoto(Photo photo)
        {
            return _photoRepository.UpdatePhoto(photo);
        }
    }
}
