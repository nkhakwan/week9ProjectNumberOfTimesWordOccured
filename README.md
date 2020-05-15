# _WordCounter_

#### _Epicodus Week 9 Code Review Project_

#### By _**KhanSahab**_

## Description

_This Project counts number of times a word occurs in a particular sentence. Both the word and the sentence is given at the prompt and the project counts number of time that particular word is repeated in that given sentence_

## Setup/Installation Requirements

* Clone this repository.
* Go to WordCounter directory and do "dotnet build" & "dotnet run"
* Go to WordCounter.Tests and do "dotnet test"


## Known Bugs

None so far

## Support and contact details

_Have a bug or an issue with this application? email post_khan@Yahoo.com_

## Technologies Used

* uses auto-implemented properties.
* Classes with namespace.
* Methods that count the number of times a particular word is repeated in a sentence
* Refactoring to make the code shorter and more effective with each iteration.
* Test direcotory and MS tests to test the Back end file

## Plain English Coding Specs. Testing Specs are after this section. 
* This Project would have a Program file in addition to BackEnd and Testing files
* User would be prompted to enter the sentence and a Word
* Instantiation of the class RepeatCounter won't be passed any arguments as it is intended that user should be able to repeatedly input his sentence and word with one instantiation
* For Now Only two fields "GrandTotal" and "WordIsThere" would be present in RepeatCounter class.
* First method would be passed with two strings as arguments and it would see whether the word is contained in the sentence string thru contain key word with " word " technique.
* Second Method would look into a dictionary or array and see how many times it occurs. It'll choose each word or the array and make sure the length of the word in the array is same and counts how many times it occurs

## Testing Specs
###  Input | OutPut | Description
##### string Sentence and string Word  passed to DoesItContain method| "WordIsThere" updated with Boolean | A sentence and a word would be passed to the function and seen if the word is contained in the sentence if yes the function would make a field go "true"
##### String Sentence and String Word passed to NumberOfTimes Method | GrandTotal would update | Method NumberOfTimes would update GrandTotal with the number




### License

This software is licensed under the Epicodus inc license.

Copyright (c) 2020 **_Khan Sahab_**