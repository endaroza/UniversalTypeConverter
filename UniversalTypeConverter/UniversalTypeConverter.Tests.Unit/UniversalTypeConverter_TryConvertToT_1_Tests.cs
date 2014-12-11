﻿using System;
using System.Globalization;
using System.Threading;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class UniversalTypeConverter_TryConvertToT_1_Tests {

        private CultureInfo mCultureInfo;

        [TestInitialize]
        public void Initialize() {
            mCultureInfo = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("de-DE");
        }

        [TestCleanup]
        public void CleanUp() {
            Thread.CurrentThread.CurrentCulture = mCultureInfo;
        }

        [TestMethod]
        public void TryConvertToT_Should_Use_CurrentCulture_As_Default() {
            DateTime inputDate = new DateTime(2011, 1, 30, 16, 30, 12);
            string input = inputDate.ToString(CultureInfo.CurrentCulture);
            DateTime result;
            UniversalTypeConverter.TryConvertTo(input, out result).Should().BeTrue();
            result.Should().Be(inputDate);
        }


        [TestMethod]
        public void TryConvertToT_Should_Use_DefaultOptions() {
            bool result;
            UniversalTypeConverter.TryConvertTo('y', out result).Should().BeTrue();
            result.Should().BeTrue();
        }

    }
}
