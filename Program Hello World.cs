class CPU
{
    public string Number, Segment;
    public int Core, Year;
    public double BFrequency, TFrequency;
    public bool HyperT;

    public int GetNumberOfThreads()
    {
        if (HyperT == true) return (Core * 2);
        else return (Core);
    }
}
