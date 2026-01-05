using BirthdaysEvent.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdaysEvent.Application.Persistence
{
    public interface IMemberRepository
    {

        Task<Member> GetAllMember(int memberId);

        Task<Member> GetMemberByNameAsync(string fullName);

        Task<Member> AddMemberAsync(Member member);
        
        Task<Member> UpdateMemberAsync(Member member);

        Task<Member> RemoveMemberAsync(int id);
    }
}
