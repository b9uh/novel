namespace Pluralize;

public static class PluralizeTask
{
	public static string PluralizeRubles(int count)
	{
		// последняя цифра числа
		int lastFigure = count % 10;
		// предпоследняя цифра числа
		int penultimateFigure = count % 100 / 10;

		if ((lastFigure == 2 || lastFigure == 3 || lastFigure == 4) && penultimateFigure != 1)
			return "рубля";
		else if (lastFigure == 1 && penultimateFigure != 1)
			return "рубль";
		else return "рублей";
	}
}