using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoBoom.Entities;

namespace PhotoBoom.Business.Abstract
{
    public interface IPhotoService
    {
        List<Photo> GetAllPhotos();
        Photo GetHotelById(int id);
        Photo CreatePhoto(Photo photo);
        Photo UpdatePhoto(Photo photo);
        void DeletePhoto(int id);
    }
}
