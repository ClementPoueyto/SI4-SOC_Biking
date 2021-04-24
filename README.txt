AUTEUR : CLEMENT POUEYTO SI4 FISA

URL github : https://github.com/ClementPoueyto/SI4-SOC_Biking
URL code : voir README moodle

angular-bike-client : client web angular
BikeClient : heavy client console
WebProxyService : serveur proxy API JCdecaux 
WebRoutingService : serveur recevant les requetes des clients


Tutoriel :
1) Dezipper le projet PoueytoSOC

2) Démarrer le serveur :
    - Executer en tant qu'administrateur SelfHosted/bin/Debug/SelfHosted.exe
    - Executer en tant qu'administrateur SelfHostedProxy/bin/Debug/SelfHostedProxy.exe

3) Démarrer le client Lourd : 
    - Executer en tant qu'administrateur BikeClient/bin/Debug/bikeClient.exe

4) Démarrer le client Web :        (Angular requis)

    - Se rendre dans : angular-bike-client/
    - Lancer les commandes : 
                            npm install
                            npm start
    - Lancer le navigateur à l'adresse : http://localhost:4200/