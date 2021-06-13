using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoBoom.DataAccess.Abstract;
using PhotoBoom.Entities;

namespace PhotoBoom.DataAccess.Concrete
{
    class PhotoRepository : IPhotoRepository
    {
        public Photo CreateHotel(Photo photo)
        {
            using var photoDbContext = new PhotoBoomDbContext();
            photoDbContext.Photos.Add(photo);
            photoDbContext.SaveChanges();
            return photo;
        }

        public void Delete(int id)
        {
            using var photoDbContext = new PhotoBoomDbContext();
            var deletePhoto = GetPhotoById(id);
            photoDbContext.Photos.Remove(deletePhoto);
            photoDbContext.SaveChanges();
        }

        public List<Photo> GetAllPhotos()
        {
            using var photoDbContext = new PhotoBoomDbContext();
            return photoDbContext.Photos.ToList();
        }

        public Photo GetPhotoById(int id)
        {
            using var photoDbContext = new PhotoBoomDbContext();
            return photoDbContext.Photos.Find(id);
        }

        public Photo Update(Photo photo)
        {
            using var photoDbContext = new PhotoBoomDbContext();
            photoDbContext.Photos.Update(photo);
            return photo;
        }
    }
}
