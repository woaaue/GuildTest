public sealed class Unpredictable : Merchant
{
    public override MerchantType Type => MerchantType.Unpredictable;

    public override int Purse => _bank.GetBalance();

    public Unpredictable()
    {
        _bank = new Bank();
        _isHonestCooperation = GetBehaviour();
    }

    public override void MakeDeal(Merchant merchant, int numberTransactions)
    {
        for (int i = 0; i < numberTransactions; ++i)
        {
            _isHonestCooperation = GetBehaviour();

            base.MakeDeal(merchant, numberTransactions);
        }
    }

    private bool GetBehaviour()
    {
        var behaviour = UnityEngine.Random.Range(0, 2);

        return behaviour == 1 ? true : false;
    }
}
