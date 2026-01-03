using BirthdaysEvent.Application.Persistence;
using BirthdaysEvent.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdaysEvent.Persistence.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        public Task<Member> GetMemberByIdAsync(int memberId)
        {
            throw new NotImplementedException();
        }
    }
}
