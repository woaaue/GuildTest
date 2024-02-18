public sealed class Bank 
{
    private int _balance;

    public Bank()
    {
        _balance = 0;
    }

    public void AddValue(int value)
    {
        _balance += value;
    }

    public int GetBalance()
    {
        return _balance;
    }
}
