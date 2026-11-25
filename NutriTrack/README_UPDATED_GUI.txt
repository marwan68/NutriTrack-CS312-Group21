NutriTrack - Updated GUI Source Project
======================================

This ZIP contains the COMPLETE original Visual Studio Windows Forms solution,
with the requested visual changes applied to the actual C# project.

WHAT CHANGED
- Dashboard: replaced the system ProgressBar with RoundedProgressBar.cs,
  a smooth green rounded calorie goal indicator that is NOT an animated or
  download-style progress indicator.
- Log a Meal: added the matching daily calorie goal display to the header.
- Log a Meal: wrapped the existing editable text boxes, meal type dropdown,
  date/time pickers, numeric inputs and notes area in soft rounded frames.
  Their original input functionality remains available.
- Log a Meal: changed the default meal image to the approved realistic meal
  bowl photo (Resources/meal_photo.jpg).
- All images are stored once in Properties/Resources.resx (files in the
  Resources folder) and shared by every form, to keep the project small.
- The Choose Photo and Clear buttons still work, including restoring the
  default meal photo when Clear is clicked.
- Original forms, solution, navigation, resources and project structure kept.

OPEN / RUN
1. Extract this ZIP to a normal folder on your Windows PC.
2. Open NutriTrack.sln in Visual Studio 2022 with the .NET desktop development
   workload and the .NET 8 SDK installed.
3. Right-click the NutriTrack project > Set as Startup Project (if necessary).
4. Press F5 (Start Debugging) or Ctrl+F5 (Start Without Debugging).
5. Navigate to Dashboard and Log Meal to see the revised styling.

IMPORTANT
- This is the original GUI-stage sample: the 72% and 550 kcal values are
  examples, and Add Meal still displays its original confirmation instead of
  saving a meal to a database.
- A Windows/.NET SDK environment is needed to compile and run this app.
