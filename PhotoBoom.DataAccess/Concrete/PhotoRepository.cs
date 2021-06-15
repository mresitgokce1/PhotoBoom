using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoBoom.DataAccess.Abstract;
using PhotoBoom.Entities;

namespace PhotoBoom.DataAccess.Concrete
{
    public class PhotoRepository : IPhotoRepository
    {
        public Photo CreatePhoto(Photo photo)
        {
            using var photoDbContext = new PhotoBoomDbContext();
            photoDbContext.Photos.Add(photo);
            photoDbContext.SaveChanges();
            return photo;
        }

        public void DeletePhoto(int id)
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

        public Photo UpdatePhoto(Photo photo)
        {
            using var photoDbContext = new PhotoBoomDbContext();
            photoDbContext.Photos.Update(photo);
            photoDbContext.SaveChanges();
            return photo;
        }
    }
}
