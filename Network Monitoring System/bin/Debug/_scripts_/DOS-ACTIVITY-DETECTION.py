import os 
import sys

interface = sys.argv[1].lower()

if os.system("ping -6 -c 2 google.com 1> error.txt") ==0:
	port='icmp6'
	
else:
	port='icmp'
	

"""

icmp = 13th bit
icmp6 = 11th bit

"""
alert_banner="""
 	!!!!!!!!!!!!!!!! UNUSUAL TRAFFIC DETECTED !!!!!!!!!!!!!!!! 

	  !!!!!!!!  POSSIBLE DOS ATTACK ON THE NETWORK  !!!!!!!!  

"""



def loop_function(x):
	os.system("mkdir DUMP 2> error.txt")
	os.system(f"tcpdump -i {interface} {x} -c 10 1> DUMP/traffic.txt 2> DUMP/error.txt")
	f = open("DUMP/traffic.txt",'r')
	f = f.read().split("\n")
	f.pop()

	f.remove(f[0])
	f.remove(f[0])

	if x=='icmp':
		for x in f:
			if int(x.split()[13]) > 400:
				print(alert_banner)
				os.system("rm -rf DUMP")
				os.system("rm -rf error.txt")			
				sys.exit()
	
			else:
				pass
	elif x=='icmp6':
		for x in f:
			if int(x.split()[11]) > 400:
				print(alert_banner)
				os.system("rm -rf DUMP")
				os.system("rm -rf error.txt")			
				sys.exit()
	
			else:
				pass

while True:
	if port=='icmp':
		loop_function('icmp')	
	elif port=='icmp6':
		loop_function('icmp6')




