using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    enum Operation { Add, Div, Sub, Mul, plusandminus }

    delegate void CalculatorDidUpdateOutput(Calculator sender, double value, int precision);

    class Calculator
    {

        double? left = null;
        double? right = null;
        Operation? currentOp = null;
        bool decimalPoint = false;
        int precision = 0;

        public event CalculatorDidUpdateOutput DidUpdateValue;
        public event EventHandler<string> InputError;
        public event EventHandler<string> CalculationError;

        public void AddDigit(int digit)
        {
            if (left.HasValue && Math.Log10(left.Value) > 10 || precision > 13)
            {
                InputError?.Invoke(this, "Input overflow");
                return;
            }
            if (precision > 10)
            {
                InputError?.Invoke(this, "Input overflow");
                return;
            }
            if (!decimalPoint)
            {
                left = (left ?? 0) * 10 + digit;
            }
            else
            {
                precision += 1;
                left = left + (Math.Pow(0.1, precision) * digit);
            }
            DidUpdateValue?.Invoke(this, left.Value, precision);
        }

        public void AddDecimalPoint()
        {
            if (!left.HasValue)
            {
                left = 0;
            }
            decimalPoint = true;
        }

        public void AddOperation(Operation op)
        {
            if (left.HasValue && currentOp.HasValue)
            {
                Compute();

            }
            if (!right.HasValue && !(op == Operation.plusandminus))
            {
                right = left;
                left = 0;
                precision = 0;
                decimalPoint = false;
                DidUpdateValue.Invoke(this, left.Value, precision);
                currentOp = op;
            }
            if (left.HasValue  && op == Operation.plusandminus)
            {
                currentOp = op;
                ComputeUnar();
                currentOp = null;
            }

        }
        
        public void ComputeUnar()
        {
            switch (currentOp)
            {
                case Operation.plusandminus:
                    right = left*(-1);
                    break;
            }
            left = right;
            DidUpdateValue?.Invoke(this, right.Value, precision);
            right = null;
        }

        public void Compute()
        {
            switch (currentOp)
            {
                case Operation.Add:
                    right = left + right;
                    left = null;
                    break;

                case Operation.Sub:
                    right = right - left;
                    left = null;
                    break;

                case Operation.Mul:
                    right = left * right;
                    left = null;
                    break;

                case Operation.Div:
                    if (left == 0)
                    {
                        CalculationError?.Invoke(this, "Division by 0!");
                        return;
                    }
                    right = right / left;
                    left = null;
                    break;
            }
            
            if (left != null)
            {
                CalculationError?.Invoke(this, "Action is not performed !!!");
            }
            else { DidUpdateValue?.Invoke(this, right.Value, precision);  }
            left = right;
            right = null;
            currentOp = null;
        }

        public void Clear()
        {
            right = null;
            left = 0;
            DidUpdateValue?.Invoke(this, left.Value, precision);
        }
        public void ClearSimbol()
        {
            if (decimalPoint)
            {
                left = left *(-1);
                if (precision == 0)
                    decimalPoint = false;
            }
            else
            {
                left = left * (-1);
            }
            DidUpdateValue?.Invoke(this, left.Value, precision);
        }
    }
}
