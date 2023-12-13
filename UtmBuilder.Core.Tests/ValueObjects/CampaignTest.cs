﻿using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects
{
    [TestClass]
    public class CampaignTest
    {
        [TestMethod]
        [DataRow("", "", "", true)]
        [DataRow("SRC", "", "", true)]
        [DataRow("src", "medium", "", true)]
        [DataRow("src", "medium", "name", false)]
        public void TestCampaign(string source, string medium, string name, bool expectException)
        {
            if (expectException)
            {
                try
                {
                    new Campaign(source, medium, name);
                    Assert.Fail();
                }
                catch (InvalidCampaignException)
                {
                    Assert.IsTrue(true);
                }
            }
            else
            {
                new Campaign(source, medium, name);
                Assert.IsTrue(true);
            }
        }
    }
}
