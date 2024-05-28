using ComicsShop.Data.Interfaces;
using ComicsShop.Data.Models;

namespace ComicsShop.Data.Mocks;

public class MockComics : IAllComics
{
    private readonly IComicsCategory _comicsCategory = new MockCategory();

    public IEnumerable<Comic> Comics =>
        new List<Comic>
        {
            new Comic
            {
                name = "Heroes of Earth: Rebirth of a Legend",
                shortDesc = "The return of heroes to protect the world",
                longDesc = "Comic book Superman: Superman (English Superman lit. “Superman”; read as “Superman” - " +
                           "a proper name) is a fantastic hero of comic books (DC Comics (English)), invented in " +
                           "1936 by friends Jerome Siegel and Joe Shuster. In our store you will find many " +
                           "interesting stories about Superman.",
                img = "/img/2024-05-21_13-40-17.png",
                price = 6,
                isFavourite = true,
                available = true,
                Category = _comicsCategory.AllCategories.First()
            },

            new Comic
            {
                name = "Chronicles of the Dark World: Rise of Darkness",
                shortDesc = "The fight between light and darkness",
                longDesc = "Comic book Superman: Superman (English Superman lit. “Superman”; read as “Superman” - " +
                           "a proper name) is a fantastic hero of comic books (DC Comics (English)), invented in " +
                           "1936 by friends Jerome Siegel and Joe Shuster. In our store you will find many " +
                           "interesting stories about Superman.",
                img = "/img/2024-05-21_13-41-59.png",
                price = 6,
                isFavourite = false,
                available = false,
                Category = _comicsCategory.AllCategories.First()
            },

            new Comic
            {
                name = "Absolute Power",
                shortDesc = "The path of revenge through everyone",
                longDesc = "Discover the untold story of what led Amanda Waller to form the TRINITY OF EVIL and " +
                           "take down Earth's Super Heroes! It's the Suicide Squad's founder as you've never seen her " +
                           "before, in an all-new companion miniseries to the Absolute Power event. The definitive " +
                           "history of one of the DCU's deadliest villains is at last revealed! Amanda Waller's " +
                           "catastrophic attack on the metahumans of Earth has rendered both hero and villain " +
                           "POWERLESS, but what led THE WALL to this place? In Absolute Power: Origins, Academy " +
                           "Award-winning writer JOHN RIDLEY and fan-favorite artist ALITHA MARTINEZ will tell " +
                           "the tale about how one woman lost everything she held dear...powerless beneath the " +
                           "forces of senseless acts of chaos. The path of vengeance would bring her to two simple " +
                           "words that would change her life--and the lives of the entire DCU--forever: NEVER AGAIN.",
                img = "/img/2024-05-21_13-40-54.png",
                price = 8,
                isFavourite = true,
                available = true,
                Category = _comicsCategory.AllCategories.First()
            },
            new Comic
            {
                name = "Star Batman Issue 3",
                shortDesc = "Batman faced perhaps the greatest threat he had faced during his journey.",
                longDesc = "Batman has his share of a new threat. Two old friends and two old enemies, " +
                           "who once dreamed of seeing the world the way they wanted, will need the help of " +
                           "friends - new and old. But Bruce's friends and enemies weren't the only ones intent " +
                           "on getting in their way. The web became tighter and tighter, and it became harder and " +
                           "harder for Batman to see a path forward.",
                img = "/img/2024-05-21_13-42-50.png",
                price = 5,
                isFavourite = false,
                available = true,
                Category = _comicsCategory.AllCategories.First()
            },
            new Comic
            {
                name = "All-New Guardians of the Galaxy #12",
                shortDesc = "Who will be the next Member of the Guardians of the Galaxy",
                longDesc = "Despite the title All-New Guardians of the Galaxy, Marvel’s next franchise relaunch " +
                           "focused on the core team of Star-Lord, Gamora, Drax, Rocket and Groot. However, Marvel " +
                           "eventually shook things up by adding Ant-Man to the mix. Later, Thor’s BFF Beta Ray Bill " +
                           "joins the team as every hero in the galaxy begins hunting for Gamora.",
                img = "/img/2024-05-22_20-00-42.png",
                price = 6,
                isFavourite = true,
                available = true,
                Category = _comicsCategory.AllCategories.Last()
            },
            new Comic
            {
                name = "Alien",
                shortDesc = "When there is no more hope ",
                longDesc = "Jane and the remaining Spinners are running out of ways to escape. " +
                           "And hope is getting slimmer as each station they reach is decimated by the Xenomorphs. " +
                           "Will help reach the colony in time? Or will the true intents of the colony destroy all hope?",
                img = "/img/2024-05-22_19-59-19.png",
                price = 4,
                isFavourite = false,
                available = true,
                Category = _comicsCategory.AllCategories.Last()
            },
            new Comic
            {
                name = "Absolute Carnage",
                shortDesc = "Revenge",
                longDesc = "After turning Venom's world upside down a year ago, DONNY CATES and RYAN STEGMAN are " +
                           "about to put the Sinister Symbiote through hell again, only this time CARNAGE has come " +
                           "calling, and everyone who's ever worn a symbiote is dead in his sights! He's skirted the " +
                           "periphery of the Marvel Universe for months, but Cletus Kasady at last stands poised to " +
                           "make his grand return to New York in a blistering triple-sized story…and he wants to " +
                           "paint the town red!",
                img = "/img/2024-05-22_19-57-26.png",
                price = 7,
                isFavourite = true,
                available = true,
                Category = _comicsCategory.AllCategories.Last()
            },
            new Comic
            {
                name = "Aquaman vs Black Manta!",
                shortDesc = "Сhance to get even",
                longDesc = "Black Manta (David Hyde) is a fictional supervillain appearing in American comic books " +
                           "published by DC Comics. Created by Bob Haney and Nick Cardy, the character was introduced " +
                           "in Aquaman #35 (September 1967) as a ruthless and bloodthirsty underwater mercenary and " +
                           "has remained the arch-enemy of the superhero Aquaman ever since.",
                img = "/img/2024-05-22_19-55-47.png",
                price = 5,
                isFavourite = false,
                available = true,
                Category = _comicsCategory.AllCategories.First()
            }
        };

    public IEnumerable<Comic> getFavComic { get; set; }

    public Comic getObjectComic(int comicId)
    {
        throw new NotImplementedException();
    }
}