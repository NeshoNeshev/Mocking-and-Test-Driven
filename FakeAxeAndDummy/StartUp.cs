using System;
using FakeAxeAndDummy.Contracts;
using Moq;

public class StartUp
{
    static void Main(string[] args)
    {
        Mock<IAttackable>target = new Mock<IAttackable>();
        target.Setup(t => t.GiveExperience()).Returns(20);

         Mock<IWeapon>weapon = new Mock<IWeapon>();
         weapon.Setup(x => x.AttackPoints).Returns(20);
         weapon.Object.Attack(target.Object);

         int exp = target.Object.GiveExperience();
         Console.WriteLine(exp);
         Hero  hero = new Hero("Pesho",weapon.Object);
    }
}
