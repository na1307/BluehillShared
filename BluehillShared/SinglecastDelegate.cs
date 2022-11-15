namespace BluehillShared;

public sealed class SinglecastDelegate<T> : IEquatable<SinglecastDelegate<T>?> where T : Delegate {
    private T? realDelegate;

    public SinglecastDelegate(T target) => realDelegate = (T)target.GetInvocationList()[0];

    public static explicit operator SinglecastDelegate<T>(T @delegate) => new(@delegate);
    public static implicit operator T?(SinglecastDelegate<T> singlecast) => singlecast.realDelegate;

    public static bool operator ==(SinglecastDelegate<T>? left, SinglecastDelegate<T>? right) => Equals(left, right);
    public static bool operator !=(SinglecastDelegate<T>? left, SinglecastDelegate<T>? right) => !(left == right);

    public static SinglecastDelegate<T> operator +(SinglecastDelegate<T> singlecast, T @delegate) {
        singlecast.realDelegate = singlecast.realDelegate is not null && singlecast.realDelegate != @delegate.GetInvocationList()[0]
            ? throw new ArgumentException("Singlecast", nameof(@delegate))
            : (T)@delegate.GetInvocationList()[0];

        return singlecast;
    }

    public static SinglecastDelegate<T> operator -(SinglecastDelegate<T> singlecast, T @delegate) {
        singlecast.realDelegate = singlecast.realDelegate is not null && singlecast.realDelegate != @delegate.GetInvocationList()[0]
            ? throw new ArgumentException("Singlecast", nameof(@delegate))
            : null;

        return singlecast;
    }

    public static bool Equals(SinglecastDelegate<T>? delegate1, SinglecastDelegate<T>? delegate2) => (object?)delegate1 == delegate2 || (delegate1 is not null && delegate2 is not null && delegate1.Equals(delegate2));
    public override bool Equals(object? obj) => Equals(obj as SinglecastDelegate<T>);
    public bool Equals(SinglecastDelegate<T>? other) => other is not null && realDelegate == other.realDelegate;
    [System.Diagnostics.CodeAnalysis.SuppressMessage("", "S2328")]
    public override int GetHashCode() => realDelegate?.GetHashCode() ?? 0;
}