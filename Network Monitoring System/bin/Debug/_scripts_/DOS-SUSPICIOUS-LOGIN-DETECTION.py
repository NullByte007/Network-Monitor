import os
os.system("mkdir DUMP")
os.system("cat /var/log/auth.log | grep 'ssh' > DUMP/log.txt")

f = open("DUMP/log.txt",'r')

f = f.read().split("\n")

for x in f:
	print(x)
	print("\n")
