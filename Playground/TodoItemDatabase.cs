using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Playground.Models;
using SQLite;

namespace Playground
{
    public class TodoItemDatabase
    {
        static readonly Lazy<SQLiteAsyncConnection> lazyInitializer = new Lazy<SQLiteAsyncConnection>(() =>
        {
            return new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        });

        static SQLiteAsyncConnection Database => lazyInitializer.Value;
        static bool initialized = false;

        public TodoItemDatabase()
        {
            InitializeAsync().SafeFireAndForget(false);
        }

        async Task InitializeAsync()
        {
            if (!initialized)
            {
                if (!Database.TableMappings.Any(m => m.MappedType.Name == typeof(UserLogin).Name))
                {
                    await Database.CreateTablesAsync(CreateFlags.None, typeof(UserLogin)).ConfigureAwait(false);
                    initialized = true;
                }
            }
        }
        public Task<List<UserLogin>> GetItemsAsync()
        {
            return Database.Table<UserLogin>().ToListAsync();
        }

        public Task<List<UserLogin>> GetItemsNotDoneAsync()
        {
            // SQL queries are also possible
            return Database.QueryAsync<UserLogin>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
        }

        public Task<UserLogin> GetItemAsync(int id)
        {
            return Database.Table<UserLogin>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(UserLogin item)
        {
            if (item.ID != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(UserLogin item)
        {
            return Database.DeleteAsync(item);
        }
        
    }
}
