using BirthdaysEvent.Application.Persistence;
using BirthdaysEvent.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace BirthdaysEvent.Persistence.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly DbContext _dbContext;
        private readonly dapper daper;

        public MemberRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Member> AddMemberAsync(Member member)
        {
            throw new NotImplementedException();
        }

        public Task<Member> GetAllMember(int memberId)
        {
            throw new NotImplementedException();
        }

        public Task<Member> GetMemberByNameAsync(string fullName)
        {
            throw new NotImplementedException();
        }

        public Task<Member> UpdateMemberAsync(Member member)
        {
            throw new NotImplementedException();
        }

        public Task<Member> RemoveMemberAsync(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
