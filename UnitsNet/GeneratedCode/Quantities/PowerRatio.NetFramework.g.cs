﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     The strength of a signal expressed in decibels (dB) relative to one watt.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct PowerRatio : IComparable, IComparable<PowerRatio>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable PowerRatio from nullable DecibelMilliwatts.
        /// </summary>
        public static PowerRatio? FromDecibelMilliwatts(QuantityValue? decibelmilliwatts)
        {
            return decibelmilliwatts.HasValue ? FromDecibelMilliwatts(decibelmilliwatts.Value) : default(PowerRatio?);
        }

        /// <summary>
        ///     Get nullable PowerRatio from nullable DecibelWatts.
        /// </summary>
        public static PowerRatio? FromDecibelWatts(QuantityValue? decibelwatts)
        {
            return decibelwatts.HasValue ? FromDecibelWatts(decibelwatts.Value) : default(PowerRatio?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="PowerRatioUnit" /> to <see cref="PowerRatio" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>PowerRatio unit value.</returns>
        public static PowerRatio? From(QuantityValue? value, PowerRatioUnit fromUnit)
        {
            return value.HasValue ? new PowerRatio((double)value.Value, fromUnit) : default(PowerRatio?);
        }

        #endregion

        #region Logarithmic Arithmetic Operators

        public static PowerRatio operator -(PowerRatio right)
        {
            return new PowerRatio(-right.Value, right.Unit);
        }

        public static PowerRatio operator +(PowerRatio left, PowerRatio right)
        {
            // Logarithmic addition
            // Formula: 10*log10(10^(x/10) + 10^(y/10))
            return new PowerRatio(10*Math.Log10(Math.Pow(10, left.Value/10) + Math.Pow(10, right.AsBaseNumericType(left.Unit)/10)), left.Unit);
        }

        public static PowerRatio operator -(PowerRatio left, PowerRatio right)
        {
            // Logarithmic subtraction
            // Formula: 10*log10(10^(x/10) - 10^(y/10))
            return new PowerRatio(10*Math.Log10(Math.Pow(10, left.Value/10) - Math.Pow(10, right.AsBaseNumericType(left.Unit)/10)), left.Unit);
        }

        public static PowerRatio operator *(double left, PowerRatio right)
        {
            // Logarithmic multiplication = addition
            return new PowerRatio(left + right.Value, right.Unit);
        }

        public static PowerRatio operator *(PowerRatio left, double right)
        {
            // Logarithmic multiplication = addition
            return new PowerRatio(left.Value + (double)right, left.Unit);
        }

        public static PowerRatio operator /(PowerRatio left, double right)
        {
            // Logarithmic division = subtraction
            return new PowerRatio(left.Value - (double)right, left.Unit);
        }

        public static double operator /(PowerRatio left, PowerRatio right)
        {
            // Logarithmic division = subtraction
            return Convert.ToDouble(left.Value - right.AsBaseNumericType(left.Unit));
        }

        #endregion

        public static bool operator <=(PowerRatio left, PowerRatio right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(PowerRatio left, PowerRatio right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(PowerRatio left, PowerRatio right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(PowerRatio left, PowerRatio right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(PowerRatio left, PowerRatio right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(PowerRatio left, PowerRatio right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }
    }
}