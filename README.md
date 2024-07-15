# Simple Calculator - WPF application
Simple calculator made in C# and WPF application. The application provides basic operations such as addition, subtraction, multiplication, and division.

# Screenshot of calculator
<img width="200" alt="Calculator_screenshot" src="https://github.com/user-attachments/assets/ce9fc6f2-45cc-4388-bf7f-df5b7fc86402">

# Documentation
## User Interface
- Window: Defines the main window of the application with a title "MainWindow" and dimensions of 450 (Height) by 800 (Width).
- Grid: The layout control is used to arrange other UI elements in rows and columns.
- RowDefinitions: Defines three rows with proportional heights.
- ColumnDefinitions: Defines five columns with specified widths, most of which are set to zero except the main content column.
- TextBox (tbTal1, tbTal2, tbResultat): Input and output text boxes for the first number, second number, and result respectively.
- Button (btn_Plus, btn_Minus, btn_Gange, btn_Divider): Buttons for performing addition, subtraction, multiplication, and division. Each button is associated with a click event handler.
- Label (lommeregnerText, number1Text, number2Text, resultText): Labels for the calculator title and descriptions for the input/output fields.

## C# Code (Application Logic)
- MainWindow Class: The main class for the application, handling the initialization and events.
- Regnetegn Enum: Defines the arithmetic operations: Plus, Minus, Divider, and Gange.
- regneFunktion Method: Performs the arithmetic operations based on the provided operator.
- Parameters: Takes an enum value representing the operation.
- Returns: The result of the arithmetic operation.
- btn_Plus_Click, btn_Minus_Click, btn_Gange_Click, btn_Divider_Click Methods: Event handlers for the buttons, calling regneFunktion with the corresponding operation and updating the result text box.

# Summary
- The XAML code defines the layout and UI components of the calculator.
- The C# code implements the logic for handling arithmetic operations and user interactions.
- The application uses basic WPF controls and event handling to provide a functional calculator interface.
