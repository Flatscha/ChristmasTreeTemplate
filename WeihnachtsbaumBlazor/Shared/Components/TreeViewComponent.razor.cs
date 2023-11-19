using global::Microsoft.AspNetCore.Components;
using WeihnachtsbaumBlazor.Shared.Dtos;

namespace WeihnachtsbaumBlazor.Shared.Components
{
    public partial class TreeViewComponent
    {
        [CascadingParameter] public TreeData Data { get; set; }

        private List<Branch> _branches = new();
        private Branch _clickedBranch = null;

        protected override async Task OnParametersSetAsync()
        {
            this._branches.Clear();

            var stepHeight = this.Data.BranchHeight + this.Data.Distance;

            var exactCount = this.Data.TotalHeight / stepHeight;
            var totalCount = (int)Math.Round(exactCount, 0, MidpointRounding.AwayFromZero);

            var diameterFactor = (this.Data.DiameterTop - this.Data.DiameterBottom) / (totalCount - 1);

            for (var i = totalCount; i >= 1; i--)
            {
                var heightStart = (i - 1) * stepHeight;
                var dto = new Branch
                {
                    Number = i,
                    HeightStart = heightStart,
                    HeightEnd = heightStart + this.Data.BranchHeight,
                    Diameter = this.Data.DiameterBottom + ((i - 1) * diameterFactor),
                    RotatedDegrees = (int)((i - 1) * (this.Data.SpiralOffset + (this.Data.SpiralRotation / this.Data.SpiralCount))) % 360,
                };

                this._branches.Add(dto);
            }

            await base.OnParametersSetAsync();
        }
    }
}