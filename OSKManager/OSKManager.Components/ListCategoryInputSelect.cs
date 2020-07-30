using Microsoft.AspNetCore.Components.Forms;
using OSKManager.Components.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace OSKManager.Components
{
    public class ListCategoryInputSelect<TValue> : InputSelect<TValue>
    {
        protected override bool TryParseValueFromString(string value, out TValue result,
            out string validationErrorMessage)
        {
            if (typeof(TValue) == typeof(List<Category>))
            {
                if (GenericMethod.GenericTryParse<List<Category>>(value, out var resultListCategory))
                {
                    result = (TValue)(object)resultListCategory;
                    validationErrorMessage = null;
                    return true;
                }
                else
                {
                    result = default;
                    validationErrorMessage =
                        $"The selected value {value} is not a valid number.";
                    return false;
                }
            }
            else
            {
                return base.TryParseValueFromString(value, out result, out validationErrorMessage);
            }
        }
    }
}
