 //
// C# class for DTO "Comment" 
// Created on 2022-12-15 ( Date ISO 2022-12-15 - Time 15:36:04 )
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
		public long oid { get; set; } 
 
		public string comment { get; set; } 
 
		public long Post_oid { get; set; }
 
     		
		public CommentUpdateDTO()
		{

		}
		
		public CommentUpdateDTO(Comment Comment)
		{
			oid =  Comment.oid;
 
			comment = Comment.comment;
 
			Post_oid = Comment.Post_oid;
 		}
	}
}
