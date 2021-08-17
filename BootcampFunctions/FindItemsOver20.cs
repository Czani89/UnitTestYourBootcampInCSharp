using System;
using System.Collections.Generic;
using System.Text.Json;

namespace BootcampFunctions
{
    public class ItemList
    {
        public int Qty { get; set; }
        public string Fruit { get; set; }
        
    }

    public class FindItemsOver20
    {

        public List<ItemList> findItemsOver20(List<ItemList> objList)
        {
            List<ItemList>  itemArr = new List<ItemList>();

            for (var i = 0; i < objList.Count; i++)
            {
                var listItem = objList[i];
                if (listItem.Qty > 20)
                {
                    itemArr.Add(listItem);
                }
            }
            return itemArr;
        }
        // private List<string> itemArr;
    }
}
