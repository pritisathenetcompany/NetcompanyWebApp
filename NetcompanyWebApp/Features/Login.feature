Feature: User Login Scenarios

Scenario Outline: Verify User Login 
	Given User navigates to the loginpage
	When Enters Username "<UserName>" and Password "<Password>"
	And Clicks on Login button
	#Then Navigates to "Dashboard" page
Examples: 
| UserName | Password       | 
| admin    | admin_password |
