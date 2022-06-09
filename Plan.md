Console Menu (Have it in a separate class)
Show method to display to user
List of options: list/array to loop through
Console.ReadLine,response from customer.

1. If choose option oflist of all public holidays for a given country and year. What country and year would you like your holiday ? Console.ReadLine for 2 values. Create variables for these values.
   Google how to make an API call in C# (get the docs)
   API call
   Method that displays name and date of holiday
   Display name, date of holiday in response, lsit
   “Would you like to return to the main menu ?“. If yes, then what option would you like to choose ?

2. What country would you like to check ?
   API call from the country to the end point
   Check the status code is of the response (Google this)
   if statement , if status code = 200 return X if X then return is not a public holiday
   Q: “What option would you like to choose ?”

3. Public Holidays for the year & country
   What day would you like to check ?
   What country would you like to check ?
   string {trim}: Google how to get the e.g. 4 last numbers of the string for the API endpoint

Q: What country would you like to check this date ?
API call for Number 1
Array of objects: filter ? the correct date, find if the date property matches the user date. How to find a date in an array ?

User option “Quit” or “select another option”
Display e.g. This is a public holiday, it is XXAustralia Day

4. Error handling
   e.g. wrong years, numbers, country code e.g. zz
   Can we search future years for the endpoint ?
   Work out how API end point works for the years.
   Error e.g. 404 “doesn’t exist”
   Call to end point, get list of country codes(availableCountries), does it exist ?,
   if it doesn’t the country code doesn’t exist.
