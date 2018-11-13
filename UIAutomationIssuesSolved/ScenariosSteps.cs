using NUnit.Framework;
using System;
using TechTalk.SpecFlow;


namespace UIAutomationIssuesSolved
{
    [Binding]
    public class ScenariosSteps
    {
        Hooks hooks;

        public ScenariosSteps(Hooks _hooks)
        {
            hooks = _hooks;
        }

        [Given(@"that Wikipedia home page is successfully loaded")]
        public void GivenThatWikipediaIsSuccessfullyLoaded()
        {
            hooks.StartWikipedia();
        }
        
        [When(@"I successfully copy text (.*) from Wikipedia home page and store it in a variable")]
        public void WhenISuccessfullyCopyTextFromOneWebpageLikeReqresHomePage(string textToCopy)
        {
            hooks.CopyTheTextToCopy();
           
        }


        [When(@"I paste the copied text into Google's search box while omitting the first and last characters")]
        public void WhenIPasteTheCopiedTextIntoGoogleSSearchBoxWhileOmittingTheFirstAndLastCharacters()
        {
            hooks.ExecuteGoogleSearch();
            
        }

        //[Then(@"the text is pasted as desired in the Google search box i.e (.*)")]
        //public void ThenTheTextIsPastedAsDesiredInTheGoogleSearchBox(string pastedText)

        //{
        //    string actualResult = hooks.AssertResult();

        //    Assert.AreSame(pastedText, actualResult, "Copied and pasted text values don't match");
        //}

        [Then(@"the resulting term should be searched when I click Search")]
        public void ThenTheResultingTermWhouldBeSearchedWhenIClickSearch()
        {
            hooks.ClickGoogleSearchButtonToSearch();


            hooks.CloseChrome();
        }

    }
}
