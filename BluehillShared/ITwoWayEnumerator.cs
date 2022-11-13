namespace BluehillShared;

public interface ITwoWayEnumerator<out T> : IEnumerator<T> {
    bool MovePrevious();
}