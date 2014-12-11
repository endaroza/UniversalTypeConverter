﻿using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    public partial class UniversalTypeConverter_Tests {

        [TestMethod]
        public void ConvertTo_Object_From_Bool_WithValueFalse_ShouldReturn_False() {
            bool value = false;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_Bool_WithValueTrue_ShouldReturn_True() {
            bool value = true;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableBool_WithValueFalse_ShouldReturn_False() {
            bool? value = false;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableBool_WithValueNull_ShouldReturn_Null() {
            bool? value = null;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().BeNull();
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableBool_WithValueTrue_ShouldReturn_True() {
            bool? value = true;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_Byte_WithValue1_ShouldReturn_1() {
            byte value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableByte_WithValue1_ShouldReturn_1() {
            byte? value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableByte_WithValueNull_ShouldReturn_Null() {
            byte? value = null;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().BeNull();
        }

        [TestMethod]
        public void ConvertTo_Object_From_Char_WithValue100_ShouldReturn_100() {
            char value = (char)100;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableChar_WithValue100_ShouldReturn_100() {
            char? value = (char)100;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableChar_WithValueNull_ShouldReturn_Null() {
            char? value = null;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().BeNull();
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableDateTime_WithValueNull_ShouldReturn_Null() {
            DateTime? value = null;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().BeNull();
        }

        [TestMethod]
        public void ConvertTo_Object_From_Decimal_WithValue1_ShouldReturn_1() {
            decimal value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableDecimal_WithValue1_ShouldReturn_1() {
            decimal? value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableDecimal_WithValueNull_ShouldReturn_Null() {
            decimal? value = null;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().BeNull();
        }

        [TestMethod]
        public void ConvertTo_Object_From_Double_WithValue1_ShouldReturn_1() {
            double value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableDouble_WithValue1_ShouldReturn_1() {
            double? value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableDouble_WithValueNull_ShouldReturn_Null() {
            double? value = null;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().BeNull();
        }

        [TestMethod]
        public void ConvertTo_Object_From_Float_WithValue1_ShouldReturn_1() {
            float value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableFloat_WithValue1_ShouldReturn_1() {
            float? value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableFloat_WithValueNull_ShouldReturn_Null() {
            float? value = null;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().BeNull();
        }

        [TestMethod]
        public void ConvertTo_Object_From_Int_WithValue1_ShouldReturn_1() {
            int value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableInt_WithValue1_ShouldReturn_1() {
            int? value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableInt_WithValueNull_ShouldReturn_Null() {
            int? value = null;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().BeNull();
        }

        [TestMethod]
        public void ConvertTo_Object_From_Long_WithValue1_ShouldReturn_1() {
            long value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableLong_WithValue1_ShouldReturn_1() {
            long? value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableLong_WithValueNull_ShouldReturn_Null() {
            long? value = null;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().BeNull();
        }

        [TestMethod]
        public void ConvertTo_Object_From_Object_WithValue1_ShouldReturn_1() {
            object value = "1";
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_Object_WithValueNull_ShouldReturn_Null() {
            object value = null;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().BeNull();
        }

        [TestMethod]
        public void ConvertTo_Object_From_SByte_WithValue1_ShouldReturn_1() {
            sbyte value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableSByte_WithValue1_ShouldReturn_1() {
            sbyte? value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableSByte_WithValueNull_ShouldReturn_Null() {
            sbyte? value = null;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().BeNull();
        }

        [TestMethod]
        public void ConvertTo_Object_From_Short_WithValue1_ShouldReturn_1() {
            short value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableShort_WithValue1_ShouldReturn_1() {
            short? value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableShort_WithValueNull_ShouldReturn_Null() {
            short? value = null;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().BeNull();
        }

        [TestMethod]
        public void ConvertTo_Object_From_String_WithValue1_ShouldReturn_1() {
            string value = "1";
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_String_WithValueAbc_ShouldReturn_Abc() {
            string value = "abc";
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_String_WithValueNull_ShouldReturn_Null() {
            string value = null;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().BeNull();
        }

        [TestMethod]
        public void ConvertTo_Object_From_UInt_WithValue1_ShouldReturn_1() {
            uint value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableUInt_WithValue1_ShouldReturn_1() {
            uint? value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableUInt_WithValueNull_ShouldReturn_Null() {
            uint? value = null;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().BeNull();
        }

        [TestMethod]
        public void ConvertTo_Object_From_ULong_WithValue1_ShouldReturn_1() {
            ulong value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableULong_WithValue1_ShouldReturn_1() {
            ulong? value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableULong_WithValueNull_ShouldReturn_Null() {
            ulong? value = null;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().BeNull();
        }

        [TestMethod]
        public void ConvertTo_Object_From_UShort_WithValue1_ShouldReturn_1() {
            ushort value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableUShort_WithValue1_ShouldReturn_1() {
            ushort? value = 1;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().Be(expectedValue);
        }

        [TestMethod]
        public void ConvertTo_Object_From_NullableUShort_WithValueNull_ShouldReturn_Null() {
            ushort? value = null;
            object expectedValue = value;
            UniversalTypeConverter.ConvertTo<object>(value).Should().BeNull();
        }
    }
}
