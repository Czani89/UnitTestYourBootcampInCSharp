using Xunit;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BootcampFunctions.Test
{
    public class FindItemsOverTest
    {
        [Fact]
        public void findItemsOverTest()
        {
            var Items = new List<FruitList>{
                new FruitList{ Qty= 5, Fruit = "Pear"},
                new FruitList{ Qty= 45, Fruit = "Apple"},
                new FruitList{ Qty= 25, Fruit = "Banana"},
                new FruitList{ Qty= 30, Fruit = "Pear"},
                new FruitList{ Qty= 40, Fruit = "Apple"},
                new FruitList{ Qty= 30, Fruit = "Banana"},
                new FruitList{ Qty= 19, Fruit = "Banana"},
                new FruitList{ Qty= 13, Fruit = "Pear"},
                new FruitList{ Qty= 10, Fruit = "Apple"},

            };
            var ItemsOver = new List<FruitList>{
                new FruitList{ Qty= 45, Fruit = "Apple"},
                new FruitList{ Qty= 25, Fruit = "Banana"},
                new FruitList{ Qty= 30, Fruit = "Pear"},
                new FruitList{ Qty= 40, Fruit = "Apple"},
                new FruitList{ Qty= 30, Fruit = "Banana"},
            };
            var findItemsOver = new FindItemsOver();

            var ItemsCheck = findItemsOver.findItemsOver(Items, 24);

            var ItemsCheckStr = JsonConvert.SerializeObject(ItemsCheck);
            var ItemsOverStr = JsonConvert.SerializeObject(ItemsOver);

            Assert.Equal(ItemsOverStr, ItemsCheckStr);
        }
    }
}