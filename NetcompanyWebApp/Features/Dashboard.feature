Feature: Dashboard Page Scenarios

Scenario Outline: Verify Dashboard Page
	Given User navigates to the dashboard
	When Selects a country "<Country>"
	Then Displays "<Country>" 
Examples: 
| Country |
| UK    |