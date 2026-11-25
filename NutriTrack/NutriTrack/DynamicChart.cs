using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
namespace NutriTrack
{
    // A real GDI+ chart, drawn on every Paint event; no chart bitmap required.
    public sealed class DynamicChart : Control
    {
        private string mode = "weight";
        private int days = 30;
        private static readonly Color Green = RoundedProgressBar.StandardFill;
        public DynamicChart() { DoubleBuffered = true; ResizeRedraw = true; BackColor = Color.White; }
        public void Configure(string chartMode, int period = 30) { mode = chartMode; days = period; Invalidate(); }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics; g.SmoothingMode = SmoothingMode.AntiAlias;
            if (Width < 100 || Height < 80) return;
            using var font = new Font("Segoe UI", 9);
            using var text = new SolidBrush(Color.FromArgb(85,100,88));
            using var green = new SolidBrush(Green);
            using var grid = new Pen(Color.FromArgb(224,232,225));
            using var line = new Pen(Green, 3);
            if (mode == "donut")
            {
                float d = Math.Min(Width, Height) - 30;
                var r = new RectangleF((Width-d)/2,(Height-d)/2,d,d);
                using var track = new Pen(RoundedProgressBar.StandardTrack, 22);
                using var fill = new Pen(Green,22);
                g.DrawEllipse(track,r); float angle = Math.Min(360, 360f * (float)TrackingData.Calories / TrackingData.CalorieGoal);
                if(angle > 0) g.DrawArc(fill,r,-90,angle);
                using var big = new Font("Segoe UI",20,FontStyle.Bold);
                using var center = new StringFormat { Alignment=StringAlignment.Center, LineAlignment=StringAlignment.Center };
                g.DrawString($"{TrackingData.Percent}%",big,green,r,center); return;
            }
            if (mode == "macros")
            {
                string[] names = {"Protein","Carbs","Fat"}; decimal[] vals = {TrackingData.Protein,TrackingData.Carbs,TrackingData.Fat}; int[] goals = {120,250,70};
                int scale = TrackingData.MacroScale;
                for(int i=0;i<3;i++) { float y=18+i*(Height-20)/3f; float w=Math.Max(1,Width-155); g.DrawString(names[i],font,text,5,y); RoundedProgressBar.DrawBar(g,new RectangleF(80,y,w,16),(float)TrackingData.MacroPercent(vals[i], goals[i])/scale,RoundedProgressBar.StandardTrack,Green,100f/scale); g.DrawString($"{vals[i]:0.#}/{goals[i]} g",font,text,85+w,y); } return;
            }
            var data = mode == "weight" ? TrackingData.WeightPeriod(days).Select(w => (Date:w.Key,Value:(double)w.Value)).ToArray() : TrackingData.Meals.Where(m=>m.Date.Date>=DateTime.Today.AddDays(1-days)&&m.Date.Date<=DateTime.Today).GroupBy(m=>m.Date.Date).OrderBy(x=>x.Key).Select(x=>(Date:x.Key,Value:(double)x.Sum(m=>m.Calories))).ToArray();
            if(data.Length==0) { g.DrawString("No records in this period",font,text,15,20); return; }
            float left=52, right=Width-20, top=17, bottom=Height-35;
            double min=mode=="weight"?Math.Floor((data.Min(x=>x.Value)-0.2)*2)/2:0;
            double max=mode=="weight"?Math.Ceiling((data.Max(x=>x.Value)+0.2)*2)/2:Math.Max(TrackingData.CalorieGoal,Math.Ceiling(data.Max(x=>x.Value)/500)*500);
            if(max<=min) max=min+1;
            for(int i=0;i<=4;i++){float y=bottom-(bottom-top)*i/4; g.DrawLine(grid,left,y,right,y); g.DrawString((min+(max-min)*i/4).ToString(mode=="weight"?"0.0":"0"),font,text,2,y-7);}
            var start=DateTime.Today.AddDays(1-days); var points=data.Select(x=>new PointF(left+(right-left)*(float)(x.Date-start).TotalDays/Math.Max(1,days-1),bottom-(bottom-top)*(float)((x.Value-min)/(max-min)))).ToArray();
            if(points.Length>1){using var area=new SolidBrush(Color.FromArgb(22,Green)); g.FillPolygon(area,new[]{new PointF(points[0].X,bottom)}.Concat(points).Append(new PointF(points[^1].X,bottom)).ToArray()); g.DrawLines(line,points);}
            foreach(var p in points){g.FillEllipse(green,p.X-4,p.Y-4,8,8);g.DrawEllipse(Pens.White,p.X-4,p.Y-4,8,8);}
            for(int i=0;i<5;i++){var date=start.AddDays((days-1)*i/4);float x=left+(right-left)*i/4; using var fmt=new StringFormat{Alignment=StringAlignment.Center}; g.DrawString(date.ToString("MMM dd"),font,text,x,bottom+7,fmt);}
        }
    }
}
