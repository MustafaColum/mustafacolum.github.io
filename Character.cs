using System;
using System.Collections.Generic;
using System.Text;

namespace TransitionGameRevision
{
    class Character
    {
        public string name;
        public Item givenItem;
        Item desiredItem;
        public Character(string Name, Item DesiredItem)
        {
            name = Name;
            desiredItem = DesiredItem;
        }

        public bool Decision()
        {
            if (givenItem.Name == desiredItem.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
