using System;
using System.Collections.Generic;
using Features.Console.Interfaces;

namespace Features.Console.Repositories
{
    public class ConsoleStateRepository : IConsoleStateRepository
    {
        private readonly Dictionary<(int id, Type type), IConsoleData> _storage = new();

        public T GetOrCreate<T>(int consoleId) where T : IConsoleData, new()
        {
            var key = (consoleId, typeof(T));
            if (!_storage.TryGetValue(key, out var data))
            {
                data = new T();
                _storage[key] = data;
            }

            return (T)data;
        }

        public void Save<T>(int consoleId, T data) where T : IConsoleData
        {
            var key = (consoleId, typeof(T));
            _storage[key] = data;
        }
    }
}