Feature: Career.google login


@Test
Scenario: Verify that the user logged in sucessfully
Given Enter the url
When Click on sign in button
Then Check that user switch to new window
When enter email and click next




@Test
Scenario: Verify that the user find all software position in dublin sucessfully
Given Enter the url
When Click on sign in button
Then Check that user switch to new window
When enter email and click next
Then Check that user is in login page
When select role and location
And Click on the search button



@Test
Scenario: Verify that the job position is opened sucessfully
Given Enter the url
When Click on sign in button
Then Check that user switch to new window
When enter email and click next
Then Check that user is in login page
When select role and location
And Click on the search button
And Click on any position to expand
Then Check that job details is expanded







