using AutoMapper;
using FeedbackService.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackService.Infrastructure.Repositories
{
    public class FeedbackRepositories : IFeedbackRepository


    {



        private readonly FeedbackDbContext _dbContext;

        private readonly IMapper _mapper;
        public FeedbackRepositories(FeedbackDbContext dbContext, IMapper mapper) 
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));

        }

        public async Task<bool> CreateFeedback(Feedback feedback)
        {
            throw new NotImplementedException();


        }

        public async Task<bool> DeleteFeedback(Feedback feedback)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Feedback>> GetAllFeedbacks()
        {
            var dbFeedbacks = await _dbContext.Feedback.ToListAsync().ConfigureAwait(false);

            return _mapper.Map<IEnumerable<Feedback>>(dbFeedbacks); 
        }

        public async Task<Feedback> GetFeedbackById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
