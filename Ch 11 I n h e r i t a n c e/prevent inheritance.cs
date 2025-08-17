class B
{
    public virtual void MyMethod() { /* ... */ }
}
class D : B
{
    // This seals MyMethod() and prevents further overrides.
    sealed public override void MyMethod() { /* ... */ }
}
class X : D
{
    // Error! MyMethod() is sealed!
    public override void MyMethod() { /* ... */ }
}
//Because MyMethod() is sealed by D, it can’t be overridden by X.