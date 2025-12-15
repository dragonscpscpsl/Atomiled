using RueI.API.Elements;
using System;

namespace HudForAtomiled
{
    internal class Dictionary
    {
        private string v;

        public Dictionary()
        {
        }

        public Dictionary(string v)
        {
            this.v = v;
        }

        public static implicit operator Tag(Dictionary v)
        {
            throw new NotImplementedException();
        }
    }
}
