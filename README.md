# CSharp-CurrencyExchangeCalc
Code Louisville C# Final Project. Currency exchange calculator
Based on the data from https://exchangeratesapi.io/

Basic menu will validate selection of Origin and Destination, responds accordingly.<br />
Fully functional search of available country codes in dictionary. A minimum of 3 characters for a search to run.<br />
Conversion based on EUR as base so calculation is a little more complicated but verified from external sources.<br />

Defaults (Origin and Destination) are saved from option 5 on last use and sent to the Default.json file. On startup<br />
the defaults are loaded back into Main().

Download project and compile to test it. Ensure the Data folder has the Defaults and Exchangerates JSON files.


