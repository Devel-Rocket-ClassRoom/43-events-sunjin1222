using System;

class InventoryUI
    {
        public void msg(string name, int oldCount, int newCount)
        {
            Console.WriteLine($"[UI] {name}: {oldCount}->{newCount}");
        }
    }


   