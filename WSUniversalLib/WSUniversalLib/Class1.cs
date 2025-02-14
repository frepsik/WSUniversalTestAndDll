namespace WSUniversalLib
{
    public class Calculation
    {
        /// <summary>
        /// Функция для расчёта количества сырья, необходимого для производства определённого количества продукции
        /// </summary>
        /// <param name="productType">Тип продукции</param>
        /// <param name="materialType">Процент брака материала</param>
        /// <param name="count">Необходимое количество продукции</param>
        /// <param name="width">Ширина</param>
        /// <param name="length">Длина</param>
        /// <returns>Количество необходимого сырья</returns>
        public static int GetQuantityForProduct(int? productType, int? materialType, int? count, float? width, float? length)
        {
            float? result = -1;

            if (productType == null || materialType == null || count == null || width == null || length == null)
                return -1;

            if (count < 1 || width < 1 || length < 1)
                return -1;

            if (count == int.MaxValue && width == float.MaxValue && length == float.MaxValue)
                return -1;

            if(float.IsNaN((float)width) || float.IsNaN((float)length))
                return -1;

            if (float.IsInfinity((float)width) || float.IsInfinity((float)length))
                return -1;

            switch (productType)
            {
                case 1:
                    result = width * length * count * 1.1f;
                    break;
                case 2:
                    result = width * length * count * 2.5f;
                    break;
                case 3:
                    result = width * length * count * 8.43f;
                    break;
                default:
                    return -1;
            }

            switch (materialType)
            {
                case 1:
                    result *= 1.003f;
                    break;
                case 2:
                    result *= 1.0012f;
                    break;
                default:
                    return -1;
            }

            return (int)Math.Ceiling((double)result) + 1;
        }
    }
}
