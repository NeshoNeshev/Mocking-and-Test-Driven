using System;
using System.Collections.Generic;
using System.Text;
using FakeAxeAndDummy.Contracts;

namespace FakeAxeAndDummy.Tests.Face
{
    class IWeaponFake:IWeapon
    {
        public int AttackPoints => 10;
        public int DurabilityPoints => 10;
        public void Attack(IAttackable target)
        {
            throw new NotImplementedException();
        }
    }
}
