import os 
import time 
import sys

os.system("mkdir DUMP 2> error.txt")

ipaddress = sys.argv[1]

##########################################################################################################
def ping_sweep():
	ipadd =''
	ip_list = []
	ip = ipaddress
	ip = ip.split(".")
	ip.pop()

	for x in ip:
		ipadd = ipadd + x + "."

	
	for x in range(0,255):
		if os.system("ping -c 2 {}{} 1> DUMP/error.txt 2> DUMP/error.txt ".format(ipadd,x)) == 0:
			ip_list.append("{}{}".format(ipadd,x))

	os.system(' echo "[*] FOUND ALIVE HOSTS : [ {} ]" '.format(len(ip_list)))
	os.system(' echo ')
	
	for x in ip_list:
		os.system(' echo " [-->] {} " '.format(x))

	os.system("touch DUMP/IP_ADDRESS.txt")
	f = open("DUMP/IP_ADDRESS.txt","a")
	for x in ip_list:
		f.write(x+"\n")
	f.close()



##########################################################################################################

def port_and_os_detection():			


	f = open("DUMP/IP_ADDRESS.txt",'r')
	f = f.read().split("\n")
	f.pop()
	for x in f:
		os.system(' echo && echo && echo "REPORT FOR ==> [ {} ] " '.format(x))
		os.system(f"nmap -sV -O {x} 1> DUMP/scan.txt 2> DUMP/error.txt")

 
		c = open("DUMP/scan.txt",'r')
		c = c.read().split("\n")
		for v in c:
			if v==' ':
				c.remove(v)
		try:
			c.pop()
			c.pop()
			c.pop()
			c.pop()
		except:
			pass

		os.system('echo && echo "|-----------------------------------------[*] PORT AND SERVICE ---------------------------------------------|" && echo "PORT     STATE SERVICE     VERSION" && cat DUMP/scan.txt | grep "open\|filtered" && echo "|-----------------------------------------------------------------------------------------------------------------------|" ')	

	       


		os.system(' echo && echo "|-----------------------------------------[*] OS DISCOVERY ---------------------------------------------------|"')
		try:
			for v in c:
				if list(v)[0]=='R' and list(v)[1]=='u' or list(v)[0]=='O' and list(v)[1]=='S':
					os.system('echo "{}"'.format(v))	
		except:
			pass
		os.system('echo && echo "|-----------------------------------------------------------------------------------------------------------------------|" && echo')



def mac_and_ip():
	os.system("arp -a > DUMP/arp.txt")
	f = open("DUMP/arp.txt",'r')
	f = f.read().split("\n")
	f.pop()
	print("+---------------------------------------------------------------------------------------------+")
	for x in f:
		if x.split()[3]=='<incomplete>':
			pass
		else:	
			print(" [ " + x.split()[0] +" ]  HAS IP ==>  " +x.split()[1] +" AND MAC ADDRESS ==> "+x.split()[3])
			print("+---------------------------------------------------------------------------------------------+")

	


# Function calls 

os.system(' echo "[*] STARTED PING SWEEPER" && echo')
os.system('echo  && echo "[*] GATHERING ALIVE HOSTS !!" ' )
ping_sweep()	
os.system('echo  && echo "[*] COMPLETED PING SWEEP !  !!" && echo ' )

os.system('echo  && echo "[*] STARTED PORT AND OS ENUMERATION ON GATHERED ADDRESSESS ! " && echo ' )
port_and_os_detection()	
os.system('echo  && echo "[*] COMPLETED PORT AND OS ENUMERATION ! " && echo ' )

#os.system('echo  && echo "[*] STARTED MAC AND DEVICE ENUMERATION ON GATHERED ADDRESSESS ! " && echo ' )
#mac_and_ip()	
#os.system('echo  && echo "[*] COMPLETED MAC AND DEVICE ENUMERATION  ! " && echo ' )



os.system("rm -rf DUMP")
os.system("rm -rf error.txt")







