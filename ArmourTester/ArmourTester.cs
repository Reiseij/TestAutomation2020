using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing2018;

namespace ArmourTester
{
    [TestClass]
    public class ArmourTester
    {
        Armour ar = new Armour("Test Gloves", "Gloves for testing purposes", 10, 2, 1);

        [TestMethod]
        public void TestLevel()
        {
           
            int lvl = ar.getLevel();
            

            // leveli voi olla vain 0 - 100
            if (lvl < 0 || lvl > 100)
            {
                Assert.Fail();
            }

        }
        [TestMethod]
        public void TestSlot()
        {

            int slot = ar.getSlot();

            // hanskojen slotti on aina 2
            if (slot != 2)
            {
                Assert.Fail();
            }

        }
        [TestMethod]
        public void TestCondition()
        {
            string condition = ar.getCondition();

            //Armorin kunto on alussa aina "Mint"
            if (condition != "Mint")
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestDamagetaken1()
        {
            ar.takeDam(1);

            //Armorin kunto damagen jälkeen ei voi olla täydellinen
            if (ar.getCurProt() != ar.getMaxProt() - 1)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestDamagetakenMax()
        {
            ar.takeDam(ar.getMaxProt());
    
            //Armorin kunto damagen max damagen jälkeen on 0
            if (ar.getCurProt() != 0)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestRepair1()
        {
            //Armorin kunto damagen max damagen jälkeen on 0
            ar.takeDam(ar.getMaxProt());
            ar.repair(1);
            
            if (ar.getCurProt() != 1)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestRepairMax()
        {
            //Armorin kunto damagen max damagen jälkeen on 0
            ar.takeDam(ar.getMaxProt());

            if (ar.getCurProt() != 0)
            {
                Assert.Fail();
            }

            ar.repair(ar.getMaxProt());

            if (ar.getCurProt() != ar.getMaxProt())
            {
                Assert.Fail();
            }
        }
    }
}
