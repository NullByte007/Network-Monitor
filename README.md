# Network-Monitor
This GUI tool can be used to Monitor / Scan Network.

<p align="center">
<img src="https://i.ibb.co/vddP1qJ/new-logo4.png">
</p>

Basic Introduction : 

	--> A tool for monitoring network and all the devices and network traffic 

Usage Information :

	[*] chmod +x NETWORK-MONITOR.exe
	[*] Run using : ./NETWORK-MONITOR.exe
	
Functionalities Provided : 
  
    [1] OPEN PORT SCANNER
    --> Module for scanning for open port with two scan destination options: 
      [->] LOCALHOST
      [->] REMOTE HOST    
        
    [2] VULNERABILITY ANALYSIS 
    --> Module for scanning vulnerabilities in the system [LOCALHOST / REMOTE HOST]
    --> All the vulnerabilities are fetched from GHDB (Google hacking database)
   
    [3] NETWORK SCANNER 
    --> Module for scanning local network and find all the devices connected and show all ports/services etc.
    
    [4] NETWORK TRAFFIC ANALYSIS
    --> Module for monitoring network traffic.
    --> Can be used with port/service filter .. eg icmp,arp
    
    [5] SUSPICIOUS ACTIVITY DETECTION
    --> Two modules under this section :
        [->] PING OF DEATH DETECTION
        [->] Unauthorized login monitoring
