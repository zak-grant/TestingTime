﻿//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;

namespace TestingTime.UnitTests
{
    // THESE METHODS MADE USING NUNIT
    [TestFixture]
    public class ReservationTests
    {
        [Test]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CabBeCancelledBy_SameUserCancelling_ReturnsTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            //Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_AnotherUserCancelling_ReturnFalse()
        {
            // Arrange
            var reservation = new Reservation { MadeBy = new User() };

            // Act
            var result = reservation.CanBeCancelledBy(new User());

            // Assert
            Assert.That(result, Is.False);
        }
    }


    // THESE METHODS MADE USING MSUNITTESTS
    //[TestClass]
    //public class ReservationTests
    //{
    //    [TestMethod]
    //    public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
    //    {
    //        // Arrange
    //        var reservation = new Reservation();

    //        // Act
    //        var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

    //        // Assert
    //        Assert.IsTrue(result);

    //    }

    //    [TestMethod]
    //    public void CabBeCancelledBy_SameUserCancelling_ReturnsTrue()
    //    {
    //        // Arrange
    //        var user = new User();
    //        var reservation = new Reservation { MadeBy = user };

    //        //Act
    //        var result = reservation.CanBeCancelledBy(user);

    //        // Assert
    //        Assert.IsTrue(result);
    //    }

    //    [TestMethod]
    //    public void CanBeCancelledBy_AnotherUserCancelling_ReturnFalse()
    //    {
    //        // Arrange
    //        var reservation = new Reservation { MadeBy = new User() };

    //        // Act
    //        var result = reservation.CanBeCancelledBy(new User());

    //        // Assert
    //        Assert.IsFalse(result);
    //    }
    //}
}
