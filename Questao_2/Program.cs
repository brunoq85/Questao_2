using Newtonsoft.Json.Linq;

public class Program
{
    private static async Task<int> GetTotalGoalsAsync(string team, int year)
    {
        int totalGoals = 0;
        int page = 1;
        HttpClient client = new HttpClient();

        while (true)
        {
            var response = await client.GetStringAsync($"https://jsonmock.hackerrank.com/api/football_matches?year={year}&team1={team}&page={page}");
            var json = JObject.Parse(response);

            var data = json["data"];
            if (data.Count() == 0) break;

            foreach (var match in data)
            {
                totalGoals += int.Parse(match["team1goals"].ToString());
            }

            page++;
        }

        page = 1;
        while (true)
        {
            var response = await client.GetStringAsync($"https://jsonmock.hackerrank.com/api/football_matches?year={year}&team2={team}&page={page}");
            var json = JObject.Parse(response);

            var data = json["data"];
            if (data.Count() == 0) break;

            foreach (var match in data)
            {
                totalGoals += int.Parse(match["team2goals"].ToString());
            }

            page++;
        }

        return totalGoals;
    }

    static async Task Main(string[] args)
    {
        string teamName = "Paris Saint-Germain";
        int year = 2013;
        int totalGoals = await GetTotalGoalsAsync(teamName, year);

        Console.WriteLine("Team " + teamName + " scored " + totalGoals.ToString() + " goals in " + year);

        teamName = "Chelsea";
        year = 2014;
        totalGoals = await GetTotalGoalsAsync(teamName, year);

        Console.WriteLine("Team " + teamName + " scored " + totalGoals.ToString() + " goals in " + year);

    }
}
