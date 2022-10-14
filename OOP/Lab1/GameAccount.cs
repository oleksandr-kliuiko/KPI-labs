namespace Lab1;

public class GameAccount : HistoryOfGames
    {
        private readonly string userName;
        private int currentRating;
        private static int gamesCount = 10000;
        public GameAccount(string userName, int currentRating)
        {
            if (currentRating <= 1)
            {
                throw new ArgumentOutOfRangeException(nameof(currentRating), "Rating cannot be less than 1");
            }

            this.userName = userName;
            this.currentRating = currentRating;
        }

        public void WinGame(GameAccount account, int rating)
        {
            if (rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "You can't play for a negative rating");
            }

            currentRating += rating;
            account.currentRating -= rating;

            if (account.currentRating <= 1)
            {
                throw new ArgumentOutOfRangeException(nameof(currentRating), "Rating cannot be less than 1");
            }

            history.Add(userName.ToString());
            history.Add("Game index: " + (++gamesCount).ToString());
            history.Add("Opponent: " + account.userName.ToString());
            history.Add("Rating: " + rating.ToString());
            history.Add("Victory");
            history.Add(userName.ToString() + " current rating: " + currentRating.ToString());
            history.Add(account.userName.ToString() + " current rating: " + account.currentRating.ToString());
            history.Add("");

        }

        public void LoseGame(GameAccount account, int rating)
        {
            if (rating <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(rating), "You can't play for a negative rating");
            }

            currentRating -= rating;
            account.currentRating += rating;

            if (currentRating <= 1)
            {
                throw new ArgumentOutOfRangeException(nameof(currentRating), "Rating cannot be less than 1");
            }

            history.Add(userName.ToString());
            history.Add("Game index: " + (++gamesCount).ToString());
            history.Add("Opponent: " + account.userName.ToString());
            history.Add("Rating: " + rating.ToString());
            history.Add("Defeat");
            history.Add(userName.ToString() + " current rating: " + currentRating.ToString());
            history.Add(account.userName.ToString() + " current rating: " + account.currentRating.ToString());
            history.Add("");
        }

        public void GetStats()
        {
            for (int i = 0; i < history.Count; i++)
            {
                if (history[i].Equals(userName.ToString()))
                {
                    for (int j = i + 1; j < i + 8; j++)
                    {
                        Console.WriteLine(history[j]);
                    }
                }
            }
        }
        
    }