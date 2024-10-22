Feature: AvivaMainPageCheck

A short summary of the feature is to go to Aviva web page and validate it.

@TestAvivaWebPage
Scenario: Check Aviva web page
	Given Open web browser
	When Navigated to the Aviva home 
    Then The title should be "Aviva corporate website - Aviva plc" 
