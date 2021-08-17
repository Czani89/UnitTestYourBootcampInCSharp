using System.Collections.Generic;
using Xunit;
using Newtonsoft.Json;

namespace BootcampFunctions.Test
{
    public class FindItemsOver20test
    {
        [Fact]
        public void findItemsOver20test()
        {
            var testData = new List<ItemList> { 

            new ItemList { Qty = 5, Fruit = "Pear" }, 
            new ItemList { Qty = 20, Fruit = "Apples" },
            new ItemList { Qty = 14, Fruit = "Pear" },
            new ItemList { Qty = 5, Fruit = "Banana" },
            new ItemList { Qty = 10, Fruit = "Pear" },
            new ItemList { Qty = 30, Fruit = "Pear" },
            new ItemList { Qty = 25, Fruit = "Pear" },
            new ItemList { Qty = 5, Fruit = "Pear" },
            new ItemList { Qty = 24, Fruit = "Pear" },
            new ItemList { Qty = 20, Fruit = "Pear" } 
            };

            var controlData = new List<ItemList> {

            new ItemList { Qty = 30, Fruit = "Pear" },
            new ItemList { Qty = 25, Fruit = "Pear" },
            new ItemList { Qty = 24, Fruit = "Pear" },
            };

            var findItemsOver20 = new FindItemsOver20();

            var returnVar = findItemsOver20.findItemsOver20(testData);

            var testDataStr = JsonConvert.SerializeObject(returnVar);
            var controlDataStr = JsonConvert.SerializeObject(controlData);


            Assert.Equal(controlDataStr, testDataStr);
        }
        [Fact]
        public void findItemsOver20test1()
        {
            var testData = new List<ItemList> {

            new ItemList { Qty = 5, Fruit = "Pear" },
            new ItemList { Qty = 20, Fruit = "Apples" },
            new ItemList { Qty = 14, Fruit = "Pear" },
            new ItemList { Qty = 5, Fruit = "Banana" },
            new ItemList { Qty = 37, Fruit = "Pear" },
            new ItemList { Qty = 30, Fruit = "Pear" },
            new ItemList { Qty = 25, Fruit = "Pear" },
            new ItemList { Qty = 30, Fruit = "Pear" },
            new ItemList { Qty = 24, Fruit = "Pear" },
            new ItemList { Qty = 27, Fruit = "Pear" }
            };

            var controlData = new List<ItemList> {

            new ItemList { Qty = 37, Fruit = "Pear" },
            new ItemList { Qty = 30, Fruit = "Pear" },
            new ItemList { Qty = 25, Fruit = "Pear" },
            new ItemList { Qty = 30, Fruit = "Pear" },
            new ItemList { Qty = 24, Fruit = "Pear" },
            new ItemList { Qty = 27, Fruit = "Pear" }
            };

            var findItemsOver20 = new FindItemsOver20();

            var returnVar = findItemsOver20.findItemsOver20(testData);

            var testDataStr = JsonConvert.SerializeObject(returnVar);
            var controlDataStr = JsonConvert.SerializeObject(controlData);


            Assert.Equal(controlDataStr, testDataStr);
        }
    }
}