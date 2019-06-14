using LearnCSharp.Membership.Interfaces;
using System;

namespace LearnCSharp.Membership
{
    public class Member : BaseMember, IDeleteByIdAble<Member>, IReadByIdAble<Member>
    {
        public Member DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        Member IReadByIdAble<Member>.ReadById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
