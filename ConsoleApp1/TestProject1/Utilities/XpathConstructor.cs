using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Utilities
{
    public static class XpathConstructor
    {
        public static string constructXpath(string tag, string attribute, string value)
        {
            return $"//{tag}[@{attribute}=\"{value}\"]";
        }
        public static string constructXpath(string attribute, string value)
        {
            return $"//*[@{attribute}=\"{value}\"]";
        }
    }


    /// <summary>
    /// 
    ///  Add all ID with in this class
    /// </summary>
    public static class ID  
    {
        public static string UserId => "UserId";
    }

    /// <summary>
    /// Add all HTML Tag Name with in this class
    /// </summary>
    public static class TagName  
    {
        public static string Button => "button";
        public static string Input => "input";
        public static string Span => "span";
        public static string H6 => "h6";
    }

    /// <summary>
    /// Add all Name with in this class
    /// </summary>
    public static class Name  
    {
        public static string Username => "username";
        public static string Password => "password";
    }

    /// <summary>
    /// Add all classname with in this class
    /// </summary>
    public static class ClassName  
    {
        public static string Username => "oxd-input"; //.oxd-topbar-header-title h6
        public static string topbar_header_title => "oxd-topbar-header-title";
    }
}
