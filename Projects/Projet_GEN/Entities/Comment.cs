 //
// GENERATED CODE DO NOT UPDATE
// Telosys Template : csharp-backend / Entities / Xxx.vm
// C# class for entity "Comment" 
// Created on 2022-12-15 ( Date ISO 2022-12-15 - Time 15:36:04 )
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
	public class Comment
	{
		//--- KEY ATTRIBUTE 

		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
 		public long oid { get; set; }
  
		//--- DATA (NOT KEY and NOT LINK) ATTRIBUTES 

		public string comment { get; set; } 

		//--- LINKS ATTRIBUTES 

		[ForeignKey("Post")]
		public long Post_oid { get; set; }
		public Post Post { get; set; }
    		
		public Comment()
		{

		}

		public override string ToString()
		{
			return string.Empty  +    comment ;	
		}
	}

  
}
