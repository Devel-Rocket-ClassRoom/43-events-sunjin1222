using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

Inventory inventory = new Inventory();
InventoryUI inventoryui = new InventoryUI();
AutoBuyer autobuyer = new AutoBuyer();

inventory.ItemChanged += inventoryui.msg;
inventory.ItemChanged += autobuyer.zero;

inventory.AddItem("포션", 5);
inventory.AddItem("화살", 10);
inventory.AddItem("포션", 3);
inventory.RemoveItem("화살", 7);
inventory.RemoveItem("화살", 7);
inventory.RemoveItem("화살", 1);



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


    class InventoryUI
    {
        public void msg(string name, int oldCount, int newCount)
        {
            Console.WriteLine($"[UI] {name}: {oldCount}->{newCount}");
        }
    }



    class AutoBuyer
    {
        public void zero(string name, int oldCount, int newCount)
        {
            if (newCount <= 0)
            {
                 Console.WriteLine($"[자동구매] {name} 재고 소진! 자동 구매 요청");
            }
        }
    }


   