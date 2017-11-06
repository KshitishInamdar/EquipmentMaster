using EquipmentMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquipmentMaster.DBConnect
{
    public class DBConnect
    {
        EquipmentEntities entities = null;

        public DBConnect()
        {
            entities = new EquipmentEntities();
        }

        public DBConnect(EquipmentEntities entities)
        {
            this.entities = entities;
        }

        public void Remove(int id)
        {
            var equipment = entities.Equipments.FirstOrDefault(x => x.ID == id);
            entities.Equipments.Remove(equipment);
            entities.SaveChanges();
        }

        public List<Equipment> GetAllEquipment()
        {
            return entities.Equipments.ToList();
        }

        public Equipment GetEquipment(int id)
        {
            return entities.Equipments.FirstOrDefault(x => x.ID == id);
        }

        public void Add(EquipmentViewModel model)
        {
            if (model.ID > 0)
            {
                Update(model);
            }
            else
            {
                entities.Equipments.Add(Utility.Utility.ToEquipment(model));
                entities.SaveChanges();
            }

            
        }

        private void Update(EquipmentViewModel model)
        {
            var equipment = entities.Equipments.FirstOrDefault(x => x.ID == model.ID);
            equipment = Utility.Utility.ToEquipment(model, equipment);
            entities.Entry(equipment).State = System.Data.Entity.EntityState.Modified;
            entities.SaveChanges();
        }

    }
}