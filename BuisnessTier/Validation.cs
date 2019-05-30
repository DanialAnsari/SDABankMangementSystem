using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuisnessTier
{
    public class Validation
    {
        public Validation()
        { }



        ////-----------for Email Validation-----------
        //public static bool IsValidEmail(string email)
        //{
        //    if (string.IsNullOrWhiteSpace(email))
        //        return false;

        //    try
        //    {
        //        // Normalize the domain
        //        email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
        //                              RegexOptions.None, TimeSpan.FromMilliseconds(200));

        //        // Examines the domain part of the email and normalizes it.
        //        string DomainMapper(Match match)
        //        {
        //            // Use IdnMapping class to convert Unicode domain names.
        //            var idn = new IdnMapping();

        //            // Pull out and process domain name (throws ArgumentException on invalid)
        //            var domainName = idn.GetAscii(match.Groups[2].Value);

        //            return match.Groups[1].Value + domainName;
        //        }
        //    }
        //    catch (RegexMatchTimeoutException e)
        //    {
        //        return false;
        //    }
        //    catch (ArgumentException e)
        //    {
        //        return false;
        //    }

        //    try
        //    {
        //        return Regex.IsMatch(email,
        //            @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
        //            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
        //            RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        //    }
        //    catch (RegexMatchTimeoutException)
        //    {
        //        return false;
        //    }
        //}

        ////-------Name-------
        public static bool IsValidName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return false;

            try
            {
                if (!Regex.Match(name, "^[A-Z][a-zA-Z]*$").Success)
                {


                    return true;
                }

            }
            catch (RegexMatchTimeoutException)
            {
                MessageBox.Show("Invalid first name", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
                name.Focus();
                return false;
            }



        }


        ////-- phone-----

        //private static string[] m_Patterns = new string[] { @"^[0-9]{10}$", @"^\+[0-9]{2}\s+[0-9]{2}[0-9]{8}$", @"^[0-9]{3}-[0-9]{4}-[0-9]{4}$", };// for 10 numbers validation

        //public static object MessageBox { get; private set; }

        //private static string MakeCombinedPattern()
        //{
        //    return string.Join("|", m_Patterns.Select(phone => "(" + phone + ")"));
        //}


        //public static bool IsValidPhone(string phone)
        //{
        //    if (string.IsNullOrWhiteSpace(phone))
        //        return false;

        //    try
        //    {
        //        if (!Regex.Match(phone.Text, @"^[1-9]\d{2}-[1-9]\d{2}-\d{4}$", MakeCombinedPattern()).Success)
        //        {

        //            return true;
        //        }

        //    }
        //    catch (RegexMatchTimeoutException)
        //    {
        //        MessageBox.Show("Invalid phone number", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
        //        phone.Focus();
        //        return false;
        //    }



        //}


        /////// address------
        //public static bool IsValidAdress(string address)
        //{
        //    if (string.IsNullOrWhiteSpace(address))
        //        return false;

        //    try
        //    {
        //        if (!Regex.Match(address.Text, @"^[0-9]+\s+([a-zA-Z]+|[a-zA-Z]+\s[a-zA-Z]+)$").Success)

        //            return true;


        //    }
        //    catch (RegexMatchTimeoutException)
        //    {
        //        MessageBox.Show("Invalid address", "Message", MessageBoxButton.OK, MessageBoxImage.Error);
        //        address.Focus();

        //        return false;
        //    }



        //}
    }

    }
