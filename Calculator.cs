using System;

namespace Experimental_Calculator
{
    internal class Calculator
    {
        private double _data;

        public Calculator setData(double data)
        {
            this._data = data;

            return this;
        }

        public double getData()
        {
            return _data;
        }

        public Calculator Add(double value)
        {
            this._data += value;

            return this;
        }

        public Calculator Subtract(double value)
        {
            this._data -= value;

            return this;
        }

        public Calculator Multiply(double value)
        {
            this._data *= value;

            return this;
        }

        public Calculator Divide(double value)
        {
            this._data /= value;

            return this;
        }

        public Calculator Power(int value)
        {
            this._data = Math.Pow(this._data, value);

            return this;
        }
    }
}
