using BirthdaysEvent.Domain.Entities;


namespace BirthdaysEvent.Application.Persistence
{
    public interface IMemberRepository
    {

        Task<IEnumerable<Member>> GetAllMember();

        Task<Member> GetMemberById(int id);

        Task<Member> AddMemberAsync(Member member);
        
        Task<Member> UpdateMemberAsync(Member member);

        Task<Member> RemoveMemberAsync(int id);
    }
}
