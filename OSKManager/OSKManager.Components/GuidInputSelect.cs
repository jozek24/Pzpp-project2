﻿using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;

namespace OSKManager.Components
{
    public class GuidInputSelect<TValue> : InputSelect<TValue>
    {
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "select");
            builder.AddMultipleAttributes(1, AdditionalAttributes);
            builder.AddAttribute(2, "class", CssClass);
            builder.AddAttribute(3, "value", BindConverter.FormatValue(CurrentValueAsString));
            builder.AddAttribute(4, "onchange", EventCallback.Factory.CreateBinder<string>(this, value => CurrentValueAsString = value, CurrentValueAsString, null));

            var i = 5;
            var guidType = GetGuidType();

            //foreach (Guid value in Guid.GetValues(guidType);
            //{
            //    builder.OpenElement(i++, "option");
            //    builder.AddAttribute(i++, "value", value.ToString());
            //    builder.AddContent(i++, GetDisplayName(value));
            //    builder.CloseElement();
            //}

            builder.CloseElement();
        }

        protected override bool TryParseValueFromString(string value, out TValue result,
            out string validationErrorMessage)
        {
            if (typeof(TValue) == typeof(Guid))
            {
                if (Guid.TryParse(value, out var resultGuid))
                {
                    result = (TValue)(object)resultGuid;
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

        private string GetDisplayName(Guid value)
        {
            var member = value.GetType().GetMember(value.ToString())[0];
            var displayAttribute = member.GetCustomAttribute<DisplayAttribute>();
            if (displayAttribute != null)
                return displayAttribute.GetName();

            return value.ToString();
        }

        private Type GetGuidType()
        {
            var nullableType = Nullable.GetUnderlyingType(typeof(Guid));
            if (nullableType != null)
                return nullableType;

            return typeof(Guid);
        }
    }
}
