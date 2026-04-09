namespace DummyApi.Domain;

public class Human
{
    private static readonly string[] Phrases =
    [
        "I find the coffee here acceptable.",
        "Has anyone seen my keys?",
        "I should probably read that book someday.",
        "Why is it always the last place you look?",
        "I'm not saying it was aliens, but...",
        "We should do this again sometime.",
        "I was just about to say that.",
        "Does this look infected to you?",
        "I had a dream about spreadsheets again.",
        "Technically, I'm always on time — the meeting is early.",
        "I have a system. I just haven't explained it to anyone."
    ];

    public string SaySomething() => Phrases[Random.Shared.Next(Phrases.Length)];

    public int CountSomething() => Random.Shared.Next(1, 100);

    public string Introduce(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return "Hi, I have no name.";

        return $"Hi, my name is {name}.";
    }
}
