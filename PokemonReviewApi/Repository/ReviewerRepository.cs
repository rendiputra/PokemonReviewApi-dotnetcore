using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PokemonReviewApi.Data;
using PokemonReviewApi.Interfaces;
using PokemonReviewApi.Models;

namespace PokemonReviewApi.Repository
{
    public class ReviewerRepository : IReviewerRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ReviewerRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ICollection<Reviewer> GetReviewByReviewer(int reviewerId)
        {
            return _context.Reviews.Where(r => r.Reviewer.Id == reviewerId).Select(e => e.Reviewer).ToList();
        }

        public Reviewer GetReviewer(int reviewerId)
        {
            return _context.Reviewers
                    .Where(r => r.Id == reviewerId)
                    .Include(e => e.Reviews)
                    .FirstOrDefault();
        }

        public ICollection<Reviewer> GetReviewers()
        {
            return _context.Reviewers.ToList();
        }

        public bool ReviewerExists(int reviewerId)
        {
            return _context.Reviewers.Any(r => r.Id == reviewerId);
        }
    }
}
