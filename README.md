# Networked Plant Watering 

- Each plant has a sensor controller (arduino or esp32), which can:
    - Communicate with a central control/monitoring server via RPC? (maybe MQTT or something, my first impression is that RPC fits the use case well). 
        - Commands (client to server):
            - Initialize/Register: add a new client.
            - Send data (history or moisture).
            - Update state (idle, watering, settling, measuring).
    - Read soil moisture level.
    - Store historical moisture for up to X days, or until the server requests data.  Microprocessor-cached data is deleted once the transaction is completed.
    - Control watering pump for this plant. Decision making on watering is made client-side by default. Watering has a cooldown.
    - Store historical watering data for up to X days, until requested by server.
 
- Server:
    - The server monitors and controls watering devices.
        - Commands (server to client):
            - Setup: intilaize a client.
            - Request data (historical or watering).
            - Request state (idle, watering, settling, measuring).
            - Request watering. 
    - Runs on some HW (raspberry pi? or maybe stateless and run from a cron job).

## HW used
## Libraries used
