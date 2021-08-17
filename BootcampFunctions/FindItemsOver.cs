using System.Collections.Generic;

namespace BootcampFunctions
{
    public class FruitList
    {
        public int Qty{set; get;}
        public string Fruit{set; get;}
    }
    public class FindItemsOver
    {
        public List<FruitList> findItemsOver(List<FruitList> ObjList, int cap)
        {
            var ItemsOver = new List<FruitList>();

            for(var i = 0; i < ObjList.Count; i++)
            {
                if(ObjList[i].Qty > cap)
                {
                    ItemsOver.Add(ObjList[i]);
                }
            }
            return ItemsOver;
        }
    }
}