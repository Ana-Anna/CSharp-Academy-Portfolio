# 📋 Habit Logger

A console app that helps the user to track and log habits that can be measured.

Inspired by the [C# Academy Habit Logger Project]([https://www.thecsharpacademy.com/project/11/calculator](https://www.thecsharpacademy.com/project/12/habit-logger)).

# 🧠 Key concepts

- Clean, modular architecture built with composition principles and single-responsibility design

- Separation of concerns:

-App/ – user interface flow and command handling

-Services/ – business logic for habits, entries, and reports

-Data/ – data access layer using ADO.NET

-Helpers/ – input formatting and validation logic

- SQLite database with secure parameterized queries via ADO.NET (no Entity Framework)

- Auto-seeded database: generates initial habit data only if the database is empty

- Support for habit editing, deleting, viewing reports, and logging multiple entries


# 🖼 Screenshots

## Main Menu
![Main Menu](https://github.com/Ana-Anna/CSharp-Academy-Portfolio/blob/main/03_HabitLogger/Assets/main_menu%20.png))


## Habit Report
![Habit Report](https://github.com/Ana-Anna/CSharp-Academy-Portfolio/blob/main/03_HabitLogger/Assets/habit_report.png)

## Logging an entry
![Logging an entry](https://github.com/Ana-Anna/CSharp-Academy-Portfolio/blob/main/03_HabitLogger/Assets/logging_entry.png)

# 🧭 Architecture Overview

This diagram shows how the program is structured:

![UML Diagram](https://github.com/Ana-Anna/CSharp-Academy-Portfolio/blob/main/03_HabitLogger/Assets/habbitLogger-UML.png)



# ▶️ How to Run

To run this project, you’ll need the [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) installed locally.

# Prerequisites
- .NET SDL 8.0 or later
- (Optional) Visual Studio 2022+ for IDE support

  Run the Project
  ```bash
  # Clone the full portfolio repo
  git clone https://github.com/Ana-Anna/CSharp-Academy-Portfolio.git

  # Navigate to the project folder
  cd CSharp-Academy-Portfolio/03_HabitLogger

  # Restore dependencies
  dotnet restore

  # Build the project
  dotnet build

  # Run the game
  dotnet run

