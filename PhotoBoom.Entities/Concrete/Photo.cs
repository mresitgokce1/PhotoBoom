using System;
using PhotoBoom.Entities.Abstract;

namespace PhotoBoom.Entities
{
    public class Photo:IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Tags { get; set; }
        public string Photos { get; set; }
    }
}
