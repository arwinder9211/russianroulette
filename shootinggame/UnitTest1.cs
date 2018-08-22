using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using shootinggame.Properties;
namespace shootinggame
{
    [TestClass]
    public class UnitTest1
    {
        int Chamber;
        int chamber_count = 0;
        Random ran = new Random();
        int[] playerGun = new int[] { 0, 0, 0, 0, 0, 0 };
        int round = 0;
        int miss_shot = 0;
        int total_score = 0;


        [TestMethod]
        public void TestMethod1()
        {
            SoundPlayer sound = new SoundPlayer(Resources.Gun_Reload);
            Assert.IsTrue(sound!=null);
        }

        [TestMethod]
        public void TestMethod2()
        {
            
            Assert.IsFalse(playerGun[chamber_count] == 1);
        }
    }
}
