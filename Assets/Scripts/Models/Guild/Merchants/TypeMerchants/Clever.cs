public sealed class Clever : Merchant
{
    public override MerchantType Type => MerchantType.Clever;

    public override int Purse => _bank.GetBalance();

    private int _transactionCounter = 0;
    private bool _IsCheating;

    public Clever()
    {
        _bank = new Bank();
        _isHonestCooperation = true;
    }

    public override void MakeDeal(Merchant merchant, int numberTransactions)
    {
        SetSequence();

        bool honestCooperation = _isHonestCooperation;

        if (_errorProbability < 6)
            honestCooperation = !honestCooperation;

        if (honestCooperation && merchant.IsHonestCooperation)
        {
            _bank.AddValue(4);
            GetBank(merchant).AddValue(4);
        }
        else if (honestCooperation && !merchant.IsHonestCooperation)
        {
            _bank.AddValue(1);
            GetBank(merchant).AddValue(5);

            if (_transactionCounter < 5)
            {
                MerchantCheated();
            }
        }
        else if (!honestCooperation && merchant.IsHonestCooperation)
        {
            _bank.AddValue(5);
            GetBank(merchant).AddValue(1);
        }
        else if (!honestCooperation && !merchant.IsHonestCooperation)
        {
            _bank.AddValue(2);
            GetBank(merchant).AddValue(2);

            if (_transactionCounter < 5)
            {
                MerchantCheated();
            }
        }

        if (_transactionCounter >= 5 && !_IsCheating)
            _isHonestCooperation = merchant.IsHonestCooperation;

        _transactionCounter++;
    }

    private void SetSequence()
    {
        if (_transactionCounter == 1)
            _isHonestCooperation = false;

        if (_transactionCounter == 2 || _transactionCounter == 3 || _transactionCounter == 4)
            _isHonestCooperation = true;

        if (_transactionCounter == 5)
        {
            if (_IsCheating)
            {
                _isHonestCooperation = false;
            }
            else
            {
                _isHonestCooperation = true;
            }
        }
    }

    private void MerchantCheated() => _IsCheating = true;
}
