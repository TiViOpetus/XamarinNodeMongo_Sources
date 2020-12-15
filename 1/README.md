# Yhteys Xamarinin Android-emulaattorista

Onnittelut, olet suorittanut tehtävän ensimmäisen osan onnistuneesti ja toteuttanut NodeJS Restful -palvelun. Tässä tehtävässä tavoitteena on avata yhteys tähän palveluun omasta Xamarin-sovelluksestasi.

Kun omalla koneellasi testaat web-palvelua, kirjoitat osoiteriville **http://localhost:3000/helloworld**. Android-emulaattorissa tai omassa puhelimessasi tämä ei tietysti onnistu, vaan osoitteena pitää olla jotain muuta. Androidin kehitysympäristössä osoite **10.0.2.2** toimii aliaksena kehitysympäristön paikalliselle loopback-osoitteelle, eli 127.0.0.1 tai **localhost**. Tämän tehtävän esimerkkikoodissa tämä on jo huomioitu, mutta kun muokkaat koodia tehtävän ohjeistuksen mukaisesti, muista varmistaa että osoitteet ovat oikein. 

Tätä varten löydät tästä kansiosta jälleen **AwesomeApp**-projektin, joka toteuttaa jo yhden edellisen vaiheen toiminnoista. Kun käynnistät sovelluksen Android-emulaattorissa tai puhelimessasi, sinun pitäisi nähdä jotain tämän kaltaista:

![Emu](/Images/11.PNG?raw=true) 

Kun nappia klikkaa, sovellus suorittaa kutsun luomallesi **NodeJS Restful**-palvelulle käyttämällä **/helloworld**-kutsua.

Tavoitteenasi tässä tehtävässä on lisätä näkymään 2 nappia. Toinen napeista suorittaa NodeJS-palvelustasi **/list** ja toinen **/add**. Muokkaa koodiasi niin että se näyttää ja toteuttaa ao. kuvankaappauksen mukaiset toiminnot:

![Emu](/Images/12.PNG?raw=true) 

Eli:
- nappi 1 suorittaa taustajärjestelmän komennon: **/helloworld**-komennon
- nappi 2 suorittaa taustajärjestelmän komennon: **/add**-komennon
- nappi 3 suorittaa taustajärjestelmän komennon: **/list**-komennon. Listauksen tulostusta varten näkymään lisätään **ListView**-tyyppinen taulukko.

Kun sovelluksesi näyttää ylläolevan kuvankaappauksen mukaiselta, vedä opettajaa hihasta joko virtuaalisesti tai fyysisesti ja kerro tehtävän olevan paketissa. Tai lähde kahville.
