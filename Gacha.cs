using System;
using System.Collections.Generic;
using System.Text;

namespace TransitionGameRevision
{
    //Gacha system created with help from Karen Spriggs from IAM Tutoring.
    class Gacha
    {
        List<Item> items = new List<Item>();

        public void itemsFill()
        {
            //add more items here
            Item Origami = new Item("Origami Rose", "Seems like a folded piece of red paper the shape of a rose.");
            Item goldenNecklace = new Item("Golden Necklace", "Seems like a lost item, it looks like jewelry.");
            Item USBDrive = new Item("USB Drive", "A USB drive, although has no label on it.");
            Item sketchPad = new Item("Sketch Pad", "Seems like a rusty sketch pad, was it lost?");
            Item Watch = new Item("Broken Watch", "The glass is cracked, it doesn't seem to be working anymore.");
            //add them to the list
            items.Add(Origami);
            items.Add(goldenNecklace);
            items.Add(USBDrive);
            items.Add(sketchPad);
            items.Add(Watch);

        }


        public Item randomizeItem()
        {
            Random rng = new Random();
            int index = rng.Next(0, items.Count);
            Item randomitem = items[index];
            items.RemoveAt(index);

            return randomitem;

        }
    }
}
