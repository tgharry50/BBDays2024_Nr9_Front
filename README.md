IoT-Based Distributed First Aid Kit System Using LoRaWAN and ESP32

Attention!!!! the entire project was implemented by the Hackathon "HackBB 2024" in Bielsko-Biała in time shorter than 24h

Frontend and Backend software - Mikołaj Harężlak

Embedded software - Wiktor Bień

Original repos of embedded project posted below (if you want to see the history of commits):

https://github.com/majorBien/BBDays-Hackathon_Embedded_Main_Hub

https://github.com/majorBien/BBDays-Hackathon_Embedded_First_Aid_Kit

![image](https://github.com/user-attachments/assets/24170a18-848a-45cb-b573-7e4a839630e6)


This innovative IoT system manages a network of distributed first aid kits in outdoor and remote environments, utilizing LoRaWAN technology for long-range communication. Each first aid kit functions as an HTTP-to-LoRaWAN gateway, enabling seamless data transfer between the web interface and the LoRaWAN network. 

![image](https://github.com/user-attachments/assets/050fbdf1-2d39-4af8-a47c-986b69d83de4)


The server-side application is split into two parts. The front-end is developed using Vue.js with Vuetify, providing a responsive and modern UI. The back-end is built in C# using the Entity Framework, which communicates with a Microsoft SQL Server database. This architecture ensures that all data, including inventory, user registration, and SOS messages, is efficiently processed and stored in a secure and scalable manner. Communication between the server and devices is handled via HTTP and JSON files, with the server-side application written in C# and the client-side built using JavaScript and Vue.js. The system tracks the contents and locations of all first aid kits, ensuring resources are always accessible.

![kit](https://github.com/user-attachments/assets/49fb38bb-b757-4e91-bd06-383231d0f446)

The embedded software for the first aid kits has been developed in C using the ESP-IDF framework. The application is designed to run in a multi-threaded environment, with the HTTP communication and LoRaWAN protocol handled on separate cores of the ESP32, ensuring efficient parallel processing. The web interface is built using jQuery, providing a user-friendly experience for interacting with the kits.

The electromagnetic lock of the first aid kit is simulated by a red LED connected to the ESP32, which activates upon establishing a Wi-Fi connection, as each kit operates as a Wi-Fi access point (AP):

![e56b8bb5-dcd3-4a26-8d52-ce3d0c4eaec7](https://github.com/user-attachments/assets/8c2a3ff4-1598-488a-be70-e6d96282a930)


Users can connect to the kit’s Wi-Fi and access a built-in web interface developed in jQuery. Through this interface, they can request emergency assistance by sending a text message over LoRaWAN, even in challenging conditions. They can also log items taken from the kit, such as bandages or hydrogen peroxide, and this information is transmitted to the central hub (concentrator) via LoRaWAN for real-time inventory tracking.

The system supports user registration and login via LoRaWAN, facilitating the management of access and user activity. Both the first aid kits and the concentrator are built using ESP32 microcontrollers and SX1262 LoRa chips, ensuring efficient data handling and transmission.

Each first aid kit provides users with several key functionalities accessible through its web interface. Users can select checkboxes to indicate which items have been taken from the kit, such as bandages or disinfectant, ensuring accurate tracking of available supplies. Additionally, the interface allows users to send an SOS message in emergencies, even under poor conditions, with the message transmitted over LoRaWAN to the central server. The system also includes user authentication features, enabling login and registration directly from the first aid kit interface. All interactions, including inventory updates, SOS messages, and user data, are securely transmitted to the server via LoRaWAN for processing and storage, ensuring centralized monitoring and control.

![8bd58d22-913c-4b9f-beff-b438fb5729a8](https://github.com/user-attachments/assets/cbf53466-2b45-4845-8489-4fbecd63533a)

Web app embedded to First Aid kit:

![image](https://github.com/user-attachments/assets/63437675-08d3-4f2e-94c4-6af2d1636a3a)

Desktop server app for IoT-Based Distributed First Aid Kit System admins:

![admin](https://github.com/user-attachments/assets/2179b578-6e85-43eb-a0dc-e1c89f3e69e5)

![image](https://github.com/user-attachments/assets/d7156940-22b2-46c8-857e-b48dd74c816a)

![image](https://github.com/user-attachments/assets/a39e680b-6d26-4d38-877a-4cad60f2a1af)

![image](https://github.com/user-attachments/assets/a90b9e45-3677-47b8-8a30-fabb1f3f585a)

![image](https://github.com/user-attachments/assets/d14acfb8-c07c-4a5a-bb32-1c4b7a85fe26)






