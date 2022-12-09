﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace Projekt_MVC.Models.Car
{
    public class CreateCarViewModel
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public List<SelectListItem> Engine { get; set; }
        public int HorsePower { get; set; }
    }
}