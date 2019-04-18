using System;
using Todo02.CommandStack.Events;
using Todo02.Infrastructure.Framework;
using Todo02.Infrastructure.Services;

namespace Todo02.CommandStack.Handlers
{
    public class EmailHandler : Handler,
        IHandleMessage<TaskCreatedEvent> 
    {
        public EmailHandler(IEventStore eventStore) 
            : base(eventStore)
        {
            
        }

        public void Handle(TaskCreatedEvent message)
        {
            var body = String.Format("Congratulations! Your task was created. Task number is {0}.",
                message.Id);

            EmailService.Send("you@someserver.com", body);
        }
    }
}