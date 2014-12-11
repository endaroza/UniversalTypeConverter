﻿using System;
using System.Globalization;
using System.Threading;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TB.ComponentModel.Tests.Unit {
    [TestClass]
    public class UniversalTypeConverter_ConvertToT_1_Tests {

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
        public void ConvertToT_Should_Use_CurrentCulture_As_Default() {
            string input = 1234.56M.ToString(CultureInfo.CurrentCulture);
            UniversalTypeConverter.ConvertTo<decimal>(input).Should().Be(1234.56M);

            DateTime inputDate = new DateTime(2011, 1, 30, 16, 30, 12);
            input = inputDate.ToString(CultureInfo.CurrentCulture);
            UniversalTypeConverter.ConvertTo<DateTime>(input).Should().Be(inputDate);
        }


        [TestMethod]
        public void ConvertToT_Should_Use_DefaultOptions() {
            UniversalTypeConverter.ConvertTo<bool>('y').Should().BeTrue();
        }

    }
}
