using SignInLib;

namespace TestProjectOne
{
    [TestClass]
    public class SignInTest
    {
        [TestMethod]
        public void SuccessMethod()
        {
            string expResult = "valid user";
            Assert.AreEqual(expResult,SignIn.Authenticate("Ananth", "Ananth@123"));
        }
        [TestMethod]
        public void FailMethod()
        {
            string expResult = "invalid user credential";
            Assert.AreEqual(expResult,SignIn.Authenticate("Prakash", "Prakash@123"));
        }
        [TestMethod]
        public void AnonymousMethodMethod()
        {
            string expResult = "You must provide username and password";
            Assert.AreEqual(expResult,SignIn.Authenticate(null,null));
        }
    }
}