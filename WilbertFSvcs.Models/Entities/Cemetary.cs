using System;

namespace WilbertFSvcs.Models.Entities
{
    public class Cemetary
    {
        public int CemetaryId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string County { get; set; }
        public string Directions { get; set; }
        public float Lattitude { get; set; }
        public float Longitude { get; set; }
        public byte[] Map { get; set; }
        public Boolean UseCoordinates { get; set; }

    }
}