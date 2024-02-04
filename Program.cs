using System;
using System.Linq;
using CSharpShellCore;

namespace DateClass;

///<summary>
/// Названия класса 
///</summary>
class DateClass
{
/// <summary>
/// Год
/// </summary>
    int year;
/// <summary>
/// Месяц
/// </summary>
	int month;
/// <summary>
/// День
/// </summary>
	int day;
/// <summary>
/// Свойства полей
/// </summary>
	public int year { get => year; set => year = value }
	public int month { get => month; set => month = value }
	public int day { get => month; set => month = value }
	
	
} 
/// <summary>
/// Констпуктор без параметров
/// </summary>
    public DateTime data()
	{

	}
/// <summary>
/// Конструктор с параметрами
/// </summary>
/// <param name="year"></param>
/// <param name="month"></param>
/// <param name="day"></param>
	public DateTime data(int year, int month, int day)
	{
	    this.year = year
		this.month = month
		this.day = day
	}
	
	public string Info()
	{
	 return $"Год-{Year}\t Месяц-{Month}\t День-{Day}"
	}
}
