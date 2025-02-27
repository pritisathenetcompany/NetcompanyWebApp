Feature: Dashboard Page Scenarios

Scenario Outline: Verify Country On Dashboard Page
	Given User navigates to the dashboard
	When Selects a country "<Country>"
	Then Displays country "<Country>" and correct "<Message>"
Examples: 
| Country | Message              |
| UK      | Country selected is: |

Scenario Outline: Verify Checkbox On Dashboard Page
	Given User navigates to the dashboard
	When Selects a checkbox 
	Then Displays "<Message>"
Examples: 
| Message				|
| Checkbox is selected.	|

Scenario Outline: Verify deselected Checkbox On Dashboard Page
	Given User navigates to the dashboard
	When Deselects a checkbox 
	Then Displays "<Message>"
Examples: 
| Message					|
| Checkbox is deselected.	|