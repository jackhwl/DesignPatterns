using System;
using System.Collections.Generic;
using Todo02.Infrastructure.Persistence.Model;
using Todo02.Infrastructure.Persistence.Repositories;

namespace Todo02.QueryStack
{
    public class ReadModel
    {
        private static readonly TodoRepository Repository = new TodoRepository();

        public static IList<TodoItem> All(DateTime? from, DateTime? to)
        {
            var list = Repository.All(from.GetValueOrDefault(), 
                to.GetValueOrDefault(DateTime.MaxValue),
                TaskStatus.All);
            return list;
        }
    }
}