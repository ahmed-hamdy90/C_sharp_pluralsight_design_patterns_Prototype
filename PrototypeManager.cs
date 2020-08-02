using System.Collections.Generic;

namespace PrototypePattern
{
    /// <summary>
    /// PrototypeManager represent manager class to store and manage prototype instances
    /// </summary>
    public class PrototypeManager
    {
        private Dictionary<string, Prototype> _prototypeLibrary = new Dictionary<string, Prototype>();

        /// <summary>
        /// member which responsible for retrieve and store any prototype instance.
        /// </summary>
        /// <param name="key">key of prototype instance wanted to store</param>
        public Prototype this[string key]
        {
            get => _prototypeLibrary[key];
            set => _prototypeLibrary.Add(key, value);
        }
    }
}