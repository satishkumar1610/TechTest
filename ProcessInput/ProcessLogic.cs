#region Using namespaces

using System;

#endregion

#region Process input namespace

/// <summary>
/// Process input namespace
/// </summary>
namespace ProcessInput
{
    #region Process Logic class

    /// <summary>
    /// Process number to word
    /// </summary>
    public class ProcessLogic
    {
        #region Public methods

        /// <summary>
        /// Returns number into word
        /// </summary>
        /// <param name="number">Input number with two digits</param>
        /// <returns>Returns outout in word format</returns>
        public string NumberToWord(decimal number)
        {
            var decimalDefault = default(decimal);
            if(number == decimalDefault)
            {
                return "Zero";
            }

            return numberToWord(number.ToString());
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Static methods contains ones numbers
        /// </summary>
        /// <param name="Number">Input number</param>
        /// <returns>Returns number to word</returns>
        private static String numberInWordOnes(String Number)
        {
            int _Number = Convert.ToInt32(Number);
            String name = "";
            switch (_Number)
            {
                case 1:
                    name = "One";
                    break;
                case 2:
                    name = "Two";
                    break;
                case 3:
                    name = "Three";
                    break;
                case 4:
                    name = "Four";
                    break;
                case 5:
                    name = "Five";
                    break;
                case 6:
                    name = "Six";
                    break;
                case 7:
                    name = "Seven";
                    break;
                case 8:
                    name = "Eight";
                    break;
                case 9:
                    name = "Nine";
                    break;
            }

            return name;
        }

        /// <summary>
        /// Static method contains tens numbers
        /// </summary>
        /// <param name="Number">Input number</param>
        /// <returns>Returns number to word</returns>
        private static String numberInWordTens(String Number)
        {
            int _Number = Convert.ToInt32(Number);
            String name = null;
            switch (_Number)
            {
                case 10:
                    name = "Ten";
                    break;
                case 11:
                    name = "Eleven";
                    break;
                case 12:
                    name = "Twelve";
                    break;
                case 13:
                    name = "Thirteen";
                    break;
                case 14:
                    name = "Fourteen";
                    break;
                case 15:
                    name = "Fifteen";
                    break;
                case 16:
                    name = "Sixteen";
                    break;
                case 17:
                    name = "Seventeen";
                    break;
                case 18:
                    name = "Eighteen";
                    break;
                case 19:
                    name = "Nineteen";
                    break;
                case 20:
                    name = "Twenty";
                    break;
                case 30:
                    name = "Thirty";
                    break;
                case 40:
                    name = "Fourty";
                    break;
                case 50:
                    name = "Fifty";
                    break;
                case 60:
                    name = "Sixty";
                    break;
                case 70:
                    name = "Seventy";
                    break;
                case 80:
                    name = "Eighty";
                    break;
                case 90:
                    name = "Ninety";
                    break;
                default:
                    if (_Number > 0)
                    {
                        name = numberInWordTens(Number.Substring(0, 1) + "0") + "-" + numberInWordOnes(Number.Substring(1));
                    }
                    break;
            }
            return name;
        }

        /// <summary>
        /// Static method convert whole number into word
        /// </summary>
        /// <param name="Number">Input number</param>
        /// <returns>Returns number to word</returns>
        private static String numberInWord(String Number)
        {
            string word = "";
            try
            {
                bool beginsZero = false;//tests for 0XX    
                bool isDone = false;//test if already translated    
                double dblAmt = (Convert.ToDouble(Number));
                //if ((dblAmt > 0) && number.StartsWith("0"))    
                if (dblAmt > 0)
                {//test for zero or digit zero in a nuemric    
                    beginsZero = Number.StartsWith("0");

                    int numDigits = Number.Length;
                    int pos = 0;//store digit grouping    
                    String place = "";//digit grouping name:hundres,thousand,etc...    
                    switch (numDigits)
                    {
                        case 1://ones' range    

                            word = numberInWordOnes(Number);
                            isDone = true;
                            break;
                        case 2://tens' range    
                            word = numberInWordTens(Number);
                            isDone = true;
                            break;
                        case 3://hundreds' range    
                            pos = (numDigits % 3) + 1;
                            place = " Hundred And ";
                            break;
                        case 4://thousands' range    
                        case 5:
                        case 6:
                            pos = (numDigits % 4) + 1;
                            place = " Thousand And ";
                            break;
                        case 7://millions' range    
                        case 8:
                        case 9:
                            pos = (numDigits % 7) + 1;
                            place = " Million And ";
                            break;
                        case 10://Billions's range    
                        case 11:
                        case 12:

                            pos = (numDigits % 10) + 1;
                            place = " Billoin And ";
                            break;
                        //add extra case options for anything above Billion...    
                        default:
                            isDone = true;
                            break;
                    }
                    if (!isDone)
                    {//if transalation is not done, continue...(Recursion comes in now!!)    
                        if (Number.Substring(0, pos) != "0" && Number.Substring(pos) != "0")
                        {
                            try
                            {
                                word = numberInWord(Number.Substring(0, pos)) + place + numberInWord(Number.Substring(pos));
                            }
                            catch { }
                        }
                        else
                        {
                            word = numberInWord(Number.Substring(0, pos)) + numberInWord(Number.Substring(pos));
                        }

                        //check for trailing zeros    
                        //if (beginsZero) word = " and " + word.Trim();    
                    }
                    //ignore digit grouping names    
                    if (word.Trim().Equals(place.Trim())) word = "";
                }
            }
            catch { }
            return word.Trim();
        }

        /// <summary>
        /// Static method convert decimal numbers to word
        /// </summary>
        /// <param name="number">Input number</param>
        /// <returns>Returns decimal number to word</returns>
        private static String numberInWordDecimal(String number)
        {
            String cd = "", digit = "", engOne = "";
            for (int i = 0; i < number.Length; i++)
            {
                digit = number[i].ToString();
                if (digit.Equals("0"))
                {
                    engOne = "Zero";
                }
                else if(i.Equals(0))
                {
                    digit = digit + "0";
                    engOne = numberInWordTens(digit);
                }
                else
                {
                    engOne = numberInWordOnes(digit);
                }
                cd += engOne + "-";
            }

            cd = cd.Remove(cd.Length - 1);
            return cd;
        }

        /// <summary>
        /// Static method intial point to process inout number
        /// </summary>
        /// <param name="numb">Input number</param>
        /// <returns>Rerturns number to word for example 123.45 to word</returns>
        private static String numberToWord(String numb)
        {
            String val = "", wholeNo = numb, points = "", andStr = "", pointStr = "";
            String endStr = ""; String currency = "Dollars";
            try
            {
                int decimalPlace = numb.IndexOf(".");
                if (decimalPlace > 0)
                {
                    wholeNo = numb.Substring(0, decimalPlace);
                    points = numb.Substring(decimalPlace + 1);
                    if (Convert.ToInt32(points) > 0)
                    {
                        andStr = "And";// just to separate whole numbers from points/cents    
                        endStr = "Cents";
                        pointStr = numberInWordDecimal(points);
                    }
                }

                //val = "{ numword:" + String.Format("{0} {1} {2} {3} {4}", numberInWord(wholeNo).Trim(), currency, andStr, pointStr, endStr) + "}";
                val = String.Format("{0} {1} {2} {3} {4}", numberInWord(wholeNo).Trim(), currency, andStr, pointStr, endStr);
            }
            catch { }
            return val;
        }

        #endregion
    }

    #endregion
}

#endregion
