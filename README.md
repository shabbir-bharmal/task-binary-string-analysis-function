# BinaryString 

## Overview

The BinaryString is a simple ASP.NET MVC application that allows users to input binary strings (composed of `0`s and `1`s) and checks whether they meet specific criteria:

1. The binary string must have an equal number of `0`s and `1`s.
2. For every prefix of the binary string, the number of `1`s must not be less than the number of `0`s.

This application utilizes jQuery for AJAX requests to provide a seamless user experience without needing to refresh the page.

## Features

- Input validation for binary strings (only accepts `0`s and `1`s).
- Real-time feedback on whether the entered binary string is "good" or "not good."
- Clear error messages for invalid inputs.

## Requirements

- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) (version 4.7 or later)
- [Visual Studio](https://visualstudio.microsoft.com/) (for development)
- Basic knowledge of C# and MVC architecture

## Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/shabbir-bharmal/task-binary-string-analysis-function.git
   
   cd task-binary-string-analysis-function
