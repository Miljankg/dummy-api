using DummyApi.Domain;

namespace DummyApi.Tests.Domain;

public class HumanTests
{
    private readonly Human _sut = new();

    [Fact]
    public void SaySomething_ReturnsNonEmptyString()
    {
        var result = _sut.SaySomething();

        Assert.False(string.IsNullOrWhiteSpace(result));
    }

    [Fact]
    public void SaySomething_ReturnsKnownPhrase()
    {
        var knownPhrases = new[]
        {
            "I find the coffee here acceptable.",
            "Has anyone seen my keys?",
            "I should probably read that book someday.",
            "Why is it always the last place you look?",
            "I'm not saying it was aliens, but...",
            "We should do this again sometime.",
            "I was just about to say that.",
            "Does this look infected to you?",
            "I had a dream about spreadsheets again.",
            "Technically, I'm always on time — the meeting is early."
        };

        var result = _sut.SaySomething();

        Assert.Contains(result, knownPhrases);
    }

    [Fact]
    public void SaySomething_CalledRepeatedly_EventuallyReturnsDifferentPhrases()
    {
        // With 10 phrases and 50 calls the probability of getting the same phrase
        // every single time is (1/10)^49 — effectively impossible.
        var results = Enumerable.Range(0, 50)
            .Select(_ => _sut.SaySomething())
            .ToHashSet();

        Assert.True(results.Count > 1, "Expected more than one distinct phrase across 50 calls.");
    }

    [Fact]
    public void SaySomething_NeverReturnsNull()
    {
        for (var i = 0; i < 100; i++)
        {
            Assert.NotNull(_sut.SaySomething());
        }
    }
}
