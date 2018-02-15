using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LinqToDB;
using LinqToDB.Data;

namespace BookReading.Models
{
    public class DbReviewContext : IReviewContext
    {
        public int IncrementAndGetLikes(int reviewId)
        {
            using (var db = new Database())
            {
                var review =
                    db.Reviews.SingleOrDefault(x => x.Id == reviewId);

                if (review == null)
                    return -1;

                review.LikeCount += 1;

                db.Update(review);
                return review.LikeCount;
            }
        }

        public List<Review> GetAll()
        {
            using (var db = new Database())
            {
                var query = (from r in db.Reviews
                    select r);
                return query.ToList();
            }
        }

        public void Report(int reviewId, string reason)
        {
            using (var db = new Database())
            {
                var review =
                    db.Reviews.SingleOrDefault(x => x.Id == reviewId);

                if (review == null)
                    return;

                review.ReportReason = reason;

                db.Update(review);
                return;
            }
        }

        public List<Review> GetTop5(int bookId)
        {
            using (var db = new Database())
            {
                var query = (from r in db.Reviews where r.BookId == bookId
                    orderby r.LikeCount descending
                    select r).Take(5);
                return query.ToList();
            }
        }

        public Review Update(Review newReview)
        {
            if (newReview == null)
                throw new ArgumentNullException(nameof(newReview));

            using (var db = new Database())
            {
                var review =
                    db.Reviews.SingleOrDefault(x => x.Id == newReview.Id);

                if (review == null)
                    return null;

                db.Update(newReview);

                review.Update(newReview);
                return review;
            }
            
        }

        public Review GetReview(int id)
        {
            using (var db = new Database())
            {
                return db.Reviews.SingleOrDefault(x => x.Id == id);
            }
        }

        private class Database : DataConnection
        {
            public Database() : base("Main")
            {

            }

            public ITable<Review> Reviews { get { return GetTable<Review>(); } }
        }
    }
}