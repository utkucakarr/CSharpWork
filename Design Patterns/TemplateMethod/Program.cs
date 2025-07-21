using System;

namespace TemplateMethod
{
    internal class Program
    {
        // Template Method ana algoritmayı tanımlar bazı adımları alt sınıflara bırakır.
        static void Main(string[] args)
        {
            ScoringAlgoritihm algoritihm;
            Console.WriteLine("Mans");
            algoritihm = new MensScoringAlgorithm();
            Console.WriteLine(algoritihm.GenerateScore(8, new TimeSpan(0, 2, 34)));

            Console.WriteLine("Womens");
            algoritihm = new WomensScoringAlgorithm();
            Console.WriteLine(algoritihm.GenerateScore(10, new TimeSpan(0, 2, 34)));

            Console.WriteLine("Childer");
            algoritihm = new ChilderensScoringAlgorithm();
            Console.WriteLine(algoritihm.GenerateScore(10, new TimeSpan(0, 2, 34)));
        }
    }

    abstract class ScoringAlgoritihm
    {
        public int GenerateScore(int hits, TimeSpan time)
        {
            int score = CalculateBaseScore(hits);
            int reduction = CalculateReduction(time);
            return CalculateOverallScore(score, reduction);
        }

        public abstract int CalculateOverallScore(int score, int reduction);

        public abstract int CalculateReduction(TimeSpan time);

        public abstract int CalculateBaseScore(int hits);
    }

    class MensScoringAlgorithm : ScoringAlgoritihm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 5;
        }
    }

    class WomensScoringAlgorithm : ScoringAlgoritihm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 3;
        }
    }

    class ChilderensScoringAlgorithm : ScoringAlgoritihm
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits / 80;
        }

        public override int CalculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 2;
        }
    }
}