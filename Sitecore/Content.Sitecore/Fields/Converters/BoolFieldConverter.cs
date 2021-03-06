﻿#region License
// Copyright © 2012 Hedgehog Development, LLC (www.hhogdev.com)
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion


namespace HedgehogDevelopment.Scaas.Content.Fields
{
    /// <summary>
    /// The FieldEvaluator class
    /// </summary>
    internal class BoolFieldConverter : FieldConverter<bool>
    {
        /// <summary>
        /// Evaluates the specified field.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <returns></returns>
        public override bool Convert(Sitecore.Data.Fields.Field field)
        {
            string value = field.Value ?? "";
            bool returnValue = false;

            if (string.IsNullOrEmpty(value))
            {
                return returnValue;
            }

            // sitecore usually stores "1" as true.
            if (value == "1")
            {
                return true;
            }
            else if (value == "0")
            {
                return false;
            }

            // parse out 'true' and 'false'
            bool.TryParse(value, out returnValue);
            return returnValue;
        }
    }
}
