using BirthdaysEvent.Application.Persistence;
using BirthdaysEvent.Domain.Entities;
using BirthdaysEvent.Persistence.Context;
using Microsoft.EntityFrameworkCore;


namespace BirthdaysEvent.Persistence.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly DbContext _dbContext;
        private readonly DapperContext _dapper;

        public MemberRepository(DbContext dbContext,DapperContext dapperContext)
        {
            _dbContext = dbContext;
            _dapper = dapperContext;

        }
        public Task<Member> GetAllMember(int memberId)
        {
            throw new NotImplementedException();
        }
        public Task<Member> GetMemberByNameAsync(string fullName)
        {
            throw new NotImplementedException();
        }
        public Task<Member> AddMemberAsync(Member member)
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
