namespace DependencyInjection
{
    public class LottoWinnerGenerator
    {
        private readonly INumberGenerator _numberGenerator;

        public LottoWinnerGenerator(INumberGenerator numberGenerator)
        {
            _numberGenerator = numberGenerator;
        }

        public string DisplayWinningNumber()
        {
            if (_numberGenerator.Generate() > 50) return "Mark";
            return "Bob";
        }
    }
}