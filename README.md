IoT-Based Distributed First Aid Kit System Using LoRaWAN and ESP32

![image](https://github.com/user-attachments/assets/24170a18-848a-45cb-b573-7e4a839630e6)

This innovative IoT system is designed to manage a network of distributed first aid kits in outdoor and remote environments, utilizing LoRaWAN technology for reliable, long-range communication. Each first aid kit is equipped with an electromagnetic lock that opens upon establishing a Wi-Fi connection. Every kit acts as an access point (AP), allowing users to connect directly. Once connected, a built-in web interface, developed in jQuery, enables users to interact with the system.

Through this web interface, users can request emergency assistance by sending a text message over LoRaWAN, even in the most challenging conditions. Additionally, users can log the items they have taken from the kit, such as bandages or hydrogen peroxide, and this data is transmitted to the main hub (concentrator) via LoRaWAN for real-time tracking of supplies.

The system also supports user registration and login through the LoRaWAN network, making it easy to manage access and usage records. All first aid kits and the central concentrator are built using ESP32 microcontrollers and the SX1262 LoRa chip, ensuring both local processing and efficient data transmission.

The back-end application, developed in C#, aggregates the data from all the first aid kits and stores it in a SQL database, maintaining a detailed log of inventory and user interactions. Separate firmware has been developed for the kits and the central concentrator using the ESP-IDF framework, written in C.

Communication between the server and devices is handled via HTTP protocols and JSON files, with the server-side application implemented using C# and the client-side using JavaScript with the Vue.js framework. The system tracks the contents and location of all first aid kits, ensuring that resources are always accessible and up-to-date.



