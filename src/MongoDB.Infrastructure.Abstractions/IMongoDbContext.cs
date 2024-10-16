﻿using MongoDB.Driver;
using System;

namespace MongoDB.Infrastructure
{
    public interface IMongoDbContext : ISyncMongoDbContext, IAsyncMongoDbContext, IDisposable
    {
        IMongoClient Client { get; }
        IMongoDatabase Database { get; }
        IClientSessionHandle Session { get; }
        bool AcceptAllChangesOnSave { get; }
    }
}
