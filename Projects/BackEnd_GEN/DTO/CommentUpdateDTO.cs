 //
// C# class for DTO "Comment" 
// Created on 2023-03-10 ( Date ISO 2023-03-10 - Time 16:46:08 )
// Generated by Telosys Tools Generator ( version 4.0.0 )
//

using System;
using System.Collections.Generic;
using System.Linq;

using CarModel.Models;
using CarModel.Entities;

namespace CarModel.DTO
{
	public class CommentUpdateDTO
	{
		// data Fields
		public string? comment { get; set; } 
   
		// Links Fields
		public long Post_oid { get; set; }
 
		
		public CommentUpdateDTO()
		{
		}
	}
}
