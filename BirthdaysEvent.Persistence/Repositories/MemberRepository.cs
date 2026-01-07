using BirthdaysEvent.Application.Persistence;
using BirthdaysEvent.Domain.Entities;
using BirthdaysEvent.Persistence.Context;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Data;


namespace BirthdaysEvent.Persistence.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        private readonly DbContext _dbContext;
        private readonly DapperContext _dapperCon;

        public MemberRepository(DbContext dbContext,DapperContext dapperContext)
        {
            _dbContext = dbContext;
            _dapperCon = dapperContext;

        }
        public async Task<IEnumerable<Member>> GetAllMember()
        {
            using var conn = _dapperCon.CreateConnection();
            var query = "SELECT * FROM Members";
            
            var members = await conn.QueryAsync<Member>(query, commandType: CommandType.Text);

            return members;
        }
        public Task<Member> GetMemberByNameAsync(string fullName)
        {
            throw new NotImplementedException();
        }
        public async Task<Member> AddMemberAsync(Member member)
        {
            _dbContext.Add(member);
            await _dbContext.SaveChangesAsync();
            return member;
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
