namespace Taller01;

public class Time
{ 
	private int _hour;
	private int _minute;
	private int _second;
	private int _millisecond;



	public Time()
	{
		_hour = 0;
		_minute = 0;
		_second = 0;
		_millisecond = 0;
	}

	public Time(int hour)
	{
		Hour = hour;
	}

	public Time(int hour, int minute)
	{
		Hour = hour;
		Minute = minute;
	}

	public Time(int hour, int minute, int second)
	{
		Hour = hour;
		Minute = minute;
		Second = second;
	}
	public Time(int hour, int minute, int second, int millisecond)
	{
		Hour = hour;
		Minute = minute;
		Second = second;
		Millisecond = millisecond;
	}

	public int Hour
	{
		get => _hour;
		set => _hour = ValidateHour(value);
	}
			
	public int Minute
	{
		get => _minute;
		set => _minute = ValidateMinute(value);
	}
			

	public int Second
	{
		get => _second;
		set => _second = ValidateSecond(value);
	}


	public int Millisecond
	{
		get => _millisecond;
		set => _millisecond = ValidateMillisecond(value);
	}

	
	public int ToMilliseconds()
	{
		if (Hour < 0 || Hour > 23) return 0;
		if (Minute < 0 || Minute > 59) return 0;
		if (Second < 0 || Second > 59) return 0;
		if (Millisecond < 0 || Millisecond > 999) return 0;
			return (Hour * 3600000) +
			   (Minute * 60000) +
			   (Second * 1000) +
			   Millisecond;
	}

	public int ToSeconds()
	{
		if (Hour < 0 || Hour > 23) return 0;
		if (Minute < 0 || Minute > 59) return 0;
		if (Second < 0 || Second > 59) return 0;
		if (Millisecond < 0 || Millisecond > 999) return 0;
		return (Hour * 3600) +
			   (Minute * 60) +
			   Second +
			   (Millisecond / 1000);
	}

	public int ToMinutes()
	{
		if (Hour < 0 || Hour > 23) return 0;
		if (Minute < 0 || Minute > 59) return 0;
		if (Second < 0 || Second > 59) return 0;
		if (Millisecond < 0 || Millisecond > 999) return 0;
		return (Hour * 60) + Minute + (Second / 60) + (Millisecond / 60000);
	}

	public Time Add(Time other)
	{
		int ms = this.ToMilliseconds() + other.ToMilliseconds();
		ms %= 86400000;
		int hor = (ms / 3600000);
		int min = (ms / 60000)%60;
		int sec = (ms / 1000) % 60;
		int mill = (ms % 1000);
		return new Time(hor, min, sec, mill);
	}

	public bool IsOtherDay(Time other)
	{
		int totalMilliseconds = this.ToMilliseconds() + other.ToMilliseconds();
		if(totalMilliseconds >= 86400000)
        {
			return true;
		}
		return false;
	}

	public override string ToString()
	{
		if (Hour < 0 || Hour > 23)
			throw new ArgumentException("The hour is not valid.");
		if (Minute < 0 || Minute > 59) throw new ArgumentException("The minute is not valid.");
		if (Second < 0 || Second > 59) throw new ArgumentException("The second is not valid.");
		if (Millisecond < 0 || Millisecond > 999) throw new ArgumentException("The millisecond is not valid.");
		int hour12 = Hour % 12;
		if (hour12 == 0)
			hour12 = 12;

		string ampm = Hour < 12 ? "AM" : "PM";

		return $"{hour12:00}:{Minute:00}:{Second:00}.{Millisecond:000} {ampm}";
	}
	private int ValidateHour(int hour)
	{
		if (hour < 0 || hour > 23)
		{
			throw new ArgumentException($"The hour: {hour}, is not valid.");
		}
		return hour;
	}
	private int ValidateMinute(int minute)
	{
		if (minute < 0 || minute > 59)
		{
			throw new ArgumentException($"The minute: {minute}, is not valid.");
		}
		return minute;
	}
	private int ValidateSecond(int second)
	{
		if (second < 0 || second > 59)
		{
			throw new ArgumentException($"The second: {second}, is not valid.");
		}
		return second;	
		
	}
	private int ValidateMillisecond(int milliseconds)
	{
		if (milliseconds < 0 || milliseconds > 999)
		{
			throw new ArgumentException($"The millisecond: {milliseconds}, is not valid.");
		}
		return milliseconds;	
		
	}








}
