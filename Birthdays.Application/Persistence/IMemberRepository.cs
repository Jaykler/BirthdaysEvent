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

        Task<Member> GetMemberByIdAsync(int memberId);
    }
}
