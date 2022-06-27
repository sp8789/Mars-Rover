using Mars_Rover_MVC.Models;
using Mars_Rover_MVC.Service;
using System;
using Xunit;

namespace MarsRoverTests
{
    public class RoverMovementShould
    {
        IRoverService _roverService = new RoverService();
        public RoverMovementShould()
        {

        } 

        [Fact]
        public void SpinLeft()
        {
            _roverService.SetLocationValues("1 2 N");
            _roverService.SpinLeft();
            Assert.Equal("W", _roverService.Direction);
        }

        [Fact]
        public void SpinRight()
        {
            _roverService.SetLocationValues("1 2 N");
            _roverService.SpinRight();
            Assert.Equal("E", _roverService.Direction);
        }

        [Fact]
        public void StepForward()
        {
            _roverService.SetLocationValues("1 2 N");
            _roverService.StepForward();
            Assert.Equal(3, _roverService.CoordinateY);
        }

        [Fact]
        public void Move()
        {
            _roverService.SetLocationValues("1 2 N");
            _roverService.Move("LMLMLMLMM");
            Assert.Equal("1 3 N", _roverService.CoordinateX + " " + _roverService.CoordinateY + " " + _roverService.Direction);
        }
    }
}
