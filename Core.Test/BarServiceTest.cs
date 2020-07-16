using Moq;
using Moq.AutoMock;
using Shouldly;
using Xunit;

namespace Core.Test
{
    public class BarServiceTest
    {

        [Fact]
        public void ShouldCallIntoFooServiceTenTimes()
        {
            // Arrange
            var automocker = new AutoMocker();
            var fixture = automocker.CreateInstance<BarService>();

            // Act
            fixture.DoBarThing();

            // Assert
            var fooServiceMock = automocker.GetMock<IFooService>();
            fooServiceMock.Verify(x => x.DoFooThing(It.IsAny<int>()), Times.Exactly(10));
        }


        [Fact]
        public void ShouldCallIntoStubbedFooService()
        {
            // Arrange
            var automocker = new AutoMocker();
            var fooServiceStub = new FooServiceStub();
            automocker.Use<IFooService>(fooServiceStub);
            var fixture = automocker.CreateInstance<BarService>();

            // Pre-assert
            fooServiceStub.Count.ShouldBe(0);

            // Act
            fixture.DoBarThing();

            // Assert
            fooServiceStub.Count.ShouldBe(45);
        }


        [Fact]
        public void ShouldPerformMockedBehaviour()
        {
            // Arrange
            var automocker = new AutoMocker();
            automocker.Use<ISomeOtherService>(x => x.GetSomeValue("value") == 30);
            var fixture = automocker.CreateInstance<BarService>();

            // Act
            var result = fixture.DoOtherThing("value");

            // Assert
            result.ShouldBe(30);
            automocker.GetMock<ISomeOtherService>().VerifyAll();
        }
    }
}
