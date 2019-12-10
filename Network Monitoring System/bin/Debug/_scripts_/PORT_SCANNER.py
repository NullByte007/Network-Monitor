import os
import socket
import sys
os.system("mkdir DUMP 1> error.txt 2> error.txt")
os.system("rm -rf error.txt")

ip = sys.argv[1]

port_range = sys.argv[2]

print("|######################################|")
print(f"| THIS ARE THE OPEN PORTS ON -->  {ip} ")
print("|######################################|")
	
os.system(f"nc -nv -z {ip} 1-{port_range} 2> DUMP/choice1.txt")
os.system("cat DUMP/choice1.txt | cut -d']' -f2 | cut -d'(' -f1 > DUMP/ports.txt")
f = open("DUMP/ports.txt","r")
f = f.read()
f = f.split("\n")
f.pop()
for x in f:
	print("[ {} ] has Service : ".format(x) + socket.getservbyport(int(x)))
os.system("rm -rf DUMP")
