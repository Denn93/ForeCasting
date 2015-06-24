using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INDTA01_2.DennisBrian.CaseStudy3
{
	class SesForecasting
	{
		private Dictionary<int, double> _originalDataset;
		private double _steps;
		private double _minRange;

		public SesForecasting(Dictionary<int, double> originalDataset)
		{
			_originalDataset = originalDataset;
		}

		public SesForecasting(Dictionary<int, double> originalDataset, double minRange, double steps)
		{
			_originalDataset = originalDataset;
			_minRange = minRange;
			_steps = steps;
		}

		public Dictionary<int, double> Calculate(double alpha)
		{
			Dictionary<int, double> result = new Dictionary<int, double>();
			double average = CalculateInitialization();
			result.Add(1, average);

			CalculateAllSesPoints(alpha, _originalDataset, result);

			return result;
		}

		public Tuple<double, double, Dictionary<int, double>> CalculateOptimal()
		{
			Dictionary<int, double> resultSet = new Dictionary<int, double>();
		    double alpha = 0.0;
		    double leastSquares = Double.MaxValue;

		    for (double i = _minRange; i < 1; i += _steps)
		    {
		        Dictionary<int, double> temp = resultSet = Calculate(i);
		        double tempLeast = CalculateLeastSquares(temp);
		        
                if (!(leastSquares > tempLeast)) continue;
		        
                resultSet = temp;
		        leastSquares = tempLeast;
		        alpha = i;
		    }

		    return new Tuple<double, double, Dictionary<int, double>>(alpha, leastSquares, resultSet);
		}

		private double CalculateLeastSquares(Dictionary<int, double> resultSet)
		{
			double sum = _originalDataset.Select((x, i) => Math.Pow(resultSet[i + 1] - x.Value, 2)).Sum();
			double count = _originalDataset.Count - 1;

			return Math.Sqrt(sum/count);
		}

		private void CalculateAllSesPoints(double alpha, Dictionary<int, double> orignalDataSet, Dictionary<int, double> resultDataSet)
		{
			foreach (KeyValuePair<int, double> pair in _originalDataset.Where((x,i) => i > 0))
			{
				resultDataSet.Add(pair.Key,
					CalculateSES(alpha, _originalDataset[pair.Key - 1], resultDataSet[pair.Key - 1]));
			}

			resultDataSet.Add(_originalDataset.Count + 1,
				CalculateSES(alpha, orignalDataSet[orignalDataSet.Count], resultDataSet[orignalDataSet.Count]));

		}

		private double CalculateSES(double alpha, double originalValue, double resultValue)
		{
			return alpha*originalValue + (1 - alpha)*resultValue;
		}

		private double CalculateInitialization()
		{
			return _originalDataset.Where((x,i) => i < 12).Average(m => m.Value);
		} 
	}
}
