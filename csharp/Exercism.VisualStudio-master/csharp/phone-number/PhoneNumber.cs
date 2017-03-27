using System;

public class PhoneNumber
{
    private string number;
    public PhoneNumber(string phoneNumber)
    {
        number = phoneNumber;
    }

    public string Number
    {
        get
        {
            string num = "";
            foreach (var i in number)
            {
                if (char.IsNumber(i))
                {
                    num += i;
                }
            }
            if (num.Length > 9 && num.Length < 12)
            {
                if (num.Length == 11 && num[0] == '1')
                {
                    num = num.Remove(0, 1);
                }
                if (num.Length == 11 && num[0] != '1')
                {
                    num = "0000000000";
                }
            }
            else
            {
                num = "0000000000";
            }
            return num;
        }
    }

    public string AreaCode
    {
        get
        {
            return Number.Substring(0, 3);
        }
    }
    public override string ToString()
    {
        return string.Format("({0}) {1}-{2}", AreaCode, Number.Substring(3, 3), Number.Substring(6, 4));
    }
}