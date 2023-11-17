using System.ComponentModel;

namespace Seafood.Helper
{
    public static class StringExtension
    {
        public static string GetEnumDescription(this System.Enum enumValue)
        {
            try
            {
                var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

                var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

                return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();
            }
            catch
            {
                return enumValue.ToString();
            }

        }
    }
}