﻿using PokemonReviewApi.Models;

namespace PokemonReviewApi.Interfaces
{
    public interface IReviewerRepository
    {
        ICollection<Reviewer> GetReviewers();
        Reviewer GetReviewer(int reviewerId);
        ICollection<Reviewer> GetReviewByReviewer(int reviewerId);
        bool ReviewerExists(int reviewerId);
    }
}