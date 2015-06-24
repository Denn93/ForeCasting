using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDTA01_2.DennisBrian.CaseStudy3
{
	class DesForecasting
	{
		private Dictionary<int, double> _originalDataset;
		private double _steps;
		private double _minRange;
	    private int _lines;

	    public DesForecasting(Dictionary<int, double> originalDataset)
		{
			_originalDataset = originalDataset;
		}

		public DesForecasting(Dictionary<int, double> originalDataset, double minRange, double steps, int lines)
		{
			_originalDataset = originalDataset;
			_minRange = minRange;
			_steps = steps;
		    _lines = lines;
		}

        public Tuple<double, double, double, Dictionary<int, double>> CalculateOptimal()
        {
            Dictionary<int, double> resultSet = new Dictionary<int, double>();
            double alpha = 0.0;
            double beta = 0.0;
            double leastSquares = Double.MaxValue;

            for (double i = _minRange; i < 1; i += _steps)
            {
                for (double j = _minRange; j < 1; j += _steps)
                {
                    Dictionary<int, double> temp = new Dictionary<int, double>();
                    temp = CalculateDesPoints(i, j);

                    double tempLeast = CalculateLeastSquares(temp);
                    
                    if (!(leastSquares > tempLeast)) continue;

                    resultSet = temp;
                    leastSquares = tempLeast;
                    alpha = i;
                    beta = j;
                }
            }

            return new Tuple<double, double, double, Dictionary<int, double>>(alpha, beta, leastSquares, resultSet);
        } 

        public Dictionary<int, double> CalculateDesPoints(double alpha, double beta)
        {
            Dictionary<int, double> resultDataSet = new Dictionary<int, double>();

            double sPrev = _originalDataset[2];
            double bPrev = _originalDataset[2] - _originalDataset[1];
            resultDataSet[3] = CalculateForeCast(sPrev, bPrev);

            foreach (KeyValuePair<int, double> pair in _originalDataset.Where((x, i) => i > 1))
            {
                double sNew = CalculateS1(alpha, pair.Value, sPrev, bPrev);
                double bNew = CalculateB1(alpha, beta, sNew, sPrev, bPrev);

                resultDataSet.Add(pair.Key + 1, CalculateForeCast(sNew, bNew));

                sPrev = sNew;
                bPrev = bNew;
            }

            int iterator = 2;

            for (int i = resultDataSet.Max(m=>m.Key) + 1; i < _lines; i++)
            {
                resultDataSet.Add(i, sPrev + (iterator * bPrev));
                iterator++;
            }

            return resultDataSet;
        }

		private double CalculateLeastSquares(Dictionary<int, double> resultSet)
		{
		    double sum =
		        _originalDataset
		            .Where(m => m.Key > 2)
		            .Select(v => Math.Pow(resultSet[v.Key] - v.Value, 2))
		            .Sum();
			double count = _originalDataset.Count - 2;

			return Math.Sqrt(sum/count);
		}

        private double CalculateB1(double alpha, double beta, double sCurrent, double sPrev, double bPrev)
        {
            return beta*(sCurrent - sPrev) + (1 - beta)*bPrev;
        }

        private double CalculateS1(double alpha, double originalValue, double sPrev, double bPrev)
        {
            return alpha*originalValue + (1 - alpha)*(sPrev + bPrev);
        }

	    private double CalculateForeCast(double s1, double b1)
	    {
	        return s1 + b1;
	    }
	}
}
