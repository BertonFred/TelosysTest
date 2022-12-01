 //
// C# class for entity "Car" 
// Created on 2022-11-25 ( Date ISO 2022-11-25 - Time 15:32:57 )
// Generated by Telosys Tools Generator ( version 4.0.0 )
//

using System;
using System.Collections.Generic;
using System.Linq;

using CarModel.Models;
using CarModel.Entities;

namespace CarModel.ViewModels
{
	public class CarCreateViewModel
	{	
		// data Fields
		public string Name { get; set; } 
		public short Year { get; set; } 
		public float Price { get; set; } 
 
		// Links Fields
		public string BrandCode { get; set; }
		public long Driver_oid { get; set; }
 

		public CarCreateViewModel()
		{

		}

		public CarCreateViewModel(Car Car)
		{

			Name = Car.Name;
			Year = Car.Year;
			Price = Car.Price;
 
			BrandCode = Car.BrandCode;
			Driver_oid = Car.Driver_oid;
 
		}

	}
}
