using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssurityApiTest
{
    [TestClass]
    public class ApiTestCases
    {
        ApiTestDefenition testDefenition = new ApiTestDefenition();
        string categoryId = "6327";

        //verify category with name "Carbon credits" for categoryId 6327
        [TestMethod]
        public void Verify_Name_6327()
        {
            testDefenition.Verify_Name(categoryId, "Carbon credits");
        }

        //verify whether the CanRelist flag is true for categoryId 6327
        [TestMethod]
        public void Verify_CanRelist_6327()
        {
            testDefenition.Verify_CanRelist(categoryId, true);
        }

        //Verify the Promotion element with Name = Gallery has a Description that contains the text "2x larger image"
        [TestMethod]
        public void Verify_Promotion_6327()
        {
            testDefenition.Verify_Promotion(categoryId, "Gallery", "2x larger image");
        }

    }
}
