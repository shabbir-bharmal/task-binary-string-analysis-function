# Binary String Validator

## Overview

The Binary String Validator is an ASP.NET MVC web application that allows users to input a binary string and determine if the string is "good" based on two key conditions:
1. The binary string must contain an equal number of `0`s and `1`s.
2. For every prefix of the binary string, the number of `1`s should not be less than the number of `0`s.

The application is interactive, providing real-time feedback about whether the binary string satisfies these criteria. AJAX is used to handle form submissions and update the result dynamically without reloading the page.

## Table of Contents
1. Installation
2. Usage
3. Features
4. Testing the Application
5. Code Structure

## Installation

Follow the steps below to set up the application on your local machine:

### Prerequisites
- .NET Framework (Version 4.7 or higher)
- Visual Studio (Any edition that supports ASP.NET MVC)
- NuGet Package Manager (Installed with Visual Studio)

### Steps

1. Clone the Repository:
   ```bash
   git clone https://github.com/shabbir-bharmal/task-binary-string-analysis-function.git
   cd task-binary-string-analysis-function

2. Open the Solution:
   Open the `.sln` file in Visual Studio to load the project.

3. Restore NuGet Packages:
   In Visual Studio, right-click on the solution in the Solution Explorer and select "Restore NuGet Packages".

4. Run the Application:
   Press `F5` or click on the Start button to run the application. It will open in your default web browser.

## Usage

Once the application is running, you can use the form on the homepage to input binary strings and evaluate them.

1. Input a binary string in the provided text box (e.g., "1100").
2. Click the "Check" button to submit the string.
3. The application will determine whether the string is "good" or "not good" based on the rules outlined below:
   - Equal number of `0`s and `1`s.
   - For each prefix, the number of `1`s must not be less than the number of `0`s.

The result will be shown below the input field along with any relevant error messages.


## Example Inputs

Here are some example binary strings you can test:

 Binary String  Result                                                                 |

 1100         Good - Equal `0`s and `1`s, and no prefix has more `0`s than `1`s. 
 1001         Not Good - The prefix "100" has more `0`s than `1`s.               
 111000       Not Good - After "111", the number of `0`s exceeds `1`s.           
 101          Not Good - Unequal number of `0`s and `1`s.                        
 110          Not Good - Unequal number of `0`s and `1`s.                        
 111222       Error - Invalid characters detected (must contain only `0` and `1`).
 (empty)      Error - Input string cannot be null or empty.                      


## Features

- Binary String Validation: Validates that the input binary string meets the criteria described.
- Real-time Feedback: Results are displayed instantly after submitting the form using AJAX.
- Error Handling: Provides clear feedback for invalid inputs, such as empty strings or non-binary characters.
- Form Validation: Prevents submission if the input is not valid.


## Testing the Application

### Manual Testing

To manually test the application:

1. Launch the application in your browser.
2. Enter various binary strings in the input field and press Check.
3. Observe the results. Try edge cases like:
   - Strings with more `0`s than `1`s.
   - Strings with non-binary characters (like `2` or `A`).
   - Empty input strings.

### Example Test Cases

Test Case Output:
"1100": Valid, as there are equal numbers of 0s and 1s, and at no prefix do 0s exceed 1s.
"1001": Invalid, because the prefix "100" has more 0s than 1s.
"101": Invalid, because the numbers of 0s and 1s are not equal.
"110": Invalid, because the numbers of 0s and 1s are not equal.
"111000": Invalid, because at the prefix "111000", the number of 0s exceeds the number of 1s after the first three characters.

## Code Structure

### Models

- BinaryStringModel.cs:
   - Contains the `BinaryString` property for input.
   - Implements the method `CheckIfGood()` to evaluate whether the string is "good" based on the validation criteria.
   
### Views

- Index.cshtml:
   - Contains the input form for binary strings.
   - Displays the result of the validation and handles the form submission using AJAX.

### Controllers

- BinaryController.cs:
   - Receives the form submission.
   - Calls the model's validation logic and returns a JSON result to the view for displaying the outcome.

### Scripts

- AJAX (in the view):
   - Manages the form submission and updates the result dynamically without refreshing the page.