using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GalaSoft.MvvmLight.Command;
using VyvojoveMetody;
using VyvojoveMetody.DependencyInjection;
using VyvojoveMetody.DependencyInjection.Validators;
using VyvojoveMetody.Models;
using VyvojoveMetody.ViewModels;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidatorCheck()
        {
            string incorrect = "";
            string corect = "aa";
            NameValidator nv = new NameValidator();
            bool correctname = nv.IsValid(corect);
            bool incorrectname = nv.IsValid(incorrect);
            Assert.IsTrue(correctname);
            Assert.IsFalse(incorrectname);
        }
        [TestMethod]
        public void BirthNumCheck() 
        {
            Pre1954Validator pre = new Pre1954Validator();
            Post1955Validator post = new Post1955Validator();
            
            
            bool a = pre.IsValid("020301/159");
            bool b = pre.IsValid("3");
            bool c = post.IsValid("123456/159");
            bool d = post.IsValid("020620/0269");

            Assert.IsTrue(a);
            Assert.IsFalse(b);
            Assert.IsFalse(c);
            Assert.IsTrue(d);
            
        }
    }
}
