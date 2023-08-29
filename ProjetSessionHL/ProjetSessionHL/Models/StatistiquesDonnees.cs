namespace ProjetSessionHL.Models
{
    public class StatistiquesDonnees
    {
        public int ID { get; set; }

        public string Mois { get; set; }

        public int VisitsToWebsite { get; set; }

        public int AccountsCreated { get; set; }

        public int Wins { get; set; }

        public int Loses { get; set; }

        public int GoalsScoredTeam { get; set; }

        public int SavesMadeTeam { get; set; }

        public int ScoreZenTotal { get; set; }

        public int GoalsZenTotal { get; set; }

        public int ShotsZenTotal { get; set; }

        public int RatingZenTotal { get; set; }
    }
}