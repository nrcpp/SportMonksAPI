using System;
namespace SportMonksSDK;

public static class Constants
{
	// value to pass to obtain
	public const string Filter_1000_Per_Page = "filters=populate";


	// limits numbers of rows to get per Method call (our internal limitation)
	public const int MaxRows_Per_Call = 1000;		
}

public static class ParticipantType
{
    public const string Players = "players";
    public const string Coaches = "coaches";
    public const string Teams = "teams";
    public const string Referees = "referees";
}

