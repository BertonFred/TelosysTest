 //
// GENERATED CODE DO NOT UPDATE
// Telosys Template : csharp-backend / Entities / Xxx.vm
// C# class for entity "Post" 
// Created on 2023-03-10 ( Date ISO 2023-03-10 - Time 16:46:08 )
// Generated by : csharp-backend 
// Generated by : Telosys Tools Generator 4.0.0
//

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace CarModel.Entities
{
	public class Post
	{
		//--- KEY ATTRIBUTE 
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
 		public long oid { get; set; }
  
		//--- DATA (NOT KEY and NOT LINK) ATTRIBUTES 
		public string Title { get; set; } 
  		public string? Description { get; set; } 
   

		//--- LINKS ATTRIBUTES 
  		
		public Post()
		{

		}

		public override string ToString()
		{
			return string.Empty  +    Title + " " +   Description ;	
		}
	}

 
}
