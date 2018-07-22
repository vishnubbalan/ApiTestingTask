using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Configuration;
namespace AssurityApiTest
{
    public class ApiTestDefenition
    {
        string baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
        string absoluteUrl = ConfigurationManager.AppSettings["CategoryAbsoluteUrl"];
        
        Data data;
        ApiRequestHandler handler = new ApiRequestHandler();

        public void Verify_Name(string categoryId, string name)
        {
            data = handler.GetApiResponce(baseUrl, absoluteUrl, categoryId);
            Assert.IsTrue((data.Name.Equals(name)), "Expected : {0} ; Actual : {1}", name, data.Name);
        }

        public void Verify_CanRelist(string categoryId, bool boolean)
        {
            data = handler.GetApiResponce(baseUrl, absoluteUrl, categoryId);
            Assert.IsTrue((data.CanRelist).Equals(boolean), "CanReList is {0}", data.CanRelist);
        }

        public void Verify_Promotion(string categoryId, string promotionName, string promotionDescription)
        {
            data = handler.GetApiResponce(baseUrl, absoluteUrl, categoryId);
            bool isTrue = false;
            foreach (Promotion promotion in data.Promotions)
            {
                if (promotion.Name.Equals(promotionName))
                {
                    if (promotion.Description.Contains(promotionDescription))
                        isTrue = true;
                }
            }
            Assert.IsTrue(isTrue, "The Promotions element with Name = {0} does not exist or does not has a Description that contains the text {1}", promotionName, promotionDescription);
        }
    }
}
