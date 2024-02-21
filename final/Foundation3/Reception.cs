using System;
using System.Collections.Generic;

public class Reception : Event
{
    
    private string _Email;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
     : base(title, description, date, time, address)

    {

        _Email = Email;

    }

    public string Email
    {

        get { return _Email; }
        set { _Email = value; }

    }

    public override string GetFullDetails()
    {

        string baseDetails = GetStandardDetails();
        return $"{baseDetails}\nType: Reception\nRSVP Email: {_Email}";

    }
}