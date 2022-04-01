namespace CatchException.BlobStoring;

public interface IBlobUrlCalculator
{
    string Calculate(string fileName);
}