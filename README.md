# GitHub Selenium
This small mini project is a web testing framework for the GitHub website. I used a Page Object Model design pattern in order to set it up. As it was only a mini project, I didn't delve deep into the various actions which can be carried out on the GitHub website. Instead, I focused on the home, log in and sign up pages which is an area where all current and potential users would come across at least once

![image](https://github.com/Shaq10/GitHubSelenium/blob/main/setup.png)

## Selenium
Selenium Driver was used to automate the browser. Each UI element on a page is located and set as a property. Methods were then created to interact with these properties for testing purposes. 

![image](https://github.com/Shaq10/GitHubSelenium/blob/main/config.png)
#### Config class instantiates, selects and sets up the driver options 

![image](https://github.com/Shaq10/GitHubSelenium/blob/main/super.png)
#### Website class is the super class which creates and instantiates the selenium config before passing the driver instantiation to all the page classes to make their objects available

![image](https://github.com/Shaq10/GitHubSelenium/blob/main/homepage.png)
#### Homepage class

## Specflow
Specflow was used in order to write tests in a BDD approach. I first created features corresponding to each page that I planned to test. Within these features, I then wrote scenarios describing the behaviour I wanted the test to evaluate. These scenarios were written in Gherkin syntax which takes the form Given ... When ... Then ... , making the requirements very clear for the stakeholders. I then generated step definitions for these scenarios where I was able to arrrange, act and assert.

![image](https://github.com/Shaq10/GitHubSelenium/blob/main/feature.png)

![image](https://github.com/Shaq10/GitHubSelenium/blob/main/steps.png)

![image](https://github.com/Shaq10/GitHubSelenium/blob/main/tests.png)


