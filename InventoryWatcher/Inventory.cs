using System;
using System.Collections.Generic;

class Inventory
{
    public event Action<string, int, int> ItemChanged;

    private Dictionary<string, int> items = new Dictionary<string, int>();

    public void AddItem(string name, int count)
    {
        int oldcount = items.ContainsKey(name) ? items[name] : 0;
        int newcount = oldcount + count;

        if (items.ContainsKey(name))
        {
            items[name] += count;
        }
        else
        {
            items[name] = count;
        }
        ItemChanged?.Invoke(name, oldcount, newcount);
    }


    public void RemoveItem(string name, int count)
    {
        int oldcount = items.ContainsKey(name) ? items[name] : 0;
        int newcount = oldcount - count;
        
        if (items.ContainsKey(name))
        {
            items[name] -= count;
            if (newcount <= 0)
            {
            
                newcount = 0;
            }
            if (oldcount <= 0)
            {
                oldcount = 0;
            }

            ItemChanged?.Invoke(name, oldcount, newcount);
        }
    }
}


   