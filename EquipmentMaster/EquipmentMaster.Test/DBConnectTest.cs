using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquipmentMaster.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Moq;

namespace EquipmentMaster.Test
{
    [TestClass]
    public class DBConnectTest
    {
        [TestMethod]
        public void RemoveTest()
        {
            //EquipmentEntities entities = new EquipmentEntities();
            //entities.Equipments = new DBSet<Equipment>();
            //var equ = new Equipment();
            //equ.ID = 1;
            //equ.NAME = "Name";
            //equ.Year = 2008;
            //equ.Make = "make";
            //equ.EquipmentModel = "model";
            //equ.Description = "desc";

            //entities.Equipments.Add(equ);
            Mock<EquipmentEntities> mock = new Mock<EquipmentEntities>();
        }
    }
}
