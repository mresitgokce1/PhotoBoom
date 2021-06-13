using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoBoom.Entities;

namespace PhotoBoom.DataAccess.Abstract
{
    interface IPhotoRepository
    {
        List<Photo> GetAllPhotos();
        Photo GetPhotoById(int id);
        Photo CreateHotel(Photo photo);
        Photo Update(Photo photo);
        void Delete(int id);
    }
}
