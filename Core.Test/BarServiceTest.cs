using Moq;
using Moq.AutoMock;
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
    }
}
