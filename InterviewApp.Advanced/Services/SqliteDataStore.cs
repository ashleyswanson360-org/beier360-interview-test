using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using InterviewApp.Models;
using InterviewApp.Interfaces;

namespace InterviewApp.Services
{
    public class SqliteDataStore : IDataStore<Item>
    {
        // Fields
        private readonly string _file;

        // Ctors
        public SqliteDataStore()
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
                Directory.CreateDirectory(libFolder);

            _file = Path.Combine(libFolder, "datastore.db3");

            SQLitePCL.Batteries.Init();
        }

        // Private
        private async Task<DataContext> GetContextAsync()
        {
            DataContext db = new DataContext(_file);

            await db.Database.EnsureCreatedAsync();

            return db;
        }

        // Public
        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            DataContext? db = null;
            try
            {
                db = await GetContextAsync();

                return db.Items.ToList();
            }
            finally
            {
                db?.Dispose();
            }
        }

        public async Task<Item?> GetItemAsync(Guid id)
        {
            DataContext? db = null;
            try
            {
                db = await GetContextAsync();

                Item? item = await db.Items.FindAsync(id);
                return item;
            }
            finally
            {
                db?.Dispose();
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            DataContext? db = null;
            try
            {
                db = await GetContextAsync();

                db.Items.Add(item);
                await db.SaveChangesAsync();

                return true;
            }
            finally
            {
                db?.Dispose();
            }
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            DataContext? db = null;
            try
            {
                db = await GetContextAsync();

                db.Items.Update(item);
                await db.SaveChangesAsync();

                return true;
            }
            finally
            {
                db?.Dispose();
            }
        }

        public async Task<bool> DeleteItemAsync(Guid id)
        {
            DataContext? db = null;
            try
            {
                db = await GetContextAsync();

                Item? item = await db.Items.FindAsync(id);
                if (item == null)
                    return false;

                db.Items.Remove(item);
                await db.SaveChangesAsync();

                return true;
            }
            finally
            {
                db?.Dispose();
            }
        }
    }
}
