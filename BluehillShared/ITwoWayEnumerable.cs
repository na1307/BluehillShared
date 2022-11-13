namespace BluehillShared;

public interface ITwoWayEnumerable<out T> : IEnumerable<T> {
    new ITwoWayEnumerator<T> GetEnumerator();
}