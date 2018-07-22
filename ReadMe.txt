The test is writen in C# and is a unit test project. 
So before execution ; make sure you had installed visual studio and latest version of .net framework.
Once downloaded, open the solution in Visual Studio, build it and execute the following three test cases.
Test Cases -> Verify_Name_6327, Verify_CanRelist_6327, Verify_Promotion_6327

- "Data.cs" contains the classes which corresponds to the JSON responce object. 
- "ApiTestCases.cs" contains three test cases which corresponds to the validation of the given three acceptance criteria
- "ApiTestDefenition.cs" contains the defenition of all methods used in ApiTestCases.cs

Acceptance criteria :
 - Name = "Carbon credits"
 - CanRelist = true
 - The Promotion element with Name = "Gallery" has a Description that contains the text "2x larger image"
