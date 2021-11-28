using Microsoft.Extensions.DependencyInjection;

namespace MinSumNumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<IMathOperation, OwnImplementationMathOperation>()
                .BuildServiceProvider();

            var mathOperation = serviceProvider
                .GetService<IMathOperation>();

            var userInteraction = new UserInteraction(mathOperation);

            userInteraction.DialogueWithUser();
        }
    }
}
