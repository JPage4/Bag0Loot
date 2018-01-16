using System.Collections.Generic;

namespace BagOLoot
{
    public class ChildRegister
    {
        private List<Child> _register = new List<Child>();
        public void AddChild (Child child)
        {
            _register.Add(child);
        }

        public void RemoveChild (Child child)
        {
            _register.Remove(child);
        }
        public List<Child> GetRegister ()
        {
            return _register;
        }
    }
}