Feature: PageObjectsModel

A short summary of the feature is to go to Aviva web page and validate it.

@TestAvivaWebPage
Scenario: PageObjectsModel
	Given Open web browser
	When Accept all cookies 
    Then The title should be "Aviva corporate website - Aviva plc" 
