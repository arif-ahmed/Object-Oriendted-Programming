using InfluencerManager;
using Infrastructure.Contracts;
using Moq;
using ServiceProvider;

namespace ServiceProviderTests
{
    public class CommandDispatcherTests
    {
        [Fact]
        public void Test_CommandDispatcher_ThrowsExceptionWhenNullCommandHasPassed()
        {
            List<ICommandHandler> handlers = new List<ICommandHandler>()
            {
                new TestCommandHandler()
            };

            ICommanDispatcher dispatcher = new CommandDispatcher(handlers);

            ArgumentNullException exception = Assert.Throws<ArgumentNullException>(() => dispatcher.Dispatch(null));
            Assert.Equal("command argument can not be null", exception.ParamName);
        }

        [Fact]
        public void Test_CommandDispatcher_ThrowsWhenCommandWithoutNoHandlerHasPassed()
        {
            List<ICommandHandler> handlers = new List<ICommandHandler>();
            ICommanDispatcher dispatcher = new CommandDispatcher(handlers);
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(() => dispatcher.Dispatch(new TestCommand { }));
            Assert.Equal("No handlers found.", exception.Message);
        }

        [Fact]
        public void Constructor_ShouldInitializeHandlers_WithReflection()
        {
            // Arrange
            var mockHandler1 = new Mock<ICommandHandler>();
            var mockHandler2 = new Mock<ICommandHandler>();
            var handlers = new List<ICommandHandler> { mockHandler1.Object, mockHandler2.Object };

            // Act
            var dispatcher = new CommandDispatcher(handlers);

            // Use reflection to access the private field
            var field = typeof(CommandDispatcher).GetField("_handlers", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var actualHandlers = field?.GetValue(dispatcher) as List<ICommandHandler>;

            // Assert
            Assert.NotNull(actualHandlers);
            Assert.Equal(handlers, actualHandlers);
        }

        [Fact]
        public void Test_CommandDispatcher_ForValidTestCommand()
        {
            List<ICommandHandler> handlers = new List<ICommandHandler>()
            {
                new TestCommandHandler()
            };

            ICommanDispatcher dispatcher = new CommandDispatcher(handlers);

            ICommandHandler handler = dispatcher.Dispatch(new TestCommand { Title = "Hello", Description = "World" });

            string expected = "TestCommand => Title: Hello, Description: World";
            string actual = handler.Handle(new TestCommand { Title = "Hello", Description = "World" });
            Assert.Equal(expected, actual);
        }
    }
}
