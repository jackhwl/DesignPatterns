﻿namespace Todo02.Infrastructure.Framework
{
    public interface IStartWithMessage<in T> where T : Message
    {
        void Handle(T message);
    }
}