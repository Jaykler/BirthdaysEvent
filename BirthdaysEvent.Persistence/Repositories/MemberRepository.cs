using BirthdaysEvent.Application.Persistence;
using BirthdaysEvent.Domain;
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
        public async Task<Member> GetMemberById(int id)
        {
            using var conn = _dapperCon.CreateConnection();

            var query = "SELECT * FROM Members WHERE Id = @Id";

            var member = await conn.QuerySingleOrDefaultAsync<Member>(query, new { Id = id }, commandType: CommandType.Text);
            // working here
            return member!;
        }
        public async Task<Member> AddMemberAsync(Member member)
        {

            _dbContext.Add(member);
            await _dbContext.SaveChangesAsync();
            return member;
        }

        public async Task<Member> UpdateMemberAsync(Member member)
        {
             _dbContext.Update(member);
            await _dbContext.SaveChangesAsync();
            return member;
        }

        public async Task<Member> RemoveMemberAsync(int id)
        {
            var member = await GetMemberById(id);
            if (member == null)
            {
                throw new KeyNotFoundException($"Member with Id {id} not found.");
            }
            
            member.status = MemberStatus.Deleted;
            await _dbContext.SaveChangesAsync();

            return member;
        }

        
    }
}
