using EquipmentMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EquipmentMaster.Utility
{
    public static class Utility
    {
        public static EquipmentViewModel ToEquipmentViewModel(Equipment equipment)
        {
            var equipmentViewModel = new EquipmentViewModel();
            equipmentViewModel.ID = equipment.ID;
            equipmentViewModel.Name = equipment.NAME;
            equipmentViewModel.Year = equipment.Year;
            equipmentViewModel.Make = equipment.Make;
            equipmentViewModel.EquipmentModel = equipment.EquipmentModel;
            equipmentViewModel.Description = equipment.Description;
            return equipmentViewModel;
        }

        public static Equipment ToEquipment(EquipmentViewModel equipmentViewModel, Equipment equipment = null)
        {
            equipment = equipment == null ? new Equipment() : equipment;
            equipment.NAME = equipmentViewModel.Name;
            equipment.Year = equipmentViewModel.Year;
            equipment.Make = equipmentViewModel.Make;
            equipment.EquipmentModel = equipmentViewModel.EquipmentModel;
            equipment.Description = equipmentViewModel.Description;

            return equipment;
        }
    }
}