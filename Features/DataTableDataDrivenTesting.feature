Feature: DataTable Data Driven Testing

A short summary of the feature is to go to Aviva web page and validate it.

@TestAvivaWebPage
Scenario Outline: Examples Data Driven Testing
	Given Open web browser
	When Navigated to the Aviva home 
    Then the title should be
	| Title                                    |
	| Aviva corporate website - Aviva plc       |
