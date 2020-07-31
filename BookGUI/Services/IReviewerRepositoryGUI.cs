using BookApiProject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookGUI.Services
{
    public interface IReviewerRepositoryGUI
    {
        IEnumerable<ReviewerDto> GetReviewers();
        ReviewDto GetReviewerById(int reviewerId);
        IEnumerable<ReviewDto> GetReviewsByReviewer(int reviewerId);
        ReviewDto GetReviewerOfAReview(int reviewId);
    }
}
