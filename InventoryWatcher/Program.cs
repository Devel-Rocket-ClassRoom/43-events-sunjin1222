using System;
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


   