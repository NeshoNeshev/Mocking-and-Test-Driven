using System;
using FakeAxeAndDummy.Contracts;
using FakeAxeAndDummy.Tests.Face;
using Moq;
using NUnit.Framework;

[TestFixture]
public class HeroTests
{
    [Test]
    public void GivenHeroShouldResiveExperienceWhenAttackedTargetDies()
    {
        Mock<IAttackable> fakeTarget= new Mock<IAttackable>();
        fakeTarget.Setup(f => f.GiveExperience()).Returns(20);
        fakeTarget.Setup(f => f.IsDead()).Returns(true);
        //IAttackable fakeTarget = new IAttackableFake();
        Mock<IWeapon> fakeWeapon = new Mock<IWeapon>();
        //IWeapon fakeWeapon = new IWeaponFake() ;
        Hero hero = new Hero("Ivan",fakeWeapon.Object);
        hero.Attack(fakeTarget.Object);
        Assert.AreEqual(20,hero.Experience);
       
    }
}