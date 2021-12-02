//------------------------------------------------------------------------------------------------------------------------------------
// Copyright 2020 Dassault Systèmes - CPE EMED
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify,
// merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished
// to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS
// BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace ds.emedcpe.samples.docs
{
    public enum ElementTypeEnum
    {
        [DefaultValue("Engineering Item")]
        EngineeringItem,
        [DefaultValue("Manufacturing Item")]
        ManufacturingItem
    }

    public class ElementTypeEnumGlobals
    {
        public static string ToString(ElementTypeEnum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DefaultValueAttribute[] attributes = fi.GetCustomAttributes(typeof(DefaultValueAttribute), false) as DefaultValueAttribute[];

            if (attributes != null && attributes.Any())
            {
                return ((string)attributes.First().Value);
            }

            return value.ToString();
        }

        public static List<ElementTypeEnum> GetAllDistinctValues()
        {
            Array values = Enum.GetValues(typeof(ElementTypeEnum));

            List<ElementTypeEnum> __allElementTypeList = new List<ElementTypeEnum>();
            foreach (ElementTypeEnum value in values)
            {
                __allElementTypeList.Add(value);
            }

            return __allElementTypeList;
        }

        public static ElementTypeEnum GetSelected(ComboBox _combobox)
        {
            ElementTypeEnum __elementType;
            Enum.TryParse(_combobox.SelectedValue.ToString(), out __elementType);
            return __elementType;
        }
    }
}
