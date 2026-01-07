/*
 
Zadanie 2 Adapter

Pracujesz nad aplikacją, która przetwarza różne formaty plików graficznych. Obecnie aplikacja obsługuje formaty JPEG i PNG poprzez interfejs IImage, który zawiera metody:

void Load(string filename)
void Display()
Masz już implementacje tego interfejsu dla formatów JPEG (JpegImage) i PNG (PngImage).

Twoja firma chce teraz dodać obsługę plików GIF. Niestety, dostarczona biblioteka do obsługi plików GIF nie implementuje interfejsu IImage i posiada inne metody w klasie GifHandler:

void OpenFile(string filename)
void RenderImage()
Twoim zadaniem jest zastosowanie wzorca projektowego Adapter, aby umożliwić użycie klasy GifHandler w istniejącym systemie poprzez interfejs IImage.

Zdefiniuj interfejs IImage:

Utwórz interfejs IImage zawierający dwie metody void Load(string filename) oraz void Display().
Zaimplementuj klasy JpegImage i PngImage, które implementują interfejs IImage:

Klasa JpegImage:

Implementuje interfejs IImage.
Metoda Load powinna przyjmować nazwę pliku i wyświetlać komunikat o ładowaniu pliku JPEG.
Metoda Display powinna wyświetlać komunikat o wyświetlaniu obrazu JPEG.
Klasa PngImage:

Implementuje interfejs IImage.
Metoda Load powinna przyjmować nazwę pliku i wyświetlać komunikat o ładowaniu pliku PNG.
Metoda Display powinna wyświetlać komunikat o wyświetlaniu obrazu PNG.
Zaimplementuj klasę GifHandler:

Klasa GifHandler posiada metody:
void OpenFile(string filename); — otwiera plik GIF.
void RenderGif(); — renderuje obraz GIF.
Zwróć uwagę, że metody te nie pasują bezpośrednio do interfejsu IImage.
Utwórz klasę adaptera GifImageAdapter, która pozwoli na użycie GifHandler poprzez interfejs IImage:

Klasa GifImageAdapter:
Implementuje interfejs IImage.
Posiada prywatne pole typu GifHandler, które będzie używane do delegowania wywołań.
Metoda Load:
Przyjmuje nazwę pliku.
Wykorzystuje obiekt typu GifHandler, aby wywołać metodę OpenFile z przekazaną nazwą pliku.
Metoda Display:
Wykorzystuje obiekt typu  GifHandler, aby wywołać metodę RenderGif
Przetestuj swoją implementację.

*/



using Exercises02;

public class Program
{
    private static void Main(string[] args)
    {

        string jpeg = "Dog.jpeg";
        IImage jpegImage = new JpegImage();
        jpegImage.Load(jpeg);
        jpegImage.Display();

        Console.WriteLine();

        string png = "Cats.png";
        IImage pngImage = new PngImage();
        pngImage.Load(png);
        pngImage.Display();

        Console.WriteLine();

        string gifrotatingGlobe = "rotatingGlobe.gif";
        GifHandler gifHandler = new GifHandler();
        IImage gifAnimated = new GifImageAdapter(gifHandler);
        // IImage gifAnimated02 = new GifImageAdapter();

        gifAnimated.Load(gifrotatingGlobe);
        gifAnimated.Display();


    }
}