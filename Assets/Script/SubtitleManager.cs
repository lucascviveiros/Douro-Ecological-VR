using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SubtitleManager : MonoBehaviour
{
    public TextMeshProUGUI textSubtitle;  
   
    public void PortuguesSubtitle()
    {
        StartCoroutine(PTSubtitleTimer());
    }

    public void SpanishSubtitle()
    {
        StartCoroutine(ESSubtitleTimer());
    }

    public void EnglishSubtitle()
    {
        StartCoroutine(ENSubtitleTimer());
    }

    public void FrenchSubtitle()
    {
        StartCoroutine(FRSubtitleTimer());
    }

    public IEnumerator PTSubtitleTimer()
    {
        textSubtitle.text = "Esta é uma viagem tridimensional e imersiva pelo Rio Douro";
        yield return new WaitForSecondsRealtime(6);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(4);        
        textSubtitle.text = "Com nascente nos picos da Serra Urbión, em Espanha.";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "O rio Douro atravessa o norte de Portugal até à foz";
        
        yield return new WaitForSecondsRealtime(3.5f);
        textSubtitle.text = "Nas cidades do Porto e de Vila Nova de Gaia";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "Na zona de Miranda do Douro, onde o rio faz fronteira";
        
        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "E o leito estreita e aprofunda";


        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "Podemos apreciar as Arribas do Douro";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(2.5f);
        textSubtitle.text = "Na margem espanhola do rio Douro ";

        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "Em frente à cidade de Miranda do Douro";
        
        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "Temos a fraga amarela onde a natureza gravou o algarismo “2”"; /// ver essas aspas aq
        
        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "Com tons amarelos, ocres e pardos";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Associados à presença de líquenes e musgos.";


        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Um pouco mais à frente";

        yield return new WaitForSecondsRealtime(1);
        textSubtitle.text = "Encontramos o “Poço das Lontras”";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "O habitat de eleição das Lontras que aqui vivem.";
        
        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Estes animais, assim como os patos";
        
        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "Estão a ser utilizados em medidas de reabilitação";

        yield return new WaitForSecondsRealtime(2.5f);
        textSubtitle.text = "Para crianças portadoras de necessidades especiais";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Conciliando o turismo rural com o turismo terapêutico.";

        yield return new WaitForSecondsRealtime(3.5f);
        textSubtitle.text = "";


        yield return new WaitForSecondsRealtime(5);
        textSubtitle.text = "A riqueza ambiental desta região e dos seus ecossistemas";

        yield return new WaitForSecondsRealtime(3.5f);
        textSubtitle.text = "Tanto a nível da flora, fauna ou geodiversidade";
  
        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "Tornam possíveis inúmeros projetos de investigação científica";
        
        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Nomeadamente, no âmbito do ecoturismo sustentável.";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(17);
        textSubtitle.text = "Neste local, onde as falésias atingem 150 metros de altura,";
        
        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "Temos o chamado “Vale da Águia”";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Zona preferencialmente habitada por águias";

        yield return new WaitForSecondsRealtime(2.5f);
        textSubtitle.text = "Nomeadamente a Águia-Real";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(5);
        textSubtitle.text = "Para além das águias";
        
        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "Toda esta região das Arribas é também um importante habitat";

        yield return new WaitForSecondsRealtime(3.5f);
        textSubtitle.text = "Para o Grifo, o Abutre-do-egito";

        yield return new WaitForSecondsRealtime(3f);
        textSubtitle.text = "A Cegonha-preta e o Milhafre-preto";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "Para além da riqueza ambiental desta região";
        
        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Todo o Parque Natural é rico culturalmente";
        
        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "De salientar a língua mirandesa, falada em algumas aldeias dos concelhos de Miranda do Douro e Vimioso";
        
        yield return new WaitForSecondsRealtime(6);
        textSubtitle.text = "A Rota dos Contrabandistas, trilhos misteriosos que eram utilizados para, em tempos";
        
        yield return new WaitForSecondsRealtime(4.5f);
        textSubtitle.text = "Atravessar bens e pessoas na fronteira";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "As festas e romarias tradicionais que ainda mantém aqui uma forte expressão";

        yield return new WaitForSecondsRealtime(5);
        textSubtitle.text = "Fazendo parte da vivência quotidiana das populações locais e atraindo cada vez mais visitantes.";

        yield return new WaitForSecondsRealtime(5f);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(14.3f);
        textSubtitle.text = "Aproveite esta experiência";

        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "Entusiasme-se e visite";

        yield return new WaitForSecondsRealtime(2f);
        textSubtitle.text = "O parque natural do Douro Internacional.";

        yield return new WaitForSecondsRealtime(5);
        textSubtitle.text = "";

    }

    public IEnumerator ESSubtitleTimer()
    {
        textSubtitle.text = "Este es un viaje tridimensional e inmersivo a través del río Duero.";
        yield return new WaitForSecondsRealtime(6);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "Con su nacimiento en las cumbres de la Sierra Urbión, en España";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "El río Duero atraviesa el norte de Portugal hasta la desembocadura";

        yield return new WaitForSecondsRealtime(3.5f);
        textSubtitle.text = "En las ciudades de Oporto y Vila Nova de Gaia";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "En la zona de Miranda do Douro, donde el río bordea";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Y su lecho se estrecha y profundiza";


        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "Podemos apreciar las Arribas del Duero";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(2.5f);
        textSubtitle.text = "En la orilla española del río Duero";

        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "Frente a la ciudad de Miranda do Douro";

        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "Se encuentra el “Fraga Amarela”, donde la naturaleza ha grabado el número “2”"; /// ver essas aspas aq

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "Con tonos amarillos, ocres y marrones";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Asociados a la presencia de líquenes y musgos.";


        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Un poco más adelante";

        yield return new WaitForSecondsRealtime(1);
        textSubtitle.text = "Encontramos el “Poço das Lontras”";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "El hábitat elegido por las nutrias que viven aquí.";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Estos animales, al igual que los patos";

        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "Se utilizan en medidas de rehabilitación";

        yield return new WaitForSecondsRealtime(2.5f);
        textSubtitle.text = "Para niños con necesidades especiales";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Conciliando el turismo rural con el terapéutico.";

        yield return new WaitForSecondsRealtime(3.5f);
        textSubtitle.text = "";


        yield return new WaitForSecondsRealtime(5);
        textSubtitle.text = "La riqueza medioambiental de esta región y sus ecosistemas";

        yield return new WaitForSecondsRealtime(3.5f);
        textSubtitle.text = "Tanto en lo que respecta a la flora como a la fauna y la geodiversidad";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "Hacen posible numerosos proyectos de investigación científica";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Especialmente en el ámbito del ecoturismo sostenible.";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(17);
        textSubtitle.text = "En este lugar, donde los acantilados alcanzan una altura de 150 m";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "Se encuentra el llamado “Vale da Águia”";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Zona habitada principalmente por águilas";

        yield return new WaitForSecondsRealtime(2.5f);
        textSubtitle.text = "Concretamente por el Águila Real";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(5);
        textSubtitle.text = "Además de las águilas";

        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "Toda esta región de las Arribes es un importante hábitat ";

        yield return new WaitForSecondsRealtime(3.5f);
        textSubtitle.text = "Para el buitre leonado, el alimoche";

        yield return new WaitForSecondsRealtime(3f);
        textSubtitle.text = "La cigüeña y el milano negros.";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "Además de la riqueza medioambiental de esta región";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Todo el Parque Natural tiene una gran riqueza cultural";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Se destaca la lengua mirandesa, hablada en algunos pueblos de los municipios de Miranda do Douro y Vimioso";

        yield return new WaitForSecondsRealtime(6);
        textSubtitle.text = "También la Ruta de los Contrabandistas, misteriosos senderos que antaño se utilizaban";

        yield return new WaitForSecondsRealtime(4.5f);
        textSubtitle.text = "Para el cruce de mercancías y personas en la frontera";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Las fiestas tradicionales y las romerías que aún mantienen una fuerte expresión aquí";

        yield return new WaitForSecondsRealtime(5);
        textSubtitle.text = "Formando parte de la vida cotidiana de la población local y atrayendo cada vez más visitantes.";

        yield return new WaitForSecondsRealtime(5f);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(14.3f);
        textSubtitle.text = "Disfrute de esta experiencia";

        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "Y anímese a visitar";

        yield return new WaitForSecondsRealtime(2f);
        textSubtitle.text = "El parque natural del Duero Internacional.";

        yield return new WaitForSecondsRealtime(5);
        textSubtitle.text = "";

    }


    public IEnumerator ENSubtitleTimer()
    {
        textSubtitle.text = "This is a three-dimensional and immersive trip across the Douro River";
        yield return new WaitForSecondsRealtime(6);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "With its spring in the peaks of the Urbión mountain, in Spain";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "The Douro River crosses the north of Portugal until the river mouth";

        yield return new WaitForSecondsRealtime(3.5f);
        textSubtitle.text = "In the cities of Porto and Vila Nova de Gaia";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "In the Miranda do Douro area, where the river forms the border";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "And its channel narrows and deepens";


        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "We can appreciate the “Arribas do Douro”";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(2.5f);
        textSubtitle.text = "On the Spanish bank of the Douro river";

        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "Opposite the town of Miranda do Douro";

        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "Is the “Fraga Amarela”, where nature has engraved the number “2”"; /// ver essas aspas aq

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "In yellow, ochre, and brown hues";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Associated with the presence of lichens and mosses.";


        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "A little further on";

        yield return new WaitForSecondsRealtime(1);
        textSubtitle.text = "We find “Poço das Lontras”";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "The favorite otters' habitat that lives here.";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "These animals, as well as the ducks";

        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "Are being used in rehabilitation measures";

        yield return new WaitForSecondsRealtime(2.5f);
        textSubtitle.text = "For children with special needs";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "By reconciling rural tourism with therapeutic tourism.";

        yield return new WaitForSecondsRealtime(3.5f);
        textSubtitle.text = "";


        yield return new WaitForSecondsRealtime(5);
        textSubtitle.text = "The environmental richness of this region and its ecosystems";

        yield return new WaitForSecondsRealtime(3.5f);
        textSubtitle.text = "Both in terms of flora, fauna or geodiversity";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "Make numerous scientific research projects possible";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Particularly in the context of sustainable ecotourism.";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(17);
        textSubtitle.text = "In this place, where the cliffs reach a height of 150 meters";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "We have the so-called “Vale da Águia”";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "An area mainly inhabited by eagles";

        yield return new WaitForSecondsRealtime(2.5f);
        textSubtitle.text = "Namely the Golden Eagle";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(5);
        textSubtitle.text = "Besides the eagles";

        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "This whole region of the Arribas is also an important habitat";

        yield return new WaitForSecondsRealtime(3.5f);
        textSubtitle.text = "For the griffon, the Egyptian vulture";

        yield return new WaitForSecondsRealtime(3f);
        textSubtitle.text = "The black stork, and the black kite";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "Besides the environmental richness of this region";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "The whole Natural Park is culturally rich";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Of particular note is the Mirandese language, spoken in some villages in the municipalities of Miranda do Douro and Vimioso";

        yield return new WaitForSecondsRealtime(6);
        textSubtitle.text = "The Smuggler's Route, mysterious trails were once used";

        yield return new WaitForSecondsRealtime(4.5f);
        textSubtitle.text = "To smuggle goods and people through the border";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "The traditional festivals and pilgrimages that still have strong roots here";

        yield return new WaitForSecondsRealtime(5);
        textSubtitle.text = "Are part of the daily life of the local populations, and attract a lot of visitors.";

        yield return new WaitForSecondsRealtime(5f);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(14.3f);
        textSubtitle.text = "Enjoy this experience";

        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "Be enthusiastic! and visit";

        yield return new WaitForSecondsRealtime(2f);
        textSubtitle.text = "The natural park of Douro International.";

        yield return new WaitForSecondsRealtime(5);
        textSubtitle.text = "";

    }

    public IEnumerator FRSubtitleTimer()
    {
        textSubtitle.text = "Il s'agit d'un voyage en trois dimensions et immersif sur le fleuve Douro";
        yield return new WaitForSecondsRealtime(6);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "Prenant sa source dans les sommets de la Sierra Urbión, en Espagne";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Le fleuve Douro traverse le nord du Portugal jusqu'à son embouchure";

        yield return new WaitForSecondsRealtime(3.5f);
        textSubtitle.text = "Dans les villes de Porto et Vila Nova de Gaia";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "Dans la région de Miranda do Douro, où la rivière forme la frontière";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Et son canal se rétrécit et s'approfondit";


        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "On peut apprécier les “Arribas do Douro”";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(2.5f);
        textSubtitle.text = "Sur la rive espagnole du fleuve Douro";

        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "En face de la ville de Miranda do Douro";

        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "nous avons la Roche Escarpée jaune où la nature a gravé le chiffre “2”"; /// ver essas aspas aq

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "Avec des tons jaunes, ocres et bruns ";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Associés à la présence de lichens et de mousses.";


        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Un peu plus loin";

        yield return new WaitForSecondsRealtime(1);
        textSubtitle.text = "nous trouvons le “Poço das Lontras”";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "l’habitat de choix pour les loutres qui vivent ici.";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Ces animaux, ainsi que les canards";

        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "Sont utilisés dans les mesures de réhabilitation ";

        yield return new WaitForSecondsRealtime(2.5f);
        textSubtitle.text = "Pour les enfants ayant des besoins spéciaux";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Conciliant tourisme rural et tourisme thérapeutique.";

        yield return new WaitForSecondsRealtime(3.5f);
        textSubtitle.text = "";


        yield return new WaitForSecondsRealtime(5);
        textSubtitle.text = "La richesse environnementale de cette région et de ses écosystèmes";

        yield return new WaitForSecondsRealtime(3.5f);
        textSubtitle.text = "Tant en termes de flore, de faune ou de géo diversité";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "Permet de nombreux projets de recherche scientifique";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Notamment dans le domaine de l’écotourisme durable.";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(17);
        textSubtitle.text = "Dans cet endroit, où les falaises atteignent 150m de haut";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "Nous avons la soi-disant “Vale da Águia”";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Une zone de préférence habitée par des aigles";

        yield return new WaitForSecondsRealtime(2.5f);
        textSubtitle.text = "À savoir l’Aigle Royal";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(5);
        textSubtitle.text = "En plus des aigles";

        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "Toute cette région de falaises est un habitat important";

        yield return new WaitForSecondsRealtime(3.5f);
        textSubtitle.text = "Pour le vautour, le vautour égyptien";

        yield return new WaitForSecondsRealtime(3f);
        textSubtitle.text = "La cigogne noire et le faucon noir";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(4);
        textSubtitle.text = "En plus de la richesse environnementale de cette région";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "l’ensemble du parc naturel est culturellement riche";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Il convient de noter la langue mirandaise, parlée dans certains villages dans les municipalités de Miranda do Douro et Vimioso";

        yield return new WaitForSecondsRealtime(6);
        textSubtitle.text = "La Route des contrebandiers, des chemins mystérieux qui étaient autrefois utilisées";

        yield return new WaitForSecondsRealtime(4.5f);
        textSubtitle.text = "pour faire traverser les marchandises et les gens de l’autre côté de la frontière.";

        yield return new WaitForSecondsRealtime(3);
        textSubtitle.text = "Les fêtes et pèlerinages traditionnels qui conservent encore tant d’expression ici";

        yield return new WaitForSecondsRealtime(5);
        textSubtitle.text = "s'inscrit dans l'expérience quotidienne des populations locales en attirant beaucoup de visiteurs.";

        yield return new WaitForSecondsRealtime(5f);
        textSubtitle.text = "";

        yield return new WaitForSecondsRealtime(14.3f);
        textSubtitle.text = "Profitez de cette expérience virtuelle";

        yield return new WaitForSecondsRealtime(2);
        textSubtitle.text = "Et soyez enthousiaste de visiter";

        yield return new WaitForSecondsRealtime(2f);
        textSubtitle.text = "Le parc naturel du Douro Internacional.";

        yield return new WaitForSecondsRealtime(5);
        textSubtitle.text = "";

    }
}
