using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace AssurityApiTest
{
    [TestClass]
    public class ApiTestCases
    {
        string baseUrl = "https://api.tmsandbox.co.nz";
        string absoluteUrl = "/v1/Categories/categoryid/Details.json?catalogue=false";
        string categoryId = "6327";
        Data data;
        ApiRequestHandler handler = new ApiRequestHandler();

        [TestMethod]
        public void Verify_Name_6327()
        {
            data = handler.GetApiResponce(baseUrl,absoluteUrl,"6327");
            Assert.IsTrue((data.Name.Equals("Carbon credits")), "Expected : {0} ; Actual : {1}", "Carbon credits", data.Name);
        }

        [TestMethod]
        public void Verify_CanRelist_6327()
        {
            data = handler.GetApiResponce(baseUrl, absoluteUrl, "6327");
            Assert.IsTrue((data.CanRelist), "CanReList is False");
        }

        [TestMethod]
        public void Verify_Promotion_6327()
        {
            data = handler.GetApiResponce(baseUrl, absoluteUrl, "6327");
            bool isTrue = false;
            foreach (Promotion promotion in data.Promotions)
            {
                if (promotion.Name.Equals("Gallery"))
                {
                    if (promotion.Description.Contains("2x larger image"))
                        isTrue = true;
                }
            }
            Assert.IsTrue(isTrue, "The Promotions element with Name = \"Gallery\" does not has a Description that contains the text \"2x larger image\"");
        }
    }
}
