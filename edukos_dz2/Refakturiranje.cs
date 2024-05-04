using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edukos_dz2
{
	//zadatak 2 
	class Avg
	{
		List<double> averages(List<double[]> arraysList)
		{
			List<double> avgs = new List<double>(); //resulting list
			double s;
			foreach (double[] a in arraysList)
			{
				 s = 0;
				//compact code formating
				AddToAvgs(avgs, a, s);
			}
			return avgs;
		}
		static void AddToAvgs(List<double> avgs, double[] a,double s)
		{
			for (int i = 0; i < a.Length; i++) s += a[i];
			avgs.Add(s / a.Length);
		}
	}

	//zadatak 4
	class DrugiZadatak
	{
		public static List<char> uniqueChars(string text)
		{
			List<char> chars = new List<char>();
			for (int i = 0; i < text.Length; i++)
			{
				int occurrenceCount = 0;
				for (int j = 0; j < text.Length; j++)
				{
					if (text[i] == text[j])
					{
						occurrenceCount++;
					}
				}
				if (occurrenceCount == 1)
				{
					chars.Add(text[i]);
				}
			}
			return chars;
		}
		static void IsUnique(string text)???
	}

	//zadatak 5
	class DrugiZadatak
	{
		public List<string> palindromes(List<string> strings)
		{
			List<string> res = new List<string>();
			if (strings == null) return res;
			foreach (string str in strings)
			{
				string temp1 = str.Replace(" ", "").ToLower();
				string temp2 = new string(temp1.Reverse().ToArray());
				//Palindrome
				if (temp1.Equals(temp2))
				{
					res.Add(str);
				}
			}
			return res;
		}
	}
	static void IsPalindrome(List<string>res)
	{
		foreach (string str in strings)
		{
			string temp1 = str.Replace(" ", "").ToLower();
			string temp2 = new string(temp1.Reverse().ToArray());
			//Palindrome
			if (temp1.Equals(temp2))
			{
				res.Add(str);
			}
		}
	}
}
