using System;
using System.Collections.Generic;

namespace BagOLoot
{
    public class Bag
    {
        private List<Present> _contents = new List<Present>();
        public List<Present> GetContents()
        {
            return _contents;
        }
        public void RemovePresent(Present present)
        {
            _contents.Remove(present);
        }
        public void AddPresent(Present present)
        {
            _contents.Add(present);
        }
        public void DeliverPresent(Present present)
        {
            present.Delivered = true;
            RemovePresent(present);
        }
    }
}