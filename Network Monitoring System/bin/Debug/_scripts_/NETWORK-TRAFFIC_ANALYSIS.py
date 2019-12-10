import sys
import os

os.system("mkdir DUMP")
"""
interface = sys.argv[1]

port = sys.argv[2]

packet_count = sys.argv[3]
"""



filterr = sys.argv[1].lower()

interface = sys.argv[2].lower()




'''
|--------------------------------------------|
| [*] SELECT FILTERS FROM THE GIVEN OPTIONS  |
|--------------------------------------------|
|--------------------------------------------|	
| [1] HTTP				     |
| [2] HTTPS 				     |
| [3] DNS				     |
| [4] ICMP (ping packets)		     |
| [5] ARP				     |
| [6] NO FILTER				     |
| [7] ENTER PORT !			     |
|--------------------------------------------|
	'''

os.system(' echo "[*] CAPTURING PACKETS ON INTERFACE [ {} ] WITH [ {} ] FILTER " '.format(interface,filterr) )



if filterr == 'all':
	os.system(f'tcpdump -i {interface} -c 20 > DUMP/traffic.txt ')

elif filterr =='icmp':
	os.system(f'tcpdump -i {interface} icmp -c 20 > DUMP/traffic.txt')

elif filterr == 'arp':
	os.system(f'tcpdump -i {interface} arp -c 4  > DUMP/traffic.txt')

else:
	if filterr =='http':
		port=80
		os.system(f'tcpdump -i {interface} port {port} -c 20  > DUMP/traffic.txt')

	elif filterr =='https':
		port=443
		os.system(f'tcpdump -i {interface} port {port} -c 20  > DUMP/traffic.txt')

	
f = open("DUMP/traffic.txt",'r')
f = f.read().split("\n")
f.pop()

for x in f:
	print(x)
	print("\n") 





