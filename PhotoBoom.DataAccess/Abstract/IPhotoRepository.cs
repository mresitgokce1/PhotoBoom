using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoBoom.Entities;

namespace PhotoBoom.DataAccess.Abstract
{
    public interface IPhotoRepository
    {
        List<Photo> GetAllPhotos();
        Photo GetPhotoById(int id);
        Photo CreatePhoto(Photo photo);
        void DeletePhoto(int id);
    }
}
