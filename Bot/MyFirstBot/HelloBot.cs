namespace MyFirstBot
{
    using System.Threading.Tasks;
    using Microsoft.Bot;
    using Microsoft.Bot.Builder;
    using Microsoft.Bot.Schema;

    public class HelloBot : IBot
    {
        public async Task OnTurn(ITurnContext turnContext)
        {
            if (turnContext.Activity.Type is ActivityTypes.Message)
            {
                var id = turnContext.Activity.From.Id;
                var name = turnContext.Activity.From.Name;
                await turnContext.SendActivity($"ID: {id}, Name: {name}");
            }
        }
    }
}