using System;
using System.Threading.Tasks;

namespace ContosoUniversity.Infrastructure
{
    public static class Catcher
    {
        public static async Task RethrowAsync(Func<Task> @do, Func<Task> @catch, Func<Task> @finally)
        {
            try
            {
                await @do();
            }
            catch
            {
                await @catch();
                throw;
            }
            finally
            {
                await @finally();
            }
        }
    }
}
