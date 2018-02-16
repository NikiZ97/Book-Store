using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using LinqToDB.Mapping;

namespace BookReading.Models
{
	public class Review
	{
	    [PrimaryKey, Identity]
        public int Id { get; set; }
		
		[Display(Name = "Author")]
		[Column]
        public string Author { get; set; }

	    [Column]
        public int BookId { get; set; }
		
		[Required (ErrorMessage = "Required field")]
		[Display(Name = "Feedback")]
		[Column]
        public string Text { get; set; }

	    [Column]
	    public int LikeCount { get; set; }

	    [Column]
	    public string ReportReason { get; set; }
		
		public void Update(Review newReview)
		{
			Author = newReview.Author;
			Text = newReview.Text;
		}
    }
}