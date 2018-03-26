using System;
using TechTalk.SpecFlow;

namespace TestSpecFlowBelote
{
    [Binding]
    public class InscriptionConcoursBeloteSteps
    {
        public ConcoursBelote ConcoursBelote { get; set; }

        [Given(@"que j'ai un concoursde belote")]
        public void SoitQueJAiUnConcoursdeBelote()
        {
            var concoursBelote = new ConcoursBelote();
        }

        [Given(@"que je suis à l'étape inscription")]
        public void SoitQueJeSuisALEtapeInscription()
        {
            concou
        }


        [When(@"Deux personnes arrive pour s'inscrire aux concours de belote")]
        public void QuandDeuxPersonnesArrivePourSInscrireAuxConcoursDeBelote()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Ils forment une équipe de deux personnes pour le Concours")]
        public void AlorsIlsFormentUneEquipeDeDeuxPersonnesPourLeConcours()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
