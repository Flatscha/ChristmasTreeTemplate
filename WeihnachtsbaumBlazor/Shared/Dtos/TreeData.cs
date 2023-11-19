namespace WeihnachtsbaumBlazor.Shared.Dtos
{
    public class TreeData
    {
        public decimal BranchWidth { get; set; } = 100;
        public decimal BranchHeight { get; set; } = 20;
        public decimal TotalHeight { get; set; } = 1600;
        public decimal Distance { get; set; } = 0;
        public decimal DiameterTop { get; set; } = 100;
        public decimal DiameterBottom { get; set; } = 800;

        public int SpiralCount { get; set; } = 2;
        public decimal SpiralRotation { get; set; } = 10;
        public decimal SpiralOffset { get; set; } = 90;

        public bool Rotate { get; set; } = false;
    }
}
