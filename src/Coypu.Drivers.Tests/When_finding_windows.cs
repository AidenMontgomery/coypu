﻿using NSpec;
using NUnit.Framework;

namespace Coypu.Drivers.Tests
{
    internal class When_finding_windows : DriverSpecs
    {
        [Test]
        public void Finds_by_name()
        {
            Driver.Click(Driver.FindLink("Open pop up window",Root));
            Driver.FindWindow("popUpWindowName", Root).Text.should_contain("I am a pop up window");
            Driver.HasContent("Open pop up window",Root);
        }

        [Test]
        public void Finds_by_title()
        {
            Driver.Click(Driver.FindLink("Open pop up window", Root));
            Driver.FindWindow("Pop Up Window", Root).Text.should_contain("I am a pop up window");
            Driver.HasContent("Open pop up window", Root);
        }

        [Test]
        public void Errors_on_no_such_window()
        {
            Driver.Click(Driver.FindButton("Open pop up window", Root));
            Assert.Throws<MissingHtmlException>(() => Driver.FindWindow("Not A Window", Root));
            ;
        }
    }
}