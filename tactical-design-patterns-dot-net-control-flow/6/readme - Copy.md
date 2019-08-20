Optional call on an object (c#)
	Option<T> type
return this.userRepository
	.Find(username)
	.Select(user => user.Balance)
	.DefaultIfEmpty(0)
	.Single();
	
Collections Map-Reduce Sequences Option<T>

