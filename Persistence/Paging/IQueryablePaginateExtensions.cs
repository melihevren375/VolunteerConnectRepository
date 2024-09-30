using Microsoft.EntityFrameworkCore;

namespace Persistence.Paging;

public static class IQueryablePaginateExtensions
{
    public static async Task<Paginate<T>> ToPaginateAsync<T>(this IQueryable<T> source,
        int index,
        int size,
        CancellationToken cancellationToken = default)
    {
        int count = await source.
            CountAsync(cancellationToken).
            ConfigureAwait(false);

        List<T> items = await source.
            Skip(index * size).
            Take(size).
            ToListAsync().
            ConfigureAwait(false);

        Paginate<T> list = new()
        {
            Count = count,
            Items = items,
            Index = index,
            Size = size,
            Pages = (int)Math.Ceiling(count / (double)(size))
        };

        return list;
    }
}
