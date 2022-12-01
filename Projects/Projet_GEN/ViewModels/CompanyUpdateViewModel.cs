 //
// C# class for entity "Company" 
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
	public class CompanyUpdateViewModel
	{
		public long oid { get; set; } 
 
		public string name { get; set; } 
 
 
 		
		public CompanyUpdateViewModel()
		{

		}
		
		public CompanyUpdateViewModel(Company Company)
		{
			oid =  Company.oid;
 
			name = Company.name;
 
 		}
	}
}
