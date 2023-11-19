namespace WeihnachtsbaumBlazor.Shared.Dtos
{
    public class Branch
    {
        public int Number { get; set; }
        public decimal HeightStart { get; set; }
        public decimal HeightEnd { get; set; }
        public decimal Height => HeightEnd - HeightStart;
        public decimal Diameter { get; set; }
        public int RotatedDegrees { get; set; }

        public override string ToString()
            => $"Brett {Number}, Höhe {HeightStart}-{HeightEnd}mm, Durchmesser {Diameter:N2}mm, Drehung {RotatedDegrees}deg";
    }
}
