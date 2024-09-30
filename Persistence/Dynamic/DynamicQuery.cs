namespace Persistence.Dynamic;

public class DynamicQuery
{
    public DynamicQuery(Filter filter, IEnumerable<Sort>? sort)
    {
        Sort = sort;
        Filter = filter;
    }

    public DynamicQuery()
    {

    }

    public IEnumerable<Sort>? Sort { get; set; }
    public Filter Filter { get; set; }
}
