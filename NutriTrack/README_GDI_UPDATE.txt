NutriTrack | CS312 Windows Forms and GDI+ update
Open NutriTrack.sln in Visual Studio 2022 with .NET 8 desktop development.
Build > Rebuild Solution, then F5. The project uses no external NuGet chart libraries.

Changes:
- DynamicChart.cs: custom Windows Forms Control using OnPaint, DrawLine, DrawLines,
  DrawEllipse, DrawArc, FillPolygon, FillRectangle, DrawString and anti-aliasing.
- TrackingData.cs: shared in-memory meal, weight and goal data for this GUI stage.
- Dashboard: dynamic calorie goal, meals, weight line and summaries.
- Log Meal: Add Meal stores data and refreshes the goal bar.
- Weight: Add Weight stores one record per date and redraws charts and BMI.
- Analytics: calorie donut, weight chart and macro bars are computed from records.
- Reports: calories chart and statistics respond to 7/30/90-day selection.
- Profile: saving goal/height updates the calculations; Manage Meals lists shared records,
  supports search/filter and deletes shared records.

Demo: initial sample records are 1450 kcal today, goal 2000 kcal, and five weight
records. Add a 300 kcal dinner today: 1750 kcal, 87% (integer truncation), 250 kcal remaining.
Add a new weight today: Dashboard and Analytics reflect it. Choose report periods.
Report averages and goal counts use logged days only; missing days are not treated as zero.
Data is in memory only and resets when the application exits. Demo values for water remain
unchanged; meal editing, report export, authentication/database are not part of this update.
The original chart PNG resources remain for compatibility but are no longer assigned to chart controls.
Build and runtime verification must be performed on Windows: this environment has no .NET SDK/WinForms runtime.

Macro update: replaced native progress bars with non-animated GDI+ RoundedProgressBar controls; values and labels use the same calculated percentage. Independently rounded percentages may total 99 or 101.

Unified bar update: all five progress controls and three macro chart bars share a flat #377753 fill, #E0ECDD track, 16px height and the same GDI+ pill drawing routine. No Windows progress animation.

Macro goal update: each macro percentage is calculated independently against 120 g protein, 250 g carbs, or 70 g fat. Both macro sections share an expanding percentage scale (minimum 100%, rounded up to the next 100% as required) and show a 100% goal marker when the scale exceeds 100%. Other progress indicators are unchanged.
