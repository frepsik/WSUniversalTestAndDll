using WSUniversalLib;

namespace UnitTestsWSUniversalLib
{
    [TestClass]
    public class UnitTestsGetQuantityForProduct
    {
        [TestMethod]
        public void GetQuantityForProduct_AreEqual_CalculationWorkingCorrect()
        {
            int productType = 3, materialType = 1, count = 15;
            float width = 20.0f, length = 45.0f;
            int actualValue = Calculation.GetQuantityForProduct(productType, 
                materialType, 
                count, 
                width, 
                length);

            int expectedValue = 114148;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void GetQuantityForProduct_AreNotEqual_CalculationWorkingCorrect()
        {
            int productType = 3, materialType = 1, count = 15;
            float width = 20.0f, length = 45.0f;
            int actualValue = Calculation.GetQuantityForProduct(productType,
                materialType,
                count,
                width,
                length);

            int expectedValue = 11414956;

            Assert.AreNotEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void GetQuantityForProduct_IsTrue_QuantityForProduct_InRange()
        {
            int productType = 3, materialType = 1, count = 15;
            float width = 20.0f, length = 45.0f;
            int actualValue = Calculation.GetQuantityForProduct(productType,
                materialType,
                count,
                width,
                length);


            Assert.IsTrue(actualValue > 0 && actualValue < float.MaxValue);
        }

        [TestMethod]
        public void GetQuantityForProduct_IsInstanceOfType_CorrectTypeQuantityForProduct()
        {
            int productType = 3, materialType = 1, count = 45;
            float width = 20.0f, length = 45.0f;
            int actualQuantityForProduct = Calculation.GetQuantityForProduct(productType,
                materialType,
                count,
                width,
                length);

                     
        }

        [TestMethod]
        public void GetQuantityForProduct_AreEqual_NonExistProductType()
        {
            int productType = 4, materialType = 1, count = 45;
            float width = 20.0f, length = 45.0f;
            int expectedValue = -1;
            int actualQuantityForProduct = Calculation.GetQuantityForProduct(productType,
                materialType,
                count,
                width,
                length);

            Assert.AreEqual(expectedValue, actualQuantityForProduct);
        }

        [TestMethod]
        public void GetQuantityForProduct_AreEqual_NonExistMaterialType()
        {
            int productType = 2, materialType = 3, count = 45;
            float width = 20.0f, length = 45.0f;
            int expectedValue = -1;
            int actualQuantityForProduct = Calculation.GetQuantityForProduct(productType,
                materialType,
                count,
                width,
                length);

            Assert.AreEqual(expectedValue, actualQuantityForProduct);
        }

        [TestMethod]
        public void GetQuantityForProduct_AreEqual_NegativeValueCount()
        {
            int productType = 2, materialType = 1, count = -1;
            float width = 20.0f, length = 45.0f;
            int expectedValue = -1;
            int actualQuantityForProduct = Calculation.GetQuantityForProduct(productType,
                materialType,
                count,
                width,
                length);

            Assert.AreEqual(expectedValue, actualQuantityForProduct);
        }

        [TestMethod]
        public void GetQuantityForProduct_AreEqual_NegativeValueWidth()
        {
            int productType = 2, materialType = 1, count = 16;
            float width = -1f, length = 45.0f;
            int expectedValue = -1;
            int actualQuantityForProduct = Calculation.GetQuantityForProduct(productType,
                materialType,
                count,
                width,
                length);

            Assert.AreEqual(expectedValue, actualQuantityForProduct);
        }

        [TestMethod]
        public void GetQuantityForProduct_AreEqual_NegativeValueLength()
        {
            int productType = 2, materialType = 1, count = 16;
            float width = 25.5f, length = -9f;
            int expectedValue = -1;
            int actualQuantityForProduct = Calculation.GetQuantityForProduct(productType,
                materialType,
                count,
                width,
                length);

            Assert.AreEqual(expectedValue, actualQuantityForProduct);
        }

        [TestMethod]
        public void GetQuantityForProduct_IsNotNull_QuantityIsNotNull()
        {
            int productType = 3, materialType = 1, count = 15;
            float width = 20.0f, length = 45.0f;
            int actualValue = Calculation.GetQuantityForProduct(productType,
                materialType,
                count,
                width,
                length);            

            Assert.IsNotNull(actualValue);
        }


        [TestMethod]
        public void GetQuantityForProduct_AreEqual_CountValueIsNull()
        {
            int productType = 3, materialType = 1;
            Nullable<int> count = null;
            float width = 20.0f, length = 45.0f;
            int expectedValue = -1;
            int actualValue = Calculation.GetQuantityForProduct(productType,
                materialType,
                Convert.ToInt32(count),
                width,
                length);

            Assert.AreEqual(expectedValue, actualValue);
        }


        [TestMethod]
        public void GetQuantityForProduct_AreEqual_ParametersFuncIsMaxValue()
        {
            int productType = 1, materialType = 1, count = int.MaxValue;
           
            float width = float.MaxValue, length = float.MaxValue;
            int expectedValue = -1;
            int actualValue = Calculation.GetQuantityForProduct(productType,
                materialType,
                count,
                width,
                length);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void GetQuantityForProduct_AreEqual_WidthIsNan()
        {
            int productType = 1, materialType = 1, count = int.MaxValue;

            float width = float.NaN, length = 25.0f;
            int expectedValue = -1;
            int actualValue = Calculation.GetQuantityForProduct(productType,
                materialType,
                count,
                width,
                length);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void GetQuantityForProduct_AreEqual_LengthIsNan()
        {
            int productType = 1, materialType = 1, count = int.MaxValue;

            float width = 25.0f, length = float.NaN;
            int expectedValue = -1;
            int actualValue = Calculation.GetQuantityForProduct(productType,
                materialType,
                count,
                width,
                length);

            Assert.AreEqual(expectedValue, actualValue);
        }


        [TestMethod]
        public void GetQuantityForProduct_AreEqual_WidthIsInfinity()
        {
            int productType = 1, materialType = 1, count = int.MaxValue;

            float width = float.PositiveInfinity, length = 255.0f;
            int expectedValue = -1;
            int actualValue = Calculation.GetQuantityForProduct(productType,
                materialType,
                count,
                width,
                length);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void GetQuantityForProduct_AreEqual_LengthIsInfinity()
        {
            int productType = 1, materialType = 1, count = int.MaxValue;

            float width = 35.0f, length = float.PositiveInfinity;
            int expectedValue = -1;
            int actualValue = Calculation.GetQuantityForProduct(productType,
                materialType,
                count,
                width,
                length);

            Assert.AreEqual(expectedValue, actualValue);
        }

    }
}