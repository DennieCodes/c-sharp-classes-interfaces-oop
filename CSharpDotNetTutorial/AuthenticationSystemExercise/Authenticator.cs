﻿namespace CSharpDotNetTutorial.AuthenticationSystemExercise;
public class Authenticator
{
    public class EyeColor
    {
        public const string Blue = "blue";
        public const string Green = "green";
        public const string Brown = "brown";
        public const string Hazel = "hazel";
        public const string Grey = "grey";
    }

    public Authenticator(Identity admin)
    {
        this.admin = admin;
    }

    private Identity admin;

    private readonly IDictionary<string, Identity> developers
        = new Dictionary<string, Identity>
        {
            ["Bertrand"] = new Identity
            {
                Email = "bert@ex.ism",
                EyeColor = "blue"
            },

            ["Anders"] = new Identity
            {
                Email = "anders@ex.ism",
                EyeColor = "brown"
            }
        };

    public Identity Admin
    {
        get { return admin; }
    }

    public IDictionary<string, Identity> GetDevelopers()
    {
        // return new ReadOnlyDictionary<string, Identity>(developers);
        return developers.ToDictionary(kvp => kvp.Key, kvp => kvp.Value).AsReadOnly();
    }
}

public struct Identity
{
    public string Email { get; set; }

    public string EyeColor { get; set; }
}
