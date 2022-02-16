using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using InterviewApp.Models;
using InterviewApp.Interfaces;

namespace InterviewApp.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        private readonly List<Item> _items;

        public MockDataStore()
        {
            _items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid(), Text = "First item",  Description="This is an item description." },
                new Item { Id = Guid.NewGuid(), Text = "Second item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid(), Text = "Third item",  Description="This is an item description." },
                new Item { Id = Guid.NewGuid(), Text = "Fourth item", Description="This is an item description." },
                new Item { Id = Guid.NewGuid(), Text = "Fifth item",  Description="This is an item description." },
                new Item { Id = Guid.NewGuid(), Text = "Sixth item",  Description="This is an item description." }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            _items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = _items.Where(i => i.Id.Equals(item.Id)).FirstOrDefault();
            _items.Remove(oldItem);
            _items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(Guid id)
        {
            var oldItem = _items.Where(i => i.Id.Equals(id)).FirstOrDefault();
            _items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item?> GetItemAsync(Guid id)
        {
            return await Task.FromResult(_items.FirstOrDefault(i => i.Id.Equals(id)));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(_items);
        }
    }
}